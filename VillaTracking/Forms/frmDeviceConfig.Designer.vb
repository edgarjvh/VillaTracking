<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeviceConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeviceConfig))
        Me.btnFicha = New ZUControls.ZUButton()
        Me.txtCallPass = New ZUControls.ZUTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbtnTcp = New System.Windows.Forms.RadioButton()
        Me.rbtnUdp = New System.Windows.Forms.RadioButton()
        Me.txtApn = New ZUControls.ZUTextBox()
        Me.txtServerIP = New ZUControls.ZUTextBox()
        Me.btnImei = New ZUControls.ZUButton()
        Me.btnCheck = New ZUControls.ZUButton()
        Me.btnResume = New ZUControls.ZUButton()
        Me.btnStop = New ZUControls.ZUButton()
        Me.btnAsignAdmin = New ZUControls.ZUButton()
        Me.btnApn = New ZUControls.ZUButton()
        Me.btnNewPassword = New ZUControls.ZUButton()
        Me.btnServer = New ZUControls.ZUButton()
        Me.btnFix = New ZUControls.ZUButton()
        Me.btnBegin = New ZUControls.ZUButton()
        Me.btnGprs = New ZUControls.ZUButton()
        Me.btnReset = New ZUControls.ZUButton()
        Me.lblComandoCheck = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblComandoPassword = New System.Windows.Forms.Label()
        Me.lblComandoFix = New System.Windows.Forms.Label()
        Me.lblComandoGprs = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblComandoApn = New System.Windows.Forms.Label()
        Me.lblComandoAdminIp = New System.Windows.Forms.Label()
        Me.lblComandoBegin = New System.Windows.Forms.Label()
        Me.lblComandoReset = New System.Windows.Forms.Label()
        Me.txtSimcard = New ZUControls.ZUTextBox()
        Me.txtDevicePass = New ZUControls.ZUNumericBox()
        Me.txtImei = New ZUControls.ZUNumericBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxSmsCommands = New System.Windows.Forms.GroupBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSmsResume = New ZUControls.ZUButton()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.btnSmsStop = New ZUControls.ZUButton()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnNoFix = New ZUControls.ZUButton()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.btnUnasignAdmin = New ZUControls.ZUButton()
        Me.txtUnasignPhoneAdmin = New ZUControls.ZUNumericBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numQuantityInterval = New System.Windows.Forms.NumericUpDown()
        Me.numTimeInterval = New System.Windows.Forms.NumericUpDown()
        Me.rbtnSeg = New System.Windows.Forms.RadioButton()
        Me.rbtnMin = New System.Windows.Forms.RadioButton()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSms = New ZUControls.ZUButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cboTimeZone = New ZUControls.ZUComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTimeZone = New ZUControls.ZUButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtAsignPhoneAdmin = New ZUControls.ZUNumericBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtNewGpsPassword = New ZUControls.ZUNumericBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtServerPort = New ZUControls.ZUNumericBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdminPass = New ZUControls.ZUTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gboxDevice = New System.Windows.Forms.GroupBox()
        Me.gboxSmsCommands.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.numQuantityInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTimeInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gboxDevice.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFicha
        '
        Me.btnFicha.BackColor = System.Drawing.Color.Transparent
        Me.btnFicha.BackgroundImage = CType(resources.GetObject("btnFicha.BackgroundImage"), System.Drawing.Image)
        Me.btnFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFicha.BackgroundOnClick = CType(resources.GetObject("btnFicha.BackgroundOnClick"), System.Drawing.Image)
        Me.btnFicha.BackgroundOnDisabled = CType(resources.GetObject("btnFicha.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnFicha.BackgroundOnHover = CType(resources.GetObject("btnFicha.BackgroundOnHover"), System.Drawing.Image)
        Me.btnFicha.BackgroundOnNormal = CType(resources.GetObject("btnFicha.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnFicha.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnFicha.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnFicha.FlatAppearance.BorderSize = 0
        Me.btnFicha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFicha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFicha.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFicha.ForeColor = System.Drawing.Color.White
        Me.btnFicha.Location = New System.Drawing.Point(588, 462)
        Me.btnFicha.Name = "btnFicha"
        Me.btnFicha.Size = New System.Drawing.Size(118, 25)
        Me.btnFicha.TabIndex = 17
        Me.btnFicha.Text = "Abrir Ficha de Cliente"
        Me.btnFicha.UseVisualStyleBackColor = False
        Me.btnFicha.Visible = False
        '
        'txtCallPass
        '
        Me.txtCallPass.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallPass.HintText = "Hint Text"
        Me.txtCallPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtCallPass.HintTextEnabled = False
        Me.txtCallPass.Location = New System.Drawing.Point(106, 464)
        Me.txtCallPass.Name = "txtCallPass"
        Me.txtCallPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtCallPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtCallPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtCallPass.ReadOnly = True
        Me.txtCallPass.Size = New System.Drawing.Size(474, 21)
        Me.txtCallPass.TabIndex = 16
        Me.txtCallPass.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Clave Telefónica"
        Me.Label7.Visible = False
        '
        'rbtnTcp
        '
        Me.rbtnTcp.AutoSize = True
        Me.rbtnTcp.Font = New System.Drawing.Font("NewsGoth BT", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTcp.ForeColor = System.Drawing.Color.Black
        Me.rbtnTcp.Location = New System.Drawing.Point(218, 28)
        Me.rbtnTcp.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtnTcp.Name = "rbtnTcp"
        Me.rbtnTcp.Size = New System.Drawing.Size(40, 15)
        Me.rbtnTcp.TabIndex = 1
        Me.rbtnTcp.Text = "TCP"
        Me.rbtnTcp.UseVisualStyleBackColor = True
        '
        'rbtnUdp
        '
        Me.rbtnUdp.AutoSize = True
        Me.rbtnUdp.Checked = True
        Me.rbtnUdp.Font = New System.Drawing.Font("NewsGoth BT", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUdp.ForeColor = System.Drawing.Color.Black
        Me.rbtnUdp.Location = New System.Drawing.Point(218, 13)
        Me.rbtnUdp.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtnUdp.Name = "rbtnUdp"
        Me.rbtnUdp.Size = New System.Drawing.Size(41, 15)
        Me.rbtnUdp.TabIndex = 0
        Me.rbtnUdp.TabStop = True
        Me.rbtnUdp.Text = "UDP"
        Me.rbtnUdp.UseVisualStyleBackColor = True
        '
        'txtApn
        '
        Me.txtApn.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtApn.HintText = "Hint Text"
        Me.txtApn.HintTextColor = System.Drawing.Color.Gray
        Me.txtApn.HintTextEnabled = False
        Me.txtApn.Location = New System.Drawing.Point(41, 18)
        Me.txtApn.Name = "txtApn"
        Me.txtApn.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtApn.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtApn.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtApn.Size = New System.Drawing.Size(234, 21)
        Me.txtApn.TabIndex = 0
        '
        'txtServerIP
        '
        Me.txtServerIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtServerIP.HintText = "Hint Text"
        Me.txtServerIP.HintTextColor = System.Drawing.Color.Gray
        Me.txtServerIP.HintTextEnabled = False
        Me.txtServerIP.Location = New System.Drawing.Point(29, 17)
        Me.txtServerIP.MaxLength = 15
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtServerIP.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtServerIP.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtServerIP.Size = New System.Drawing.Size(143, 21)
        Me.txtServerIP.TabIndex = 0
        Me.txtServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnImei
        '
        Me.btnImei.BackColor = System.Drawing.Color.Transparent
        Me.btnImei.BackgroundImage = CType(resources.GetObject("btnImei.BackgroundImage"), System.Drawing.Image)
        Me.btnImei.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImei.BackgroundOnClick = CType(resources.GetObject("btnImei.BackgroundOnClick"), System.Drawing.Image)
        Me.btnImei.BackgroundOnDisabled = CType(resources.GetObject("btnImei.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnImei.BackgroundOnHover = CType(resources.GetObject("btnImei.BackgroundOnHover"), System.Drawing.Image)
        Me.btnImei.BackgroundOnNormal = CType(resources.GetObject("btnImei.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnImei.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnImei.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnImei.FlatAppearance.BorderSize = 0
        Me.btnImei.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImei.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImei.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImei.ForeColor = System.Drawing.Color.White
        Me.btnImei.Location = New System.Drawing.Point(282, 15)
        Me.btnImei.Name = "btnImei"
        Me.btnImei.Size = New System.Drawing.Size(56, 25)
        Me.btnImei.TabIndex = 0
        Me.btnImei.Text = "Enviar"
        Me.btnImei.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Transparent
        Me.btnCheck.BackgroundImage = CType(resources.GetObject("btnCheck.BackgroundImage"), System.Drawing.Image)
        Me.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCheck.BackgroundOnClick = CType(resources.GetObject("btnCheck.BackgroundOnClick"), System.Drawing.Image)
        Me.btnCheck.BackgroundOnDisabled = CType(resources.GetObject("btnCheck.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnCheck.BackgroundOnHover = CType(resources.GetObject("btnCheck.BackgroundOnHover"), System.Drawing.Image)
        Me.btnCheck.BackgroundOnNormal = CType(resources.GetObject("btnCheck.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnCheck.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnCheck.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.Location = New System.Drawing.Point(282, 15)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(56, 25)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Enviar"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.Transparent
        Me.btnResume.BackgroundImage = CType(resources.GetObject("btnResume.BackgroundImage"), System.Drawing.Image)
        Me.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnResume.BackgroundOnClick = CType(resources.GetObject("btnResume.BackgroundOnClick"), System.Drawing.Image)
        Me.btnResume.BackgroundOnDisabled = CType(resources.GetObject("btnResume.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnResume.BackgroundOnHover = CType(resources.GetObject("btnResume.BackgroundOnHover"), System.Drawing.Image)
        Me.btnResume.BackgroundOnNormal = CType(resources.GetObject("btnResume.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnResume.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnResume.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnResume.FlatAppearance.BorderSize = 0
        Me.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResume.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResume.ForeColor = System.Drawing.Color.Black
        Me.btnResume.Location = New System.Drawing.Point(282, 15)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(56, 25)
        Me.btnResume.TabIndex = 1
        Me.btnResume.Text = "GPRS"
        Me.btnResume.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.BackgroundImage = CType(resources.GetObject("btnStop.BackgroundImage"), System.Drawing.Image)
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.BackgroundOnClick = CType(resources.GetObject("btnStop.BackgroundOnClick"), System.Drawing.Image)
        Me.btnStop.BackgroundOnDisabled = CType(resources.GetObject("btnStop.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnStop.BackgroundOnHover = CType(resources.GetObject("btnStop.BackgroundOnHover"), System.Drawing.Image)
        Me.btnStop.BackgroundOnNormal = CType(resources.GetObject("btnStop.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnStop.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnStop.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(282, 15)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(56, 25)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "GPRS"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnAsignAdmin
        '
        Me.btnAsignAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAsignAdmin.BackgroundImage = CType(resources.GetObject("btnAsignAdmin.BackgroundImage"), System.Drawing.Image)
        Me.btnAsignAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsignAdmin.BackgroundOnClick = CType(resources.GetObject("btnAsignAdmin.BackgroundOnClick"), System.Drawing.Image)
        Me.btnAsignAdmin.BackgroundOnDisabled = CType(resources.GetObject("btnAsignAdmin.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnAsignAdmin.BackgroundOnHover = CType(resources.GetObject("btnAsignAdmin.BackgroundOnHover"), System.Drawing.Image)
        Me.btnAsignAdmin.BackgroundOnNormal = CType(resources.GetObject("btnAsignAdmin.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnAsignAdmin.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnAsignAdmin.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnAsignAdmin.FlatAppearance.BorderSize = 0
        Me.btnAsignAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAsignAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAsignAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignAdmin.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAsignAdmin.Location = New System.Drawing.Point(282, 16)
        Me.btnAsignAdmin.Name = "btnAsignAdmin"
        Me.btnAsignAdmin.Size = New System.Drawing.Size(56, 25)
        Me.btnAsignAdmin.TabIndex = 1
        Me.btnAsignAdmin.Text = "Enviar"
        Me.btnAsignAdmin.UseVisualStyleBackColor = False
        '
        'btnApn
        '
        Me.btnApn.BackColor = System.Drawing.Color.Transparent
        Me.btnApn.BackgroundImage = CType(resources.GetObject("btnApn.BackgroundImage"), System.Drawing.Image)
        Me.btnApn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnApn.BackgroundOnClick = CType(resources.GetObject("btnApn.BackgroundOnClick"), System.Drawing.Image)
        Me.btnApn.BackgroundOnDisabled = CType(resources.GetObject("btnApn.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnApn.BackgroundOnHover = CType(resources.GetObject("btnApn.BackgroundOnHover"), System.Drawing.Image)
        Me.btnApn.BackgroundOnNormal = CType(resources.GetObject("btnApn.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnApn.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnApn.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnApn.FlatAppearance.BorderSize = 0
        Me.btnApn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnApn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnApn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApn.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApn.ForeColor = System.Drawing.Color.White
        Me.btnApn.Location = New System.Drawing.Point(282, 16)
        Me.btnApn.Name = "btnApn"
        Me.btnApn.Size = New System.Drawing.Size(56, 25)
        Me.btnApn.TabIndex = 1
        Me.btnApn.Text = "Enviar"
        Me.btnApn.UseVisualStyleBackColor = False
        '
        'btnNewPassword
        '
        Me.btnNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnNewPassword.BackgroundImage = CType(resources.GetObject("btnNewPassword.BackgroundImage"), System.Drawing.Image)
        Me.btnNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewPassword.BackgroundOnClick = CType(resources.GetObject("btnNewPassword.BackgroundOnClick"), System.Drawing.Image)
        Me.btnNewPassword.BackgroundOnDisabled = CType(resources.GetObject("btnNewPassword.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnNewPassword.BackgroundOnHover = CType(resources.GetObject("btnNewPassword.BackgroundOnHover"), System.Drawing.Image)
        Me.btnNewPassword.BackgroundOnNormal = CType(resources.GetObject("btnNewPassword.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnNewPassword.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnNewPassword.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnNewPassword.FlatAppearance.BorderSize = 0
        Me.btnNewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPassword.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPassword.ForeColor = System.Drawing.Color.White
        Me.btnNewPassword.Location = New System.Drawing.Point(282, 15)
        Me.btnNewPassword.Name = "btnNewPassword"
        Me.btnNewPassword.Size = New System.Drawing.Size(56, 25)
        Me.btnNewPassword.TabIndex = 1
        Me.btnNewPassword.Text = "Enviar"
        Me.btnNewPassword.UseVisualStyleBackColor = False
        '
        'btnServer
        '
        Me.btnServer.BackColor = System.Drawing.Color.Transparent
        Me.btnServer.BackgroundImage = CType(resources.GetObject("btnServer.BackgroundImage"), System.Drawing.Image)
        Me.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnServer.BackgroundOnClick = CType(resources.GetObject("btnServer.BackgroundOnClick"), System.Drawing.Image)
        Me.btnServer.BackgroundOnDisabled = CType(resources.GetObject("btnServer.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnServer.BackgroundOnHover = CType(resources.GetObject("btnServer.BackgroundOnHover"), System.Drawing.Image)
        Me.btnServer.BackgroundOnNormal = CType(resources.GetObject("btnServer.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnServer.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnServer.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnServer.FlatAppearance.BorderSize = 0
        Me.btnServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServer.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServer.ForeColor = System.Drawing.Color.White
        Me.btnServer.Location = New System.Drawing.Point(282, 15)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Size = New System.Drawing.Size(56, 25)
        Me.btnServer.TabIndex = 2
        Me.btnServer.Text = "Enviar"
        Me.btnServer.UseVisualStyleBackColor = False
        '
        'btnFix
        '
        Me.btnFix.BackColor = System.Drawing.Color.Transparent
        Me.btnFix.BackgroundImage = CType(resources.GetObject("btnFix.BackgroundImage"), System.Drawing.Image)
        Me.btnFix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFix.BackgroundOnClick = CType(resources.GetObject("btnFix.BackgroundOnClick"), System.Drawing.Image)
        Me.btnFix.BackgroundOnDisabled = CType(resources.GetObject("btnFix.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnFix.BackgroundOnHover = CType(resources.GetObject("btnFix.BackgroundOnHover"), System.Drawing.Image)
        Me.btnFix.BackgroundOnNormal = CType(resources.GetObject("btnFix.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnFix.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnFix.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnFix.FlatAppearance.BorderSize = 0
        Me.btnFix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFix.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFix.ForeColor = System.Drawing.Color.White
        Me.btnFix.Location = New System.Drawing.Point(282, 15)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(56, 25)
        Me.btnFix.TabIndex = 4
        Me.btnFix.Text = "Enviar"
        Me.btnFix.UseVisualStyleBackColor = False
        '
        'btnBegin
        '
        Me.btnBegin.BackColor = System.Drawing.Color.Transparent
        Me.btnBegin.BackgroundImage = CType(resources.GetObject("btnBegin.BackgroundImage"), System.Drawing.Image)
        Me.btnBegin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBegin.BackgroundOnClick = CType(resources.GetObject("btnBegin.BackgroundOnClick"), System.Drawing.Image)
        Me.btnBegin.BackgroundOnDisabled = CType(resources.GetObject("btnBegin.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnBegin.BackgroundOnHover = CType(resources.GetObject("btnBegin.BackgroundOnHover"), System.Drawing.Image)
        Me.btnBegin.BackgroundOnNormal = CType(resources.GetObject("btnBegin.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnBegin.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnBegin.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnBegin.FlatAppearance.BorderSize = 0
        Me.btnBegin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBegin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBegin.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.ForeColor = System.Drawing.Color.White
        Me.btnBegin.Location = New System.Drawing.Point(282, 15)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(56, 25)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.Text = "Enviar"
        Me.btnBegin.UseVisualStyleBackColor = False
        '
        'btnGprs
        '
        Me.btnGprs.BackColor = System.Drawing.Color.Transparent
        Me.btnGprs.BackgroundImage = CType(resources.GetObject("btnGprs.BackgroundImage"), System.Drawing.Image)
        Me.btnGprs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGprs.BackgroundOnClick = CType(resources.GetObject("btnGprs.BackgroundOnClick"), System.Drawing.Image)
        Me.btnGprs.BackgroundOnDisabled = CType(resources.GetObject("btnGprs.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnGprs.BackgroundOnHover = CType(resources.GetObject("btnGprs.BackgroundOnHover"), System.Drawing.Image)
        Me.btnGprs.BackgroundOnNormal = CType(resources.GetObject("btnGprs.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnGprs.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnGprs.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnGprs.FlatAppearance.BorderSize = 0
        Me.btnGprs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGprs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGprs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGprs.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGprs.ForeColor = System.Drawing.Color.White
        Me.btnGprs.Location = New System.Drawing.Point(282, 16)
        Me.btnGprs.Name = "btnGprs"
        Me.btnGprs.Size = New System.Drawing.Size(56, 25)
        Me.btnGprs.TabIndex = 2
        Me.btnGprs.Text = "Enviar"
        Me.btnGprs.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.BackgroundOnClick = CType(resources.GetObject("btnReset.BackgroundOnClick"), System.Drawing.Image)
        Me.btnReset.BackgroundOnDisabled = CType(resources.GetObject("btnReset.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnReset.BackgroundOnHover = CType(resources.GetObject("btnReset.BackgroundOnHover"), System.Drawing.Image)
        Me.btnReset.BackgroundOnNormal = CType(resources.GetObject("btnReset.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnReset.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnReset.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(282, 15)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(56, 25)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Enviar"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblComandoCheck
        '
        Me.lblComandoCheck.AutoSize = True
        Me.lblComandoCheck.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoCheck.ForeColor = System.Drawing.Color.Black
        Me.lblComandoCheck.Location = New System.Drawing.Point(6, 20)
        Me.lblComandoCheck.Name = "lblComandoCheck"
        Me.lblComandoCheck.Size = New System.Drawing.Size(247, 14)
        Me.lblComandoCheck.TabIndex = 6
        Me.lblComandoCheck.Text = "Solicitar la configuración actual del dispositivo gps"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Seleccione el método de envío"
        '
        'lblComandoPassword
        '
        Me.lblComandoPassword.AutoSize = True
        Me.lblComandoPassword.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoPassword.ForeColor = System.Drawing.Color.Black
        Me.lblComandoPassword.Location = New System.Drawing.Point(6, 20)
        Me.lblComandoPassword.Name = "lblComandoPassword"
        Me.lblComandoPassword.Size = New System.Drawing.Size(94, 14)
        Me.lblComandoPassword.TabIndex = 8
        Me.lblComandoPassword.Text = "Nueva Contraseña"
        '
        'lblComandoFix
        '
        Me.lblComandoFix.AutoSize = True
        Me.lblComandoFix.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoFix.ForeColor = System.Drawing.Color.Black
        Me.lblComandoFix.Location = New System.Drawing.Point(6, 22)
        Me.lblComandoFix.Name = "lblComandoFix"
        Me.lblComandoFix.Size = New System.Drawing.Size(48, 14)
        Me.lblComandoFix.TabIndex = 9
        Me.lblComandoFix.Text = "Intervalo"
        '
        'lblComandoGprs
        '
        Me.lblComandoGprs.AutoSize = True
        Me.lblComandoGprs.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoGprs.ForeColor = System.Drawing.Color.Black
        Me.lblComandoGprs.Location = New System.Drawing.Point(6, 22)
        Me.lblComandoGprs.Name = "lblComandoGprs"
        Me.lblComandoGprs.Size = New System.Drawing.Size(198, 14)
        Me.lblComandoGprs.TabIndex = 10
        Me.lblComandoGprs.Text = "Seleccione el protocolo de comunicación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Solicitar el imei del dispositivo gps"
        '
        'lblComandoApn
        '
        Me.lblComandoApn.AutoSize = True
        Me.lblComandoApn.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoApn.ForeColor = System.Drawing.Color.Black
        Me.lblComandoApn.Location = New System.Drawing.Point(6, 21)
        Me.lblComandoApn.Name = "lblComandoApn"
        Me.lblComandoApn.Size = New System.Drawing.Size(29, 14)
        Me.lblComandoApn.TabIndex = 2
        Me.lblComandoApn.Text = "APN"
        '
        'lblComandoAdminIp
        '
        Me.lblComandoAdminIp.AutoSize = True
        Me.lblComandoAdminIp.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoAdminIp.ForeColor = System.Drawing.Color.Black
        Me.lblComandoAdminIp.Location = New System.Drawing.Point(6, 20)
        Me.lblComandoAdminIp.Name = "lblComandoAdminIp"
        Me.lblComandoAdminIp.Size = New System.Drawing.Size(17, 14)
        Me.lblComandoAdminIp.TabIndex = 3
        Me.lblComandoAdminIp.Text = "IP"
        '
        'lblComandoBegin
        '
        Me.lblComandoBegin.AutoSize = True
        Me.lblComandoBegin.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoBegin.ForeColor = System.Drawing.Color.Black
        Me.lblComandoBegin.Location = New System.Drawing.Point(6, 20)
        Me.lblComandoBegin.Name = "lblComandoBegin"
        Me.lblComandoBegin.Size = New System.Drawing.Size(244, 14)
        Me.lblComandoBegin.TabIndex = 4
        Me.lblComandoBegin.Text = "Inicializar el dispositivo gps para su configuración"
        '
        'lblComandoReset
        '
        Me.lblComandoReset.AutoSize = True
        Me.lblComandoReset.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoReset.ForeColor = System.Drawing.Color.Black
        Me.lblComandoReset.Location = New System.Drawing.Point(6, 21)
        Me.lblComandoReset.Name = "lblComandoReset"
        Me.lblComandoReset.Size = New System.Drawing.Size(269, 14)
        Me.lblComandoReset.TabIndex = 5
        Me.lblComandoReset.Text = "Resetear el dispositivo gps a la configuración de fábrica"
        '
        'txtSimcard
        '
        Me.txtSimcard.BackColor = System.Drawing.SystemColors.Control
        Me.txtSimcard.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimcard.ForeColor = System.Drawing.Color.Black
        Me.txtSimcard.HintText = "Hint Text"
        Me.txtSimcard.HintTextColor = System.Drawing.Color.Gray
        Me.txtSimcard.HintTextEnabled = False
        Me.txtSimcard.Location = New System.Drawing.Point(228, 17)
        Me.txtSimcard.Name = "txtSimcard"
        Me.txtSimcard.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtSimcard.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtSimcard.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtSimcard.ReadOnly = True
        Me.txtSimcard.Size = New System.Drawing.Size(86, 21)
        Me.txtSimcard.TabIndex = 1
        Me.txtSimcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDevicePass
        '
        Me.txtDevicePass.CaracterDecimal = False
        Me.txtDevicePass.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevicePass.ForeColor = System.Drawing.Color.Black
        Me.txtDevicePass.HintText = "Hint Text"
        Me.txtDevicePass.HintTextColor = System.Drawing.Color.Gray
        Me.txtDevicePass.HintTextEnabled = False
        Me.txtDevicePass.Location = New System.Drawing.Point(409, 17)
        Me.txtDevicePass.MaxLength = 6
        Me.txtDevicePass.Name = "txtDevicePass"
        Me.txtDevicePass.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtDevicePass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtDevicePass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtDevicePass.Size = New System.Drawing.Size(58, 21)
        Me.txtDevicePass.TabIndex = 2
        Me.txtDevicePass.Text = "123456"
        Me.txtDevicePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImei
        '
        Me.txtImei.BackColor = System.Drawing.SystemColors.Control
        Me.txtImei.CaracterDecimal = False
        Me.txtImei.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImei.ForeColor = System.Drawing.Color.Black
        Me.txtImei.HintText = "Hint Text"
        Me.txtImei.HintTextColor = System.Drawing.Color.Gray
        Me.txtImei.HintTextEnabled = False
        Me.txtImei.Location = New System.Drawing.Point(43, 17)
        Me.txtImei.MaxLength = 15
        Me.txtImei.Name = "txtImei"
        Me.txtImei.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtImei.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtImei.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtImei.ReadOnly = True
        Me.txtImei.Size = New System.Drawing.Size(122, 21)
        Me.txtImei.TabIndex = 0
        Me.txtImei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(320, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Contraseña Gps"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(171, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sim Card"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Imei"
        '
        'gboxSmsCommands
        '
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox16)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox15)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox14)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox13)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox12)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox11)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox10)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox9)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox8)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox7)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox6)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox5)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox4)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox3)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox2)
        Me.gboxSmsCommands.Controls.Add(Me.GroupBox1)
        Me.gboxSmsCommands.Controls.Add(Me.btnFicha)
        Me.gboxSmsCommands.Controls.Add(Me.txtCallPass)
        Me.gboxSmsCommands.Controls.Add(Me.Label7)
        Me.gboxSmsCommands.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboxSmsCommands.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxSmsCommands.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxSmsCommands.Location = New System.Drawing.Point(0, 45)
        Me.gboxSmsCommands.Name = "gboxSmsCommands"
        Me.gboxSmsCommands.Size = New System.Drawing.Size(724, 496)
        Me.gboxSmsCommands.TabIndex = 1
        Me.gboxSmsCommands.TabStop = False
        Me.gboxSmsCommands.Text = "Comandos SMS"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Label6)
        Me.GroupBox16.Controls.Add(Me.btnResume)
        Me.GroupBox16.Controls.Add(Me.btnSmsResume)
        Me.GroupBox16.Location = New System.Drawing.Point(368, 405)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox16.TabIndex = 15
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "ENCENDIDO DE MOTOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Seleccione el método de envío"
        '
        'btnSmsResume
        '
        Me.btnSmsResume.BackColor = System.Drawing.Color.Transparent
        Me.btnSmsResume.BackgroundImage = CType(resources.GetObject("btnSmsResume.BackgroundImage"), System.Drawing.Image)
        Me.btnSmsResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSmsResume.BackgroundOnClick = CType(resources.GetObject("btnSmsResume.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSmsResume.BackgroundOnDisabled = CType(resources.GetObject("btnSmsResume.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSmsResume.BackgroundOnHover = CType(resources.GetObject("btnSmsResume.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSmsResume.BackgroundOnNormal = CType(resources.GetObject("btnSmsResume.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSmsResume.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSmsResume.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnSmsResume.FlatAppearance.BorderSize = 0
        Me.btnSmsResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSmsResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSmsResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSmsResume.ForeColor = System.Drawing.Color.Black
        Me.btnSmsResume.Location = New System.Drawing.Point(220, 15)
        Me.btnSmsResume.Name = "btnSmsResume"
        Me.btnSmsResume.Size = New System.Drawing.Size(56, 25)
        Me.btnSmsResume.TabIndex = 0
        Me.btnSmsResume.Text = "SMS"
        Me.btnSmsResume.UseVisualStyleBackColor = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label5)
        Me.GroupBox15.Controls.Add(Me.btnStop)
        Me.GroupBox15.Controls.Add(Me.btnSmsStop)
        Me.GroupBox15.Location = New System.Drawing.Point(12, 405)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox15.TabIndex = 14
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "APAGADO DE MOTOR"
        '
        'btnSmsStop
        '
        Me.btnSmsStop.BackColor = System.Drawing.Color.Transparent
        Me.btnSmsStop.BackgroundImage = CType(resources.GetObject("btnSmsStop.BackgroundImage"), System.Drawing.Image)
        Me.btnSmsStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSmsStop.BackgroundOnClick = CType(resources.GetObject("btnSmsStop.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSmsStop.BackgroundOnDisabled = CType(resources.GetObject("btnSmsStop.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSmsStop.BackgroundOnHover = CType(resources.GetObject("btnSmsStop.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSmsStop.BackgroundOnNormal = CType(resources.GetObject("btnSmsStop.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSmsStop.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSmsStop.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnSmsStop.FlatAppearance.BorderSize = 0
        Me.btnSmsStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSmsStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSmsStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSmsStop.ForeColor = System.Drawing.Color.Black
        Me.btnSmsStop.Location = New System.Drawing.Point(220, 15)
        Me.btnSmsStop.Name = "btnSmsStop"
        Me.btnSmsStop.Size = New System.Drawing.Size(56, 25)
        Me.btnSmsStop.TabIndex = 0
        Me.btnSmsStop.Text = "SMS"
        Me.btnSmsStop.UseVisualStyleBackColor = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Label11)
        Me.GroupBox14.Controls.Add(Me.btnNoFix)
        Me.GroupBox14.Location = New System.Drawing.Point(368, 350)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox14.TabIndex = 13
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "DESACTIVAR INTERVALO DE REPORTES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(216, 14)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Cancelar el envío de reportes por sms o gprs"
        '
        'btnNoFix
        '
        Me.btnNoFix.BackColor = System.Drawing.Color.Transparent
        Me.btnNoFix.BackgroundImage = CType(resources.GetObject("btnNoFix.BackgroundImage"), System.Drawing.Image)
        Me.btnNoFix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNoFix.BackgroundOnClick = CType(resources.GetObject("btnNoFix.BackgroundOnClick"), System.Drawing.Image)
        Me.btnNoFix.BackgroundOnDisabled = CType(resources.GetObject("btnNoFix.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnNoFix.BackgroundOnHover = CType(resources.GetObject("btnNoFix.BackgroundOnHover"), System.Drawing.Image)
        Me.btnNoFix.BackgroundOnNormal = CType(resources.GetObject("btnNoFix.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnNoFix.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnNoFix.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnNoFix.FlatAppearance.BorderSize = 0
        Me.btnNoFix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNoFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNoFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoFix.ForeColor = System.Drawing.Color.White
        Me.btnNoFix.Location = New System.Drawing.Point(282, 15)
        Me.btnNoFix.Name = "btnNoFix"
        Me.btnNoFix.Size = New System.Drawing.Size(56, 25)
        Me.btnNoFix.TabIndex = 0
        Me.btnNoFix.Text = "Enviar"
        Me.btnNoFix.UseVisualStyleBackColor = False
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.btnUnasignAdmin)
        Me.GroupBox13.Controls.Add(Me.txtUnasignPhoneAdmin)
        Me.GroupBox13.Location = New System.Drawing.Point(368, 240)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox13.TabIndex = 9
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "DESASIGNAR TELÉFONO ADMINISTRADOR"
        '
        'btnUnasignAdmin
        '
        Me.btnUnasignAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnUnasignAdmin.BackgroundImage = CType(resources.GetObject("btnUnasignAdmin.BackgroundImage"), System.Drawing.Image)
        Me.btnUnasignAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUnasignAdmin.BackgroundOnClick = CType(resources.GetObject("btnUnasignAdmin.BackgroundOnClick"), System.Drawing.Image)
        Me.btnUnasignAdmin.BackgroundOnDisabled = CType(resources.GetObject("btnUnasignAdmin.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnUnasignAdmin.BackgroundOnHover = CType(resources.GetObject("btnUnasignAdmin.BackgroundOnHover"), System.Drawing.Image)
        Me.btnUnasignAdmin.BackgroundOnNormal = CType(resources.GetObject("btnUnasignAdmin.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnUnasignAdmin.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnUnasignAdmin.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnUnasignAdmin.FlatAppearance.BorderSize = 0
        Me.btnUnasignAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUnasignAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUnasignAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnasignAdmin.ForeColor = System.Drawing.Color.White
        Me.btnUnasignAdmin.Location = New System.Drawing.Point(282, 16)
        Me.btnUnasignAdmin.Name = "btnUnasignAdmin"
        Me.btnUnasignAdmin.Size = New System.Drawing.Size(56, 25)
        Me.btnUnasignAdmin.TabIndex = 1
        Me.btnUnasignAdmin.Text = "Enviar"
        Me.btnUnasignAdmin.UseVisualStyleBackColor = False
        '
        'txtUnasignPhoneAdmin
        '
        Me.txtUnasignPhoneAdmin.CaracterDecimal = False
        Me.txtUnasignPhoneAdmin.HintText = "Hint Text"
        Me.txtUnasignPhoneAdmin.HintTextColor = System.Drawing.Color.Gray
        Me.txtUnasignPhoneAdmin.HintTextEnabled = False
        Me.txtUnasignPhoneAdmin.Location = New System.Drawing.Point(9, 19)
        Me.txtUnasignPhoneAdmin.MaxLength = 11
        Me.txtUnasignPhoneAdmin.Name = "txtUnasignPhoneAdmin"
        Me.txtUnasignPhoneAdmin.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtUnasignPhoneAdmin.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtUnasignPhoneAdmin.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtUnasignPhoneAdmin.Size = New System.Drawing.Size(266, 21)
        Me.txtUnasignPhoneAdmin.TabIndex = 0
        Me.txtUnasignPhoneAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label13)
        Me.GroupBox12.Controls.Add(Me.lblComandoFix)
        Me.GroupBox12.Controls.Add(Me.btnFix)
        Me.GroupBox12.Controls.Add(Me.numQuantityInterval)
        Me.GroupBox12.Controls.Add(Me.numTimeInterval)
        Me.GroupBox12.Controls.Add(Me.rbtnSeg)
        Me.GroupBox12.Controls.Add(Me.rbtnMin)
        Me.GroupBox12.Location = New System.Drawing.Point(12, 350)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox12.TabIndex = 12
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "ACTIVAR INTERVALO DE REPORTES"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(166, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 14)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Cantidad"
        '
        'numQuantityInterval
        '
        Me.numQuantityInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numQuantityInterval.Location = New System.Drawing.Point(222, 18)
        Me.numQuantityInterval.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numQuantityInterval.Name = "numQuantityInterval"
        Me.numQuantityInterval.Size = New System.Drawing.Size(50, 21)
        Me.numQuantityInterval.TabIndex = 3
        Me.numQuantityInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numTimeInterval
        '
        Me.numTimeInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numTimeInterval.Location = New System.Drawing.Point(59, 18)
        Me.numTimeInterval.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.numTimeInterval.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numTimeInterval.Name = "numTimeInterval"
        Me.numTimeInterval.Size = New System.Drawing.Size(50, 21)
        Me.numTimeInterval.TabIndex = 0
        Me.numTimeInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numTimeInterval.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'rbtnSeg
        '
        Me.rbtnSeg.AutoSize = True
        Me.rbtnSeg.Checked = True
        Me.rbtnSeg.Font = New System.Drawing.Font("NewsGoth BT", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSeg.ForeColor = System.Drawing.Color.Black
        Me.rbtnSeg.Location = New System.Drawing.Point(118, 14)
        Me.rbtnSeg.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtnSeg.Name = "rbtnSeg"
        Me.rbtnSeg.Size = New System.Drawing.Size(39, 15)
        Me.rbtnSeg.TabIndex = 1
        Me.rbtnSeg.TabStop = True
        Me.rbtnSeg.Text = "SEG"
        Me.rbtnSeg.UseVisualStyleBackColor = True
        '
        'rbtnMin
        '
        Me.rbtnMin.AutoSize = True
        Me.rbtnMin.Font = New System.Drawing.Font("NewsGoth BT", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMin.ForeColor = System.Drawing.Color.Black
        Me.rbtnMin.Location = New System.Drawing.Point(118, 29)
        Me.rbtnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtnMin.Name = "rbtnMin"
        Me.rbtnMin.Size = New System.Drawing.Size(40, 15)
        Me.rbtnMin.TabIndex = 2
        Me.rbtnMin.Text = "MIN"
        Me.rbtnMin.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label8)
        Me.GroupBox11.Controls.Add(Me.btnSms)
        Me.GroupBox11.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox11.TabIndex = 10
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "ACTIVAR MODO SMS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(226, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Transmisión de reportes por mensajes de texto"
        '
        'btnSms
        '
        Me.btnSms.BackColor = System.Drawing.Color.Transparent
        Me.btnSms.BackgroundImage = CType(resources.GetObject("btnSms.BackgroundImage"), System.Drawing.Image)
        Me.btnSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSms.BackgroundOnClick = CType(resources.GetObject("btnSms.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSms.BackgroundOnDisabled = CType(resources.GetObject("btnSms.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSms.BackgroundOnHover = CType(resources.GetObject("btnSms.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSms.BackgroundOnNormal = CType(resources.GetObject("btnSms.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSms.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSms.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnSms.FlatAppearance.BorderSize = 0
        Me.btnSms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSms.ForeColor = System.Drawing.Color.White
        Me.btnSms.Location = New System.Drawing.Point(282, 16)
        Me.btnSms.Name = "btnSms"
        Me.btnSms.Size = New System.Drawing.Size(56, 25)
        Me.btnSms.TabIndex = 0
        Me.btnSms.Text = "Enviar"
        Me.btnSms.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lblComandoGprs)
        Me.GroupBox10.Controls.Add(Me.btnGprs)
        Me.GroupBox10.Controls.Add(Me.rbtnUdp)
        Me.GroupBox10.Controls.Add(Me.rbtnTcp)
        Me.GroupBox10.Location = New System.Drawing.Point(368, 295)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox10.TabIndex = 11
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "ACTIVAR MODO GPRS"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cboTimeZone)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.btnTimeZone)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "ZONA HORARIA"
        '
        'cboTimeZone
        '
        Me.cboTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTimeZone.FormattingEnabled = True
        Me.cboTimeZone.HintText = "Hint Text"
        Me.cboTimeZone.HintTextColor = System.Drawing.Color.Gray
        Me.cboTimeZone.HintTextEnabled = False
        Me.cboTimeZone.Location = New System.Drawing.Point(147, 18)
        Me.cboTimeZone.Name = "cboTimeZone"
        Me.cboTimeZone.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboTimeZone.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboTimeZone.Size = New System.Drawing.Size(128, 22)
        Me.cboTimeZone.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 14)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Seleccione la Zona Horaria"
        '
        'btnTimeZone
        '
        Me.btnTimeZone.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeZone.BackgroundImage = CType(resources.GetObject("btnTimeZone.BackgroundImage"), System.Drawing.Image)
        Me.btnTimeZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimeZone.BackgroundOnClick = CType(resources.GetObject("btnTimeZone.BackgroundOnClick"), System.Drawing.Image)
        Me.btnTimeZone.BackgroundOnDisabled = CType(resources.GetObject("btnTimeZone.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnTimeZone.BackgroundOnHover = CType(resources.GetObject("btnTimeZone.BackgroundOnHover"), System.Drawing.Image)
        Me.btnTimeZone.BackgroundOnNormal = CType(resources.GetObject("btnTimeZone.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnTimeZone.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnTimeZone.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnTimeZone.FlatAppearance.BorderSize = 0
        Me.btnTimeZone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTimeZone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTimeZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeZone.ForeColor = System.Drawing.Color.White
        Me.btnTimeZone.Location = New System.Drawing.Point(282, 16)
        Me.btnTimeZone.Name = "btnTimeZone"
        Me.btnTimeZone.Size = New System.Drawing.Size(56, 25)
        Me.btnTimeZone.TabIndex = 1
        Me.btnTimeZone.Text = "Enviar"
        Me.btnTimeZone.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtAsignPhoneAdmin)
        Me.GroupBox8.Controls.Add(Me.btnAsignAdmin)
        Me.GroupBox8.Location = New System.Drawing.Point(368, 185)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "ASIGNAR TELÉFONO ADMINISTRADOR"
        '
        'txtAsignPhoneAdmin
        '
        Me.txtAsignPhoneAdmin.CaracterDecimal = False
        Me.txtAsignPhoneAdmin.HintText = "Hint Text"
        Me.txtAsignPhoneAdmin.HintTextColor = System.Drawing.Color.Gray
        Me.txtAsignPhoneAdmin.HintTextEnabled = False
        Me.txtAsignPhoneAdmin.Location = New System.Drawing.Point(9, 18)
        Me.txtAsignPhoneAdmin.MaxLength = 11
        Me.txtAsignPhoneAdmin.Name = "txtAsignPhoneAdmin"
        Me.txtAsignPhoneAdmin.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtAsignPhoneAdmin.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtAsignPhoneAdmin.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtAsignPhoneAdmin.Size = New System.Drawing.Size(266, 21)
        Me.txtAsignPhoneAdmin.TabIndex = 0
        Me.txtAsignPhoneAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblComandoApn)
        Me.GroupBox7.Controls.Add(Me.txtApn)
        Me.GroupBox7.Controls.Add(Me.btnApn)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "APN"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtNewGpsPassword)
        Me.GroupBox6.Controls.Add(Me.lblComandoPassword)
        Me.GroupBox6.Controls.Add(Me.btnNewPassword)
        Me.GroupBox6.Location = New System.Drawing.Point(368, 130)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CONTRASEÑA GPS"
        '
        'txtNewGpsPassword
        '
        Me.txtNewGpsPassword.CaracterDecimal = False
        Me.txtNewGpsPassword.HintText = "Hint Text"
        Me.txtNewGpsPassword.HintTextColor = System.Drawing.Color.Gray
        Me.txtNewGpsPassword.HintTextEnabled = False
        Me.txtNewGpsPassword.Location = New System.Drawing.Point(105, 17)
        Me.txtNewGpsPassword.MaxLength = 6
        Me.txtNewGpsPassword.Name = "txtNewGpsPassword"
        Me.txtNewGpsPassword.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtNewGpsPassword.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtNewGpsPassword.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtNewGpsPassword.Size = New System.Drawing.Size(170, 21)
        Me.txtNewGpsPassword.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtServerPort)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.lblComandoAdminIp)
        Me.GroupBox5.Controls.Add(Me.txtServerIP)
        Me.GroupBox5.Controls.Add(Me.btnServer)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SERVER"
        '
        'txtServerPort
        '
        Me.txtServerPort.CaracterDecimal = False
        Me.txtServerPort.HintText = "Hint Text"
        Me.txtServerPort.HintTextColor = System.Drawing.Color.Gray
        Me.txtServerPort.HintTextEnabled = False
        Me.txtServerPort.Location = New System.Drawing.Point(222, 17)
        Me.txtServerPort.MaxLength = 5
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtServerPort.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtServerPort.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtServerPort.Size = New System.Drawing.Size(53, 21)
        Me.txtServerPort.TabIndex = 1
        Me.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(178, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 14)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Puerto"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblComandoCheck)
        Me.GroupBox4.Controls.Add(Me.btnCheck)
        Me.GroupBox4.Location = New System.Drawing.Point(368, 75)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CHECK"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblComandoBegin)
        Me.GroupBox3.Controls.Add(Me.btnBegin)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BEGIN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnImei)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IMEI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblComandoReset)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 49)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESET"
        '
        'txtAdminPass
        '
        Me.txtAdminPass.HintText = "Hint Text"
        Me.txtAdminPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtAdminPass.HintTextEnabled = False
        Me.txtAdminPass.Location = New System.Drawing.Point(613, 18)
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtAdminPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtAdminPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtAdminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPass.Size = New System.Drawing.Size(105, 21)
        Me.txtAdminPass.TabIndex = 3
        Me.txtAdminPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(473, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 14)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Contraseña Administrador"
        '
        'gboxDevice
        '
        Me.gboxDevice.Controls.Add(Me.txtSimcard)
        Me.gboxDevice.Controls.Add(Me.txtDevicePass)
        Me.gboxDevice.Controls.Add(Me.txtImei)
        Me.gboxDevice.Controls.Add(Me.Label3)
        Me.gboxDevice.Controls.Add(Me.Label2)
        Me.gboxDevice.Controls.Add(Me.Label1)
        Me.gboxDevice.Controls.Add(Me.Label9)
        Me.gboxDevice.Controls.Add(Me.txtAdminPass)
        Me.gboxDevice.Dock = System.Windows.Forms.DockStyle.Top
        Me.gboxDevice.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxDevice.Location = New System.Drawing.Point(0, 0)
        Me.gboxDevice.Name = "gboxDevice"
        Me.gboxDevice.Size = New System.Drawing.Size(724, 45)
        Me.gboxDevice.TabIndex = 0
        Me.gboxDevice.TabStop = False
        Me.gboxDevice.Text = "Dispositivo"
        '
        'frmDeviceConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 541)
        Me.Controls.Add(Me.gboxSmsCommands)
        Me.Controls.Add(Me.gboxDevice)
        Me.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDeviceConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Dispositivo"
        Me.gboxSmsCommands.ResumeLayout(False)
        Me.gboxSmsCommands.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.numQuantityInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTimeInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboxDevice.ResumeLayout(False)
        Me.gboxDevice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFicha As ZUControls.ZUButton
    Friend WithEvents txtCallPass As ZUControls.ZUTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rbtnTcp As RadioButton
    Friend WithEvents rbtnUdp As RadioButton
    Friend WithEvents txtApn As ZUControls.ZUTextBox
    Friend WithEvents txtServerIP As ZUControls.ZUTextBox
    Friend WithEvents btnImei As ZUControls.ZUButton
    Friend WithEvents btnCheck As ZUControls.ZUButton
    Friend WithEvents btnResume As ZUControls.ZUButton
    Friend WithEvents btnStop As ZUControls.ZUButton
    Friend WithEvents btnAsignAdmin As ZUControls.ZUButton
    Friend WithEvents btnApn As ZUControls.ZUButton
    Friend WithEvents btnNewPassword As ZUControls.ZUButton
    Friend WithEvents btnServer As ZUControls.ZUButton
    Friend WithEvents btnFix As ZUControls.ZUButton
    Friend WithEvents btnBegin As ZUControls.ZUButton
    Friend WithEvents btnGprs As ZUControls.ZUButton
    Friend WithEvents btnReset As ZUControls.ZUButton
    Friend WithEvents lblComandoCheck As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblComandoPassword As Label
    Friend WithEvents lblComandoFix As Label
    Friend WithEvents lblComandoGprs As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblComandoApn As Label
    Friend WithEvents lblComandoAdminIp As Label
    Friend WithEvents lblComandoBegin As Label
    Friend WithEvents lblComandoReset As Label
    Friend WithEvents txtSimcard As ZUControls.ZUTextBox
    Friend WithEvents txtDevicePass As ZUControls.ZUNumericBox
    Friend WithEvents txtImei As ZUControls.ZUNumericBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gboxSmsCommands As GroupBox
    Friend WithEvents gboxDevice As GroupBox
    Friend WithEvents btnSmsResume As ZUControls.ZUButton
    Friend WithEvents btnSmsStop As ZUControls.ZUButton
    Friend WithEvents btnSms As ZUControls.ZUButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAdminPass As ZUControls.ZUTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnTimeZone As ZUControls.ZUButton
    Friend WithEvents Label10 As Label
    Friend WithEvents btnNoFix As ZUControls.ZUButton
    Friend WithEvents Label11 As Label
    Friend WithEvents rbtnMin As RadioButton
    Friend WithEvents rbtnSeg As RadioButton
    Friend WithEvents numTimeInterval As NumericUpDown
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtServerPort As ZUControls.ZUNumericBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents txtAsignPhoneAdmin As ZUControls.ZUNumericBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtNewGpsPassword As ZUControls.ZUNumericBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents cboTimeZone As ZUControls.ZUComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents btnUnasignAdmin As ZUControls.ZUButton
    Friend WithEvents txtUnasignPhoneAdmin As ZUControls.ZUNumericBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents numQuantityInterval As NumericUpDown
End Class
