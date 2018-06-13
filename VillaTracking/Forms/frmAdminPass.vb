Imports MySql.Data.MySqlClient

Public Class frmAdminPass
    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Try
            Dim enc As New Encryptation

            Dim defPass As String = "12345"
            defPass = enc.Encrypt(defPass)

            Dim proc As New Procedure
            Dim query1 As String = "select * from configs"
            Dim query2 As String = "update configs set admin_pass = @1 where config_id = @2"
            Dim query3 As String = "insert into configs (admin_pass) values (@1)"

            Using conn As New MySqlConnection(proc.strConn)
                conn.Open()

                Dim cmd As New MySqlCommand(query1, conn)
                Dim da As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then

                    If txtCurrentPass.Text.Trim = "" Then
                        MsgBox("Debe ingresar su contraseña actual", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                        txtCurrentPass.Focus()
                        Exit Sub
                    End If

                    If txtNewPass.Text.Trim = "" Then
                        MsgBox("Debe ingresar su nueva contraseña", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                        txtNewPass.Focus()
                        Exit Sub
                    End If

                    If txtNewPass.Text.Trim <> txtConfirmPass.Text.Trim Then
                        MsgBox("La confirmación de contraseña no coincide", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                        txtConfirmPass.Focus()
                        Exit Sub
                    End If

                    If enc.Encrypt(txtCurrentPass.Text.Trim) = ds.Tables(0).Rows(0)("admin_pass").ToString Then
                        cmd = New MySqlCommand(query2, conn)
                        cmd.Parameters.AddWithValue("@1", enc.Encrypt(txtNewPass.Text.Trim))
                        cmd.Parameters.AddWithValue("@2", ds.Tables(0).Rows(0)("config_id"))
                        cmd.ExecuteNonQuery()

                        MsgBox("Contraseña actualizada exitosamente", MsgBoxStyle.Information, "Mensaje del Sistema")

                        txtCurrentPass.Text = ""
                        txtNewPass.Text = ""
                        txtConfirmPass.Text = ""

                        txtCurrentPass.Focus()
                    Else
                        MsgBox("Contraseña actual incorrecta", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                        txtCurrentPass.Focus()
                    End If
                Else
                    If txtCurrentPass.Text.Trim = "" Then
                        cmd = New MySqlCommand(query3, conn)
                        cmd.Parameters.AddWithValue("@1", enc.Encrypt(txtNewPass.Text.Trim))
                        cmd.ExecuteNonQuery()

                        MsgBox("Contraseña actualizada exitosamente", MsgBoxStyle.Information, "Mensaje del Sistema")

                        txtCurrentPass.Text = ""
                        txtNewPass.Text = ""
                        txtConfirmPass.Text = ""

                        txtCurrentPass.Focus()
                    Else
                        MsgBox("Contraseña actual incorrecta", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                        txtCurrentPass.Focus()
                    End If
                End If
            End Using

        Catch ex As Exception

        End Try
    End Sub
End Class