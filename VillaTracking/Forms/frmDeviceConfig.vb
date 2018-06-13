Imports System.IO
Imports System.IO.Ports
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmDeviceConfig
    Dim port As SerialPort
    Dim row1, row2 As DataGridViewRow
    Dim sms_stop, sms_resume, callPass As String
    Dim client_id As Integer
    Dim vehicle_id As Integer
    Dim mainForm As Form
    Dim dtTimeZones As DataTable

    Public Sub New(ByVal row1 As DataGridViewRow, ByVal row2 As DataGridViewRow,
                   Optional port As SerialPort = Nothing,
                   Optional mainForm As Form = Nothing)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.row1 = row1
        Me.row2 = row2
        Me.port = port
        Me.mainForm = mainForm

        fillData()
    End Sub

    Private Sub fillData()
        Dim device_model_id As Integer = 0

        If Not row1 Is Nothing Then
            txtImei.Text = row1.Cells("dgvDevices_imei").Value
            txtSimcard.Text = row1.Cells("dgvDevices_phone_number").Value
            device_model_id = row1.Cells("dgvDevices_device_model_id").Value
            sms_stop = row1.Cells("dgvDevices_sms_stop").Value
            sms_resume = row1.Cells("dgvDevices_sms_resume").Value
            client_id = 0
            vehicle_id = 0
        Else
            Dim enc As New Encryptation

            txtImei.Text = row2.Cells("dgvVehicles_imei").Value
            txtSimcard.Text = row2.Cells("dgvVehicles_simcard").Value
            device_model_id = row2.Cells("dgvVehicles_device_model_id").Value
            sms_stop = row2.Cells("dgvVehicles_sms_stop").Value
            sms_resume = row2.Cells("dgvVehicles_sms_resume").Value

            If Not row2.Cells("dgvVehicles_call_pass").Value.ToString() = "" Then
                txtCallPass.Text = enc.Decrypt(row2.Cells("dgvVehicles_call_pass").Value)
            End If

            client_id = row2.Cells("dgvVehicles_client_id").Value
            vehicle_id = row2.Cells("dgvVehicles_vehicle_id").Value
        End If

        If device_model_id <> 1 And device_model_id <> 7 And device_model_id <> 8 And device_model_id <> 9 And device_model_id <> 11 Then
            For Each ctl As Control In gboxSmsCommands.Controls
                If TypeOf ctl Is ZUControls.ZUTextBox Then
                    ctl.Enabled = False
                End If

                If TypeOf ctl Is RadioButton Then
                    ctl.Enabled = False
                End If

                If TypeOf ctl Is ZUControls.ZUButton Then
                    If ctl.Name <> "btnStop" And ctl.Name <> "btnResume" Then
                        ctl.Enabled = False
                    End If
                End If
            Next
        End If

        txtDevicePass.Text = "123456"

        btnFicha.Enabled = client_id > 0

        dtTimeZones = New DataTable("dtTimeZones")

        Dim col1 As New DataColumn("time_id")
        Dim col2 As New DataColumn("time_name")

        dtTimeZones.Columns.Add(col1)
        dtTimeZones.Columns.Add(col2)

        Dim row As DataRow

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-12"
        row.Item("time_name") = "UTC -12:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-11.5"
        row.Item("time_name") = "UTC -11:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-11"
        row.Item("time_name") = "UTC -11:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-10.5"
        row.Item("time_name") = "UTC -10:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-10"
        row.Item("time_name") = "UTC -10:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-9.5"
        row.Item("time_name") = "UTC -09:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-9"
        row.Item("time_name") = "UTC -09:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-8.5"
        row.Item("time_name") = "UTC -08:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-8"
        row.Item("time_name") = "UTC -08:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-7.5"
        row.Item("time_name") = "UTC -07:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-7"
        row.Item("time_name") = "UTC -07:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-6.5"
        row.Item("time_name") = "UTC -06:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-6"
        row.Item("time_name") = "UTC -06:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-5.5"
        row.Item("time_name") = "UTC -05:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-5"
        row.Item("time_name") = "UTC -05:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-4.5"
        row.Item("time_name") = "UTC -04:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-4"
        row.Item("time_name") = "UTC -04:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-3.5"
        row.Item("time_name") = "UTC -03:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-3"
        row.Item("time_name") = "UTC -03:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-2.5"
        row.Item("time_name") = "UTC -02:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-2"
        row.Item("time_name") = "UTC -02:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-1.5"
        row.Item("time_name") = "UTC -01:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-1"
        row.Item("time_name") = "UTC -01:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "-0.5"
        row.Item("time_name") = "UTC -00:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "0"
        row.Item("time_name") = "UTC  00:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "0.5"
        row.Item("time_name") = "UTC +00:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "1"
        row.Item("time_name") = "UTC +01:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "1.5"
        row.Item("time_name") = "UTC +01:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "2"
        row.Item("time_name") = "UTC +02:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "2.5"
        row.Item("time_name") = "UTC +02:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "3"
        row.Item("time_name") = "UTC +03:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "3.5"
        row.Item("time_name") = "UTC +03:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "4"
        row.Item("time_name") = "UTC +04:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "4.5"
        row.Item("time_name") = "UTC +04:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "5"
        row.Item("time_name") = "UTC +05:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "5.5"
        row.Item("time_name") = "UTC +05:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "6"
        row.Item("time_name") = "UTC +06:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "6.5"
        row.Item("time_name") = "UTC +06:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "7"
        row.Item("time_name") = "UTC +07:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "7.5"
        row.Item("time_name") = "UTC +07:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "8"
        row.Item("time_name") = "UTC +08:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "8.5"
        row.Item("time_name") = "UTC +08:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "9"
        row.Item("time_name") = "UTC +09:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "9.5"
        row.Item("time_name") = "UTC +09:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "10"
        row.Item("time_name") = "UTC +10:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "10.5"
        row.Item("time_name") = "UTC +10:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "11"
        row.Item("time_name") = "UTC +11:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "11.5"
        row.Item("time_name") = "UTC +11:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "12"
        row.Item("time_name") = "UTC +12:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "12.5"
        row.Item("time_name") = "UTC +12:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "13"
        row.Item("time_name") = "UTC +13:00"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "13.5"
        row.Item("time_name") = "UTC +13:30"
        dtTimeZones.Rows.Add(row)

        row = dtTimeZones.NewRow()
        row.Item("time_id") = "14"
        row.Item("time_name") = "UTC +14:00"
        dtTimeZones.Rows.Add(row)

        cboTimeZone.DataSource = dtTimeZones
        cboTimeZone.DisplayMember = "time_name"
        cboTimeZone.ValueMember = "time_id"
        cboTimeZone.SelectedIndex = 16
    End Sub

    Private Sub frmDeviceConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        If File.Exists(Application.StartupPath & "\images\app_icon.ico") Then
            Icon = New Icon(Application.StartupPath & "\images\app_icon.ico")
        End If

        cboTimeZone.SelectedIndex = 16

        txtDevicePass.Focus()

    End Sub

    Private Sub sendCommand(ByVal phone_number As String, ByVal message As String)
        Try
            If Not port Is Nothing AndAlso port.IsOpen Then
                port.DiscardInBuffer()
                port.Write("AT+CMGS=" & Chr(34) & phone_number & Chr(34) & Chr(13))
                Threading.Thread.Sleep(500)
                port.Write(message & Chr(26))
                Threading.Thread.Sleep(500)
                Application.DoEvents()
                'port.Write("AT+CNMI=1,2,0,1,0" & Chr(13))
                'Threading.Thread.Sleep(500)
                MsgBox("Comando enviado", MsgBoxStyle.Information, "Mensaje del Sistema")
            Else
                MsgBox("El modem se encuentra desconectado", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje del Sistema")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "reset" & txtDevicePass.Text.Trim)
    End Sub

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "begin" & txtDevicePass.Text.Trim)
    End Sub

    Private Sub btnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If txtServerIP.Text.Trim = "" Then
            MsgBox("Debe ingresar la IP del servidor", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtServerIP.Focus()
            Exit Sub
        End If

        If txtServerPort.Text.Trim = "" Then
            MsgBox("Debe ingresar el puerto del servidor", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtServerPort.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "adminip" & txtDevicePass.Text.Trim & " " & txtServerIP.Text.Trim & " " & txtServerPort.Text.Trim)
    End Sub

    Private Sub btnApn_Click(sender As Object, e As EventArgs) Handles btnApn.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If txtApn.Text.Trim = "" Then
            MsgBox("Debe ingresar el apn de la operadora telefónica", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtApn.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "apn" & txtDevicePass.Text.Trim & " " & txtApn.Text.Trim)
    End Sub

    Private Sub btnGprs_Click(sender As Object, e As EventArgs) Handles btnGprs.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "gprs" & txtDevicePass.Text.Trim & If(rbtnUdp.Checked, ",1,1", ",0,0"))
    End Sub

    Private Sub btnFix_Click(sender As Object, e As EventArgs) Handles btnFix.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "fix" & numTimeInterval.Value.ToString.PadLeft(3, "0") & If(rbtnSeg.Checked, "s", "m") & If(numQuantityInterval.Value > 0, numQuantityInterval.Value.ToString.PadLeft(3, "0"), "***") & "n" & txtDevicePass.Text.Trim)
    End Sub

    Private Sub btnNewPassword_Click(sender As Object, e As EventArgs) Handles btnNewPassword.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If txtNewGpsPassword.Text.Trim = "" Then
            MsgBox("Debe ingresar la nueva clave", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtNewGpsPassword.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "password" & txtDevicePass.Text.Trim & " " & txtNewGpsPassword.Text.Trim)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAsignAdmin.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If txtAsignPhoneAdmin.Text.Trim = "" Then
            MsgBox("Debe ingresar número telefónico administrador", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtAsignPhoneAdmin.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "admin" & txtDevicePass.Text.Trim & " " & txtAsignPhoneAdmin.Text.Trim)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "check" & txtDevicePass.Text.Trim)
    End Sub

    Private Sub btnFicha_Click(sender As Object, e As EventArgs) Handles btnFicha.Click
        Dim frm As New frmClients(client_id, mainForm, 1, vehicle_id)
        frm.Show()
        frm.BringToFront()
    End Sub

    Private Sub btnSmsStop_Click(sender As Object, e As EventArgs) Handles btnSmsStop.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If txtAdminPass.Text.Trim = "" Then
            MsgBox("Debe ingresar la contraseña de administrador para ejecutar este comando", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtAdminPass.Focus()
            Exit Sub
        End If

        Dim enc As New Encryptation
        Dim proc As New Procedure
        Dim query1 As String = "select * from configs"

        Using conn As New MySqlConnection(proc.strConn)
            conn.Open()

            Dim cmd As New MySqlCommand(query1, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                If enc.Encrypt(txtAdminPass.Text.Trim) = ds.Tables(0).Rows(0)("admin_pass").ToString Then
                    sms_stop = sms_stop.Replace("[ID]", txtImei.Text.Trim)
                    sms_stop = sms_stop.Replace("[pass]", "123456")
                    sendCommand(txtSimcard.Text.Trim, sms_stop)
                Else
                    MsgBox("Contraseña de Administrador incorrecta", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    txtAdminPass.Focus()
                End If
            End If
        End Using



    End Sub

    Private Sub btnSmsResume_Click(sender As Object, e As EventArgs) Handles btnSmsResume.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If txtAdminPass.Text.Trim = "" Then
            MsgBox("Debe ingresar la contraseña de administrador para ejecutar este comando", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtAdminPass.Focus()
            Exit Sub
        End If

        Dim enc As New Encryptation
        Dim proc As New Procedure
        Dim query1 As String = "select * from configs"

        Using conn As New MySqlConnection(proc.strConn)
            conn.Open()

            Dim cmd As New MySqlCommand(query1, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                If enc.Encrypt(txtAdminPass.Text.Trim) = ds.Tables(0).Rows(0)("admin_pass").ToString Then
                    sms_resume = sms_resume.Replace("[ID]", txtImei.Text.Trim)
                    sms_resume = sms_resume.Replace("[pass]", "123456")
                    sendCommand(txtSimcard.Text.Trim, sms_resume)
                Else
                    MsgBox("Contraseña de Administrador incorrecta", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    txtAdminPass.Focus()
                End If
            End If
        End Using
    End Sub

    Private Sub btnSms_Click(sender As Object, e As EventArgs) Handles btnSms.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "sms" & txtDevicePass.Text.Trim)
    End Sub

    Private Sub btnTimeZone_Click(sender As Object, e As EventArgs) Handles btnTimeZone.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If cboTimeZone.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar la zona horaria de la lista", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            cboTimeZone.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "time zone" & txtDevicePass.Text.Trim & " " & cboTimeZone.SelectedValue.ToString)
    End Sub

    Private Sub btnNoFix_Click(sender As Object, e As EventArgs) Handles btnNoFix.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "nofix" & txtDevicePass.Text.Trim)
    End Sub

    Private Sub gboxSmsCommands_Enter(sender As Object, e As EventArgs) Handles gboxSmsCommands.Enter

    End Sub

    Private Sub btnUnasignAdmin_Click(sender As Object, e As EventArgs) Handles btnUnasignAdmin.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        If txtUnasignPhoneAdmin.Text.Trim = "" Then
            MsgBox("Debe ingresar número telefónico a desasignar", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtUnasignPhoneAdmin.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "noadmin" & txtDevicePass.Text.Trim & " " & txtUnasignPhoneAdmin.Text.Trim)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If txtAdminPass.Text.Trim = "" Then
            MsgBox("Debe ingresar la contraseña de administrador para ejecutar este comando", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtAdminPass.Focus()
            Exit Sub
        End If

        Dim enc As New Encryptation
        Dim proc As New Procedure
        Dim query1 As String = "select * from configs"

        Using conn As New MySqlConnection(proc.strConn)
            conn.Open()

            Dim cmd As New MySqlCommand(query1, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                If enc.Encrypt(txtAdminPass.Text.Trim) = ds.Tables(0).Rows(0)("admin_pass").ToString Then
                    Dim udp As New UdpClient
                    Dim ep As New IPEndPoint(IPAddress.Parse("172.87.221.236"), 15004)
                    Dim respuesta As Byte() = Encoding.ASCII.GetBytes("@**,imei:" & txtImei.Text.Trim & ",J@" & txtImei.Text.Trim)
                    udp.Send(respuesta, respuesta.Length, ep)

                    MsgBox("Comando enviado", MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MsgBox("Contraseña de Administrador incorrecta", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    txtAdminPass.Focus()
                End If
            End If
        End Using
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        If txtAdminPass.Text.Trim = "" Then
            MsgBox("Debe ingresar la contraseña de administrador para ejecutar este comando", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtAdminPass.Focus()
            Exit Sub
        End If

        Dim enc As New Encryptation
        Dim proc As New Procedure
        Dim query1 As String = "select * from configs"

        Using conn As New MySqlConnection(proc.strConn)
            conn.Open()

            Dim cmd As New MySqlCommand(query1, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                If enc.Encrypt(txtAdminPass.Text.Trim) = ds.Tables(0).Rows(0)("admin_pass").ToString Then
                    Dim udp As New UdpClient
                    Dim ep As New IPEndPoint(IPAddress.Parse("172.87.221.236"), 15004)
                    Dim respuesta As Byte() = Encoding.ASCII.GetBytes("@**,imei:" & txtImei.Text.Trim & ",K@" & txtImei.Text.Trim)
                    udp.Send(respuesta, respuesta.Length, ep)

                    MsgBox("Comando enviado", MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MsgBox("Contraseña de Administrador incorrecta", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    txtAdminPass.Focus()
                End If
            End If
        End Using
    End Sub

    Private Sub btnImei_Click(sender As Object, e As EventArgs) Handles btnImei.Click
        If txtSimcard.Text.Trim = "" Then
            MsgBox("El campo simcard está vacío", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtDevicePass.Text.Trim = "" OrElse txtDevicePass.Text.Trim.Length < 6 Then
            MsgBox("El campo clave debe contener 6 dígitos", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            txtDevicePass.Focus()
            Exit Sub
        End If

        sendCommand(txtSimcard.Text.Trim, "imei" & txtDevicePass.Text.Trim)
    End Sub
End Class