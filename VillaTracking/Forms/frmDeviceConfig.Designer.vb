﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtAdmin = New ZUControls.ZUTextBox()
        Me.txtPassword = New ZUControls.ZUTextBox()
        Me.txtFix = New ZUControls.ZUTextBox()
        Me.txtAdminIp = New ZUControls.ZUTextBox()
        Me.btnImei = New ZUControls.ZUButton()
        Me.btnCheck = New ZUControls.ZUButton()
        Me.btnResume = New ZUControls.ZUButton()
        Me.btnStop = New ZUControls.ZUButton()
        Me.btnAdmin = New ZUControls.ZUButton()
        Me.btnApn = New ZUControls.ZUButton()
        Me.btnPassword = New ZUControls.ZUButton()
        Me.btnAdminIp = New ZUControls.ZUButton()
        Me.btnFix = New ZUControls.ZUButton()
        Me.btnBegin = New ZUControls.ZUButton()
        Me.btnGprs = New ZUControls.ZUButton()
        Me.btnReset = New ZUControls.ZUButton()
        Me.lblComandoCheck = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblComandoAdmin = New System.Windows.Forms.Label()
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
        Me.gboxDevice = New System.Windows.Forms.GroupBox()
        Me.ZuButton1 = New ZUControls.ZUButton()
        Me.ZuButton2 = New ZUControls.ZUButton()
        Me.gboxSmsCommands.SuspendLayout()
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
        Me.btnFicha.Location = New System.Drawing.Point(451, 206)
        Me.btnFicha.Name = "btnFicha"
        Me.btnFicha.Size = New System.Drawing.Size(82, 25)
        Me.btnFicha.TabIndex = 21
        Me.btnFicha.Text = "Abrir Ficha"
        Me.btnFicha.UseVisualStyleBackColor = False
        '
        'txtCallPass
        '
        Me.txtCallPass.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallPass.HintText = "Hint Text"
        Me.txtCallPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtCallPass.HintTextEnabled = False
        Me.txtCallPass.Location = New System.Drawing.Point(102, 209)
        Me.txtCallPass.Name = "txtCallPass"
        Me.txtCallPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtCallPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtCallPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtCallPass.ReadOnly = True
        Me.txtCallPass.Size = New System.Drawing.Size(343, 21)
        Me.txtCallPass.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Clave Telefónica"
        '
        'rbtnTcp
        '
        Me.rbtnTcp.AutoSize = True
        Me.rbtnTcp.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTcp.ForeColor = System.Drawing.Color.Black
        Me.rbtnTcp.Location = New System.Drawing.Point(102, 143)
        Me.rbtnTcp.Name = "rbtnTcp"
        Me.rbtnTcp.Size = New System.Drawing.Size(45, 18)
        Me.rbtnTcp.TabIndex = 7
        Me.rbtnTcp.Text = "TCP"
        Me.rbtnTcp.UseVisualStyleBackColor = True
        '
        'rbtnUdp
        '
        Me.rbtnUdp.AutoSize = True
        Me.rbtnUdp.Checked = True
        Me.rbtnUdp.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUdp.ForeColor = System.Drawing.Color.Black
        Me.rbtnUdp.Location = New System.Drawing.Point(51, 143)
        Me.rbtnUdp.Name = "rbtnUdp"
        Me.rbtnUdp.Size = New System.Drawing.Size(47, 18)
        Me.rbtnUdp.TabIndex = 6
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
        Me.txtApn.Location = New System.Drawing.Point(41, 111)
        Me.txtApn.Name = "txtApn"
        Me.txtApn.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtApn.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtApn.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtApn.Size = New System.Drawing.Size(184, 21)
        Me.txtApn.TabIndex = 4
        '
        'txtAdmin
        '
        Me.txtAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtAdmin.HintText = "Hint Text"
        Me.txtAdmin.HintTextColor = System.Drawing.Color.Gray
        Me.txtAdmin.HintTextEnabled = False
        Me.txtAdmin.Location = New System.Drawing.Point(335, 111)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtAdmin.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtAdmin.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtAdmin.Size = New System.Drawing.Size(136, 21)
        Me.txtAdmin.TabIndex = 15
        '
        'txtPassword
        '
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPassword.HintText = "Hint Text"
        Me.txtPassword.HintTextColor = System.Drawing.Color.Gray
        Me.txtPassword.HintTextEnabled = False
        Me.txtPassword.Location = New System.Drawing.Point(356, 79)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtPassword.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtPassword.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtPassword.Size = New System.Drawing.Size(115, 21)
        Me.txtPassword.TabIndex = 13
        '
        'txtFix
        '
        Me.txtFix.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFix.HintText = "Hint Text"
        Me.txtFix.HintTextColor = System.Drawing.Color.Gray
        Me.txtFix.HintTextEnabled = False
        Me.txtFix.Location = New System.Drawing.Point(36, 173)
        Me.txtFix.Name = "txtFix"
        Me.txtFix.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtFix.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtFix.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtFix.Size = New System.Drawing.Size(189, 21)
        Me.txtFix.TabIndex = 9
        '
        'txtAdminIp
        '
        Me.txtAdminIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtAdminIp.HintText = "Hint Text"
        Me.txtAdminIp.HintTextColor = System.Drawing.Color.Gray
        Me.txtAdminIp.HintTextEnabled = False
        Me.txtAdminIp.Location = New System.Drawing.Point(64, 79)
        Me.txtAdminIp.Name = "txtAdminIp"
        Me.txtAdminIp.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtAdminIp.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtAdminIp.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtAdminIp.Size = New System.Drawing.Size(161, 21)
        Me.txtAdminIp.TabIndex = 2
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
        Me.btnImei.Location = New System.Drawing.Point(477, 16)
        Me.btnImei.Name = "btnImei"
        Me.btnImei.Size = New System.Drawing.Size(56, 25)
        Me.btnImei.TabIndex = 11
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
        Me.btnCheck.Location = New System.Drawing.Point(477, 46)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(56, 25)
        Me.btnCheck.TabIndex = 12
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
        Me.btnResume.Location = New System.Drawing.Point(477, 171)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(56, 25)
        Me.btnResume.TabIndex = 18
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
        Me.btnStop.Location = New System.Drawing.Point(477, 140)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(56, 25)
        Me.btnStop.TabIndex = 17
        Me.btnStop.Text = "GPRS"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.BackgroundImage = CType(resources.GetObject("btnAdmin.BackgroundImage"), System.Drawing.Image)
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdmin.BackgroundOnClick = CType(resources.GetObject("btnAdmin.BackgroundOnClick"), System.Drawing.Image)
        Me.btnAdmin.BackgroundOnDisabled = CType(resources.GetObject("btnAdmin.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnAdmin.BackgroundOnHover = CType(resources.GetObject("btnAdmin.BackgroundOnHover"), System.Drawing.Image)
        Me.btnAdmin.BackgroundOnNormal = CType(resources.GetObject("btnAdmin.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnAdmin.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnAdmin.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(477, 108)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(56, 25)
        Me.btnAdmin.TabIndex = 16
        Me.btnAdmin.Text = "Enviar"
        Me.btnAdmin.UseVisualStyleBackColor = False
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
        Me.btnApn.Location = New System.Drawing.Point(231, 108)
        Me.btnApn.Name = "btnApn"
        Me.btnApn.Size = New System.Drawing.Size(56, 25)
        Me.btnApn.TabIndex = 5
        Me.btnApn.Text = "Enviar"
        Me.btnApn.UseVisualStyleBackColor = False
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnPassword.BackgroundImage = CType(resources.GetObject("btnPassword.BackgroundImage"), System.Drawing.Image)
        Me.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPassword.BackgroundOnClick = CType(resources.GetObject("btnPassword.BackgroundOnClick"), System.Drawing.Image)
        Me.btnPassword.BackgroundOnDisabled = CType(resources.GetObject("btnPassword.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnPassword.BackgroundOnHover = CType(resources.GetObject("btnPassword.BackgroundOnHover"), System.Drawing.Image)
        Me.btnPassword.BackgroundOnNormal = CType(resources.GetObject("btnPassword.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnPassword.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnPassword.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Location = New System.Drawing.Point(477, 77)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(56, 25)
        Me.btnPassword.TabIndex = 14
        Me.btnPassword.Text = "Enviar"
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'btnAdminIp
        '
        Me.btnAdminIp.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminIp.BackgroundImage = CType(resources.GetObject("btnAdminIp.BackgroundImage"), System.Drawing.Image)
        Me.btnAdminIp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdminIp.BackgroundOnClick = CType(resources.GetObject("btnAdminIp.BackgroundOnClick"), System.Drawing.Image)
        Me.btnAdminIp.BackgroundOnDisabled = CType(resources.GetObject("btnAdminIp.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnAdminIp.BackgroundOnHover = CType(resources.GetObject("btnAdminIp.BackgroundOnHover"), System.Drawing.Image)
        Me.btnAdminIp.BackgroundOnNormal = CType(resources.GetObject("btnAdminIp.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnAdminIp.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnAdminIp.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnAdminIp.FlatAppearance.BorderSize = 0
        Me.btnAdminIp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdminIp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdminIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminIp.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminIp.ForeColor = System.Drawing.Color.White
        Me.btnAdminIp.Location = New System.Drawing.Point(231, 77)
        Me.btnAdminIp.Name = "btnAdminIp"
        Me.btnAdminIp.Size = New System.Drawing.Size(56, 25)
        Me.btnAdminIp.TabIndex = 3
        Me.btnAdminIp.Text = "Enviar"
        Me.btnAdminIp.UseVisualStyleBackColor = False
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
        Me.btnFix.Location = New System.Drawing.Point(231, 171)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(56, 25)
        Me.btnFix.TabIndex = 10
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
        Me.btnBegin.Location = New System.Drawing.Point(231, 46)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(56, 25)
        Me.btnBegin.TabIndex = 1
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
        Me.btnGprs.Location = New System.Drawing.Point(231, 140)
        Me.btnGprs.Name = "btnGprs"
        Me.btnGprs.Size = New System.Drawing.Size(56, 25)
        Me.btnGprs.TabIndex = 8
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
        Me.btnReset.Location = New System.Drawing.Point(231, 16)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(56, 25)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Enviar"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblComandoCheck
        '
        Me.lblComandoCheck.AutoSize = True
        Me.lblComandoCheck.ForeColor = System.Drawing.Color.Black
        Me.lblComandoCheck.Location = New System.Drawing.Point(293, 51)
        Me.lblComandoCheck.Name = "lblComandoCheck"
        Me.lblComandoCheck.Size = New System.Drawing.Size(36, 14)
        Me.lblComandoCheck.TabIndex = 6
        Me.lblComandoCheck.Text = "Check"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(293, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Encendido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(293, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Apagado"
        '
        'lblComandoAdmin
        '
        Me.lblComandoAdmin.AutoSize = True
        Me.lblComandoAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblComandoAdmin.Location = New System.Drawing.Point(293, 114)
        Me.lblComandoAdmin.Name = "lblComandoAdmin"
        Me.lblComandoAdmin.Size = New System.Drawing.Size(38, 14)
        Me.lblComandoAdmin.TabIndex = 7
        Me.lblComandoAdmin.Text = "Admin"
        '
        'lblComandoPassword
        '
        Me.lblComandoPassword.AutoSize = True
        Me.lblComandoPassword.ForeColor = System.Drawing.Color.Black
        Me.lblComandoPassword.Location = New System.Drawing.Point(293, 83)
        Me.lblComandoPassword.Name = "lblComandoPassword"
        Me.lblComandoPassword.Size = New System.Drawing.Size(54, 14)
        Me.lblComandoPassword.TabIndex = 8
        Me.lblComandoPassword.Text = "Password"
        '
        'lblComandoFix
        '
        Me.lblComandoFix.AutoSize = True
        Me.lblComandoFix.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoFix.ForeColor = System.Drawing.Color.Black
        Me.lblComandoFix.Location = New System.Drawing.Point(12, 176)
        Me.lblComandoFix.Name = "lblComandoFix"
        Me.lblComandoFix.Size = New System.Drawing.Size(21, 14)
        Me.lblComandoFix.TabIndex = 9
        Me.lblComandoFix.Text = "Fix"
        '
        'lblComandoGprs
        '
        Me.lblComandoGprs.AutoSize = True
        Me.lblComandoGprs.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoGprs.ForeColor = System.Drawing.Color.Black
        Me.lblComandoGprs.Location = New System.Drawing.Point(12, 145)
        Me.lblComandoGprs.Name = "lblComandoGprs"
        Me.lblComandoGprs.Size = New System.Drawing.Size(29, 14)
        Me.lblComandoGprs.TabIndex = 10
        Me.lblComandoGprs.Text = "Gprs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(293, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Imei"
        '
        'lblComandoApn
        '
        Me.lblComandoApn.AutoSize = True
        Me.lblComandoApn.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoApn.ForeColor = System.Drawing.Color.Black
        Me.lblComandoApn.Location = New System.Drawing.Point(12, 114)
        Me.lblComandoApn.Name = "lblComandoApn"
        Me.lblComandoApn.Size = New System.Drawing.Size(26, 14)
        Me.lblComandoApn.TabIndex = 2
        Me.lblComandoApn.Text = "Apn"
        '
        'lblComandoAdminIp
        '
        Me.lblComandoAdminIp.AutoSize = True
        Me.lblComandoAdminIp.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoAdminIp.ForeColor = System.Drawing.Color.Black
        Me.lblComandoAdminIp.Location = New System.Drawing.Point(12, 83)
        Me.lblComandoAdminIp.Name = "lblComandoAdminIp"
        Me.lblComandoAdminIp.Size = New System.Drawing.Size(47, 14)
        Me.lblComandoAdminIp.TabIndex = 3
        Me.lblComandoAdminIp.Text = "Adminip"
        '
        'lblComandoBegin
        '
        Me.lblComandoBegin.AutoSize = True
        Me.lblComandoBegin.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoBegin.ForeColor = System.Drawing.Color.Black
        Me.lblComandoBegin.Location = New System.Drawing.Point(12, 51)
        Me.lblComandoBegin.Name = "lblComandoBegin"
        Me.lblComandoBegin.Size = New System.Drawing.Size(33, 14)
        Me.lblComandoBegin.TabIndex = 4
        Me.lblComandoBegin.Text = "Begin"
        '
        'lblComandoReset
        '
        Me.lblComandoReset.AutoSize = True
        Me.lblComandoReset.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComandoReset.ForeColor = System.Drawing.Color.Black
        Me.lblComandoReset.Location = New System.Drawing.Point(12, 21)
        Me.lblComandoReset.Name = "lblComandoReset"
        Me.lblComandoReset.Size = New System.Drawing.Size(33, 14)
        Me.lblComandoReset.TabIndex = 5
        Me.lblComandoReset.Text = "Reset"
        '
        'txtSimcard
        '
        Me.txtSimcard.BackColor = System.Drawing.Color.White
        Me.txtSimcard.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimcard.ForeColor = System.Drawing.Color.Black
        Me.txtSimcard.HintText = "Hint Text"
        Me.txtSimcard.HintTextColor = System.Drawing.Color.Gray
        Me.txtSimcard.HintTextEnabled = False
        Me.txtSimcard.Location = New System.Drawing.Point(250, 17)
        Me.txtSimcard.Name = "txtSimcard"
        Me.txtSimcard.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtSimcard.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtSimcard.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtSimcard.ReadOnly = True
        Me.txtSimcard.Size = New System.Drawing.Size(178, 21)
        Me.txtSimcard.TabIndex = 1
        '
        'txtDevicePass
        '
        Me.txtDevicePass.CaracterDecimal = False
        Me.txtDevicePass.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevicePass.ForeColor = System.Drawing.Color.Black
        Me.txtDevicePass.HintText = "Hint Text"
        Me.txtDevicePass.HintTextColor = System.Drawing.Color.Gray
        Me.txtDevicePass.HintTextEnabled = False
        Me.txtDevicePass.Location = New System.Drawing.Point(474, 17)
        Me.txtDevicePass.MaxLength = 6
        Me.txtDevicePass.Name = "txtDevicePass"
        Me.txtDevicePass.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtDevicePass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtDevicePass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtDevicePass.Size = New System.Drawing.Size(58, 21)
        Me.txtDevicePass.TabIndex = 2
        '
        'txtImei
        '
        Me.txtImei.BackColor = System.Drawing.Color.White
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
        Me.txtImei.Size = New System.Drawing.Size(149, 21)
        Me.txtImei.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(434, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Clave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(198, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Simcard"
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
        Me.gboxSmsCommands.Controls.Add(Me.ZuButton2)
        Me.gboxSmsCommands.Controls.Add(Me.ZuButton1)
        Me.gboxSmsCommands.Controls.Add(Me.btnFicha)
        Me.gboxSmsCommands.Controls.Add(Me.txtCallPass)
        Me.gboxSmsCommands.Controls.Add(Me.Label7)
        Me.gboxSmsCommands.Controls.Add(Me.rbtnTcp)
        Me.gboxSmsCommands.Controls.Add(Me.rbtnUdp)
        Me.gboxSmsCommands.Controls.Add(Me.txtApn)
        Me.gboxSmsCommands.Controls.Add(Me.txtAdmin)
        Me.gboxSmsCommands.Controls.Add(Me.txtPassword)
        Me.gboxSmsCommands.Controls.Add(Me.txtFix)
        Me.gboxSmsCommands.Controls.Add(Me.txtAdminIp)
        Me.gboxSmsCommands.Controls.Add(Me.btnImei)
        Me.gboxSmsCommands.Controls.Add(Me.btnCheck)
        Me.gboxSmsCommands.Controls.Add(Me.btnResume)
        Me.gboxSmsCommands.Controls.Add(Me.btnStop)
        Me.gboxSmsCommands.Controls.Add(Me.btnAdmin)
        Me.gboxSmsCommands.Controls.Add(Me.btnApn)
        Me.gboxSmsCommands.Controls.Add(Me.btnPassword)
        Me.gboxSmsCommands.Controls.Add(Me.btnAdminIp)
        Me.gboxSmsCommands.Controls.Add(Me.btnFix)
        Me.gboxSmsCommands.Controls.Add(Me.btnBegin)
        Me.gboxSmsCommands.Controls.Add(Me.btnGprs)
        Me.gboxSmsCommands.Controls.Add(Me.btnReset)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoCheck)
        Me.gboxSmsCommands.Controls.Add(Me.Label6)
        Me.gboxSmsCommands.Controls.Add(Me.Label5)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoAdmin)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoPassword)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoFix)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoGprs)
        Me.gboxSmsCommands.Controls.Add(Me.Label4)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoApn)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoAdminIp)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoBegin)
        Me.gboxSmsCommands.Controls.Add(Me.lblComandoReset)
        Me.gboxSmsCommands.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboxSmsCommands.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxSmsCommands.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxSmsCommands.Location = New System.Drawing.Point(0, 45)
        Me.gboxSmsCommands.Name = "gboxSmsCommands"
        Me.gboxSmsCommands.Size = New System.Drawing.Size(542, 237)
        Me.gboxSmsCommands.TabIndex = 3
        Me.gboxSmsCommands.TabStop = False
        Me.gboxSmsCommands.Text = "Comandos SMS"
        '
        'gboxDevice
        '
        Me.gboxDevice.Controls.Add(Me.txtSimcard)
        Me.gboxDevice.Controls.Add(Me.txtDevicePass)
        Me.gboxDevice.Controls.Add(Me.txtImei)
        Me.gboxDevice.Controls.Add(Me.Label3)
        Me.gboxDevice.Controls.Add(Me.Label2)
        Me.gboxDevice.Controls.Add(Me.Label1)
        Me.gboxDevice.Dock = System.Windows.Forms.DockStyle.Top
        Me.gboxDevice.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxDevice.Location = New System.Drawing.Point(0, 0)
        Me.gboxDevice.Name = "gboxDevice"
        Me.gboxDevice.Size = New System.Drawing.Size(542, 45)
        Me.gboxDevice.TabIndex = 2
        Me.gboxDevice.TabStop = False
        Me.gboxDevice.Text = "Dispositivo"
        '
        'ZuButton1
        '
        Me.ZuButton1.BackColor = System.Drawing.Color.Transparent
        Me.ZuButton1.BackgroundImage = CType(resources.GetObject("ZuButton1.BackgroundImage"), System.Drawing.Image)
        Me.ZuButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZuButton1.BackgroundOnClick = CType(resources.GetObject("ZuButton1.BackgroundOnClick"), System.Drawing.Image)
        Me.ZuButton1.BackgroundOnDisabled = CType(resources.GetObject("ZuButton1.BackgroundOnDisabled"), System.Drawing.Image)
        Me.ZuButton1.BackgroundOnHover = CType(resources.GetObject("ZuButton1.BackgroundOnHover"), System.Drawing.Image)
        Me.ZuButton1.BackgroundOnNormal = CType(resources.GetObject("ZuButton1.BackgroundOnNormal"), System.Drawing.Image)
        Me.ZuButton1.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.ZuButton1.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.ZuButton1.FlatAppearance.BorderSize = 0
        Me.ZuButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ZuButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ZuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZuButton1.ForeColor = System.Drawing.Color.Black
        Me.ZuButton1.Location = New System.Drawing.Point(411, 140)
        Me.ZuButton1.Name = "ZuButton1"
        Me.ZuButton1.Size = New System.Drawing.Size(56, 25)
        Me.ZuButton1.TabIndex = 22
        Me.ZuButton1.Text = "SMS"
        Me.ZuButton1.UseVisualStyleBackColor = False
        '
        'ZuButton2
        '
        Me.ZuButton2.BackColor = System.Drawing.Color.Transparent
        Me.ZuButton2.BackgroundImage = CType(resources.GetObject("ZuButton2.BackgroundImage"), System.Drawing.Image)
        Me.ZuButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZuButton2.BackgroundOnClick = CType(resources.GetObject("ZuButton2.BackgroundOnClick"), System.Drawing.Image)
        Me.ZuButton2.BackgroundOnDisabled = CType(resources.GetObject("ZuButton2.BackgroundOnDisabled"), System.Drawing.Image)
        Me.ZuButton2.BackgroundOnHover = CType(resources.GetObject("ZuButton2.BackgroundOnHover"), System.Drawing.Image)
        Me.ZuButton2.BackgroundOnNormal = CType(resources.GetObject("ZuButton2.BackgroundOnNormal"), System.Drawing.Image)
        Me.ZuButton2.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.ZuButton2.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.ZuButton2.FlatAppearance.BorderSize = 0
        Me.ZuButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ZuButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ZuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZuButton2.ForeColor = System.Drawing.Color.Black
        Me.ZuButton2.Location = New System.Drawing.Point(411, 171)
        Me.ZuButton2.Name = "ZuButton2"
        Me.ZuButton2.Size = New System.Drawing.Size(56, 25)
        Me.ZuButton2.TabIndex = 22
        Me.ZuButton2.Text = "SMS"
        Me.ZuButton2.UseVisualStyleBackColor = False
        '
        'frmDeviceConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 282)
        Me.Controls.Add(Me.gboxSmsCommands)
        Me.Controls.Add(Me.gboxDevice)
        Me.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDeviceConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.gboxSmsCommands.ResumeLayout(False)
        Me.gboxSmsCommands.PerformLayout()
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
    Friend WithEvents txtAdmin As ZUControls.ZUTextBox
    Friend WithEvents txtPassword As ZUControls.ZUTextBox
    Friend WithEvents txtFix As ZUControls.ZUTextBox
    Friend WithEvents txtAdminIp As ZUControls.ZUTextBox
    Friend WithEvents btnImei As ZUControls.ZUButton
    Friend WithEvents btnCheck As ZUControls.ZUButton
    Friend WithEvents btnResume As ZUControls.ZUButton
    Friend WithEvents btnStop As ZUControls.ZUButton
    Friend WithEvents btnAdmin As ZUControls.ZUButton
    Friend WithEvents btnApn As ZUControls.ZUButton
    Friend WithEvents btnPassword As ZUControls.ZUButton
    Friend WithEvents btnAdminIp As ZUControls.ZUButton
    Friend WithEvents btnFix As ZUControls.ZUButton
    Friend WithEvents btnBegin As ZUControls.ZUButton
    Friend WithEvents btnGprs As ZUControls.ZUButton
    Friend WithEvents btnReset As ZUControls.ZUButton
    Friend WithEvents lblComandoCheck As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblComandoAdmin As Label
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
    Friend WithEvents ZuButton2 As ZUControls.ZUButton
    Friend WithEvents ZuButton1 As ZUControls.ZUButton
End Class
