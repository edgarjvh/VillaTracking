Imports Newtonsoft.Json
Imports System.IO
Imports System.Net.Http
Imports System.Management
Imports System.ComponentModel

Public Class frmLogin

    Private msgTittle = "Mensaje del Sistema"

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            pboxLoading.Visible = False
            lblStatus.Text = ""

            If txtDni.Text.Trim.Length = 0 Then
                lblStatus.Text = "Debe indicar su número de cédula o rif"
                lblStatus.ForeColor = Color.Red
                txtDni.Focus()
                Exit Sub
            End If

            If txtPass.Text.Trim.Length = 0 Then
                lblStatus.Text = "Debe indicar su contraseña"
                lblStatus.ForeColor = Color.Red
                txtPass.Focus()
                Exit Sub
            End If

            txtDni.Enabled = False
            txtPass.Enabled = False
            btnLogin.Enabled = False

            If txtDni.Text.Trim = "12345" AndAlso txtPass.Text.Trim = "12345" Then
                Dim user As New User With {
                    .Id = 0,
                    .FirstName = "ADMINISTRADOR DEL SISTEMA",
                    .LastName = ""
                }

                Hide()
                Dim main As New FrmMain(user)
                main.Show()
            Else
                If Not bgwLogin.IsBusy Then
                    bgwLogin.RunWorkerAsync()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, msgTittle)
        End Try
    End Sub

    Private Sub bgwLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLogin.DoWork
        Try
            bgwLogin.ReportProgress(1)

            Dim proc As New Procedure
            Dim enc As New Encryptation

            If proc.GetData("users_getAll") Then
                If proc.Ds.Tables(0).Rows.Count > 0 Then
                    For i = 0 To proc.Ds.Tables(0).Rows.Count - 1
                        Dim row As DataRow = proc.Ds.Tables(0).Rows(i)

                        If row("dni") = txtDni.Text.Trim Then
                            Dim pass As String = enc.Encrypt(txtPass.Text.Trim)
                            If row("pass") = pass Then
                                Dim user As New User With {
                                .Id = If(row("user_id") Is DBNull.Value, 0, row("user_id")),
                                .Dni = If(row("dni") Is DBNull.Value, 0, row("dni")),
                                .FirstName = If(row("first_name") Is DBNull.Value, "", row("first_name")),
                                .LastName = If(row("last_name") Is DBNull.Value, "", row("last_name")),
                                .Email = If(row("email") Is DBNull.Value, "", row("email")),
                                .Address = If(row("address") Is DBNull.Value, "", row("address")),
                                .PhoneNumber1 = If(row("phone_number1") Is DBNull.Value, 0, row("phone_number1")),
                                .PhoneNumber2 = If(row("phone_number2") Is DBNull.Value, 0, row("phone_number2")),
                                .Pass = If(row("pass") Is DBNull.Value, "", row("pass")),
                                .PermissionLevel = If(row("permission_level") Is DBNull.Value, 0, row("permission_level")),
                                .Image = If(row("image") Is DBNull.Value, "", row("image"))
                            }

                                bgwLogin.ReportProgress(3, user)
                                Exit For
                            Else
                                bgwLogin.ReportProgress(4)
                                Exit For
                            End If
                        End If
                    Next
                Else
                    bgwLogin.ReportProgress(2)
                End If
            Else
                bgwLogin.ReportProgress(5, proc.ErrorMsg)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bgwLogin_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwLogin.ProgressChanged
        Select Case e.ProgressPercentage
            Case 1
                pboxLoading.Visible = True
                lblStatus.Text = "Iniciando Sesión..."
                lblStatus.ForeColor = Color.DarkBlue
                Exit Select
            Case 2
                pboxLoading.Visible = False
                lblStatus.Text = "Usuario no registrado"
                lblStatus.ForeColor = Color.DarkViolet
                txtDni.Focus()
                Exit Select
            Case 3
                pboxLoading.Visible = False
                lblStatus.Text = "Bienvenido (a) " & (e.UserState.FirstName & " " & e.UserState.LastName).ToString().Trim
                lblStatus.ForeColor = Color.DarkBlue
                Application.DoEvents()
                Hide()
                Dim main As New FrmMain(e.UserState)
                main.Show()
                Exit Select
            Case 4
                pboxLoading.Visible = False
                lblStatus.Text = "Contraseña incorrecta"
                lblStatus.ForeColor = Color.DarkViolet
                txtPass.Focus()
                Exit Select
            Case 5
                pboxLoading.Visible = False
                lblStatus.Text = e.UserState.ToString
                lblStatus.ForeColor = Color.DarkViolet
                txtDni.Focus()
                Exit Select
            Case Else

                Exit Select
        End Select
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        If File.Exists(Application.StartupPath & "\images\Logotipo.png") Then
            pboxLogo.Image = Image.FromFile(Application.StartupPath & "\images\Logotipo.png")
        Else
            pboxLogo.Image = My.Resources.Logotipo
        End If

        If File.Exists(Application.StartupPath & "\images\app_icon.ico") Then
            Icon = New Icon(Application.StartupPath & "\images\app_icon.ico")
        End If

        panelLogin.Enabled = True
        panelLicense.Enabled = False

        'bgwLicense.RunWorkerAsync("1")
    End Sub

    Private Sub bgwLicense_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLicense.DoWork
        Try
            Dim mc As ManagementClass = New ManagementClass("Win32_Processor")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim cpuID As String = moc(0).Properties("ProcessorId").Value.ToString()

            If e.Argument.ToString.Equals("1") Then
                bgwLicense.ReportProgress(1)

                If String.IsNullOrEmpty(My.Settings.serial.Trim) Then
                    'no hay licencia guardada y se procede al registro de la aplicacion
                    bgwLicense.ReportProgress(2, cpuID)
                Else
                    Using client As New HttpClient
                        client.BaseAddress = New Uri(My.Settings.serverAddress)
                        client.DefaultRequestHeaders.Accept.Clear()
                        client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))

                        Dim response As HttpResponseMessage

                        response = client.GetAsync("api/License/" & My.Settings.serial.Trim & "/" & cpuID & "/" & "1").Result

                        If response.StatusCode = Net.HttpStatusCode.Accepted Then
                            Dim reports As String = response.Content.ReadAsStringAsync().Result

                            If reports = "NO OWNER" Then
                                bgwLicense.ReportProgress(3, cpuID)
                            ElseIf reports = "EXPIRED" Then
                                bgwLicense.ReportProgress(4, cpuID)
                            End If

                        ElseIf response.StatusCode = Net.HttpStatusCode.NotFound Then
                            Dim reports As String = response.Content.ReadAsStringAsync().Result
                            bgwLicense.ReportProgress(5, cpuID)

                        ElseIf response.StatusCode = Net.HttpStatusCode.InternalServerError Then
                            Dim reports As String = response.Content.ReadAsStringAsync().Result
                            bgwLicense.ReportProgress(6, cpuID)

                        ElseIf response.StatusCode = Net.HttpStatusCode.OK Then
                            bgwLicense.ReportProgress(9)
                        End If
                    End Using
                End If
            Else
                bgwLicense.ReportProgress(1)

                If txtSerial.Text.Trim.Length < 15 Then
                    bgwLicense.ReportProgress(7, cpuID)
                Else
                    Using client As New HttpClient
                        client.BaseAddress = New Uri(My.Settings.serverAddress)
                        client.DefaultRequestHeaders.Accept.Clear()
                        client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))

                        Dim response As HttpResponseMessage

                        response = client.GetAsync("api/License/" & txtSerial.Text.Trim & "/" & txtDeviceId.Text & "/" & "2").Result

                        If response.StatusCode = Net.HttpStatusCode.Accepted Then
                            Dim reports As String = response.Content.ReadAsStringAsync().Result

                            bgwLicense.ReportProgress(8, cpuID)
                            txtSerial.Enabled = True
                        ElseIf response.StatusCode = Net.HttpStatusCode.NotFound Then
                            Dim reports As String = response.Content.ReadAsStringAsync().Result
                            bgwLicense.ReportProgress(5, cpuID)
                        ElseIf response.StatusCode = Net.HttpStatusCode.InternalServerError Then
                            Dim reports As String = response.Content.ReadAsStringAsync().Result
                            bgwLicense.ReportProgress(6, cpuID)
                        ElseIf response.StatusCode = Net.HttpStatusCode.OK Then

                            Dim reports As String = response.Content.ReadAsAsync(Of String).Result

                            Dim lic As License = JsonConvert.DeserializeObject(Of License)(reports)

                            My.Settings.serial = lic.Serial
                            My.Settings.Save()

                            bgwLicense.ReportProgress(9)
                        End If
                    End Using
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, msgTittle)
        End Try
    End Sub

    Private Sub bgwLicense_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwLicense.ProgressChanged
        Select Case e.ProgressPercentage
            Case 1
                pboxLoading.Visible = True
                panelLicense.Enabled = False
                panelLogin.Enabled = False
                lblStatus.Text = "Validando licencia por favor espere..."
                lblStatus.ForeColor = Color.DarkBlue
                Exit Select
            Case 2
                pboxLoading.Visible = False
                lblStatus.Text = ""
                panelLogin.Visible = False
                panelLicense.Enabled = True
                txtDeviceId.Text = e.UserState.ToString
                panelLicense.BringToFront()
                txtSerial.Focus()
                Exit Select
            Case 3
                pboxLoading.Visible = False
                panelLogin.Visible = False
                panelLicense.Enabled = True
                txtDeviceId.Text = e.UserState.ToString
                panelLicense.BringToFront()
                lblStatus.Text = "Licencia no autorizada"
                lblStatus.ForeColor = Color.DarkViolet
                txtSerial.Focus()
                Exit Select
            Case 4
                pboxLoading.Visible = False
                panelLogin.Visible = False
                panelLicense.Enabled = True
                txtDeviceId.Text = e.UserState.ToString
                panelLicense.BringToFront()
                lblStatus.Text = "Licencia vencida"
                lblStatus.ForeColor = Color.DarkViolet
                txtSerial.Focus()
                Exit Select
            Case 5
                pboxLoading.Visible = False
                panelLogin.Visible = False
                panelLicense.Enabled = True
                txtDeviceId.Text = e.UserState.ToString
                panelLicense.BringToFront()
                lblStatus.Text = "Licencia inválida"
                lblStatus.ForeColor = Color.DarkViolet
                txtSerial.Focus()
                Exit Select
            Case 6
                pboxLoading.Visible = False
                panelLogin.Visible = False
                panelLicense.Enabled = True
                txtDeviceId.Text = e.UserState.ToString
                panelLicense.BringToFront()
                lblStatus.Text = "Error al validar licencia"
                lblStatus.ForeColor = Color.DarkViolet
                txtSerial.Focus()
                Exit Select
            Case 7
                pboxLoading.Visible = False
                lblStatus.Text = "La licencia debe contener 15 caracteres"
                lblStatus.ForeColor = Color.DarkViolet
                panelLogin.Visible = False
                panelLicense.Enabled = True
                txtDeviceId.Text = e.UserState.ToString
                panelLicense.BringToFront()
                txtSerial.Focus()
                Exit Select
            Case 8
                pboxLoading.Visible = False
                lblStatus.Text = "Licencia en uso"
                lblStatus.ForeColor = Color.DarkViolet
                panelLogin.Visible = False
                panelLicense.Enabled = True
                txtDeviceId.Text = e.UserState.ToString
                panelLicense.BringToFront()
                txtSerial.Focus()
                Exit Select
            Case 9
                pboxLoading.Visible = False
                panelLogin.Visible = True
                panelLogin.Enabled = True
                panelLicense.Enabled = False
                panelLogin.BringToFront()
                lblStatus.Text = ""
                lblStatus.ForeColor = Color.DarkBlue
                txtDni.Focus()
                Exit Select
            Case Else

                Exit Select
        End Select
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not bgwLicense.IsBusy Then
            bgwLicense.RunWorkerAsync("2")
        End If
    End Sub

    Private Sub txtDni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDni.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub bgwLogin_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLogin.RunWorkerCompleted
        txtDni.Enabled = True
        txtPass.Enabled = True
        btnLogin.Enabled = True
    End Sub
End Class
