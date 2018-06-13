<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.splitParent = New System.Windows.Forms.SplitContainer()
        Me.panelLoadingClients = New ZUControls.ZUPanel()
        Me.pbarStatusLoadingClients = New System.Windows.Forms.ProgressBar()
        Me.lblStatusLoadingClients = New System.Windows.Forms.Label()
        Me.tviewClients = New ZUControls.ZUTreeView()
        Me.panelClientFilter = New ZUControls.ZUPanel()
        Me.cboxExpandClients = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClientFilter = New ZUControls.ZUTextBox()
        Me.panelClientCount = New ZUControls.ZUPanel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.lblVehiclesQuantity = New System.Windows.Forms.Label()
        Me.lblClientsQuantity = New System.Windows.Forms.Label()
        Me.cboDealers = New ZUControls.ZUComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.splitChild = New System.Windows.Forms.SplitContainer()
        Me.ZuPanel1 = New ZUControls.ZUPanel()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.num = New System.Windows.Forms.NumericUpDown()
        Me.btnBgwGprsReceiver = New ZUControls.ZUButton()
        Me.btnBgwGetEvents = New ZUControls.ZUButton()
        Me.btnBgwGetCurrentLocations = New ZUControls.ZUButton()
        Me.btnBgwGetClients = New ZUControls.ZUButton()
        Me.panelGeofencesVehicles = New ZUControls.ZUPanel()
        Me.dgvGeofences = New System.Windows.Forms.DataGridView()
        Me.dgvGeofences_on_map = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvGeofences_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_imei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_geofence_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_vehicle_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_points = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLicensePlate = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tbarMapZoom = New XComponent.SliderBar.ZUTrackBar()
        Me.btnHybrid = New ZUControls.ZUButton()
        Me.btnSatellite = New ZUControls.ZUButton()
        Me.btnMap = New ZUControls.ZUButton()
        Me.mapMain = New ZUControls.ZUMapa()
        Me.tabConsole = New System.Windows.Forms.TabControl()
        Me.tpageVehicles = New System.Windows.Forms.TabPage()
        Me.dgvConsoleVehicles = New ZUControls.ZUDataGridView()
        Me.dgvVehicles_onMap = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvVehicles_config = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvVehicles_vehicle_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_device_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_imei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_simcard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_cliente_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_license_plate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_last_report = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_speed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_origin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_expiration_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_client_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_vehicle_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_device_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_device_model_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_sms_stop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_sms_resume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_gprs_stop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_gprs_resume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_call_pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpageEvents = New System.Windows.Forms.TabPage()
        Me.dgvEvents = New ZUControls.ZUDataGridView()
        Me.dgvEvents_onMap = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvEvents_vehicle_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_client_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_imei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_license_plate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_date_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_validation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_client_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_vehicle_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_report_type_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_geofence_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_geofence_points = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_latitude = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_longitude = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_speed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEvents_orientation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpageGprsReceiver = New System.Windows.Forms.TabPage()
        Me.dgvGprsReceiver = New ZUControls.ZUDataGridView()
        Me.dgvGprsReceiver_port = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGprsReceiver_device_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGprsReceiver_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGprsReceiver_date_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGprsReceiver_trace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGprsReceiver_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpageModemSms = New System.Windows.Forms.TabPage()
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.panelModemSms = New ZUControls.ZUPanel()
        Me.btnSendAtCommand = New ZUControls.ZUButton()
        Me.txtAtCommand = New ZUControls.ZUTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboxAutoScroll = New System.Windows.Forms.CheckBox()
        Me.btnClearDgvModemSms = New ZUControls.ZUButton()
        Me.timerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.timerCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.cmenuOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuOptionAutoCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptionShowMapCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptionShowMapControls = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptionShowClientsWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptionShowVehiclesWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaDeGeocercasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapaDeEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehículosEnMovimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptionModemSms = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptionDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptionVoices = New System.Windows.Forms.ToolStripMenuItem()
        Me.rbtnOptionXimena = New ToolStripRadioButtonMenuItem()
        Me.rbtnOptionCarlos = New ToolStripRadioButtonMenuItem()
        Me.rbtnOptionCarmen = New ToolStripRadioButtonMenuItem()
        Me.rbtnOptionSoledad = New ToolStripRadioButtonMenuItem()
        Me.rbtnOptionJorge = New ToolStripRadioButtonMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.rbtnOptionNone = New ToolStripRadioButtonMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServidorPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuOptionSwitchUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgwGetClients = New System.ComponentModel.BackgroundWorker()
        Me.bgwGetCurrentLocations = New System.ComponentModel.BackgroundWorker()
        Me.bgwNoReportingVehicles = New System.ComponentModel.BackgroundWorker()
        Me.bgwGetEvents = New System.ComponentModel.BackgroundWorker()
        Me.bgwGeofences = New System.ComponentModel.BackgroundWorker()
        Me.serialModemSms = New System.IO.Ports.SerialPort(Me.components)
        Me.bgwModemSms = New System.ComponentModel.BackgroundWorker()
        Me.bgwSendEventsEmail = New System.ComponentModel.BackgroundWorker()
        Me.panelHeader = New ZUControls.ZUPanel()
        Me.pboxLogo = New System.Windows.Forms.PictureBox()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.menuUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDealers = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSimCards = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDevices = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClients = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTravelHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEventHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGeofence = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNoReporting = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelInfo = New ZUControls.ZUPanel()
        Me.panelSignal = New ZUControls.ZUPanel()
        Me.pbarModem = New System.Windows.Forms.ProgressBar()
        Me.cboxModem = New System.Windows.Forms.CheckBox()
        Me.btnMonitoring = New ZUControls.ZUButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bgwTTS = New System.ComponentModel.BackgroundWorker()
        Me.bgwGprsEvents = New System.ComponentModel.BackgroundWorker()
        Me.bgwGprsReceiver = New System.ComponentModel.BackgroundWorker()
        CType(Me.splitParent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitParent.Panel1.SuspendLayout()
        Me.splitParent.Panel2.SuspendLayout()
        Me.splitParent.SuspendLayout()
        Me.panelLoadingClients.SuspendLayout()
        Me.panelClientFilter.SuspendLayout()
        Me.panelClientCount.SuspendLayout()
        CType(Me.splitChild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitChild.Panel1.SuspendLayout()
        Me.splitChild.Panel2.SuspendLayout()
        Me.splitChild.SuspendLayout()
        Me.ZuPanel1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGeofencesVehicles.SuspendLayout()
        CType(Me.dgvGeofences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsole.SuspendLayout()
        Me.tpageVehicles.SuspendLayout()
        CType(Me.dgvConsoleVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpageEvents.SuspendLayout()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpageGprsReceiver.SuspendLayout()
        CType(Me.dgvGprsReceiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpageModemSms.SuspendLayout()
        Me.panelModemSms.SuspendLayout()
        Me.cmenuOptions.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuMain.SuspendLayout()
        Me.panelInfo.SuspendLayout()
        Me.panelSignal.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitParent
        '
        Me.splitParent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitParent.Location = New System.Drawing.Point(0, 76)
        Me.splitParent.Name = "splitParent"
        '
        'splitParent.Panel1
        '
        Me.splitParent.Panel1.Controls.Add(Me.panelLoadingClients)
        Me.splitParent.Panel1.Controls.Add(Me.tviewClients)
        Me.splitParent.Panel1.Controls.Add(Me.panelClientFilter)
        Me.splitParent.Panel1.Controls.Add(Me.panelClientCount)
        Me.splitParent.Panel1MinSize = 240
        '
        'splitParent.Panel2
        '
        Me.splitParent.Panel2.Controls.Add(Me.splitChild)
        Me.splitParent.Size = New System.Drawing.Size(1197, 477)
        Me.splitParent.SplitterDistance = 240
        Me.splitParent.TabIndex = 1
        '
        'panelLoadingClients
        '
        Me.panelLoadingClients.Controls.Add(Me.pbarStatusLoadingClients)
        Me.panelLoadingClients.Controls.Add(Me.lblStatusLoadingClients)
        Me.panelLoadingClients.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLoadingClients.Location = New System.Drawing.Point(0, 89)
        Me.panelLoadingClients.Name = "panelLoadingClients"
        Me.panelLoadingClients.Size = New System.Drawing.Size(236, 24)
        Me.panelLoadingClients.TabIndex = 4
        Me.panelLoadingClients.Visible = False
        '
        'pbarStatusLoadingClients
        '
        Me.pbarStatusLoadingClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbarStatusLoadingClients.Location = New System.Drawing.Point(0, 13)
        Me.pbarStatusLoadingClients.MarqueeAnimationSpeed = 10
        Me.pbarStatusLoadingClients.Name = "pbarStatusLoadingClients"
        Me.pbarStatusLoadingClients.Size = New System.Drawing.Size(236, 11)
        Me.pbarStatusLoadingClients.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbarStatusLoadingClients.TabIndex = 1
        '
        'lblStatusLoadingClients
        '
        Me.lblStatusLoadingClients.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatusLoadingClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusLoadingClients.ForeColor = System.Drawing.Color.Blue
        Me.lblStatusLoadingClients.Location = New System.Drawing.Point(0, 0)
        Me.lblStatusLoadingClients.Name = "lblStatusLoadingClients"
        Me.lblStatusLoadingClients.Size = New System.Drawing.Size(236, 13)
        Me.lblStatusLoadingClients.TabIndex = 0
        Me.lblStatusLoadingClients.Text = "Cargando clientes..."
        Me.lblStatusLoadingClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tviewClients
        '
        Me.tviewClients.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.tviewClients.CheckBoxes = True
        Me.tviewClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tviewClients.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll
        Me.tviewClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tviewClients.Location = New System.Drawing.Point(0, 89)
        Me.tviewClients.Name = "tviewClients"
        Me.tviewClients.Size = New System.Drawing.Size(236, 384)
        Me.tviewClients.TabIndex = 5
        '
        'panelClientFilter
        '
        Me.panelClientFilter.Controls.Add(Me.cboxExpandClients)
        Me.panelClientFilter.Controls.Add(Me.Label7)
        Me.panelClientFilter.Controls.Add(Me.txtClientFilter)
        Me.panelClientFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelClientFilter.Location = New System.Drawing.Point(0, 56)
        Me.panelClientFilter.Name = "panelClientFilter"
        Me.panelClientFilter.Size = New System.Drawing.Size(236, 33)
        Me.panelClientFilter.TabIndex = 7
        '
        'cboxExpandClients
        '
        Me.cboxExpandClients.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboxExpandClients.AutoSize = True
        Me.cboxExpandClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxExpandClients.Location = New System.Drawing.Point(175, 9)
        Me.cboxExpandClients.Name = "cboxExpandClients"
        Me.cboxExpandClients.Size = New System.Drawing.Size(60, 16)
        Me.cboxExpandClients.TabIndex = 8
        Me.cboxExpandClients.Text = "Expandir"
        Me.cboxExpandClients.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Filtrar Por"
        '
        'txtClientFilter
        '
        Me.txtClientFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientFilter.BackColor = System.Drawing.Color.LightYellow
        Me.txtClientFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClientFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientFilter.HintText = "Hint Text"
        Me.txtClientFilter.HintTextColor = System.Drawing.Color.Gray
        Me.txtClientFilter.HintTextEnabled = False
        Me.txtClientFilter.Location = New System.Drawing.Point(78, 6)
        Me.txtClientFilter.Name = "txtClientFilter"
        Me.txtClientFilter.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtClientFilter.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtClientFilter.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtClientFilter.Size = New System.Drawing.Size(91, 20)
        Me.txtClientFilter.TabIndex = 6
        Me.txtClientFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panelClientCount
        '
        Me.panelClientCount.Controls.Add(Me.btnReload)
        Me.panelClientCount.Controls.Add(Me.lblVehiclesQuantity)
        Me.panelClientCount.Controls.Add(Me.lblClientsQuantity)
        Me.panelClientCount.Controls.Add(Me.cboDealers)
        Me.panelClientCount.Controls.Add(Me.Label6)
        Me.panelClientCount.Controls.Add(Me.Label5)
        Me.panelClientCount.Controls.Add(Me.Label4)
        Me.panelClientCount.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelClientCount.Location = New System.Drawing.Point(0, 0)
        Me.panelClientCount.Name = "panelClientCount"
        Me.panelClientCount.Size = New System.Drawing.Size(236, 56)
        Me.panelClientCount.TabIndex = 3
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.Transparent
        Me.btnReload.BackgroundImage = Global.VillaTracking.My.Resources.Resources.refresh_icon
        Me.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(4, 4)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(40, 40)
        Me.btnReload.TabIndex = 4
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'lblVehiclesQuantity
        '
        Me.lblVehiclesQuantity.AutoSize = True
        Me.lblVehiclesQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehiclesQuantity.ForeColor = System.Drawing.Color.Green
        Me.lblVehiclesQuantity.Location = New System.Drawing.Point(192, 32)
        Me.lblVehiclesQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVehiclesQuantity.Name = "lblVehiclesQuantity"
        Me.lblVehiclesQuantity.Size = New System.Drawing.Size(35, 13)
        Me.lblVehiclesQuantity.TabIndex = 3
        Me.lblVehiclesQuantity.Text = "0000"
        '
        'lblClientsQuantity
        '
        Me.lblClientsQuantity.AutoSize = True
        Me.lblClientsQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientsQuantity.ForeColor = System.Drawing.Color.Green
        Me.lblClientsQuantity.Location = New System.Drawing.Point(95, 32)
        Me.lblClientsQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClientsQuantity.Name = "lblClientsQuantity"
        Me.lblClientsQuantity.Size = New System.Drawing.Size(35, 13)
        Me.lblClientsQuantity.TabIndex = 3
        Me.lblClientsQuantity.Text = "0000"
        '
        'cboDealers
        '
        Me.cboDealers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDealers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDealers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDealers.FormattingEnabled = True
        Me.cboDealers.HintText = "Hint Text"
        Me.cboDealers.HintTextColor = System.Drawing.Color.Gray
        Me.cboDealers.HintTextEnabled = False
        Me.cboDealers.Location = New System.Drawing.Point(95, 2)
        Me.cboDealers.Name = "cboDealers"
        Me.cboDealers.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboDealers.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboDealers.Size = New System.Drawing.Size(136, 21)
        Me.cboDealers.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Vehículos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Clientes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Dealer:"
        '
        'splitChild
        '
        Me.splitChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitChild.Location = New System.Drawing.Point(0, 0)
        Me.splitChild.Name = "splitChild"
        Me.splitChild.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitChild.Panel1
        '
        Me.splitChild.Panel1.Controls.Add(Me.ZuPanel1)
        Me.splitChild.Panel1.Controls.Add(Me.panelGeofencesVehicles)
        Me.splitChild.Panel1.Controls.Add(Me.tbarMapZoom)
        Me.splitChild.Panel1.Controls.Add(Me.btnHybrid)
        Me.splitChild.Panel1.Controls.Add(Me.btnSatellite)
        Me.splitChild.Panel1.Controls.Add(Me.btnMap)
        Me.splitChild.Panel1.Controls.Add(Me.mapMain)
        '
        'splitChild.Panel2
        '
        Me.splitChild.Panel2.Controls.Add(Me.tabConsole)
        Me.splitChild.Size = New System.Drawing.Size(953, 477)
        Me.splitChild.SplitterDistance = 275
        Me.splitChild.TabIndex = 1
        '
        'ZuPanel1
        '
        Me.ZuPanel1.Controls.Add(Me.NumericUpDown2)
        Me.ZuPanel1.Controls.Add(Me.NumericUpDown1)
        Me.ZuPanel1.Controls.Add(Me.num)
        Me.ZuPanel1.Controls.Add(Me.btnBgwGprsReceiver)
        Me.ZuPanel1.Controls.Add(Me.btnBgwGetEvents)
        Me.ZuPanel1.Controls.Add(Me.btnBgwGetCurrentLocations)
        Me.ZuPanel1.Controls.Add(Me.btnBgwGetClients)
        Me.ZuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ZuPanel1.Location = New System.Drawing.Point(0, 228)
        Me.ZuPanel1.Name = "ZuPanel1"
        Me.ZuPanel1.Size = New System.Drawing.Size(745, 43)
        Me.ZuPanel1.TabIndex = 8
        Me.ZuPanel1.Visible = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(513, 13)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDown2.TabIndex = 3
        Me.NumericUpDown2.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(463, 13)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown1.TabIndex = 2
        '
        'num
        '
        Me.num.Location = New System.Drawing.Point(355, 13)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(35, 20)
        Me.num.TabIndex = 1
        '
        'btnBgwGprsReceiver
        '
        Me.btnBgwGprsReceiver.BackColor = System.Drawing.Color.Transparent
        Me.btnBgwGprsReceiver.BackgroundImage = CType(resources.GetObject("btnBgwGprsReceiver.BackgroundImage"), System.Drawing.Image)
        Me.btnBgwGprsReceiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBgwGprsReceiver.BackgroundOnClick = CType(resources.GetObject("btnBgwGprsReceiver.BackgroundOnClick"), System.Drawing.Image)
        Me.btnBgwGprsReceiver.BackgroundOnDisabled = CType(resources.GetObject("btnBgwGprsReceiver.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnBgwGprsReceiver.BackgroundOnHover = CType(resources.GetObject("btnBgwGprsReceiver.BackgroundOnHover"), System.Drawing.Image)
        Me.btnBgwGprsReceiver.BackgroundOnNormal = CType(resources.GetObject("btnBgwGprsReceiver.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnBgwGprsReceiver.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnBgwGprsReceiver.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnBgwGprsReceiver.FlatAppearance.BorderSize = 0
        Me.btnBgwGprsReceiver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGprsReceiver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGprsReceiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBgwGprsReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBgwGprsReceiver.Location = New System.Drawing.Point(258, 3)
        Me.btnBgwGprsReceiver.Name = "btnBgwGprsReceiver"
        Me.btnBgwGprsReceiver.Size = New System.Drawing.Size(78, 37)
        Me.btnBgwGprsReceiver.TabIndex = 0
        Me.btnBgwGprsReceiver.Text = "Getting Gprs Data"
        Me.btnBgwGprsReceiver.UseVisualStyleBackColor = False
        '
        'btnBgwGetEvents
        '
        Me.btnBgwGetEvents.BackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetEvents.BackgroundImage = CType(resources.GetObject("btnBgwGetEvents.BackgroundImage"), System.Drawing.Image)
        Me.btnBgwGetEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBgwGetEvents.BackgroundOnClick = CType(resources.GetObject("btnBgwGetEvents.BackgroundOnClick"), System.Drawing.Image)
        Me.btnBgwGetEvents.BackgroundOnDisabled = CType(resources.GetObject("btnBgwGetEvents.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnBgwGetEvents.BackgroundOnHover = CType(resources.GetObject("btnBgwGetEvents.BackgroundOnHover"), System.Drawing.Image)
        Me.btnBgwGetEvents.BackgroundOnNormal = CType(resources.GetObject("btnBgwGetEvents.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnBgwGetEvents.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnBgwGetEvents.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnBgwGetEvents.FlatAppearance.BorderSize = 0
        Me.btnBgwGetEvents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBgwGetEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBgwGetEvents.Location = New System.Drawing.Point(174, 3)
        Me.btnBgwGetEvents.Name = "btnBgwGetEvents"
        Me.btnBgwGetEvents.Size = New System.Drawing.Size(78, 37)
        Me.btnBgwGetEvents.TabIndex = 0
        Me.btnBgwGetEvents.Text = "Getting Evetns"
        Me.btnBgwGetEvents.UseVisualStyleBackColor = False
        '
        'btnBgwGetCurrentLocations
        '
        Me.btnBgwGetCurrentLocations.BackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetCurrentLocations.BackgroundImage = CType(resources.GetObject("btnBgwGetCurrentLocations.BackgroundImage"), System.Drawing.Image)
        Me.btnBgwGetCurrentLocations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBgwGetCurrentLocations.BackgroundOnClick = CType(resources.GetObject("btnBgwGetCurrentLocations.BackgroundOnClick"), System.Drawing.Image)
        Me.btnBgwGetCurrentLocations.BackgroundOnDisabled = CType(resources.GetObject("btnBgwGetCurrentLocations.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnBgwGetCurrentLocations.BackgroundOnHover = CType(resources.GetObject("btnBgwGetCurrentLocations.BackgroundOnHover"), System.Drawing.Image)
        Me.btnBgwGetCurrentLocations.BackgroundOnNormal = CType(resources.GetObject("btnBgwGetCurrentLocations.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnBgwGetCurrentLocations.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnBgwGetCurrentLocations.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnBgwGetCurrentLocations.FlatAppearance.BorderSize = 0
        Me.btnBgwGetCurrentLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetCurrentLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetCurrentLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBgwGetCurrentLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBgwGetCurrentLocations.Location = New System.Drawing.Point(90, 3)
        Me.btnBgwGetCurrentLocations.Name = "btnBgwGetCurrentLocations"
        Me.btnBgwGetCurrentLocations.Size = New System.Drawing.Size(78, 37)
        Me.btnBgwGetCurrentLocations.TabIndex = 0
        Me.btnBgwGetCurrentLocations.Text = "Getting Locations"
        Me.btnBgwGetCurrentLocations.UseVisualStyleBackColor = False
        '
        'btnBgwGetClients
        '
        Me.btnBgwGetClients.BackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetClients.BackgroundImage = CType(resources.GetObject("btnBgwGetClients.BackgroundImage"), System.Drawing.Image)
        Me.btnBgwGetClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBgwGetClients.BackgroundOnClick = CType(resources.GetObject("btnBgwGetClients.BackgroundOnClick"), System.Drawing.Image)
        Me.btnBgwGetClients.BackgroundOnDisabled = CType(resources.GetObject("btnBgwGetClients.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnBgwGetClients.BackgroundOnHover = CType(resources.GetObject("btnBgwGetClients.BackgroundOnHover"), System.Drawing.Image)
        Me.btnBgwGetClients.BackgroundOnNormal = CType(resources.GetObject("btnBgwGetClients.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnBgwGetClients.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnBgwGetClients.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnBgwGetClients.FlatAppearance.BorderSize = 0
        Me.btnBgwGetClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBgwGetClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBgwGetClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBgwGetClients.Location = New System.Drawing.Point(6, 3)
        Me.btnBgwGetClients.Name = "btnBgwGetClients"
        Me.btnBgwGetClients.Size = New System.Drawing.Size(78, 37)
        Me.btnBgwGetClients.TabIndex = 0
        Me.btnBgwGetClients.Text = "Getting Clients"
        Me.btnBgwGetClients.UseVisualStyleBackColor = False
        '
        'panelGeofencesVehicles
        '
        Me.panelGeofencesVehicles.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.panelGeofencesVehicles.Controls.Add(Me.dgvGeofences)
        Me.panelGeofencesVehicles.Controls.Add(Me.lblLicensePlate)
        Me.panelGeofencesVehicles.Controls.Add(Me.label8)
        Me.panelGeofencesVehicles.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelGeofencesVehicles.Location = New System.Drawing.Point(745, 0)
        Me.panelGeofencesVehicles.Name = "panelGeofencesVehicles"
        Me.panelGeofencesVehicles.Size = New System.Drawing.Size(204, 271)
        Me.panelGeofencesVehicles.TabIndex = 7
        Me.panelGeofencesVehicles.Visible = False
        '
        'dgvGeofences
        '
        Me.dgvGeofences.AllowUserToAddRows = False
        Me.dgvGeofences.AllowUserToDeleteRows = False
        Me.dgvGeofences.AllowUserToResizeColumns = False
        Me.dgvGeofences.AllowUserToResizeRows = False
        Me.dgvGeofences.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dgvGeofences.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGeofences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGeofences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGeofences.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGeofences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGeofences.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvGeofences_on_map, Me.dgvGeofences_name, Me.dgvGeofences_imei, Me.dgvGeofences_geofence_id, Me.dgvGeofences_vehicle_id, Me.dgvGeofences_points})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGeofences.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGeofences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGeofences.EnableHeadersVisualStyles = False
        Me.dgvGeofences.GridColor = System.Drawing.SystemColors.Control
        Me.dgvGeofences.Location = New System.Drawing.Point(0, 44)
        Me.dgvGeofences.MultiSelect = False
        Me.dgvGeofences.Name = "dgvGeofences"
        Me.dgvGeofences.ReadOnly = True
        Me.dgvGeofences.RowHeadersVisible = False
        Me.dgvGeofences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGeofences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGeofences.Size = New System.Drawing.Size(204, 227)
        Me.dgvGeofences.TabIndex = 1
        '
        'dgvGeofences_on_map
        '
        Me.dgvGeofences_on_map.HeaderText = "VER"
        Me.dgvGeofences_on_map.Name = "dgvGeofences_on_map"
        Me.dgvGeofences_on_map.ReadOnly = True
        Me.dgvGeofences_on_map.Width = 30
        '
        'dgvGeofences_name
        '
        Me.dgvGeofences_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvGeofences_name.HeaderText = "GEOCERCA"
        Me.dgvGeofences_name.Name = "dgvGeofences_name"
        Me.dgvGeofences_name.ReadOnly = True
        '
        'dgvGeofences_imei
        '
        Me.dgvGeofences_imei.HeaderText = "IMEI"
        Me.dgvGeofences_imei.Name = "dgvGeofences_imei"
        Me.dgvGeofences_imei.ReadOnly = True
        Me.dgvGeofences_imei.Visible = False
        '
        'dgvGeofences_geofence_id
        '
        Me.dgvGeofences_geofence_id.HeaderText = "ID GEOCERCA"
        Me.dgvGeofences_geofence_id.Name = "dgvGeofences_geofence_id"
        Me.dgvGeofences_geofence_id.ReadOnly = True
        Me.dgvGeofences_geofence_id.Visible = False
        '
        'dgvGeofences_vehicle_id
        '
        Me.dgvGeofences_vehicle_id.HeaderText = "ID VEHICULO"
        Me.dgvGeofences_vehicle_id.Name = "dgvGeofences_vehicle_id"
        Me.dgvGeofences_vehicle_id.ReadOnly = True
        Me.dgvGeofences_vehicle_id.Visible = False
        '
        'dgvGeofences_points
        '
        Me.dgvGeofences_points.HeaderText = "POINTS"
        Me.dgvGeofences_points.Name = "dgvGeofences_points"
        Me.dgvGeofences_points.ReadOnly = True
        Me.dgvGeofences_points.Visible = False
        '
        'lblLicensePlate
        '
        Me.lblLicensePlate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lblLicensePlate.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLicensePlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicensePlate.ForeColor = System.Drawing.Color.White
        Me.lblLicensePlate.Location = New System.Drawing.Point(0, 18)
        Me.lblLicensePlate.Name = "lblLicensePlate"
        Me.lblLicensePlate.Size = New System.Drawing.Size(204, 26)
        Me.lblLicensePlate.TabIndex = 2
        Me.lblLicensePlate.Text = "----"
        Me.lblLicensePlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label8
        '
        Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Black
        Me.label8.Location = New System.Drawing.Point(0, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(204, 18)
        Me.label8.TabIndex = 0
        Me.label8.Text = "Vehículo"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbarMapZoom
        '
        Me.tbarMapZoom.BackColor = System.Drawing.Color.Transparent
        Me.tbarMapZoom.BorderColor = System.Drawing.Color.Transparent
        Me.tbarMapZoom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbarMapZoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.tbarMapZoom.IndentHeight = 3
        Me.tbarMapZoom.Location = New System.Drawing.Point(7, 31)
        Me.tbarMapZoom.Maximum = 19
        Me.tbarMapZoom.Minimum = 3
        Me.tbarMapZoom.Name = "tbarMapZoom"
        Me.tbarMapZoom.Size = New System.Drawing.Size(237, 25)
        Me.tbarMapZoom.TabIndex = 6
        Me.tbarMapZoom.TextTickStyle = System.Windows.Forms.TickStyle.None
        Me.tbarMapZoom.TickColor = System.Drawing.Color.Red
        Me.tbarMapZoom.TickHeight = 2
        Me.tbarMapZoom.TrackerColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.tbarMapZoom.TrackerSize = New System.Drawing.Size(16, 16)
        Me.tbarMapZoom.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.tbarMapZoom.TrackLineHeight = 3
        Me.tbarMapZoom.Value = 3
        '
        'btnHybrid
        '
        Me.btnHybrid.BackColor = System.Drawing.Color.Transparent
        Me.btnHybrid.BackgroundImage = CType(resources.GetObject("btnHybrid.BackgroundImage"), System.Drawing.Image)
        Me.btnHybrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHybrid.BackgroundOnClick = CType(resources.GetObject("btnHybrid.BackgroundOnClick"), System.Drawing.Image)
        Me.btnHybrid.BackgroundOnDisabled = CType(resources.GetObject("btnHybrid.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnHybrid.BackgroundOnHover = CType(resources.GetObject("btnHybrid.BackgroundOnHover"), System.Drawing.Image)
        Me.btnHybrid.BackgroundOnNormal = CType(resources.GetObject("btnHybrid.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnHybrid.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnHybrid.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnHybrid.FlatAppearance.BorderSize = 0
        Me.btnHybrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHybrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHybrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHybrid.Location = New System.Drawing.Point(169, 4)
        Me.btnHybrid.Name = "btnHybrid"
        Me.btnHybrid.Size = New System.Drawing.Size(75, 23)
        Me.btnHybrid.TabIndex = 3
        Me.btnHybrid.Text = "Híbrido"
        Me.btnHybrid.UseVisualStyleBackColor = False
        '
        'btnSatellite
        '
        Me.btnSatellite.BackColor = System.Drawing.Color.Transparent
        Me.btnSatellite.BackgroundImage = CType(resources.GetObject("btnSatellite.BackgroundImage"), System.Drawing.Image)
        Me.btnSatellite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSatellite.BackgroundOnClick = CType(resources.GetObject("btnSatellite.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSatellite.BackgroundOnDisabled = CType(resources.GetObject("btnSatellite.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSatellite.BackgroundOnHover = CType(resources.GetObject("btnSatellite.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSatellite.BackgroundOnNormal = CType(resources.GetObject("btnSatellite.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSatellite.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSatellite.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnSatellite.FlatAppearance.BorderSize = 0
        Me.btnSatellite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSatellite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSatellite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSatellite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSatellite.Location = New System.Drawing.Point(88, 4)
        Me.btnSatellite.Name = "btnSatellite"
        Me.btnSatellite.Size = New System.Drawing.Size(75, 23)
        Me.btnSatellite.TabIndex = 4
        Me.btnSatellite.Text = "Satélite"
        Me.btnSatellite.UseVisualStyleBackColor = False
        '
        'btnMap
        '
        Me.btnMap.BackColor = System.Drawing.Color.Transparent
        Me.btnMap.BackgroundImage = CType(resources.GetObject("btnMap.BackgroundImage"), System.Drawing.Image)
        Me.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMap.BackgroundOnClick = CType(resources.GetObject("btnMap.BackgroundOnClick"), System.Drawing.Image)
        Me.btnMap.BackgroundOnDisabled = CType(resources.GetObject("btnMap.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnMap.BackgroundOnHover = CType(resources.GetObject("btnMap.BackgroundOnHover"), System.Drawing.Image)
        Me.btnMap.BackgroundOnNormal = CType(resources.GetObject("btnMap.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnMap.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnMap.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnMap.FlatAppearance.BorderSize = 0
        Me.btnMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMap.Location = New System.Drawing.Point(7, 4)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(75, 23)
        Me.btnMap.TabIndex = 5
        Me.btnMap.Text = "Mapa"
        Me.btnMap.UseVisualStyleBackColor = False
        '
        'mapMain
        '
        Me.mapMain.Bearing = 0!
        Me.mapMain.CanDragMap = True
        Me.mapMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mapMain.EmptyTileColor = System.Drawing.Color.Navy
        Me.mapMain.GrayScaleMode = False
        Me.mapMain.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.mapMain.LevelsKeepInMemmory = 5
        Me.mapMain.Location = New System.Drawing.Point(0, 0)
        Me.mapMain.MarkersEnabled = True
        Me.mapMain.MaxZoom = 19
        Me.mapMain.MinZoom = 3
        Me.mapMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.mapMain.Name = "mapMain"
        Me.mapMain.NegativeMode = False
        Me.mapMain.PolygonsEnabled = True
        Me.mapMain.RetryLoadTile = 0
        Me.mapMain.RoutesEnabled = True
        Me.mapMain.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.mapMain.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.mapMain.ShowTileGridLines = False
        Me.mapMain.Size = New System.Drawing.Size(949, 271)
        Me.mapMain.TabIndex = 1
        Me.mapMain.Zoom = 12.0R
        '
        'tabConsole
        '
        Me.tabConsole.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabConsole.Controls.Add(Me.tpageVehicles)
        Me.tabConsole.Controls.Add(Me.tpageEvents)
        Me.tabConsole.Controls.Add(Me.tpageGprsReceiver)
        Me.tabConsole.Controls.Add(Me.tpageModemSms)
        Me.tabConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabConsole.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabConsole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabConsole.ItemSize = New System.Drawing.Size(220, 21)
        Me.tabConsole.Location = New System.Drawing.Point(0, 0)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.SelectedIndex = 0
        Me.tabConsole.Size = New System.Drawing.Size(949, 194)
        Me.tabConsole.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabConsole.TabIndex = 0
        '
        'tpageVehicles
        '
        Me.tpageVehicles.Controls.Add(Me.dgvConsoleVehicles)
        Me.tpageVehicles.Location = New System.Drawing.Point(4, 25)
        Me.tpageVehicles.Name = "tpageVehicles"
        Me.tpageVehicles.Size = New System.Drawing.Size(941, 165)
        Me.tpageVehicles.TabIndex = 0
        Me.tpageVehicles.Text = "VEHÍCULOS (000)"
        Me.tpageVehicles.UseVisualStyleBackColor = True
        '
        'dgvConsoleVehicles
        '
        Me.dgvConsoleVehicles.AllowUserToAddRows = False
        Me.dgvConsoleVehicles.AllowUserToDeleteRows = False
        Me.dgvConsoleVehicles.AllowUserToResizeColumns = False
        Me.dgvConsoleVehicles.AllowUserToResizeRows = False
        Me.dgvConsoleVehicles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvConsoleVehicles.BackgroundHeader = CType(resources.GetObject("dgvConsoleVehicles.BackgroundHeader"), System.Drawing.Image)
        Me.dgvConsoleVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvConsoleVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvConsoleVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvConsoleVehicles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConsoleVehicles.ColumnHeadersHeight = 15
        Me.dgvConsoleVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvConsoleVehicles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvVehicles_onMap, Me.dgvVehicles_config, Me.dgvVehicles_vehicle_code, Me.dgvVehicles_device_model, Me.dgvVehicles_imei, Me.dgvVehicles_simcard, Me.dgvVehicles_cliente_name, Me.dgvVehicles_license_plate, Me.dgvVehicles_brand, Me.dgvVehicles_model, Me.dgvVehicles_type, Me.dgvVehicles_year, Me.dgvVehicles_color, Me.dgvVehicles_last_report, Me.dgvVehicles_speed, Me.dgvVehicles_origin, Me.dgvVehicles_expiration_date, Me.dgvVehicles_client_id, Me.dgvVehicles_vehicle_id, Me.dgvVehicles_device_id, Me.dgvVehicles_device_model_id, Me.dgvVehicles_sms_stop, Me.dgvVehicles_sms_resume, Me.dgvVehicles_gprs_stop, Me.dgvVehicles_gprs_resume, Me.dgvVehicles_call_pass})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsoleVehicles.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvConsoleVehicles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConsoleVehicles.EnableHeadersVisualStyles = False
        Me.dgvConsoleVehicles.GridColor = System.Drawing.Color.White
        Me.dgvConsoleVehicles.HeaderFontSize = 7.0!
        Me.dgvConsoleVehicles.HeaderForeColor = System.Drawing.Color.White
        Me.dgvConsoleVehicles.Location = New System.Drawing.Point(0, 0)
        Me.dgvConsoleVehicles.MultiSelect = False
        Me.dgvConsoleVehicles.Name = "dgvConsoleVehicles"
        Me.dgvConsoleVehicles.ReadOnly = True
        Me.dgvConsoleVehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvConsoleVehicles.RowHeadersVisible = False
        Me.dgvConsoleVehicles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvConsoleVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsoleVehicles.Size = New System.Drawing.Size(941, 165)
        Me.dgvConsoleVehicles.TabIndex = 1
        '
        'dgvVehicles_onMap
        '
        Me.dgvVehicles_onMap.HeaderText = "VER"
        Me.dgvVehicles_onMap.Name = "dgvVehicles_onMap"
        Me.dgvVehicles_onMap.ReadOnly = True
        Me.dgvVehicles_onMap.Width = 36
        '
        'dgvVehicles_config
        '
        Me.dgvVehicles_config.HeaderText = ""
        Me.dgvVehicles_config.Name = "dgvVehicles_config"
        Me.dgvVehicles_config.ReadOnly = True
        Me.dgvVehicles_config.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVehicles_config.Text = "Config"
        Me.dgvVehicles_config.UseColumnTextForButtonValue = True
        Me.dgvVehicles_config.Width = 45
        '
        'dgvVehicles_vehicle_code
        '
        Me.dgvVehicles_vehicle_code.HeaderText = "CÓDIGO"
        Me.dgvVehicles_vehicle_code.Name = "dgvVehicles_vehicle_code"
        Me.dgvVehicles_vehicle_code.ReadOnly = True
        Me.dgvVehicles_vehicle_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_vehicle_code.Width = 60
        '
        'dgvVehicles_device_model
        '
        Me.dgvVehicles_device_model.HeaderText = "DISPOSITIVO"
        Me.dgvVehicles_device_model.Name = "dgvVehicles_device_model"
        Me.dgvVehicles_device_model.ReadOnly = True
        Me.dgvVehicles_device_model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_device_model.Visible = False
        Me.dgvVehicles_device_model.Width = 111
        '
        'dgvVehicles_imei
        '
        Me.dgvVehicles_imei.HeaderText = "IMEI"
        Me.dgvVehicles_imei.Name = "dgvVehicles_imei"
        Me.dgvVehicles_imei.ReadOnly = True
        Me.dgvVehicles_imei.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvVehicles_simcard
        '
        Me.dgvVehicles_simcard.HeaderText = "SIM CARD"
        Me.dgvVehicles_simcard.Name = "dgvVehicles_simcard"
        Me.dgvVehicles_simcard.ReadOnly = True
        Me.dgvVehicles_simcard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_simcard.Width = 70
        '
        'dgvVehicles_cliente_name
        '
        Me.dgvVehicles_cliente_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvVehicles_cliente_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVehicles_cliente_name.HeaderText = "CLIENTE"
        Me.dgvVehicles_cliente_name.Name = "dgvVehicles_cliente_name"
        Me.dgvVehicles_cliente_name.ReadOnly = True
        Me.dgvVehicles_cliente_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvVehicles_license_plate
        '
        Me.dgvVehicles_license_plate.HeaderText = "MATRÍCULA"
        Me.dgvVehicles_license_plate.Name = "dgvVehicles_license_plate"
        Me.dgvVehicles_license_plate.ReadOnly = True
        Me.dgvVehicles_license_plate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_license_plate.Width = 65
        '
        'dgvVehicles_brand
        '
        Me.dgvVehicles_brand.HeaderText = "MARCA"
        Me.dgvVehicles_brand.Name = "dgvVehicles_brand"
        Me.dgvVehicles_brand.ReadOnly = True
        Me.dgvVehicles_brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_brand.Width = 65
        '
        'dgvVehicles_model
        '
        Me.dgvVehicles_model.HeaderText = "MODELO"
        Me.dgvVehicles_model.Name = "dgvVehicles_model"
        Me.dgvVehicles_model.ReadOnly = True
        Me.dgvVehicles_model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_model.Width = 65
        '
        'dgvVehicles_type
        '
        Me.dgvVehicles_type.HeaderText = "TIPO"
        Me.dgvVehicles_type.Name = "dgvVehicles_type"
        Me.dgvVehicles_type.ReadOnly = True
        Me.dgvVehicles_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_type.Visible = False
        Me.dgvVehicles_type.Width = 42
        '
        'dgvVehicles_year
        '
        DataGridViewCellStyle5.Format = "####"
        DataGridViewCellStyle5.NullValue = "0000"
        Me.dgvVehicles_year.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVehicles_year.HeaderText = "AÑO"
        Me.dgvVehicles_year.Name = "dgvVehicles_year"
        Me.dgvVehicles_year.ReadOnly = True
        Me.dgvVehicles_year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_year.Visible = False
        Me.dgvVehicles_year.Width = 39
        '
        'dgvVehicles_color
        '
        Me.dgvVehicles_color.HeaderText = "COLOR"
        Me.dgvVehicles_color.Name = "dgvVehicles_color"
        Me.dgvVehicles_color.ReadOnly = True
        Me.dgvVehicles_color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_color.Width = 65
        '
        'dgvVehicles_last_report
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.dgvVehicles_last_report.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVehicles_last_report.HeaderText = "ÚLTIMO REPORTE"
        Me.dgvVehicles_last_report.Name = "dgvVehicles_last_report"
        Me.dgvVehicles_last_report.ReadOnly = True
        Me.dgvVehicles_last_report.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_last_report.Width = 140
        '
        'dgvVehicles_speed
        '
        Me.dgvVehicles_speed.HeaderText = "VELOCIDAD"
        Me.dgvVehicles_speed.Name = "dgvVehicles_speed"
        Me.dgvVehicles_speed.ReadOnly = True
        Me.dgvVehicles_speed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_speed.Width = 70
        '
        'dgvVehicles_origin
        '
        Me.dgvVehicles_origin.HeaderText = "ORIGEN"
        Me.dgvVehicles_origin.Name = "dgvVehicles_origin"
        Me.dgvVehicles_origin.ReadOnly = True
        Me.dgvVehicles_origin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_origin.Width = 50
        '
        'dgvVehicles_expiration_date
        '
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dgvVehicles_expiration_date.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVehicles_expiration_date.HeaderText = "FECHA VENCIMIENTO"
        Me.dgvVehicles_expiration_date.Name = "dgvVehicles_expiration_date"
        Me.dgvVehicles_expiration_date.ReadOnly = True
        Me.dgvVehicles_expiration_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_expiration_date.Visible = False
        Me.dgvVehicles_expiration_date.Width = 161
        '
        'dgvVehicles_client_id
        '
        Me.dgvVehicles_client_id.HeaderText = "ID CLIENTE"
        Me.dgvVehicles_client_id.Name = "dgvVehicles_client_id"
        Me.dgvVehicles_client_id.ReadOnly = True
        Me.dgvVehicles_client_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvVehicles_client_id.Visible = False
        Me.dgvVehicles_client_id.Width = 82
        '
        'dgvVehicles_vehicle_id
        '
        Me.dgvVehicles_vehicle_id.HeaderText = "ID VEHICULO"
        Me.dgvVehicles_vehicle_id.Name = "dgvVehicles_vehicle_id"
        Me.dgvVehicles_vehicle_id.ReadOnly = True
        Me.dgvVehicles_vehicle_id.Visible = False
        Me.dgvVehicles_vehicle_id.Width = 111
        '
        'dgvVehicles_device_id
        '
        Me.dgvVehicles_device_id.HeaderText = "ID EQUIPO GPS"
        Me.dgvVehicles_device_id.Name = "dgvVehicles_device_id"
        Me.dgvVehicles_device_id.ReadOnly = True
        Me.dgvVehicles_device_id.Visible = False
        Me.dgvVehicles_device_id.Width = 125
        '
        'dgvVehicles_device_model_id
        '
        Me.dgvVehicles_device_model_id.HeaderText = "ID MODELO DISPOSITIVO"
        Me.dgvVehicles_device_model_id.Name = "dgvVehicles_device_model_id"
        Me.dgvVehicles_device_model_id.ReadOnly = True
        Me.dgvVehicles_device_model_id.Visible = False
        Me.dgvVehicles_device_model_id.Width = 184
        '
        'dgvVehicles_sms_stop
        '
        Me.dgvVehicles_sms_stop.HeaderText = "SMS STOP"
        Me.dgvVehicles_sms_stop.Name = "dgvVehicles_sms_stop"
        Me.dgvVehicles_sms_stop.ReadOnly = True
        Me.dgvVehicles_sms_stop.Visible = False
        Me.dgvVehicles_sms_stop.Width = 95
        '
        'dgvVehicles_sms_resume
        '
        Me.dgvVehicles_sms_resume.HeaderText = "SMS RESUME"
        Me.dgvVehicles_sms_resume.Name = "dgvVehicles_sms_resume"
        Me.dgvVehicles_sms_resume.ReadOnly = True
        Me.dgvVehicles_sms_resume.Visible = False
        Me.dgvVehicles_sms_resume.Width = 114
        '
        'dgvVehicles_gprs_stop
        '
        Me.dgvVehicles_gprs_stop.HeaderText = "GPRS STOP"
        Me.dgvVehicles_gprs_stop.Name = "dgvVehicles_gprs_stop"
        Me.dgvVehicles_gprs_stop.ReadOnly = True
        Me.dgvVehicles_gprs_stop.Visible = False
        Me.dgvVehicles_gprs_stop.Width = 103
        '
        'dgvVehicles_gprs_resume
        '
        Me.dgvVehicles_gprs_resume.HeaderText = "GPRS RESUME"
        Me.dgvVehicles_gprs_resume.Name = "dgvVehicles_gprs_resume"
        Me.dgvVehicles_gprs_resume.ReadOnly = True
        Me.dgvVehicles_gprs_resume.Visible = False
        Me.dgvVehicles_gprs_resume.Width = 122
        '
        'dgvVehicles_call_pass
        '
        Me.dgvVehicles_call_pass.HeaderText = "CALL PASS"
        Me.dgvVehicles_call_pass.Name = "dgvVehicles_call_pass"
        Me.dgvVehicles_call_pass.ReadOnly = True
        Me.dgvVehicles_call_pass.Visible = False
        Me.dgvVehicles_call_pass.Width = 98
        '
        'tpageEvents
        '
        Me.tpageEvents.Controls.Add(Me.dgvEvents)
        Me.tpageEvents.Location = New System.Drawing.Point(4, 25)
        Me.tpageEvents.Name = "tpageEvents"
        Me.tpageEvents.Size = New System.Drawing.Size(937, 164)
        Me.tpageEvents.TabIndex = 1
        Me.tpageEvents.Text = "EVENTOS (000)"
        Me.tpageEvents.UseVisualStyleBackColor = True
        '
        'dgvEvents
        '
        Me.dgvEvents.AllowUserToAddRows = False
        Me.dgvEvents.AllowUserToDeleteRows = False
        Me.dgvEvents.AllowUserToResizeColumns = False
        Me.dgvEvents.AllowUserToResizeRows = False
        Me.dgvEvents.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvEvents.BackgroundHeader = CType(resources.GetObject("dgvEvents.BackgroundHeader"), System.Drawing.Image)
        Me.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvEvents.ColumnHeadersHeight = 15
        Me.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvEvents_onMap, Me.dgvEvents_vehicle_code, Me.dgvEvents_client_name, Me.dgvEvents_imei, Me.dgvEvents_license_plate, Me.dgvEvents_date_time, Me.dgvEvents_name, Me.dgvEvents_validation, Me.dgvEvents_client_id, Me.dgvEvents_vehicle_id, Me.dgvEvents_report_type_id, Me.dgvEvents_geofence_id, Me.dgvEvents_geofence_points, Me.dgvEvents_latitude, Me.dgvEvents_longitude, Me.dgvEvents_speed, Me.dgvEvents_orientation})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEvents.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEvents.EnableHeadersVisualStyles = False
        Me.dgvEvents.GridColor = System.Drawing.Color.White
        Me.dgvEvents.HeaderFontSize = 7.0!
        Me.dgvEvents.HeaderForeColor = System.Drawing.Color.White
        Me.dgvEvents.Location = New System.Drawing.Point(0, 0)
        Me.dgvEvents.MultiSelect = False
        Me.dgvEvents.Name = "dgvEvents"
        Me.dgvEvents.ReadOnly = True
        Me.dgvEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEvents.RowHeadersVisible = False
        Me.dgvEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEvents.Size = New System.Drawing.Size(937, 164)
        Me.dgvEvents.TabIndex = 4
        '
        'dgvEvents_onMap
        '
        Me.dgvEvents_onMap.DataPropertyName = "dgvEvents_onMap"
        Me.dgvEvents_onMap.HeaderText = "VER"
        Me.dgvEvents_onMap.Name = "dgvEvents_onMap"
        Me.dgvEvents_onMap.ReadOnly = True
        Me.dgvEvents_onMap.Width = 36
        '
        'dgvEvents_vehicle_code
        '
        Me.dgvEvents_vehicle_code.HeaderText = "CÓDIGO"
        Me.dgvEvents_vehicle_code.Name = "dgvEvents_vehicle_code"
        Me.dgvEvents_vehicle_code.ReadOnly = True
        Me.dgvEvents_vehicle_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvEvents_vehicle_code.Width = 60
        '
        'dgvEvents_client_name
        '
        Me.dgvEvents_client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvEvents_client_name.DataPropertyName = "dgvEvents_client_name"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvEvents_client_name.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvEvents_client_name.HeaderText = "CLIENTE"
        Me.dgvEvents_client_name.Name = "dgvEvents_client_name"
        Me.dgvEvents_client_name.ReadOnly = True
        Me.dgvEvents_client_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvEvents_imei
        '
        Me.dgvEvents_imei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvEvents_imei.DataPropertyName = "dgvEvents_imei"
        Me.dgvEvents_imei.HeaderText = "IMEI"
        Me.dgvEvents_imei.Name = "dgvEvents_imei"
        Me.dgvEvents_imei.ReadOnly = True
        Me.dgvEvents_imei.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvEvents_license_plate
        '
        Me.dgvEvents_license_plate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvEvents_license_plate.DataPropertyName = "dgvEvents_license_plate"
        Me.dgvEvents_license_plate.HeaderText = "MATRÍCULA"
        Me.dgvEvents_license_plate.Name = "dgvEvents_license_plate"
        Me.dgvEvents_license_plate.ReadOnly = True
        Me.dgvEvents_license_plate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvEvents_license_plate.Width = 65
        '
        'dgvEvents_date_time
        '
        Me.dgvEvents_date_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvEvents_date_time.DataPropertyName = "dgvEvents_date_time"
        DataGridViewCellStyle11.Format = "dd/MM/yyyy hh:mm:ss tt"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.dgvEvents_date_time.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvEvents_date_time.HeaderText = "FECHA"
        Me.dgvEvents_date_time.Name = "dgvEvents_date_time"
        Me.dgvEvents_date_time.ReadOnly = True
        Me.dgvEvents_date_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvEvents_date_time.Width = 140
        '
        'dgvEvents_name
        '
        Me.dgvEvents_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvEvents_name.DataPropertyName = "dgvEvents_name"
        Me.dgvEvents_name.HeaderText = "EVENTO"
        Me.dgvEvents_name.Name = "dgvEvents_name"
        Me.dgvEvents_name.ReadOnly = True
        Me.dgvEvents_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvEvents_validation
        '
        Me.dgvEvents_validation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvEvents_validation.DataPropertyName = "dgvEvents_validation"
        DataGridViewCellStyle12.Format = "dd/MM/yyyy hh:mm:ss tt"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.dgvEvents_validation.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvEvents_validation.HeaderText = "VÁLIDO HASTA"
        Me.dgvEvents_validation.Name = "dgvEvents_validation"
        Me.dgvEvents_validation.ReadOnly = True
        Me.dgvEvents_validation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvEvents_validation.Width = 140
        '
        'dgvEvents_client_id
        '
        Me.dgvEvents_client_id.DataPropertyName = "dgvEvents_client_id"
        Me.dgvEvents_client_id.HeaderText = "ID CLIENTE"
        Me.dgvEvents_client_id.Name = "dgvEvents_client_id"
        Me.dgvEvents_client_id.ReadOnly = True
        Me.dgvEvents_client_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvEvents_client_id.Visible = False
        Me.dgvEvents_client_id.Width = 80
        '
        'dgvEvents_vehicle_id
        '
        Me.dgvEvents_vehicle_id.DataPropertyName = "dgvEvents_vehicle_id"
        Me.dgvEvents_vehicle_id.HeaderText = "ID VEHICULO"
        Me.dgvEvents_vehicle_id.Name = "dgvEvents_vehicle_id"
        Me.dgvEvents_vehicle_id.ReadOnly = True
        Me.dgvEvents_vehicle_id.Visible = False
        Me.dgvEvents_vehicle_id.Width = 109
        '
        'dgvEvents_report_type_id
        '
        Me.dgvEvents_report_type_id.DataPropertyName = "dgvEvents_report_type_id"
        Me.dgvEvents_report_type_id.HeaderText = "ID TIPO REPORTE"
        Me.dgvEvents_report_type_id.Name = "dgvEvents_report_type_id"
        Me.dgvEvents_report_type_id.ReadOnly = True
        Me.dgvEvents_report_type_id.Visible = False
        Me.dgvEvents_report_type_id.Width = 139
        '
        'dgvEvents_geofence_id
        '
        Me.dgvEvents_geofence_id.DataPropertyName = "dgvEvents_geofence_id"
        Me.dgvEvents_geofence_id.HeaderText = "ID GEOCERCA"
        Me.dgvEvents_geofence_id.Name = "dgvEvents_geofence_id"
        Me.dgvEvents_geofence_id.ReadOnly = True
        Me.dgvEvents_geofence_id.Visible = False
        Me.dgvEvents_geofence_id.Width = 114
        '
        'dgvEvents_geofence_points
        '
        Me.dgvEvents_geofence_points.DataPropertyName = "dgvEvents_geofence_points"
        Me.dgvEvents_geofence_points.HeaderText = "PUNTOS GEOCERCA"
        Me.dgvEvents_geofence_points.Name = "dgvEvents_geofence_points"
        Me.dgvEvents_geofence_points.ReadOnly = True
        Me.dgvEvents_geofence_points.Visible = False
        Me.dgvEvents_geofence_points.Width = 152
        '
        'dgvEvents_latitude
        '
        Me.dgvEvents_latitude.DataPropertyName = "dgvEvents_latitude"
        Me.dgvEvents_latitude.HeaderText = "LATITUD"
        Me.dgvEvents_latitude.Name = "dgvEvents_latitude"
        Me.dgvEvents_latitude.ReadOnly = True
        Me.dgvEvents_latitude.Visible = False
        Me.dgvEvents_latitude.Width = 83
        '
        'dgvEvents_longitude
        '
        Me.dgvEvents_longitude.DataPropertyName = "dgvEvents_longitude"
        Me.dgvEvents_longitude.HeaderText = "LONGITUD"
        Me.dgvEvents_longitude.Name = "dgvEvents_longitude"
        Me.dgvEvents_longitude.ReadOnly = True
        Me.dgvEvents_longitude.Visible = False
        Me.dgvEvents_longitude.Width = 94
        '
        'dgvEvents_speed
        '
        Me.dgvEvents_speed.DataPropertyName = "dgvEvents_speed"
        Me.dgvEvents_speed.HeaderText = "VELOCIDAD"
        Me.dgvEvents_speed.Name = "dgvEvents_speed"
        Me.dgvEvents_speed.ReadOnly = True
        Me.dgvEvents_speed.Visible = False
        '
        'dgvEvents_orientation
        '
        Me.dgvEvents_orientation.DataPropertyName = "dgvEvents_orientation"
        Me.dgvEvents_orientation.HeaderText = "ORIENTACIÓN"
        Me.dgvEvents_orientation.Name = "dgvEvents_orientation"
        Me.dgvEvents_orientation.ReadOnly = True
        Me.dgvEvents_orientation.Visible = False
        Me.dgvEvents_orientation.Width = 115
        '
        'tpageGprsReceiver
        '
        Me.tpageGprsReceiver.Controls.Add(Me.dgvGprsReceiver)
        Me.tpageGprsReceiver.Location = New System.Drawing.Point(4, 25)
        Me.tpageGprsReceiver.Name = "tpageGprsReceiver"
        Me.tpageGprsReceiver.Size = New System.Drawing.Size(937, 164)
        Me.tpageGprsReceiver.TabIndex = 2
        Me.tpageGprsReceiver.Text = "GPRS DATA"
        Me.tpageGprsReceiver.UseVisualStyleBackColor = True
        '
        'dgvGprsReceiver
        '
        Me.dgvGprsReceiver.AllowUserToAddRows = False
        Me.dgvGprsReceiver.AllowUserToDeleteRows = False
        Me.dgvGprsReceiver.AllowUserToResizeColumns = False
        Me.dgvGprsReceiver.AllowUserToResizeRows = False
        Me.dgvGprsReceiver.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvGprsReceiver.BackgroundHeader = CType(resources.GetObject("dgvGprsReceiver.BackgroundHeader"), System.Drawing.Image)
        Me.dgvGprsReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGprsReceiver.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGprsReceiver.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        Me.dgvGprsReceiver.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvGprsReceiver.ColumnHeadersHeight = 15
        Me.dgvGprsReceiver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGprsReceiver.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvGprsReceiver_port, Me.dgvGprsReceiver_device_model, Me.dgvGprsReceiver_client, Me.dgvGprsReceiver_date_time, Me.dgvGprsReceiver_trace, Me.dgvGprsReceiver_status})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGprsReceiver.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvGprsReceiver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGprsReceiver.EnableHeadersVisualStyles = False
        Me.dgvGprsReceiver.GridColor = System.Drawing.Color.White
        Me.dgvGprsReceiver.HeaderFontSize = 7.0!
        Me.dgvGprsReceiver.HeaderForeColor = System.Drawing.Color.White
        Me.dgvGprsReceiver.Location = New System.Drawing.Point(0, 0)
        Me.dgvGprsReceiver.MultiSelect = False
        Me.dgvGprsReceiver.Name = "dgvGprsReceiver"
        Me.dgvGprsReceiver.ReadOnly = True
        Me.dgvGprsReceiver.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGprsReceiver.RowHeadersVisible = False
        Me.dgvGprsReceiver.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGprsReceiver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGprsReceiver.Size = New System.Drawing.Size(937, 164)
        Me.dgvGprsReceiver.TabIndex = 5
        '
        'dgvGprsReceiver_port
        '
        Me.dgvGprsReceiver_port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvGprsReceiver_port.HeaderText = "PUERTO"
        Me.dgvGprsReceiver_port.Name = "dgvGprsReceiver_port"
        Me.dgvGprsReceiver_port.ReadOnly = True
        Me.dgvGprsReceiver_port.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvGprsReceiver_port.Width = 55
        '
        'dgvGprsReceiver_device_model
        '
        Me.dgvGprsReceiver_device_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvGprsReceiver_device_model.HeaderText = "MODELO GPS"
        Me.dgvGprsReceiver_device_model.Name = "dgvGprsReceiver_device_model"
        Me.dgvGprsReceiver_device_model.ReadOnly = True
        Me.dgvGprsReceiver_device_model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvGprsReceiver_device_model.Width = 80
        '
        'dgvGprsReceiver_client
        '
        Me.dgvGprsReceiver_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvGprsReceiver_client.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvGprsReceiver_client.HeaderText = "CLIENTE"
        Me.dgvGprsReceiver_client.Name = "dgvGprsReceiver_client"
        Me.dgvGprsReceiver_client.ReadOnly = True
        Me.dgvGprsReceiver_client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvGprsReceiver_client.Width = 300
        '
        'dgvGprsReceiver_date_time
        '
        Me.dgvGprsReceiver_date_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvGprsReceiver_date_time.HeaderText = "FECHA"
        Me.dgvGprsReceiver_date_time.Name = "dgvGprsReceiver_date_time"
        Me.dgvGprsReceiver_date_time.ReadOnly = True
        Me.dgvGprsReceiver_date_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvGprsReceiver_date_time.Width = 140
        '
        'dgvGprsReceiver_trace
        '
        Me.dgvGprsReceiver_trace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvGprsReceiver_trace.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvGprsReceiver_trace.HeaderText = "TRAZA"
        Me.dgvGprsReceiver_trace.Name = "dgvGprsReceiver_trace"
        Me.dgvGprsReceiver_trace.ReadOnly = True
        Me.dgvGprsReceiver_trace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvGprsReceiver_status
        '
        DataGridViewCellStyle17.Format = "N0"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.dgvGprsReceiver_status.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvGprsReceiver_status.HeaderText = "STATUS"
        Me.dgvGprsReceiver_status.Name = "dgvGprsReceiver_status"
        Me.dgvGprsReceiver_status.ReadOnly = True
        Me.dgvGprsReceiver_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvGprsReceiver_status.Visible = False
        Me.dgvGprsReceiver_status.Width = 60
        '
        'tpageModemSms
        '
        Me.tpageModemSms.Controls.Add(Me.rtb)
        Me.tpageModemSms.Controls.Add(Me.panelModemSms)
        Me.tpageModemSms.Location = New System.Drawing.Point(4, 25)
        Me.tpageModemSms.Name = "tpageModemSms"
        Me.tpageModemSms.Padding = New System.Windows.Forms.Padding(3)
        Me.tpageModemSms.Size = New System.Drawing.Size(937, 164)
        Me.tpageModemSms.TabIndex = 3
        Me.tpageModemSms.Text = "SMS DATA"
        Me.tpageModemSms.UseVisualStyleBackColor = True
        '
        'rtb
        '
        Me.rtb.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.rtb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb.Location = New System.Drawing.Point(3, 31)
        Me.rtb.Name = "rtb"
        Me.rtb.ReadOnly = True
        Me.rtb.Size = New System.Drawing.Size(931, 130)
        Me.rtb.TabIndex = 2
        Me.rtb.Text = ""
        '
        'panelModemSms
        '
        Me.panelModemSms.Controls.Add(Me.btnSendAtCommand)
        Me.panelModemSms.Controls.Add(Me.txtAtCommand)
        Me.panelModemSms.Controls.Add(Me.Label9)
        Me.panelModemSms.Controls.Add(Me.cboxAutoScroll)
        Me.panelModemSms.Controls.Add(Me.btnClearDgvModemSms)
        Me.panelModemSms.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelModemSms.Location = New System.Drawing.Point(3, 3)
        Me.panelModemSms.Name = "panelModemSms"
        Me.panelModemSms.Size = New System.Drawing.Size(931, 28)
        Me.panelModemSms.TabIndex = 1
        '
        'btnSendAtCommand
        '
        Me.btnSendAtCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendAtCommand.BackColor = System.Drawing.Color.Transparent
        Me.btnSendAtCommand.BackgroundImage = CType(resources.GetObject("btnSendAtCommand.BackgroundImage"), System.Drawing.Image)
        Me.btnSendAtCommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSendAtCommand.BackgroundOnClick = Nothing
        Me.btnSendAtCommand.BackgroundOnDisabled = Nothing
        Me.btnSendAtCommand.BackgroundOnHover = Nothing
        Me.btnSendAtCommand.BackgroundOnNormal = Nothing
        Me.btnSendAtCommand.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSendAtCommand.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnSendAtCommand.FlatAppearance.BorderSize = 0
        Me.btnSendAtCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSendAtCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSendAtCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendAtCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendAtCommand.Location = New System.Drawing.Point(853, 3)
        Me.btnSendAtCommand.Name = "btnSendAtCommand"
        Me.btnSendAtCommand.Size = New System.Drawing.Size(75, 23)
        Me.btnSendAtCommand.TabIndex = 4
        Me.btnSendAtCommand.Text = "Enviar"
        Me.btnSendAtCommand.UseVisualStyleBackColor = False
        Me.btnSendAtCommand.Visible = False
        '
        'txtAtCommand
        '
        Me.txtAtCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAtCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtCommand.HintText = "Hint Text"
        Me.txtAtCommand.HintTextColor = System.Drawing.Color.Gray
        Me.txtAtCommand.HintTextEnabled = False
        Me.txtAtCommand.Location = New System.Drawing.Point(587, 5)
        Me.txtAtCommand.Name = "txtAtCommand"
        Me.txtAtCommand.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtAtCommand.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtAtCommand.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtAtCommand.Size = New System.Drawing.Size(260, 20)
        Me.txtAtCommand.TabIndex = 3
        Me.txtAtCommand.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(462, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Enviar Comando AT"
        Me.Label9.Visible = False
        '
        'cboxAutoScroll
        '
        Me.cboxAutoScroll.AutoSize = True
        Me.cboxAutoScroll.Checked = True
        Me.cboxAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboxAutoScroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAutoScroll.Location = New System.Drawing.Point(84, 7)
        Me.cboxAutoScroll.Name = "cboxAutoScroll"
        Me.cboxAutoScroll.Size = New System.Drawing.Size(145, 17)
        Me.cboxAutoScroll.TabIndex = 1
        Me.cboxAutoScroll.Text = "Auto Desplazamiento"
        Me.cboxAutoScroll.UseVisualStyleBackColor = True
        '
        'btnClearDgvModemSms
        '
        Me.btnClearDgvModemSms.BackColor = System.Drawing.Color.Transparent
        Me.btnClearDgvModemSms.BackgroundImage = CType(resources.GetObject("btnClearDgvModemSms.BackgroundImage"), System.Drawing.Image)
        Me.btnClearDgvModemSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearDgvModemSms.BackgroundOnClick = CType(resources.GetObject("btnClearDgvModemSms.BackgroundOnClick"), System.Drawing.Image)
        Me.btnClearDgvModemSms.BackgroundOnDisabled = CType(resources.GetObject("btnClearDgvModemSms.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnClearDgvModemSms.BackgroundOnHover = CType(resources.GetObject("btnClearDgvModemSms.BackgroundOnHover"), System.Drawing.Image)
        Me.btnClearDgvModemSms.BackgroundOnNormal = CType(resources.GetObject("btnClearDgvModemSms.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnClearDgvModemSms.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnClearDgvModemSms.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnClearDgvModemSms.FlatAppearance.BorderSize = 0
        Me.btnClearDgvModemSms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClearDgvModemSms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClearDgvModemSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDgvModemSms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearDgvModemSms.Location = New System.Drawing.Point(3, 3)
        Me.btnClearDgvModemSms.Name = "btnClearDgvModemSms"
        Me.btnClearDgvModemSms.Size = New System.Drawing.Size(75, 23)
        Me.btnClearDgvModemSms.TabIndex = 0
        Me.btnClearDgvModemSms.Text = "Limpiar"
        Me.btnClearDgvModemSms.UseVisualStyleBackColor = False
        '
        'timerDateTime
        '
        Me.timerDateTime.Interval = 500
        '
        'timerCountdown
        '
        Me.timerCountdown.Interval = 1000
        '
        'cmenuOptions
        '
        Me.cmenuOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmenuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOptionAutoCenter, Me.menuOptionShowMapCenter, Me.menuOptionShowMapControls, Me.menuOptionShowClientsWindow, Me.menuOptionShowVehiclesWindow, Me.VentanaDeGeocercasToolStripMenuItem, Me.CapaDeEventosToolStripMenuItem, Me.VehículosEnMovimientoToolStripMenuItem, Me.menuOptionModemSms, Me.menuOptionDatabase, Me.menuOptionVoices, Me.ToolStripMenuItem1, Me.ServidorPrincipalToolStripMenuItem, Me.ToolStripSeparator1, Me.menuOptionSwitchUsers})
        Me.cmenuOptions.Name = "cmenuOptions"
        Me.cmenuOptions.Size = New System.Drawing.Size(220, 542)
        '
        'menuOptionAutoCenter
        '
        Me.menuOptionAutoCenter.Checked = True
        Me.menuOptionAutoCenter.CheckOnClick = True
        Me.menuOptionAutoCenter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuOptionAutoCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionAutoCenter.Name = "menuOptionAutoCenter"
        Me.menuOptionAutoCenter.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionAutoCenter.Text = "&Auto Centrar"
        '
        'menuOptionShowMapCenter
        '
        Me.menuOptionShowMapCenter.CheckOnClick = True
        Me.menuOptionShowMapCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionShowMapCenter.Name = "menuOptionShowMapCenter"
        Me.menuOptionShowMapCenter.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionShowMapCenter.Text = "Centro del &Mapa"
        '
        'menuOptionShowMapControls
        '
        Me.menuOptionShowMapControls.Checked = True
        Me.menuOptionShowMapControls.CheckOnClick = True
        Me.menuOptionShowMapControls.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuOptionShowMapControls.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionShowMapControls.Name = "menuOptionShowMapControls"
        Me.menuOptionShowMapControls.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionShowMapControls.Text = "&Controles del Mapa"
        '
        'menuOptionShowClientsWindow
        '
        Me.menuOptionShowClientsWindow.Checked = True
        Me.menuOptionShowClientsWindow.CheckOnClick = True
        Me.menuOptionShowClientsWindow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuOptionShowClientsWindow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionShowClientsWindow.Name = "menuOptionShowClientsWindow"
        Me.menuOptionShowClientsWindow.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionShowClientsWindow.Text = "&Ventana de Clientes"
        '
        'menuOptionShowVehiclesWindow
        '
        Me.menuOptionShowVehiclesWindow.Checked = True
        Me.menuOptionShowVehiclesWindow.CheckOnClick = True
        Me.menuOptionShowVehiclesWindow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuOptionShowVehiclesWindow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionShowVehiclesWindow.Name = "menuOptionShowVehiclesWindow"
        Me.menuOptionShowVehiclesWindow.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionShowVehiclesWindow.Text = "V&entana de Vehículos"
        '
        'VentanaDeGeocercasToolStripMenuItem
        '
        Me.VentanaDeGeocercasToolStripMenuItem.CheckOnClick = True
        Me.VentanaDeGeocercasToolStripMenuItem.Name = "VentanaDeGeocercasToolStripMenuItem"
        Me.VentanaDeGeocercasToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.VentanaDeGeocercasToolStripMenuItem.Text = "Ventana de Geocercas"
        '
        'CapaDeEventosToolStripMenuItem
        '
        Me.CapaDeEventosToolStripMenuItem.Checked = True
        Me.CapaDeEventosToolStripMenuItem.CheckOnClick = True
        Me.CapaDeEventosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CapaDeEventosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CapaDeEventosToolStripMenuItem.Name = "CapaDeEventosToolStripMenuItem"
        Me.CapaDeEventosToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.CapaDeEventosToolStripMenuItem.Text = "Capa &de Eventos"
        '
        'VehículosEnMovimientoToolStripMenuItem
        '
        Me.VehículosEnMovimientoToolStripMenuItem.CheckOnClick = True
        Me.VehículosEnMovimientoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VehículosEnMovimientoToolStripMenuItem.Name = "VehículosEnMovimientoToolStripMenuItem"
        Me.VehículosEnMovimientoToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.VehículosEnMovimientoToolStripMenuItem.Text = "Vehículos en Movimiento"
        Me.VehículosEnMovimientoToolStripMenuItem.Visible = False
        '
        'menuOptionModemSms
        '
        Me.menuOptionModemSms.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionModemSms.Name = "menuOptionModemSms"
        Me.menuOptionModemSms.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionModemSms.Text = "M&odem Sms"
        '
        'menuOptionDatabase
        '
        Me.menuOptionDatabase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionDatabase.Name = "menuOptionDatabase"
        Me.menuOptionDatabase.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionDatabase.Text = "&Base de Datos"
        '
        'menuOptionVoices
        '
        Me.menuOptionVoices.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rbtnOptionXimena, Me.rbtnOptionCarlos, Me.rbtnOptionCarmen, Me.rbtnOptionSoledad, Me.rbtnOptionJorge, Me.ToolStripSeparator2, Me.rbtnOptionNone})
        Me.menuOptionVoices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionVoices.Name = "menuOptionVoices"
        Me.menuOptionVoices.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionVoices.Text = "Voce&s"
        Me.menuOptionVoices.Visible = False
        '
        'rbtnOptionXimena
        '
        Me.rbtnOptionXimena.CheckOnClick = True
        Me.rbtnOptionXimena.Name = "rbtnOptionXimena"
        Me.rbtnOptionXimena.Size = New System.Drawing.Size(120, 22)
        Me.rbtnOptionXimena.Text = "Ximena"
        '
        'rbtnOptionCarlos
        '
        Me.rbtnOptionCarlos.CheckOnClick = True
        Me.rbtnOptionCarlos.Name = "rbtnOptionCarlos"
        Me.rbtnOptionCarlos.Size = New System.Drawing.Size(120, 22)
        Me.rbtnOptionCarlos.Text = "Carlos"
        '
        'rbtnOptionCarmen
        '
        Me.rbtnOptionCarmen.CheckOnClick = True
        Me.rbtnOptionCarmen.Name = "rbtnOptionCarmen"
        Me.rbtnOptionCarmen.Size = New System.Drawing.Size(120, 22)
        Me.rbtnOptionCarmen.Text = "Carmen"
        '
        'rbtnOptionSoledad
        '
        Me.rbtnOptionSoledad.CheckOnClick = True
        Me.rbtnOptionSoledad.Name = "rbtnOptionSoledad"
        Me.rbtnOptionSoledad.Size = New System.Drawing.Size(120, 22)
        Me.rbtnOptionSoledad.Text = "Soledad"
        '
        'rbtnOptionJorge
        '
        Me.rbtnOptionJorge.CheckOnClick = True
        Me.rbtnOptionJorge.Name = "rbtnOptionJorge"
        Me.rbtnOptionJorge.Size = New System.Drawing.Size(120, 22)
        Me.rbtnOptionJorge.Text = "Jorge"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(117, 6)
        '
        'rbtnOptionNone
        '
        Me.rbtnOptionNone.CheckOnClick = True
        Me.rbtnOptionNone.Name = "rbtnOptionNone"
        Me.rbtnOptionNone.Size = New System.Drawing.Size(120, 22)
        Me.rbtnOptionNone.Text = "Ninguno"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(219, 38)
        Me.ToolStripMenuItem1.Text = "Contraseña Admin"
        '
        'ServidorPrincipalToolStripMenuItem
        '
        Me.ServidorPrincipalToolStripMenuItem.Checked = True
        Me.ServidorPrincipalToolStripMenuItem.CheckOnClick = True
        Me.ServidorPrincipalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ServidorPrincipalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ServidorPrincipalToolStripMenuItem.Name = "ServidorPrincipalToolStripMenuItem"
        Me.ServidorPrincipalToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.ServidorPrincipalToolStripMenuItem.Text = "Servidor Principal"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(216, 6)
        '
        'menuOptionSwitchUsers
        '
        Me.menuOptionSwitchUsers.Image = Global.VillaTracking.My.Resources.Resources.change_user_icon
        Me.menuOptionSwitchUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptionSwitchUsers.Name = "menuOptionSwitchUsers"
        Me.menuOptionSwitchUsers.Size = New System.Drawing.Size(219, 38)
        Me.menuOptionSwitchUsers.Text = "Cambio de &Usuario"
        '
        'bgwGetClients
        '
        Me.bgwGetClients.WorkerReportsProgress = True
        Me.bgwGetClients.WorkerSupportsCancellation = True
        '
        'bgwGetCurrentLocations
        '
        Me.bgwGetCurrentLocations.WorkerReportsProgress = True
        Me.bgwGetCurrentLocations.WorkerSupportsCancellation = True
        '
        'bgwNoReportingVehicles
        '
        Me.bgwNoReportingVehicles.WorkerReportsProgress = True
        Me.bgwNoReportingVehicles.WorkerSupportsCancellation = True
        '
        'bgwGetEvents
        '
        Me.bgwGetEvents.WorkerReportsProgress = True
        Me.bgwGetEvents.WorkerSupportsCancellation = True
        '
        'bgwGeofences
        '
        Me.bgwGeofences.WorkerReportsProgress = True
        Me.bgwGeofences.WorkerSupportsCancellation = True
        '
        'serialModemSms
        '
        '
        'bgwModemSms
        '
        Me.bgwModemSms.WorkerReportsProgress = True
        Me.bgwModemSms.WorkerSupportsCancellation = True
        '
        'bgwSendEventsEmail
        '
        Me.bgwSendEventsEmail.WorkerReportsProgress = True
        Me.bgwSendEventsEmail.WorkerSupportsCancellation = True
        '
        'panelHeader
        '
        Me.panelHeader.Controls.Add(Me.pboxLogo)
        Me.panelHeader.Controls.Add(Me.menuMain)
        Me.panelHeader.Controls.Add(Me.panelInfo)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1197, 76)
        Me.panelHeader.TabIndex = 0
        '
        'pboxLogo
        '
        Me.pboxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pboxLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pboxLogo.Image = Global.VillaTracking.My.Resources.Resources.Logotipo_White
        Me.pboxLogo.Location = New System.Drawing.Point(992, 23)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(198, 55)
        Me.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLogo.TabIndex = 4
        Me.pboxLogo.TabStop = False
        '
        'menuMain
        '
        Me.menuMain.AutoSize = False
        Me.menuMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.menuMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.menuMain.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUsers, Me.menuDealers, Me.menuSimCards, Me.menuDevices, Me.menuClients, Me.menuTravelHistory, Me.menuEventHistory, Me.menuGeofence, Me.menuReports, Me.menuNoReporting, Me.menuOptions})
        Me.menuMain.Location = New System.Drawing.Point(0, 21)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(1197, 55)
        Me.menuMain.TabIndex = 2
        Me.menuMain.Text = "menuMain"
        '
        'menuUsers
        '
        Me.menuUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuUsers.ForeColor = System.Drawing.Color.White
        Me.menuUsers.Image = Global.VillaTracking.My.Resources.Resources.user_icon
        Me.menuUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuUsers.Name = "menuUsers"
        Me.menuUsers.Size = New System.Drawing.Size(76, 51)
        Me.menuUsers.Text = "&Usuarios"
        Me.menuUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuDealers
        '
        Me.menuDealers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuDealers.ForeColor = System.Drawing.Color.White
        Me.menuDealers.Image = Global.VillaTracking.My.Resources.Resources.dealer_icon
        Me.menuDealers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuDealers.Name = "menuDealers"
        Me.menuDealers.Size = New System.Drawing.Size(69, 51)
        Me.menuDealers.Text = "D&ealers"
        Me.menuDealers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuDealers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuSimCards
        '
        Me.menuSimCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuSimCards.ForeColor = System.Drawing.Color.White
        Me.menuSimCards.Image = Global.VillaTracking.My.Resources.Resources.simcard_icon
        Me.menuSimCards.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuSimCards.Name = "menuSimCards"
        Me.menuSimCards.Size = New System.Drawing.Size(85, 51)
        Me.menuSimCards.Text = "&Sim Cards"
        Me.menuSimCards.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuSimCards.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuDevices
        '
        Me.menuDevices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuDevices.ForeColor = System.Drawing.Color.White
        Me.menuDevices.Image = Global.VillaTracking.My.Resources.Resources.gps_icon
        Me.menuDevices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuDevices.Name = "menuDevices"
        Me.menuDevices.Size = New System.Drawing.Size(96, 51)
        Me.menuDevices.Text = "&Dispositivos"
        Me.menuDevices.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuClients
        '
        Me.menuClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuClients.ForeColor = System.Drawing.Color.White
        Me.menuClients.Image = Global.VillaTracking.My.Resources.Resources.costumer_icon
        Me.menuClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuClients.Name = "menuClients"
        Me.menuClients.Size = New System.Drawing.Size(71, 51)
        Me.menuClients.Text = "&Clientes"
        Me.menuClients.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuClients.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.menuClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuTravelHistory
        '
        Me.menuTravelHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuTravelHistory.ForeColor = System.Drawing.Color.White
        Me.menuTravelHistory.Image = Global.VillaTracking.My.Resources.Resources.travel_history_icon
        Me.menuTravelHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuTravelHistory.Name = "menuTravelHistory"
        Me.menuTravelHistory.Size = New System.Drawing.Size(82, 51)
        Me.menuTravelHistory.Text = "&Recorrido"
        Me.menuTravelHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuTravelHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuEventHistory
        '
        Me.menuEventHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuEventHistory.ForeColor = System.Drawing.Color.White
        Me.menuEventHistory.Image = Global.VillaTracking.My.Resources.Resources.event_history_icon
        Me.menuEventHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuEventHistory.Name = "menuEventHistory"
        Me.menuEventHistory.Size = New System.Drawing.Size(69, 51)
        Me.menuEventHistory.Text = "E&ventos"
        Me.menuEventHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuEventHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuGeofence
        '
        Me.menuGeofence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuGeofence.ForeColor = System.Drawing.Color.White
        Me.menuGeofence.Image = Global.VillaTracking.My.Resources.Resources.geofence_icon
        Me.menuGeofence.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuGeofence.Name = "menuGeofence"
        Me.menuGeofence.Size = New System.Drawing.Size(87, 51)
        Me.menuGeofence.Text = "&Geocercas"
        Me.menuGeofence.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuGeofence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuReports
        '
        Me.menuReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuReports.ForeColor = System.Drawing.Color.White
        Me.menuReports.Image = Global.VillaTracking.My.Resources.Resources.reports_icon
        Me.menuReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuReports.Name = "menuReports"
        Me.menuReports.Size = New System.Drawing.Size(75, 51)
        Me.menuReports.Text = "&Informes"
        Me.menuReports.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuNoReporting
        '
        Me.menuNoReporting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuNoReporting.ForeColor = System.Drawing.Color.White
        Me.menuNoReporting.Image = Global.VillaTracking.My.Resources.Resources.no_reporting_icon
        Me.menuNoReporting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuNoReporting.Name = "menuNoReporting"
        Me.menuNoReporting.Size = New System.Drawing.Size(100, 51)
        Me.menuNoReporting.Text = "Sin Reportar"
        Me.menuNoReporting.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuNoReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.menuNoReporting.Visible = False
        '
        'menuOptions
        '
        Me.menuOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuOptions.ForeColor = System.Drawing.Color.White
        Me.menuOptions.Image = Global.VillaTracking.My.Resources.Resources.settings_icon
        Me.menuOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuOptions.Name = "menuOptions"
        Me.menuOptions.Size = New System.Drawing.Size(79, 51)
        Me.menuOptions.Text = "&Opciones"
        Me.menuOptions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menuOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'panelInfo
        '
        Me.panelInfo.BackColor = System.Drawing.Color.Black
        Me.panelInfo.Controls.Add(Me.panelSignal)
        Me.panelInfo.Controls.Add(Me.btnMonitoring)
        Me.panelInfo.Controls.Add(Me.Label3)
        Me.panelInfo.Controls.Add(Me.lblDateTime)
        Me.panelInfo.Controls.Add(Me.Label2)
        Me.panelInfo.Controls.Add(Me.lblUser)
        Me.panelInfo.Controls.Add(Me.Label1)
        Me.panelInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelInfo.Location = New System.Drawing.Point(0, 0)
        Me.panelInfo.Name = "panelInfo"
        Me.panelInfo.Padding = New System.Windows.Forms.Padding(5, 2, 0, 0)
        Me.panelInfo.Size = New System.Drawing.Size(1197, 21)
        Me.panelInfo.TabIndex = 3
        '
        'panelSignal
        '
        Me.panelSignal.Controls.Add(Me.pbarModem)
        Me.panelSignal.Controls.Add(Me.cboxModem)
        Me.panelSignal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSignal.Location = New System.Drawing.Point(587, 2)
        Me.panelSignal.Name = "panelSignal"
        Me.panelSignal.Padding = New System.Windows.Forms.Padding(20, 1, 5, 2)
        Me.panelSignal.Size = New System.Drawing.Size(610, 19)
        Me.panelSignal.TabIndex = 6
        '
        'pbarModem
        '
        Me.pbarModem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbarModem.Location = New System.Drawing.Point(172, 1)
        Me.pbarModem.Maximum = 32
        Me.pbarModem.Name = "pbarModem"
        Me.pbarModem.Size = New System.Drawing.Size(433, 16)
        Me.pbarModem.TabIndex = 7
        '
        'cboxModem
        '
        Me.cboxModem.AutoSize = True
        Me.cboxModem.Checked = True
        Me.cboxModem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboxModem.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboxModem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxModem.ForeColor = System.Drawing.Color.Red
        Me.cboxModem.Location = New System.Drawing.Point(20, 1)
        Me.cboxModem.Name = "cboxModem"
        Me.cboxModem.Size = New System.Drawing.Size(152, 16)
        Me.cboxModem.TabIndex = 6
        Me.cboxModem.Text = "Módem Desconectado"
        Me.cboxModem.UseVisualStyleBackColor = True
        '
        'btnMonitoring
        '
        Me.btnMonitoring.BackColor = System.Drawing.Color.Transparent
        Me.btnMonitoring.BackgroundImage = CType(resources.GetObject("btnMonitoring.BackgroundImage"), System.Drawing.Image)
        Me.btnMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMonitoring.BackgroundOnClick = CType(resources.GetObject("btnMonitoring.BackgroundOnClick"), System.Drawing.Image)
        Me.btnMonitoring.BackgroundOnDisabled = CType(resources.GetObject("btnMonitoring.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnMonitoring.BackgroundOnHover = CType(resources.GetObject("btnMonitoring.BackgroundOnHover"), System.Drawing.Image)
        Me.btnMonitoring.BackgroundOnNormal = CType(resources.GetObject("btnMonitoring.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnMonitoring.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnMonitoring.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnMonitoring.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMonitoring.FlatAppearance.BorderSize = 0
        Me.btnMonitoring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonitoring.Location = New System.Drawing.Point(497, 2)
        Me.btnMonitoring.Name = "btnMonitoring"
        Me.btnMonitoring.Size = New System.Drawing.Size(90, 19)
        Me.btnMonitoring.TabIndex = 7
        Me.btnMonitoring.Text = "INACTIVO"
        Me.btnMonitoring.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(415, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(15, 2, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monitoreo:"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(276, 2)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.lblDateTime.Size = New System.Drawing.Size(139, 15)
        Me.lblDateTime.TabIndex = 3
        Me.lblDateTime.Text = "19/05/2017 12:00 a.m."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(174, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(15, 2, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha / Hora:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Black
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(63, 2)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.lblUser.Size = New System.Drawing.Size(111, 15)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "ADMINISTRADOR"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bgwTTS
        '
        Me.bgwTTS.WorkerReportsProgress = True
        Me.bgwTTS.WorkerSupportsCancellation = True
        '
        'bgwGprsEvents
        '
        Me.bgwGprsEvents.WorkerReportsProgress = True
        Me.bgwGprsEvents.WorkerSupportsCancellation = True
        '
        'bgwGprsReceiver
        '
        Me.bgwGprsReceiver.WorkerReportsProgress = True
        Me.bgwGprsReceiver.WorkerSupportsCancellation = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 553)
        Me.Controls.Add(Me.splitParent)
        Me.Controls.Add(Me.panelHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuMain
        Me.MinimumSize = New System.Drawing.Size(1213, 591)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Villa Tracking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.splitParent.Panel1.ResumeLayout(False)
        Me.splitParent.Panel2.ResumeLayout(False)
        CType(Me.splitParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitParent.ResumeLayout(False)
        Me.panelLoadingClients.ResumeLayout(False)
        Me.panelClientFilter.ResumeLayout(False)
        Me.panelClientFilter.PerformLayout()
        Me.panelClientCount.ResumeLayout(False)
        Me.panelClientCount.PerformLayout()
        Me.splitChild.Panel1.ResumeLayout(False)
        Me.splitChild.Panel1.PerformLayout()
        Me.splitChild.Panel2.ResumeLayout(False)
        CType(Me.splitChild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitChild.ResumeLayout(False)
        Me.ZuPanel1.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGeofencesVehicles.ResumeLayout(False)
        CType(Me.dgvGeofences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsole.ResumeLayout(False)
        Me.tpageVehicles.ResumeLayout(False)
        CType(Me.dgvConsoleVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpageEvents.ResumeLayout(False)
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpageGprsReceiver.ResumeLayout(False)
        CType(Me.dgvGprsReceiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpageModemSms.ResumeLayout(False)
        Me.panelModemSms.ResumeLayout(False)
        Me.panelModemSms.PerformLayout()
        Me.cmenuOptions.ResumeLayout(False)
        Me.panelHeader.ResumeLayout(False)
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.panelInfo.ResumeLayout(False)
        Me.panelInfo.PerformLayout()
        Me.panelSignal.ResumeLayout(False)
        Me.panelSignal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As ZUControls.ZUPanel
    Friend WithEvents splitParent As SplitContainer
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents menuClients As ToolStripMenuItem
    Friend WithEvents menuTravelHistory As ToolStripMenuItem
    Friend WithEvents menuOptions As ToolStripMenuItem
    Friend WithEvents panelInfo As ZUControls.ZUPanel
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents timerDateTime As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents timerCountdown As Timer
    Friend WithEvents tabConsole As TabControl
    Friend WithEvents tpageVehicles As TabPage
    Friend WithEvents tpageEvents As TabPage
    Friend WithEvents tpageGprsReceiver As TabPage
    Friend WithEvents panelLoadingClients As ZUControls.ZUPanel
    Friend WithEvents pbarStatusLoadingClients As ProgressBar
    Friend WithEvents lblStatusLoadingClients As Label
    Friend WithEvents panelClientCount As ZUControls.ZUPanel
    Friend WithEvents btnReload As Button
    Friend WithEvents lblVehiclesQuantity As Label
    Friend WithEvents lblClientsQuantity As Label
    Friend WithEvents cboDealers As ZUControls.ZUComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents splitChild As SplitContainer
    Friend WithEvents tbarMapZoom As XComponent.SliderBar.ZUTrackBar
    Friend WithEvents btnHybrid As ZUControls.ZUButton
    Friend WithEvents btnSatellite As ZUControls.ZUButton
    Friend WithEvents btnMap As ZUControls.ZUButton
    Friend WithEvents mapMain As ZUControls.ZUMapa
    Friend WithEvents cmenuOptions As ContextMenuStrip
    Friend WithEvents menuOptionAutoCenter As ToolStripMenuItem
    Friend WithEvents menuOptionShowMapCenter As ToolStripMenuItem
    Friend WithEvents menuOptionShowMapControls As ToolStripMenuItem
    Friend WithEvents menuOptionShowClientsWindow As ToolStripMenuItem
    Friend WithEvents menuOptionShowVehiclesWindow As ToolStripMenuItem
    Friend WithEvents menuSimCards As ToolStripMenuItem
    Friend WithEvents menuDevices As ToolStripMenuItem
    Friend WithEvents menuUsers As ToolStripMenuItem
    Friend WithEvents menuDealers As ToolStripMenuItem
    Friend WithEvents menuEventHistory As ToolStripMenuItem
    Friend WithEvents menuGeofence As ToolStripMenuItem
    Friend WithEvents menuReports As ToolStripMenuItem
    Friend WithEvents menuOptionModemSms As ToolStripMenuItem
    Friend WithEvents menuOptionVoices As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents menuOptionSwitchUsers As ToolStripMenuItem
    Friend WithEvents cboxModem As CheckBox
    Friend WithEvents panelSignal As ZUControls.ZUPanel
    Friend WithEvents pbarModem As ProgressBar
    Friend WithEvents rbtnOptionXimena As ToolStripRadioButtonMenuItem
    Friend WithEvents rbtnOptionCarlos As ToolStripRadioButtonMenuItem
    Friend WithEvents rbtnOptionCarmen As ToolStripRadioButtonMenuItem
    Friend WithEvents rbtnOptionSoledad As ToolStripRadioButtonMenuItem
    Friend WithEvents rbtnOptionJorge As ToolStripRadioButtonMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents rbtnOptionNone As ToolStripRadioButtonMenuItem
    Friend WithEvents bgwGetClients As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvConsoleVehicles As ZUControls.ZUDataGridView
    Friend WithEvents bgwGetCurrentLocations As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvEvents As ZUControls.ZUDataGridView
    'Public WithEvents dgvEvents As DataGridView
    Friend WithEvents dgvGprsReceiver As ZUControls.ZUDataGridView
    Friend WithEvents bgwNoReportingVehicles As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGetEvents As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGeofences As System.ComponentModel.BackgroundWorker
    Friend WithEvents tpageModemSms As TabPage
    Friend WithEvents panelModemSms As ZUControls.ZUPanel
    Friend WithEvents btnClearDgvModemSms As ZUControls.ZUButton
    Public WithEvents serialModemSms As IO.Ports.SerialPort
    Friend WithEvents bgwModemSms As System.ComponentModel.BackgroundWorker
    Friend WithEvents menuOptionDatabase As ToolStripMenuItem
    Friend WithEvents CapaDeEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rtb As RichTextBox
    Friend WithEvents cboxAutoScroll As CheckBox
    Friend WithEvents menuNoReporting As ToolStripMenuItem
    Friend WithEvents panelClientFilter As ZUControls.ZUPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtClientFilter As ZUControls.ZUTextBox
    Friend WithEvents tviewClients As ZUControls.ZUTreeView
    Friend WithEvents cboxExpandClients As CheckBox
    Friend WithEvents pboxLogo As PictureBox
    Friend WithEvents VehículosEnMovimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgwSendEventsEmail As System.ComponentModel.BackgroundWorker
    Friend WithEvents ServidorPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelGeofencesVehicles As ZUControls.ZUPanel
    Friend WithEvents dgvGeofences As DataGridView
    Friend WithEvents label8 As Label
    Friend WithEvents lblLicensePlate As Label
    Friend WithEvents dgvGeofences_on_map As DataGridViewCheckBoxColumn
    Friend WithEvents dgvGeofences_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_imei As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_geofence_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_vehicle_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_points As DataGridViewTextBoxColumn
    Friend WithEvents VentanaDeGeocercasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSendAtCommand As ZUControls.ZUButton
    Friend WithEvents txtAtCommand As ZUControls.ZUTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnMonitoring As ZUControls.ZUButton
    Friend WithEvents bgwTTS As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGprsEvents As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents bgwGprsReceiver As System.ComponentModel.BackgroundWorker
    Friend WithEvents ZuPanel1 As ZUControls.ZUPanel
    Friend WithEvents btnBgwGetClients As ZUControls.ZUButton
    Friend WithEvents btnBgwGprsReceiver As ZUControls.ZUButton
    Friend WithEvents btnBgwGetEvents As ZUControls.ZUButton
    Friend WithEvents btnBgwGetCurrentLocations As ZUControls.ZUButton
    Friend WithEvents num As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents dgvGprsReceiver_port As DataGridViewTextBoxColumn
    Friend WithEvents dgvGprsReceiver_device_model As DataGridViewTextBoxColumn
    Friend WithEvents dgvGprsReceiver_client As DataGridViewTextBoxColumn
    Friend WithEvents dgvGprsReceiver_date_time As DataGridViewTextBoxColumn
    Friend WithEvents dgvGprsReceiver_trace As DataGridViewTextBoxColumn
    Friend WithEvents dgvGprsReceiver_status As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_onMap As DataGridViewCheckBoxColumn
    Friend WithEvents dgvEvents_vehicle_code As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_client_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_imei As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_license_plate As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_date_time As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_validation As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_client_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_vehicle_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_report_type_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_geofence_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_geofence_points As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_latitude As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_longitude As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_speed As DataGridViewTextBoxColumn
    Friend WithEvents dgvEvents_orientation As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_onMap As DataGridViewCheckBoxColumn
    Friend WithEvents dgvVehicles_config As DataGridViewButtonColumn
    Friend WithEvents dgvVehicles_vehicle_code As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_device_model As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_imei As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_simcard As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_cliente_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_license_plate As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_brand As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_model As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_type As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_year As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_color As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_last_report As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_speed As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_origin As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_expiration_date As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_client_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_vehicle_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_device_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_device_model_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_sms_stop As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_sms_resume As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_gprs_stop As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_gprs_resume As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_call_pass As DataGridViewTextBoxColumn
End Class
