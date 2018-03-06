<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pboxLogo = New System.Windows.Forms.PictureBox()
        Me.txtDni = New ZUControls.ZUNumericBox()
        Me.txtPass = New ZUControls.ZUTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pboxLoading = New System.Windows.Forms.PictureBox()
        Me.bgwLogin = New System.ComponentModel.BackgroundWorker()
        Me.btnLogin = New ZUControls.ZUButton()
        Me.panelLogin = New ZUControls.ZUPanel()
        Me.panelLicense = New ZUControls.ZUPanel()
        Me.btnSubmit = New ZUControls.ZUButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeviceId = New ZUControls.ZUTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSerial = New ZUControls.ZUTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bgwLicense = New System.ComponentModel.BackgroundWorker()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin.SuspendLayout()
        Me.panelLicense.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cédula Rif"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Contraseña"
        '
        'pboxLogo
        '
        Me.pboxLogo.Image = Global.VillaTracking.My.Resources.Resources.Logotipo
        Me.pboxLogo.Location = New System.Drawing.Point(17, 9)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(301, 67)
        Me.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLogo.TabIndex = 2
        Me.pboxLogo.TabStop = False
        '
        'txtDni
        '
        Me.txtDni.CaracterDecimal = False
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.HintText = "Hint Text"
        Me.txtDni.HintTextColor = System.Drawing.Color.Gray
        Me.txtDni.HintTextEnabled = False
        Me.txtDni.Location = New System.Drawing.Point(91, 79)
        Me.txtDni.MaxLength = 10
        Me.txtDni.Name = "txtDni"
        Me.txtDni.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtDni.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtDni.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtDni.Size = New System.Drawing.Size(227, 20)
        Me.txtDni.TabIndex = 0
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.HintText = "Hint Text"
        Me.txtPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtPass.HintTextEnabled = False
        Me.txtPass.Location = New System.Drawing.Point(91, 105)
        Me.txtPass.MaxLength = 20
        Me.txtPass.Name = "txtPass"
        Me.txtPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(227, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Location = New System.Drawing.Point(0, 181)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(337, 25)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pboxLoading
        '
        Me.pboxLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pboxLoading.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pboxLoading.Image = Global.VillaTracking.My.Resources.Resources.loading
        Me.pboxLoading.Location = New System.Drawing.Point(316, 181)
        Me.pboxLoading.Name = "pboxLoading"
        Me.pboxLoading.Size = New System.Drawing.Size(21, 25)
        Me.pboxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLoading.TabIndex = 6
        Me.pboxLoading.TabStop = False
        Me.pboxLoading.Visible = False
        '
        'bgwLogin
        '
        Me.bgwLogin.WorkerReportsProgress = True
        Me.bgwLogin.WorkerSupportsCancellation = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BackgroundOnClick = CType(resources.GetObject("btnLogin.BackgroundOnClick"), System.Drawing.Image)
        Me.btnLogin.BackgroundOnDisabled = CType(resources.GetObject("btnLogin.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnLogin.BackgroundOnHover = CType(resources.GetObject("btnLogin.BackgroundOnHover"), System.Drawing.Image)
        Me.btnLogin.BackgroundOnNormal = CType(resources.GetObject("btnLogin.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnLogin.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnLogin.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(230, 132)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 30)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Acceder"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'panelLogin
        '
        Me.panelLogin.Controls.Add(Me.pboxLogo)
        Me.panelLogin.Controls.Add(Me.btnLogin)
        Me.panelLogin.Controls.Add(Me.Label1)
        Me.panelLogin.Controls.Add(Me.Label3)
        Me.panelLogin.Controls.Add(Me.txtPass)
        Me.panelLogin.Controls.Add(Me.txtDni)
        Me.panelLogin.Location = New System.Drawing.Point(3, 3)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(333, 172)
        Me.panelLogin.TabIndex = 8
        '
        'panelLicense
        '
        Me.panelLicense.Controls.Add(Me.btnSubmit)
        Me.panelLicense.Controls.Add(Me.Label2)
        Me.panelLicense.Controls.Add(Me.txtDeviceId)
        Me.panelLicense.Controls.Add(Me.Label4)
        Me.panelLicense.Controls.Add(Me.txtSerial)
        Me.panelLicense.Controls.Add(Me.Label5)
        Me.panelLicense.Location = New System.Drawing.Point(3, 3)
        Me.panelLicense.Name = "panelLicense"
        Me.panelLicense.Size = New System.Drawing.Size(333, 172)
        Me.panelLicense.TabIndex = 9
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BackgroundImage = CType(resources.GetObject("btnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmit.BackgroundOnClick = CType(resources.GetObject("btnSubmit.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSubmit.BackgroundOnDisabled = CType(resources.GetObject("btnSubmit.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSubmit.BackgroundOnHover = CType(resources.GetObject("btnSubmit.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSubmit.BackgroundOnNormal = CType(resources.GetObject("btnSubmit.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSubmit.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSubmit.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(230, 132)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(88, 30)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Registrar"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Registro de Aplicación"
        '
        'txtDeviceId
        '
        Me.txtDeviceId.HintText = "Hint Text"
        Me.txtDeviceId.HintTextColor = System.Drawing.Color.Gray
        Me.txtDeviceId.HintTextEnabled = False
        Me.txtDeviceId.Location = New System.Drawing.Point(17, 108)
        Me.txtDeviceId.MaxLength = 15
        Me.txtDeviceId.Name = "txtDeviceId"
        Me.txtDeviceId.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtDeviceId.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtDeviceId.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtDeviceId.ReadOnly = True
        Me.txtDeviceId.Size = New System.Drawing.Size(302, 20)
        Me.txtDeviceId.TabIndex = 12
        Me.txtDeviceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID Dispositivo"
        '
        'txtSerial
        '
        Me.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial.HintText = "Hint Text"
        Me.txtSerial.HintTextColor = System.Drawing.Color.Gray
        Me.txtSerial.HintTextEnabled = False
        Me.txtSerial.Location = New System.Drawing.Point(17, 59)
        Me.txtSerial.MaxLength = 15
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtSerial.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtSerial.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtSerial.Size = New System.Drawing.Size(302, 20)
        Me.txtSerial.TabIndex = 13
        Me.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Serial"
        '
        'bgwLicense
        '
        Me.bgwLicense.WorkerReportsProgress = True
        Me.bgwLicense.WorkerSupportsCancellation = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 206)
        Me.Controls.Add(Me.pboxLoading)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.panelLicense)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        Me.panelLicense.ResumeLayout(False)
        Me.panelLicense.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pboxLogo As PictureBox
    Friend WithEvents txtDni As ZUControls.ZUNumericBox
    Friend WithEvents txtPass As ZUControls.ZUTextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents pboxLoading As PictureBox
    Friend WithEvents bgwLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnLogin As ZUControls.ZUButton
    Friend WithEvents panelLogin As ZUControls.ZUPanel
    Friend WithEvents panelLicense As ZUControls.ZUPanel
    Friend WithEvents btnSubmit As ZUControls.ZUButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDeviceId As ZUControls.ZUTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSerial As ZUControls.ZUTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bgwLicense As System.ComponentModel.BackgroundWorker
End Class
