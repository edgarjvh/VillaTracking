<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPass
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminPass))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentPass = New ZUControls.ZUTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewPass = New ZUControls.ZUTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New ZUControls.ZUTextBox()
        Me.btnChangePass = New ZUControls.ZUButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Actual"
        '
        'txtCurrentPass
        '
        Me.txtCurrentPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentPass.HintText = "Hint Text"
        Me.txtCurrentPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtCurrentPass.HintTextEnabled = False
        Me.txtCurrentPass.Location = New System.Drawing.Point(15, 26)
        Me.txtCurrentPass.Name = "txtCurrentPass"
        Me.txtCurrentPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtCurrentPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtCurrentPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtCurrentPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPass.Size = New System.Drawing.Size(311, 20)
        Me.txtCurrentPass.TabIndex = 0
        Me.txtCurrentPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nueva Contraseña"
        '
        'txtNewPass
        '
        Me.txtNewPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewPass.HintText = "Hint Text"
        Me.txtNewPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtNewPass.HintTextEnabled = False
        Me.txtNewPass.Location = New System.Drawing.Point(15, 73)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtNewPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtNewPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(311, 20)
        Me.txtNewPass.TabIndex = 1
        Me.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Confirme su Contraseña"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirmPass.HintText = "Hint Text"
        Me.txtConfirmPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtConfirmPass.HintTextEnabled = False
        Me.txtConfirmPass.Location = New System.Drawing.Point(15, 124)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtConfirmPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtConfirmPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(311, 20)
        Me.txtConfirmPass.TabIndex = 2
        Me.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.Color.Transparent
        Me.btnChangePass.BackgroundImage = CType(resources.GetObject("btnChangePass.BackgroundImage"), System.Drawing.Image)
        Me.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangePass.BackgroundOnClick = CType(resources.GetObject("btnChangePass.BackgroundOnClick"), System.Drawing.Image)
        Me.btnChangePass.BackgroundOnDisabled = CType(resources.GetObject("btnChangePass.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnChangePass.BackgroundOnHover = CType(resources.GetObject("btnChangePass.BackgroundOnHover"), System.Drawing.Image)
        Me.btnChangePass.BackgroundOnNormal = CType(resources.GetObject("btnChangePass.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnChangePass.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnChangePass.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnChangePass.FlatAppearance.BorderSize = 0
        Me.btnChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePass.Location = New System.Drawing.Point(98, 159)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(142, 34)
        Me.btnChangePass.TabIndex = 3
        Me.btnChangePass.Text = "Cambiar Contraseña"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'frmAdminPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 199)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurrentPass)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contraseña de Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentPass As ZUControls.ZUTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewPass As ZUControls.ZUTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPass As ZUControls.ZUTextBox
    Friend WithEvents btnChangePass As ZUControls.ZUButton
End Class
