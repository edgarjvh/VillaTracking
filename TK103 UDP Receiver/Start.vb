Imports System.ComponentModel
Imports System.Deployment.Application
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Timers

Module Start
#Region "VARIABLES GLOBALES"
    Friend WithEvents bgw As New BackgroundWorker
    Friend WithEvents bgwe As New BackgroundWorker
    Dim aTimer As System.Timers.Timer
    Dim receivingUdpClient As UdpClient
    Dim RemoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
    Dim threadReceive As Thread
    Dim threadTeclas As Thread
    Dim puertoEscucha As Integer
    Dim ipEscucha As String
    Dim ipCorrecta As Boolean = False
    Dim puertoCorrecto As Boolean = False
    Dim trace As New Trace
    Dim vehicles As New List(Of Vehicle)
    Dim udpsender As UdpClient
    Dim trsender As Thread
    Dim trEvent As Thread
    Dim detenidoPorUsuario As Boolean = False
#End Region

    Sub Main()
        Try
            Do Until puertoCorrecto
                setPort(0)
            Loop

            Do Until ipCorrecta
                setIP(0)
            Loop

            bgw.RunWorkerAsync()

            threadTeclas = New Thread(AddressOf leerTeclas)
            threadTeclas.Start()

            iniciarCaptura()
            SetTimer()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try
    End Sub

