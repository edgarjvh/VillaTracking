<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModemSms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModemSms))
        Me.btnSave = New ZUControls.ZUButton()
        Me.txtWriteBufferSize = New ZUControls.ZUNumericBox()
        Me.txtReadBufferSize = New ZUControls.ZUNumericBox()
        Me.txtWriteTimeout = New ZUControls.ZUNumericBox()
        Me.btnGetPorts = New ZUControls.ZUButton()
        Me.gboxParameters = New System.Windows.Forms.GroupBox()
        Me.btnDefaultValues = New ZUControls.ZUButton()
        Me.cboPortName = New System.Windows.Forms.ComboBox()
        Me.cboHandshake = New System.Windows.Forms.ComboBox()
        Me.cboStopBits = New System.Windows.Forms.ComboBox()
        Me.cboParity = New System.Windows.Forms.ComboBox()
        Me.cboDataBits = New System.Windows.Forms.ComboBox()
        Me.cboBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gboxSmsTemplates = New System.Windows.Forms.GroupBox()
        Me.txtMotionTemplate = New System.Windows.Forms.TextBox()
        Me.txtSpeedTemplate = New System.Windows.Forms.TextBox()
        Me.txtGeofenceTemplate = New System.Windows.Forms.TextBox()
        Me.txtBatteryTemplate = New System.Windows.Forms.TextBox()
        Me.txtIgnitionTemplate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gboxParameters.SuspendLayout()
        Me.gboxSmsTemplates.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BackgroundOnClick = CType(resources.GetObject("btnSave.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSave.BackgroundOnDisabled = CType(resources.GetObject("btnSave.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSave.BackgroundOnHover = CType(resources.GetObject("btnSave.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSave.BackgroundOnNormal = CType(resources.GetObject("btnSave.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSave.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSave.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(244, 552)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtWriteBufferSize
        '
        Me.txtWriteBufferSize.CaracterDecimal = False
        Me.txtWriteBufferSize.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWriteBufferSize.HintText = "Hint Text"
        Me.txtWriteBufferSize.HintTextColor = System.Drawing.Color.Gray
        Me.txtWriteBufferSize.HintTextEnabled = False
        Me.txtWriteBufferSize.Location = New System.Drawing.Point(384, 83)
        Me.txtWriteBufferSize.Name = "txtWriteBufferSize"
        Me.txtWriteBufferSize.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtWriteBufferSize.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtWriteBufferSize.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtWriteBufferSize.Size = New System.Drawing.Size(173, 21)
        Me.txtWriteBufferSize.TabIndex = 7
        '
        'txtReadBufferSize
        '
        Me.txtReadBufferSize.CaracterDecimal = False
        Me.txtReadBufferSize.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReadBufferSize.HintText = "Hint Text"
        Me.txtReadBufferSize.HintTextColor = System.Drawing.Color.Gray
        Me.txtReadBufferSize.HintTextEnabled = False
        Me.txtReadBufferSize.Location = New System.Drawing.Point(100, 83)
        Me.txtReadBufferSize.Name = "txtReadBufferSize"
        Me.txtReadBufferSize.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtReadBufferSize.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtReadBufferSize.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtReadBufferSize.Size = New System.Drawing.Size(179, 21)
        Me.txtReadBufferSize.TabIndex = 6
        '
        'txtWriteTimeout
        '
        Me.txtWriteTimeout.CaracterDecimal = False
        Me.txtWriteTimeout.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWriteTimeout.HintText = "Hint Text"
        Me.txtWriteTimeout.HintTextColor = System.Drawing.Color.Gray
        Me.txtWriteTimeout.HintTextEnabled = False
        Me.txtWriteTimeout.Location = New System.Drawing.Point(474, 54)
        Me.txtWriteTimeout.Name = "txtWriteTimeout"
        Me.txtWriteTimeout.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtWriteTimeout.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtWriteTimeout.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtWriteTimeout.Size = New System.Drawing.Size(83, 21)
        Me.txtWriteTimeout.TabIndex = 5
        '
        'btnGetPorts
        '
        Me.btnGetPorts.BackColor = System.Drawing.Color.Transparent
        Me.btnGetPorts.BackgroundImage = CType(resources.GetObject("btnGetPorts.BackgroundImage"), System.Drawing.Image)
        Me.btnGetPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetPorts.BackgroundOnClick = CType(resources.GetObject("btnGetPorts.BackgroundOnClick"), System.Drawing.Image)
        Me.btnGetPorts.BackgroundOnDisabled = CType(resources.GetObject("btnGetPorts.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnGetPorts.BackgroundOnHover = CType(resources.GetObject("btnGetPorts.BackgroundOnHover"), System.Drawing.Image)
        Me.btnGetPorts.BackgroundOnNormal = CType(resources.GetObject("btnGetPorts.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnGetPorts.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnGetPorts.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnGetPorts.FlatAppearance.BorderSize = 0
        Me.btnGetPorts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGetPorts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGetPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetPorts.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPorts.ForeColor = System.Drawing.Color.Black
        Me.btnGetPorts.Location = New System.Drawing.Point(187, 110)
        Me.btnGetPorts.Name = "btnGetPorts"
        Me.btnGetPorts.Size = New System.Drawing.Size(204, 25)
        Me.btnGetPorts.TabIndex = 9
        Me.btnGetPorts.Text = "<< Obtener Puertos Disponibles"
        Me.btnGetPorts.UseVisualStyleBackColor = False
        '
        'gboxParameters
        '
        Me.gboxParameters.BackColor = System.Drawing.SystemColors.Control
        Me.gboxParameters.Controls.Add(Me.txtWriteBufferSize)
        Me.gboxParameters.Controls.Add(Me.txtReadBufferSize)
        Me.gboxParameters.Controls.Add(Me.txtWriteTimeout)
        Me.gboxParameters.Controls.Add(Me.btnGetPorts)
        Me.gboxParameters.Controls.Add(Me.btnDefaultValues)
        Me.gboxParameters.Controls.Add(Me.cboPortName)
        Me.gboxParameters.Controls.Add(Me.cboHandshake)
        Me.gboxParameters.Controls.Add(Me.cboStopBits)
        Me.gboxParameters.Controls.Add(Me.cboParity)
        Me.gboxParameters.Controls.Add(Me.cboDataBits)
        Me.gboxParameters.Controls.Add(Me.cboBaudRate)
        Me.gboxParameters.Controls.Add(Me.Label9)
        Me.gboxParameters.Controls.Add(Me.Label7)
        Me.gboxParameters.Controls.Add(Me.Label8)
        Me.gboxParameters.Controls.Add(Me.Label6)
        Me.gboxParameters.Controls.Add(Me.Label5)
        Me.gboxParameters.Controls.Add(Me.Label4)
        Me.gboxParameters.Controls.Add(Me.Label3)
        Me.gboxParameters.Controls.Add(Me.Label2)
        Me.gboxParameters.Controls.Add(Me.Label1)
        Me.gboxParameters.Dock = System.Windows.Forms.DockStyle.Top
        Me.gboxParameters.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxParameters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxParameters.Location = New System.Drawing.Point(0, 0)
        Me.gboxParameters.Name = "gboxParameters"
        Me.gboxParameters.Size = New System.Drawing.Size(563, 149)
        Me.gboxParameters.TabIndex = 3
        Me.gboxParameters.TabStop = False
        Me.gboxParameters.Tag = "35"
        Me.gboxParameters.Text = "Parámetros"
        '
        'btnDefaultValues
        '
        Me.btnDefaultValues.BackColor = System.Drawing.Color.Transparent
        Me.btnDefaultValues.BackgroundImage = CType(resources.GetObject("btnDefaultValues.BackgroundImage"), System.Drawing.Image)
        Me.btnDefaultValues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDefaultValues.BackgroundOnClick = CType(resources.GetObject("btnDefaultValues.BackgroundOnClick"), System.Drawing.Image)
        Me.btnDefaultValues.BackgroundOnDisabled = CType(resources.GetObject("btnDefaultValues.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnDefaultValues.BackgroundOnHover = CType(resources.GetObject("btnDefaultValues.BackgroundOnHover"), System.Drawing.Image)
        Me.btnDefaultValues.BackgroundOnNormal = CType(resources.GetObject("btnDefaultValues.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnDefaultValues.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnDefaultValues.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnDefaultValues.FlatAppearance.BorderSize = 0
        Me.btnDefaultValues.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDefaultValues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDefaultValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaultValues.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaultValues.ForeColor = System.Drawing.Color.Black
        Me.btnDefaultValues.Location = New System.Drawing.Point(397, 110)
        Me.btnDefaultValues.Name = "btnDefaultValues"
        Me.btnDefaultValues.Size = New System.Drawing.Size(160, 25)
        Me.btnDefaultValues.TabIndex = 10
        Me.btnDefaultValues.Text = "Valores Predeterminados"
        Me.btnDefaultValues.UseVisualStyleBackColor = False
        '
        'cboPortName
        '
        Me.cboPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPortName.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPortName.FormattingEnabled = True
        Me.cboPortName.Location = New System.Drawing.Point(84, 111)
        Me.cboPortName.Name = "cboPortName"
        Me.cboPortName.Size = New System.Drawing.Size(97, 22)
        Me.cboPortName.TabIndex = 8
        '
        'cboHandshake
        '
        Me.cboHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHandshake.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHandshake.ForeColor = System.Drawing.Color.Black
        Me.cboHandshake.FormattingEnabled = True
        Me.cboHandshake.Items.AddRange(New Object() {"Hardware", "Xon / Xoff", "Hardware y Xon/Xoff", "Ninguno"})
        Me.cboHandshake.Location = New System.Drawing.Point(269, 54)
        Me.cboHandshake.Name = "cboHandshake"
        Me.cboHandshake.Size = New System.Drawing.Size(101, 22)
        Me.cboHandshake.TabIndex = 4
        '
        'cboStopBits
        '
        Me.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStopBits.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStopBits.ForeColor = System.Drawing.Color.Black
        Me.cboStopBits.FormattingEnabled = True
        Me.cboStopBits.Items.AddRange(New Object() {"1", "1.5", "2", "Ninguno"})
        Me.cboStopBits.Location = New System.Drawing.Point(93, 54)
        Me.cboStopBits.Name = "cboStopBits"
        Me.cboStopBits.Size = New System.Drawing.Size(80, 22)
        Me.cboStopBits.TabIndex = 3
        '
        'cboParity
        '
        Me.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParity.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboParity.ForeColor = System.Drawing.Color.Black
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Items.AddRange(New Object() {"Par", "Impar", "Ninguno", "Marca", "Espacio"})
        Me.cboParity.Location = New System.Drawing.Point(454, 24)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(103, 22)
        Me.cboParity.TabIndex = 2
        '
        'cboDataBits
        '
        Me.cboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDataBits.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDataBits.ForeColor = System.Drawing.Color.Black
        Me.cboDataBits.FormattingEnabled = True
        Me.cboDataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cboDataBits.Location = New System.Drawing.Point(294, 24)
        Me.cboDataBits.Name = "cboDataBits"
        Me.cboDataBits.Size = New System.Drawing.Size(103, 22)
        Me.cboDataBits.TabIndex = 1
        '
        'cboBaudRate
        '
        Me.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaudRate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaudRate.ForeColor = System.Drawing.Color.Black
        Me.cboBaudRate.FormattingEnabled = True
        Me.cboBaudRate.Items.AddRange(New Object() {"110", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"})
        Me.cboBaudRate.Location = New System.Drawing.Point(103, 24)
        Me.cboBaudRate.Name = "cboBaudRate"
        Me.cboBaudRate.Size = New System.Drawing.Size(107, 22)
        Me.cboBaudRate.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(376, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tiempo de Espera"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(285, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Búfer de Escritura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(9, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Puerto Serial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Búfer de Lectura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(179, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Control de Flujo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(403, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Paridad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Bits de Parada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(216, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bits de Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bits por Segundo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Batería"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(9, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ignición"
        '
        'gboxSmsTemplates
        '
        Me.gboxSmsTemplates.Controls.Add(Me.txtMotionTemplate)
        Me.gboxSmsTemplates.Controls.Add(Me.txtSpeedTemplate)
        Me.gboxSmsTemplates.Controls.Add(Me.txtGeofenceTemplate)
        Me.gboxSmsTemplates.Controls.Add(Me.txtBatteryTemplate)
        Me.gboxSmsTemplates.Controls.Add(Me.txtIgnitionTemplate)
        Me.gboxSmsTemplates.Controls.Add(Me.Label14)
        Me.gboxSmsTemplates.Controls.Add(Me.Label13)
        Me.gboxSmsTemplates.Controls.Add(Me.Label12)
        Me.gboxSmsTemplates.Controls.Add(Me.Label10)
        Me.gboxSmsTemplates.Controls.Add(Me.Label11)
        Me.gboxSmsTemplates.Dock = System.Windows.Forms.DockStyle.Top
        Me.gboxSmsTemplates.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxSmsTemplates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxSmsTemplates.Location = New System.Drawing.Point(0, 149)
        Me.gboxSmsTemplates.Name = "gboxSmsTemplates"
        Me.gboxSmsTemplates.Size = New System.Drawing.Size(563, 395)
        Me.gboxSmsTemplates.TabIndex = 4
        Me.gboxSmsTemplates.TabStop = False
        Me.gboxSmsTemplates.Tag = "35"
        Me.gboxSmsTemplates.Text = "Plantillas Sms"
        '
        'txtMotionTemplate
        '
        Me.txtMotionTemplate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotionTemplate.Location = New System.Drawing.Point(12, 338)
        Me.txtMotionTemplate.MaxLength = 200
        Me.txtMotionTemplate.Multiline = True
        Me.txtMotionTemplate.Name = "txtMotionTemplate"
        Me.txtMotionTemplate.Size = New System.Drawing.Size(539, 48)
        Me.txtMotionTemplate.TabIndex = 4
        '
        'txtSpeedTemplate
        '
        Me.txtSpeedTemplate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeedTemplate.Location = New System.Drawing.Point(12, 263)
        Me.txtSpeedTemplate.MaxLength = 200
        Me.txtSpeedTemplate.Multiline = True
        Me.txtSpeedTemplate.Name = "txtSpeedTemplate"
        Me.txtSpeedTemplate.Size = New System.Drawing.Size(539, 48)
        Me.txtSpeedTemplate.TabIndex = 3
        '
        'txtGeofenceTemplate
        '
        Me.txtGeofenceTemplate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeofenceTemplate.Location = New System.Drawing.Point(12, 188)
        Me.txtGeofenceTemplate.MaxLength = 200
        Me.txtGeofenceTemplate.Multiline = True
        Me.txtGeofenceTemplate.Name = "txtGeofenceTemplate"
        Me.txtGeofenceTemplate.Size = New System.Drawing.Size(539, 48)
        Me.txtGeofenceTemplate.TabIndex = 2
        '
        'txtBatteryTemplate
        '
        Me.txtBatteryTemplate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatteryTemplate.Location = New System.Drawing.Point(12, 113)
        Me.txtBatteryTemplate.MaxLength = 200
        Me.txtBatteryTemplate.Multiline = True
        Me.txtBatteryTemplate.Name = "txtBatteryTemplate"
        Me.txtBatteryTemplate.Size = New System.Drawing.Size(539, 48)
        Me.txtBatteryTemplate.TabIndex = 1
        '
        'txtIgnitionTemplate
        '
        Me.txtIgnitionTemplate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgnitionTemplate.Location = New System.Drawing.Point(12, 40)
        Me.txtIgnitionTemplate.MaxLength = 200
        Me.txtIgnitionTemplate.Multiline = True
        Me.txtIgnitionTemplate.Name = "txtIgnitionTemplate"
        Me.txtIgnitionTemplate.Size = New System.Drawing.Size(539, 48)
        Me.txtIgnitionTemplate.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(9, 321)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 14)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Movimiento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(9, 246)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Velocidad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(9, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 14)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Geocerca"
        '
        'frmModemSms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 580)
        Me.Controls.Add(Me.gboxSmsTemplates)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gboxParameters)
        Me.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModemSms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modem Sms"
        Me.gboxParameters.ResumeLayout(False)
        Me.gboxParameters.PerformLayout()
        Me.gboxSmsTemplates.ResumeLayout(False)
        Me.gboxSmsTemplates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As ZUControls.ZUButton
    Friend WithEvents txtWriteBufferSize As ZUControls.ZUNumericBox
    Friend WithEvents txtReadBufferSize As ZUControls.ZUNumericBox
    Friend WithEvents txtWriteTimeout As ZUControls.ZUNumericBox
    Friend WithEvents btnGetPorts As ZUControls.ZUButton
    Friend WithEvents gboxParameters As GroupBox
    Friend WithEvents btnDefaultValues As ZUControls.ZUButton
    Friend WithEvents cboPortName As ComboBox
    Friend WithEvents cboHandshake As ComboBox
    Friend WithEvents cboStopBits As ComboBox
    Friend WithEvents cboParity As ComboBox
    Friend WithEvents cboDataBits As ComboBox
    Friend WithEvents cboBaudRate As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gboxSmsTemplates As GroupBox
    Friend WithEvents txtMotionTemplate As TextBox
    Friend WithEvents txtSpeedTemplate As TextBox
    Friend WithEvents txtGeofenceTemplate As TextBox
    Friend WithEvents txtBatteryTemplate As TextBox
    Friend WithEvents txtIgnitionTemplate As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