#Region "FUNCIONES Y RUTINAS"
    Sub setTitle()
        Try
            Console.Title = "<::: Capturador UDP TK103A - " & My.Settings._ip & ":" & My.Settings._port & " :::>" &
                            " REV. " & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Catch ex As Exception
            'Console.WriteLine(ex.Message)
            Console.Title = "<::: Capturador UDP TK103A - " & My.Settings._ip & ":" & My.Settings._port & " :::>"
        End Try
    End Sub

    Function setPort(ByVal peticionDeCambio As Integer) As Boolean
        Dim tempPort As Integer = Nothing

        If peticionDeCambio = 1 Then
            Console.WriteLine("INTRODUZCA EL PUERTO DE ESCUCHA: ")
            Dim port As Object = Console.ReadLine()

            If Integer.TryParse(port, tempPort) Then
                My.Settings._port = tempPort
                My.Settings.Save()
                puertoEscucha = CInt(My.Settings._port)
                puertoCorrecto = True
                Return True
            Else
                puertoCorrecto = False
                Return False
            End If
        Else
            If Not My.Settings._port = "" Then
                puertoEscucha = CInt(My.Settings._port)
                puertoCorrecto = True
                Return True
            Else
                Console.WriteLine("INTRODUZCA EL PUERTO DE ESCUCHA: ")
                If Integer.TryParse(Console.ReadLine(), tempPort) Then
                    My.Settings._port = tempPort
                    My.Settings.Save()
                    puertoEscucha = CInt(My.Settings._port)
                    puertoCorrecto = True
                    Return True
                Else
                    puertoCorrecto = False
                    Return False
                End If
            End If
        End If
    End Function

    Function setIP(ByVal peticionDeCambio As Integer) As Boolean
        Dim tempIP As IPAddress = Nothing

        If peticionDeCambio = 1 Then

            Dim ipadd() As IPAddress = Dns.GetHostAddresses("127.0.0.1")

            Return True
            Dim ip As Object = ipadd(0).ToString()

            If IPAddress.TryParse(ip, tempIP) Then
                My.Settings._ip = tempIP.ToString
                My.Settings.Save()
                ipEscucha = My.Settings._ip

                Try
                    Dim lep As New IPEndPoint(IPAddress.Parse(ipEscucha), puertoEscucha)
                    receivingUdpClient = New UdpClient(lep)
                    ipCorrecta = True
                    receivingUdpClient.Close()
                    Return True
                Catch ex As Exception
                    ipCorrecta = False
                    Return False
                End Try
            Else
                ipCorrecta = False
                Return False
            End If
        Else
            If Not My.Settings._ip = "" Then
                ipEscucha = ""

                Try
                    Dim lep As New IPEndPoint(IPAddress.Parse(ipEscucha), puertoEscucha)
                    receivingUdpClient = New UdpClient(lep)
                    ipCorrecta = True
                    receivingUdpClient.Close()
                    Return True
                Catch ex As Exception
                    Console.WriteLine("INTRODUZCA LA IP DE ESCUCHA: ")
                    If IPAddress.TryParse(Console.ReadLine, tempIP) Then
                        My.Settings._ip = tempIP.ToString
                        My.Settings.Save()
                        ipEscucha = My.Settings._ip

                        Try
                            Dim lep As New IPEndPoint(IPAddress.Parse(ipEscucha), puertoEscucha)
                            receivingUdpClient = New UdpClient(lep)
                            ipCorrecta = True
                            receivingUdpClient.Close()
                            Return True
                        Catch exe As Exception
                            ipCorrecta = False
                            Return False
                        End Try
                    Else
                        ipCorrecta = False
                        Return False
                    End If
                End Try
            Else
                Console.WriteLine("INTRODUZCA LA IP DE ESCUCHA: ")
                If IPAddress.TryParse(Console.ReadLine, tempIP) Then
                    My.Settings._ip = tempIP.ToString
                    My.Settings.Save()
                    ipEscucha = My.Settings._ip

                    Try
                        Dim lep As New IPEndPoint(IPAddress.Parse(ipEscucha), puertoEscucha)
                        receivingUdpClient = New UdpClient(lep)
                        ipCorrecta = True
                        receivingUdpClient.Close()
                        Return True
                    Catch ex As Exception
                        ipCorrecta = False
                        Return False
                    End Try
                Else
                    ipCorrecta = False
                    Return False
                End If
            End If
        End If
    End Function

    Private Sub SetTimer()
        ' Create a timer with a two second interval.
        aTimer = New Timers.Timer(2000)
        ' Hook up the Elapsed event for the timer. 
        AddHandler aTimer.Elapsed, AddressOf OnTimedEvent
        aTimer.AutoReset = True
        aTimer.Enabled = True
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        If Not bgw.IsBusy Then
            bgw.RunWorkerAsync()
        End If

        If Not detenidoPorUsuario Then
            iniciarCaptura()
        End If
    End Sub

    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs) Handles bgw.DoWork
        Try
            udpsender = New UdpClient(30001)

            While True
                Dim receiveBytes As Byte() = udpsender.Receive(RemoteIpEndPoint)
                Dim BitDet As BitArray
                BitDet = New BitArray(receiveBytes)
                Dim strReturnData As String = Encoding.ASCII.GetString(receiveBytes)

                Dim cadena() As String = strReturnData.Split("@")

                For i = 0 To vehicles.Count - 1
                    If vehicles(i).Imei = cadena(2) Then
                        Dim respuesta As Byte() = Encoding.ASCII.GetBytes(cadena(1))
                        vehicles(i).UdpClient.Send(respuesta, respuesta.Length, vehicles(i).EndPoint)
                        Exit For
                    End If
                Next
            End While
        Catch ex As Exception
            Console.WriteLine(vbNewLine & ex.Message & vbNewLine)
        End Try
    End Sub

    Private Sub bgwe_dowork(sender As Object, e As DoWorkEventArgs) Handles bgwe.DoWork
        Dim udp As New UdpClient
        Dim ep As New IPEndPoint(IPAddress.Parse("127.0.0.1"), 1500)
        Dim respuesta As Byte() = Encoding.ASCII.GetBytes(e.Argument.ToString)
        udp.Send(respuesta, respuesta.Length, ep)
    End Sub

    Function ReceiveMessages()
        Try
            Console.WriteLine("CAPTURA INICIADA CORRECTAMENTE AL PUERTO " & My.Settings._port)

            While True
                Dim receiveBytes As Byte() = receivingUdpClient.Receive(RemoteIpEndPoint)
                Dim BitDet As BitArray
                BitDet = New BitArray(receiveBytes)
                Dim strReturnData As String = Encoding.ASCII.GetString(receiveBytes)

                strReturnData = strReturnData.Replace("$", "")

                Dim idgps As String = ""

                If strReturnData.Length = 16 Then
                    'se verifica si la trama contiene solo el imei del dispositivo
                    '123456789123456;
                    'y se envia una respuesta automatica "ON" al dispositivo

                    idgps = Mid(strReturnData, 1, 15)
                    'Dim respuesta As [Byte]() = Encoding.ASCII.GetBytes("ON")
                    'receivingUdpClient.Send(respuesta, respuesta.Length, RemoteIpEndPoint)

                ElseIf strReturnData.Contains("##") Then
                    'se verifica si la trama contiene la cadena solicitud de respuesta
                    '##,imei:123456789123456,A;
                    'y se envia una respuesta automatica "LOAD" al dispositivo

                    idgps = Mid(strReturnData, 9, 15)
                    'Dim respuesta As [Byte]() = Encoding.ASCII.GetBytes("LOAD")
                    'receivingUdpClient.Send(respuesta, respuesta.Length, RemoteIpEndPoint)
                Else
                    'si contiene la trama standard del dispositivo, se captura el imei en una variable

                    idgps = Mid(strReturnData, 6, 15)
                End If

                Dim existe As Boolean = False

                'se almacena la informacion de coneccion del dispositivo mediante la clase "gpsConectado"
                'para validar su existencia en la variable lista gpsConectados declarada en el módulo "moduloGps"
                'en caso de existir, solo se actualiza el objeto ipEndPoint y el UdpClient
                'de lo contrario se agrega a la variable lista
                Dim gps As New Vehicle
                gps.EndPoint = RemoteIpEndPoint
                gps.Imei = idgps
                gps.UdpClient = receivingUdpClient

                For Each _gps In vehicles
                    If _gps.Imei = idgps Then
                        _gps.EndPoint = RemoteIpEndPoint
                        _gps.UdpClient = receivingUdpClient
                        existe = True
                        Exit For
                    End If
                Next

                If existe = False Then
                    vehicles.Add(gps)
                End If

                If strReturnData.Contains("jt") Then
                    If Not bgwe.IsBusy Then
                        bgwe.RunWorkerAsync(idgps & "*1")
                    End If
                ElseIf strReturnData.Contains("kt") Then
                    If Not bgwe.IsBusy Then
                        bgwe.RunWorkerAsync(idgps & "*0")
                    End If
                End If

                ''ENVIAMOS LA TRAMA, LA IP Y EL PUERTO, A LA CLASE CORRESPONDIETE PARA SU TRATAMIENTO Y VALIDACION...
                trace.transformTrace(strReturnData, RemoteIpEndPoint.Address.ToString, RemoteIpEndPoint.Port.ToString)

                strReturnData = strReturnData.Replace(idgps, idgps.Insert(10, " "))

                'ESCRIBIMOS EN LA CONSOLA LA TRAMA RECIBIDA POR EL GPS...
                Console.WriteLine(Now)
                Console.WriteLine(strReturnData)
                Console.WriteLine()
            End While
            Return True
        Catch ex As Exception
            Return False
            detenerCaptura()
            iniciarCaptura()
        End Try
    End Function

    Function leerTeclas()
        Dim cki As ConsoleKeyInfo
        Dim combinacion As String = Nothing

        Console.TreatControlCAsInput = True

        Do
            cki = Console.ReadKey(True)
            combinacion = cki.Key.ToString

            Select Case combinacion
                Case "F4"
                    detenidoPorUsuario = True
                    detenerCaptura()
                Case "F10"
                    iniciarCaptura()
                Case "F11"
                    If threadReceive.IsAlive = False Then
                        cambiarPuerto()
                    End If
                Case "F12"
                    If threadReceive.IsAlive = False Then
                        cambiarIP()
                    End If
            End Select

            combinacion = Nothing
        Loop
    End Function

    Sub detenerCaptura()
        If threadReceive.IsAlive = True Then
            threadReceive.Abort()
            receivingUdpClient.Close()
            Console.WriteLine("CAPTURA DETENIDA POR EL USUARIO, PRESIONE F10 PARA INICIAR LA CAPTURA NUEVAMENTE")
        End If

        If Not threadTeclas.IsAlive = True Then
            threadTeclas.Start()
        End If
    End Sub

    Sub iniciarCaptura()
        If threadReceive IsNot Nothing Then
            If threadReceive.IsAlive = False Then
                Dim lep As New IPEndPoint(IPAddress.Parse(ipEscucha), puertoEscucha)
                receivingUdpClient = New UdpClient(lep)
                threadReceive = New Thread(AddressOf ReceiveMessages)
                threadReceive.Start()
                setTitle()
                detenidoPorUsuario = False
            End If
        Else
            Dim lep As New IPEndPoint(IPAddress.Parse(ipEscucha), puertoEscucha)
            receivingUdpClient = New UdpClient(lep)
            threadReceive = New Thread(AddressOf ReceiveMessages)
            threadReceive.Start()
            setTitle()
            detenidoPorUsuario = False
        End If
    End Sub

    Sub cambiarPuerto()
        Try
            If threadReceive.IsAlive = True Then
                threadReceive.Abort()
                receivingUdpClient.Close()
            End If

            puertoCorrecto = False
            Do Until puertoCorrecto
                setPort(1)
            Loop

            iniciarCaptura()
        Catch ex As Exception
            Console.WriteLine(vbNewLine & ex.Message & vbNewLine)
            Console.ReadLine()
        End Try
    End Sub

    Sub cambiarIP()
        Try
            If threadReceive.IsAlive = True Then
                threadReceive.Abort()
                receivingUdpClient.Close()
            End If

            ipCorrecta = False
            Do Until ipCorrecta
                setIP(1)
            Loop

            iniciarCaptura()
        Catch ex As Exception
            Console.WriteLine(vbNewLine & ex.Message & vbNewLine)
            Console.ReadLine()
        End Try
    End Sub
#End Region
End Module
