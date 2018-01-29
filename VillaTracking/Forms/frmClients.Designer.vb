<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClients))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnFLastTen = New ZUControls.ZUButton()
        Me.btnFSearch = New ZUControls.ZUButton()
        Me.dtpFRangeTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFRangeFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpFByYear = New ZUControls.ZUMonthPicker()
        Me.dtpFByMonth = New ZUControls.ZUMonthPicker()
        Me.cboFUser = New ZUControls.ZUComboBox()
        Me.cboFReportType = New ZUControls.ZUComboBox()
        Me.rbtnFByRange = New System.Windows.Forms.RadioButton()
        Me.dgvReports_transmitter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dgvReports_receiver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReports_report_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReports_report_type_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbtnFByYear = New System.Windows.Forms.RadioButton()
        Me.dgvReports_user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxSearchReports = New System.Windows.Forms.GroupBox()
        Me.rbtnFByMonth = New System.Windows.Forms.RadioButton()
        Me.rbtnFToday = New System.Windows.Forms.RadioButton()
        Me.cboxFUser = New System.Windows.Forms.CheckBox()
        Me.cboxFVehicle = New System.Windows.Forms.CheckBox()
        Me.cboxFReportType = New System.Windows.Forms.CheckBox()
        Me.rbtnSearchReports = New System.Windows.Forms.RadioButton()
        Me.cboFVehicle = New ZUControls.ZUComboBox()
        Me.dgvReports_communication_mode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReports_vehicle_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReports_user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSaveClient = New ZUControls.ZUButton()
        Me.btnDeleteClient = New ZUControls.ZUButton()
        Me.cboxClientStatus = New System.Windows.Forms.CheckBox()
        Me.btnCancelClient = New ZUControls.ZUButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.bgwSavingReports = New System.ComponentModel.BackgroundWorker()
        Me.panelHeaderPersonal = New ZUControls.ZUPanel()
        Me.txtDni = New ZUControls.ZUNumericBox()
        Me.rbtnDni = New System.Windows.Forms.RadioButton()
        Me.btnRegisterClient = New ZUControls.ZUButton()
        Me.btnEditClient = New ZUControls.ZUButton()
        Me.dgvReports_license_plate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelReports = New ZUControls.ZUPanel()
        Me.panelLoadingReports = New ZUControls.ZUPanel()
        Me.lblLoadingReports = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.dgvReports_date_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReports_report_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReports_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxInsertReport = New System.Windows.Forms.GroupBox()
        Me.cboxGeneralReport = New System.Windows.Forms.CheckBox()
        Me.btnMReceiverClient = New System.Windows.Forms.Button()
        Me.btnMReceiverUser = New System.Windows.Forms.Button()
        Me.btnMTransmitterClient = New System.Windows.Forms.Button()
        Me.btnMTransmitterUser = New System.Windows.Forms.Button()
        Me.btnMInsertReport = New ZUControls.ZUButton()
        Me.cboMValidation = New ZUControls.ZUComboBox()
        Me.numValidation = New System.Windows.Forms.NumericUpDown()
        Me.txtMDescription = New ZUControls.ZUTextBox()
        Me.txtMReceiver = New ZUControls.ZUTextBox()
        Me.txtMTransmitter = New ZUControls.ZUTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboMVehicle = New ZUControls.ZUComboBox()
        Me.cboCommunicationMode = New ZUControls.ZUComboBox()
        Me.cboMReportType = New ZUControls.ZUComboBox()
        Me.rbtnInsertReports = New System.Windows.Forms.RadioButton()
        Me.bgwGetClientById = New System.ComponentModel.BackgroundWorker()
        Me.bgwSavingClient = New System.ComponentModel.BackgroundWorker()
        Me.bgwDeletingClient = New System.ComponentModel.BackgroundWorker()
        Me.bgwSavingContacts = New System.ComponentModel.BackgroundWorker()
        Me.bgwDeletingContacts = New System.ComponentModel.BackgroundWorker()
        Me.bgwGetContacts = New System.ComponentModel.BackgroundWorker()
        Me.bgwGetDevices = New System.ComponentModel.BackgroundWorker()
        Me.ofdClientImage = New System.Windows.Forms.OpenFileDialog()
        Me.bgwGetDealers = New System.ComponentModel.BackgroundWorker()
        Me.bgwGetVehicles = New System.ComponentModel.BackgroundWorker()
        Me.bgwSavingVehicles = New System.ComponentModel.BackgroundWorker()
        Me.bgwDeletingVehicles = New System.ComponentModel.BackgroundWorker()
        Me.bgwFiller = New System.ComponentModel.BackgroundWorker()
        Me.bgwSearchingReports = New System.ComponentModel.BackgroundWorker()
        Me.pboxLoading = New System.Windows.Forms.PictureBox()
        Me.bgwGetClientByDni = New System.ComponentModel.BackgroundWorker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvVehicles_vehicle_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_dealer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboxVehicleStatus = New System.Windows.Forms.CheckBox()
        Me.btnCancelVehicle = New ZUControls.ZUButton()
        Me.btnDeleteVehicle = New ZUControls.ZUButton()
        Me.btnSaveVehicle = New ZUControls.ZUButton()
        Me.btnEditVehicle = New ZUControls.ZUButton()
        Me.btnNewVehicle = New ZUControls.ZUButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvVehicles_device_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpInstallationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDevice = New ZUControls.ZUComboBox()
        Me.cboDealer = New ZUControls.ZUComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSpeedLimit = New ZUControls.ZUNumericBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtYear = New ZUControls.ZUNumericBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvVehicles_observations = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabConsole = New System.Windows.Forms.TabControl()
        Me.tpageClient = New System.Windows.Forms.TabPage()
        Me.panelHeaderVehicles = New ZUControls.ZUPanel()
        Me.panelLoadingVehicles = New ZUControls.ZUPanel()
        Me.lblLoadingVehicles = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtVehicleObservations = New ZUControls.ZUTextBox()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.dgvVehicles_dealer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_imei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_license_plate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_speed_limit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_phone_pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_installation_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_expiration_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_priority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicles_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtModel = New ZUControls.ZUTextBox()
        Me.txtColor = New ZUControls.ZUTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCallPass = New ZUControls.ZUTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtType = New ZUControls.ZUTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBrand = New ZUControls.ZUTextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLicensePlate = New ZUControls.ZUTextBox()
        Me.panelHeaderContacts = New ZUControls.ZUPanel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnCancelContact = New ZUControls.ZUButton()
        Me.btnDeleteContact = New ZUControls.ZUButton()
        Me.btnSaveContact = New ZUControls.ZUButton()
        Me.btnEditContact = New ZUControls.ZUButton()
        Me.btnNewContact = New ZUControls.ZUButton()
        Me.txtContactObservations = New ZUControls.ZUTextBox()
        Me.txtContactName = New ZUControls.ZUTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContactPhoneNumber2 = New ZUControls.ZUNumericBox()
        Me.txtContactPhoneNumber1 = New ZUControls.ZUNumericBox()
        Me.txtContactDni = New ZUControls.ZUNumericBox()
        Me.panelLoadingContacts = New ZUControls.ZUPanel()
        Me.lblLoadingContacts = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvContacts = New System.Windows.Forms.DataGridView()
        Me.dgvContacts_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvContacts_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvContacts_phone_number1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvContacts_phone_number2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvContacts_observations = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvContacts_contact_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelCenterPersonal = New ZUControls.ZUPanel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEmail = New ZUControls.ZUTextBox()
        Me.txtObservations = New ZUControls.ZUTextBox()
        Me.txtAddress = New ZUControls.ZUTextBox()
        Me.txtLastName = New ZUControls.ZUTextBox()
        Me.txtPhoneNumber2 = New ZUControls.ZUNumericBox()
        Me.txtPhoneNumber1 = New ZUControls.ZUNumericBox()
        Me.txtFirstName = New ZUControls.ZUTextBox()
        Me.gboxSearchReports.SuspendLayout()
        Me.panelHeaderPersonal.SuspendLayout()
        Me.panelReports.SuspendLayout()
        Me.panelLoadingReports.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxInsertReport.SuspendLayout()
        CType(Me.numValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsole.SuspendLayout()
        Me.tpageClient.SuspendLayout()
        Me.panelHeaderVehicles.SuspendLayout()
        Me.panelLoadingVehicles.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelHeaderContacts.SuspendLayout()
        Me.panelLoadingContacts.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCenterPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("NewsGoth BT", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(90, 76)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 11)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Desde"
        '
        'btnFLastTen
        '
        Me.btnFLastTen.BackColor = System.Drawing.Color.Transparent
        Me.btnFLastTen.BackgroundImage = CType(resources.GetObject("btnFLastTen.BackgroundImage"), System.Drawing.Image)
        Me.btnFLastTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFLastTen.BackgroundOnClick = CType(resources.GetObject("btnFLastTen.BackgroundOnClick"), System.Drawing.Image)
        Me.btnFLastTen.BackgroundOnDisabled = CType(resources.GetObject("btnFLastTen.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnFLastTen.BackgroundOnHover = CType(resources.GetObject("btnFLastTen.BackgroundOnHover"), System.Drawing.Image)
        Me.btnFLastTen.BackgroundOnNormal = CType(resources.GetObject("btnFLastTen.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnFLastTen.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnFLastTen.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnFLastTen.FlatAppearance.BorderSize = 0
        Me.btnFLastTen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFLastTen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFLastTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFLastTen.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFLastTen.Location = New System.Drawing.Point(440, 69)
        Me.btnFLastTen.Name = "btnFLastTen"
        Me.btnFLastTen.Size = New System.Drawing.Size(75, 25)
        Me.btnFLastTen.TabIndex = 13
        Me.btnFLastTen.Text = "Últimos 10"
        Me.btnFLastTen.UseVisualStyleBackColor = False
        '
        'btnFSearch
        '
        Me.btnFSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnFSearch.BackgroundImage = CType(resources.GetObject("btnFSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnFSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFSearch.BackgroundOnClick = CType(resources.GetObject("btnFSearch.BackgroundOnClick"), System.Drawing.Image)
        Me.btnFSearch.BackgroundOnDisabled = CType(resources.GetObject("btnFSearch.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnFSearch.BackgroundOnHover = CType(resources.GetObject("btnFSearch.BackgroundOnHover"), System.Drawing.Image)
        Me.btnFSearch.BackgroundOnNormal = CType(resources.GetObject("btnFSearch.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnFSearch.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnFSearch.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnFSearch.FlatAppearance.BorderSize = 0
        Me.btnFSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFSearch.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFSearch.Location = New System.Drawing.Point(521, 69)
        Me.btnFSearch.Name = "btnFSearch"
        Me.btnFSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnFSearch.TabIndex = 14
        Me.btnFSearch.Text = "Buscar"
        Me.btnFSearch.UseVisualStyleBackColor = False
        '
        'dtpFRangeTo
        '
        Me.dtpFRangeTo.Enabled = False
        Me.dtpFRangeTo.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFRangeTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFRangeTo.Location = New System.Drawing.Point(288, 73)
        Me.dtpFRangeTo.Name = "dtpFRangeTo"
        Me.dtpFRangeTo.Size = New System.Drawing.Size(117, 21)
        Me.dtpFRangeTo.TabIndex = 12
        '
        'dtpFRangeFrom
        '
        Me.dtpFRangeFrom.Enabled = False
        Me.dtpFRangeFrom.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFRangeFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFRangeFrom.Location = New System.Drawing.Point(124, 73)
        Me.dtpFRangeFrom.Name = "dtpFRangeFrom"
        Me.dtpFRangeFrom.Size = New System.Drawing.Size(115, 21)
        Me.dtpFRangeFrom.TabIndex = 11
        '
        'dtpFByYear
        '
        Me.dtpFByYear.CustomFormat = "yyyy"
        Me.dtpFByYear.Enabled = False
        Me.dtpFByYear.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFByYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFByYear.Location = New System.Drawing.Point(543, 46)
        Me.dtpFByYear.MaxDate = New Date(2017, 5, 31, 15, 10, 41, 977)
        Me.dtpFByYear.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.dtpFByYear.Name = "dtpFByYear"
        Me.dtpFByYear.ShowUpDown = True
        Me.dtpFByYear.Size = New System.Drawing.Size(53, 21)
        Me.dtpFByYear.TabIndex = 9
        Me.dtpFByYear.Value = New Date(2017, 5, 1, 0, 0, 0, 0)
        '
        'dtpFByMonth
        '
        Me.dtpFByMonth.CustomFormat = "MMMM yyyy"
        Me.dtpFByMonth.Enabled = False
        Me.dtpFByMonth.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFByMonth.Location = New System.Drawing.Point(342, 46)
        Me.dtpFByMonth.MaxDate = New Date(2017, 5, 31, 15, 10, 41, 977)
        Me.dtpFByMonth.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.dtpFByMonth.Name = "dtpFByMonth"
        Me.dtpFByMonth.ShowUpDown = True
        Me.dtpFByMonth.Size = New System.Drawing.Size(120, 21)
        Me.dtpFByMonth.TabIndex = 7
        Me.dtpFByMonth.Value = New Date(2017, 5, 1, 0, 0, 0, 0)
        '
        'cboFUser
        '
        Me.cboFUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFUser.Enabled = False
        Me.cboFUser.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFUser.FormattingEnabled = True
        Me.cboFUser.HintText = "Hint Text"
        Me.cboFUser.HintTextColor = System.Drawing.Color.Gray
        Me.cboFUser.HintTextEnabled = False
        Me.cboFUser.Location = New System.Drawing.Point(385, 22)
        Me.cboFUser.Name = "cboFUser"
        Me.cboFUser.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboFUser.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboFUser.Size = New System.Drawing.Size(211, 22)
        Me.cboFUser.TabIndex = 4
        '
        'cboFReportType
        '
        Me.cboFReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFReportType.Enabled = False
        Me.cboFReportType.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFReportType.FormattingEnabled = True
        Me.cboFReportType.HintText = "Hint Text"
        Me.cboFReportType.HintTextColor = System.Drawing.Color.Gray
        Me.cboFReportType.HintTextEnabled = False
        Me.cboFReportType.Location = New System.Drawing.Point(102, 22)
        Me.cboFReportType.Name = "cboFReportType"
        Me.cboFReportType.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboFReportType.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboFReportType.Size = New System.Drawing.Size(199, 22)
        Me.cboFReportType.TabIndex = 2
        '
        'rbtnFByRange
        '
        Me.rbtnFByRange.AutoSize = True
        Me.rbtnFByRange.Location = New System.Drawing.Point(9, 74)
        Me.rbtnFByRange.Name = "rbtnFByRange"
        Me.rbtnFByRange.Size = New System.Drawing.Size(75, 18)
        Me.rbtnFByRange.TabIndex = 10
        Me.rbtnFByRange.Text = "Por Rango"
        Me.rbtnFByRange.UseVisualStyleBackColor = True
        '
        'dgvReports_transmitter
        '
        Me.dgvReports_transmitter.HeaderText = "EMISOR"
        Me.dgvReports_transmitter.Name = "dgvReports_transmitter"
        Me.dgvReports_transmitter.ReadOnly = True
        Me.dgvReports_transmitter.Visible = False
        Me.dgvReports_transmitter.Width = 80
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("NewsGoth BT", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(255, 76)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(28, 11)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Hasta"
        '
        'dgvReports_receiver
        '
        Me.dgvReports_receiver.HeaderText = "RECEPTOR"
        Me.dgvReports_receiver.Name = "dgvReports_receiver"
        Me.dgvReports_receiver.ReadOnly = True
        Me.dgvReports_receiver.Visible = False
        Me.dgvReports_receiver.Width = 99
        '
        'dgvReports_report_id
        '
        Me.dgvReports_report_id.HeaderText = "ID REPORTE"
        Me.dgvReports_report_id.Name = "dgvReports_report_id"
        Me.dgvReports_report_id.ReadOnly = True
        Me.dgvReports_report_id.Visible = False
        Me.dgvReports_report_id.Width = 108
        '
        'dgvReports_report_type_id
        '
        Me.dgvReports_report_type_id.HeaderText = "ID TIPO REPORTE"
        Me.dgvReports_report_type_id.Name = "dgvReports_report_type_id"
        Me.dgvReports_report_type_id.ReadOnly = True
        Me.dgvReports_report_type_id.Visible = False
        Me.dgvReports_report_type_id.Width = 141
        '
        'rbtnFByYear
        '
        Me.rbtnFByYear.AutoSize = True
        Me.rbtnFByYear.Location = New System.Drawing.Point(474, 48)
        Me.rbtnFByYear.Name = "rbtnFByYear"
        Me.rbtnFByYear.Size = New System.Drawing.Size(64, 18)
        Me.rbtnFByYear.TabIndex = 8
        Me.rbtnFByYear.Text = "Por Año"
        Me.rbtnFByYear.UseVisualStyleBackColor = True
        '
        'dgvReports_user_id
        '
        Me.dgvReports_user_id.HeaderText = "ID USUARIO"
        Me.dgvReports_user_id.Name = "dgvReports_user_id"
        Me.dgvReports_user_id.ReadOnly = True
        Me.dgvReports_user_id.Visible = False
        Me.dgvReports_user_id.Width = 105
        '
        'gboxSearchReports
        '
        Me.gboxSearchReports.Controls.Add(Me.Label33)
        Me.gboxSearchReports.Controls.Add(Me.Label32)
        Me.gboxSearchReports.Controls.Add(Me.btnFLastTen)
        Me.gboxSearchReports.Controls.Add(Me.btnFSearch)
        Me.gboxSearchReports.Controls.Add(Me.dtpFRangeTo)
        Me.gboxSearchReports.Controls.Add(Me.dtpFRangeFrom)
        Me.gboxSearchReports.Controls.Add(Me.dtpFByYear)
        Me.gboxSearchReports.Controls.Add(Me.dtpFByMonth)
        Me.gboxSearchReports.Controls.Add(Me.cboFUser)
        Me.gboxSearchReports.Controls.Add(Me.cboFReportType)
        Me.gboxSearchReports.Controls.Add(Me.rbtnFByRange)
        Me.gboxSearchReports.Controls.Add(Me.rbtnFByYear)
        Me.gboxSearchReports.Controls.Add(Me.rbtnFByMonth)
        Me.gboxSearchReports.Controls.Add(Me.rbtnFToday)
        Me.gboxSearchReports.Controls.Add(Me.cboxFUser)
        Me.gboxSearchReports.Controls.Add(Me.cboxFVehicle)
        Me.gboxSearchReports.Controls.Add(Me.cboxFReportType)
        Me.gboxSearchReports.Controls.Add(Me.rbtnSearchReports)
        Me.gboxSearchReports.Controls.Add(Me.cboFVehicle)
        Me.gboxSearchReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.gboxSearchReports.Enabled = False
        Me.gboxSearchReports.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxSearchReports.Location = New System.Drawing.Point(0, 149)
        Me.gboxSearchReports.Name = "gboxSearchReports"
        Me.gboxSearchReports.Size = New System.Drawing.Size(598, 99)
        Me.gboxSearchReports.TabIndex = 2
        Me.gboxSearchReports.TabStop = False
        '
        'rbtnFByMonth
        '
        Me.rbtnFByMonth.AutoSize = True
        Me.rbtnFByMonth.Location = New System.Drawing.Point(268, 48)
        Me.rbtnFByMonth.Name = "rbtnFByMonth"
        Me.rbtnFByMonth.Size = New System.Drawing.Size(64, 18)
        Me.rbtnFByMonth.TabIndex = 6
        Me.rbtnFByMonth.Text = "Por Mes"
        Me.rbtnFByMonth.UseVisualStyleBackColor = True
        '
        'rbtnFToday
        '
        Me.rbtnFToday.AutoSize = True
        Me.rbtnFToday.Checked = True
        Me.rbtnFToday.Location = New System.Drawing.Point(218, 48)
        Me.rbtnFToday.Name = "rbtnFToday"
        Me.rbtnFToday.Size = New System.Drawing.Size(44, 18)
        Me.rbtnFToday.TabIndex = 5
        Me.rbtnFToday.TabStop = True
        Me.rbtnFToday.Text = "Hoy"
        Me.rbtnFToday.UseVisualStyleBackColor = True
        '
        'cboxFUser
        '
        Me.cboxFUser.AutoSize = True
        Me.cboxFUser.Location = New System.Drawing.Point(315, 24)
        Me.cboxFUser.Name = "cboxFUser"
        Me.cboxFUser.Size = New System.Drawing.Size(64, 18)
        Me.cboxFUser.TabIndex = 3
        Me.cboxFUser.Text = "Usuario"
        Me.cboxFUser.UseVisualStyleBackColor = True
        '
        'cboxFVehicle
        '
        Me.cboxFVehicle.AutoSize = True
        Me.cboxFVehicle.Location = New System.Drawing.Point(9, 50)
        Me.cboxFVehicle.Name = "cboxFVehicle"
        Me.cboxFVehicle.Size = New System.Drawing.Size(67, 18)
        Me.cboxFVehicle.TabIndex = 1
        Me.cboxFVehicle.Text = "Vehículo"
        Me.cboxFVehicle.UseVisualStyleBackColor = True
        '
        'cboxFReportType
        '
        Me.cboxFReportType.AutoSize = True
        Me.cboxFReportType.Location = New System.Drawing.Point(9, 24)
        Me.cboxFReportType.Name = "cboxFReportType"
        Me.cboxFReportType.Size = New System.Drawing.Size(87, 18)
        Me.cboxFReportType.TabIndex = 1
        Me.cboxFReportType.Text = "Tipo Reporte"
        Me.cboxFReportType.UseVisualStyleBackColor = True
        '
        'rbtnSearchReports
        '
        Me.rbtnSearchReports.AutoSize = True
        Me.rbtnSearchReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtnSearchReports.Location = New System.Drawing.Point(5, 0)
        Me.rbtnSearchReports.Name = "rbtnSearchReports"
        Me.rbtnSearchReports.Size = New System.Drawing.Size(103, 18)
        Me.rbtnSearchReports.TabIndex = 0
        Me.rbtnSearchReports.Text = "Buscar Reportes"
        Me.rbtnSearchReports.UseVisualStyleBackColor = True
        '
        'cboFVehicle
        '
        Me.cboFVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFVehicle.Enabled = False
        Me.cboFVehicle.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFVehicle.FormattingEnabled = True
        Me.cboFVehicle.HintText = "Hint Text"
        Me.cboFVehicle.HintTextColor = System.Drawing.Color.Gray
        Me.cboFVehicle.HintTextEnabled = False
        Me.cboFVehicle.Location = New System.Drawing.Point(82, 47)
        Me.cboFVehicle.Name = "cboFVehicle"
        Me.cboFVehicle.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboFVehicle.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboFVehicle.Size = New System.Drawing.Size(127, 22)
        Me.cboFVehicle.TabIndex = 2
        '
        'dgvReports_communication_mode
        '
        Me.dgvReports_communication_mode.HeaderText = "MODO COMUNICACIÓN"
        Me.dgvReports_communication_mode.Name = "dgvReports_communication_mode"
        Me.dgvReports_communication_mode.ReadOnly = True
        Me.dgvReports_communication_mode.Visible = False
        Me.dgvReports_communication_mode.Width = 168
        '
        'dgvReports_vehicle_id
        '
        Me.dgvReports_vehicle_id.HeaderText = "ID VEHICULO"
        Me.dgvReports_vehicle_id.Name = "dgvReports_vehicle_id"
        Me.dgvReports_vehicle_id.ReadOnly = True
        Me.dgvReports_vehicle_id.Visible = False
        Me.dgvReports_vehicle_id.Width = 111
        '
        'dgvReports_user_name
        '
        Me.dgvReports_user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvReports_user_name.HeaderText = "USUARIO"
        Me.dgvReports_user_name.Name = "dgvReports_user_name"
        Me.dgvReports_user_name.ReadOnly = True
        Me.dgvReports_user_name.Width = 77
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.LightCoral
        Me.lblStatus.Location = New System.Drawing.Point(80, 170)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(500, 19)
        Me.lblStatus.TabIndex = 28
        '
        'btnSaveClient
        '
        Me.btnSaveClient.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveClient.BackgroundImage = CType(resources.GetObject("btnSaveClient.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveClient.BackgroundOnClick = CType(resources.GetObject("btnSaveClient.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSaveClient.BackgroundOnDisabled = CType(resources.GetObject("btnSaveClient.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSaveClient.BackgroundOnHover = CType(resources.GetObject("btnSaveClient.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSaveClient.BackgroundOnNormal = CType(resources.GetObject("btnSaveClient.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSaveClient.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSaveClient.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnSaveClient.Enabled = False
        Me.btnSaveClient.FlatAppearance.BorderSize = 0
        Me.btnSaveClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveClient.ForeColor = System.Drawing.Color.Black
        Me.btnSaveClient.Location = New System.Drawing.Point(586, 101)
        Me.btnSaveClient.Name = "btnSaveClient"
        Me.btnSaveClient.Size = New System.Drawing.Size(75, 29)
        Me.btnSaveClient.TabIndex = 10
        Me.btnSaveClient.Text = "Guardar"
        Me.btnSaveClient.UseVisualStyleBackColor = False
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteClient.BackgroundImage = CType(resources.GetObject("btnDeleteClient.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteClient.BackgroundOnClick = CType(resources.GetObject("btnDeleteClient.BackgroundOnClick"), System.Drawing.Image)
        Me.btnDeleteClient.BackgroundOnDisabled = CType(resources.GetObject("btnDeleteClient.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnDeleteClient.BackgroundOnHover = CType(resources.GetObject("btnDeleteClient.BackgroundOnHover"), System.Drawing.Image)
        Me.btnDeleteClient.BackgroundOnNormal = CType(resources.GetObject("btnDeleteClient.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnDeleteClient.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnDeleteClient.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnDeleteClient.Enabled = False
        Me.btnDeleteClient.FlatAppearance.BorderSize = 0
        Me.btnDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteClient.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteClient.Location = New System.Drawing.Point(586, 131)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(75, 29)
        Me.btnDeleteClient.TabIndex = 11
        Me.btnDeleteClient.Text = "Eliminar"
        Me.btnDeleteClient.UseVisualStyleBackColor = False
        '
        'cboxClientStatus
        '
        Me.cboxClientStatus.AutoSize = True
        Me.cboxClientStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cboxClientStatus.Enabled = False
        Me.cboxClientStatus.Location = New System.Drawing.Point(8, 171)
        Me.cboxClientStatus.Name = "cboxClientStatus"
        Me.cboxClientStatus.Size = New System.Drawing.Size(60, 18)
        Me.cboxClientStatus.TabIndex = 27
        Me.cboxClientStatus.Text = "Estado"
        Me.cboxClientStatus.UseVisualStyleBackColor = True
        '
        'btnCancelClient
        '
        Me.btnCancelClient.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelClient.BackgroundImage = CType(resources.GetObject("btnCancelClient.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelClient.BackgroundOnClick = CType(resources.GetObject("btnCancelClient.BackgroundOnClick"), System.Drawing.Image)
        Me.btnCancelClient.BackgroundOnDisabled = CType(resources.GetObject("btnCancelClient.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnCancelClient.BackgroundOnHover = CType(resources.GetObject("btnCancelClient.BackgroundOnHover"), System.Drawing.Image)
        Me.btnCancelClient.BackgroundOnNormal = CType(resources.GetObject("btnCancelClient.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnCancelClient.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnCancelClient.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnCancelClient.Enabled = False
        Me.btnCancelClient.FlatAppearance.BorderSize = 0
        Me.btnCancelClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelClient.ForeColor = System.Drawing.Color.Black
        Me.btnCancelClient.Location = New System.Drawing.Point(586, 163)
        Me.btnCancelClient.Name = "btnCancelClient"
        Me.btnCancelClient.Size = New System.Drawing.Size(75, 29)
        Me.btnCancelClient.TabIndex = 12
        Me.btnCancelClient.Text = "Cancelar"
        Me.btnCancelClient.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(325, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 14)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Teléfono 2"
        '
        'bgwSavingReports
        '
        Me.bgwSavingReports.WorkerReportsProgress = True
        Me.bgwSavingReports.WorkerSupportsCancellation = True
        '
        'panelHeaderPersonal
        '
        Me.panelHeaderPersonal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelHeaderPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelHeaderPersonal.Controls.Add(Me.txtDni)
        Me.panelHeaderPersonal.Controls.Add(Me.rbtnDni)
        Me.panelHeaderPersonal.Controls.Add(Me.btnRegisterClient)
        Me.panelHeaderPersonal.Controls.Add(Me.btnEditClient)
        Me.panelHeaderPersonal.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderPersonal.Location = New System.Drawing.Point(3, 3)
        Me.panelHeaderPersonal.Name = "panelHeaderPersonal"
        Me.panelHeaderPersonal.Size = New System.Drawing.Size(667, 30)
        Me.panelHeaderPersonal.TabIndex = 0
        '
        'txtDni
        '
        Me.txtDni.CaracterDecimal = False
        Me.txtDni.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.HintText = "Hint Text"
        Me.txtDni.HintTextColor = System.Drawing.Color.Gray
        Me.txtDni.HintTextEnabled = False
        Me.txtDni.Location = New System.Drawing.Point(86, 2)
        Me.txtDni.MaxLength = 10
        Me.txtDni.Name = "txtDni"
        Me.txtDni.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtDni.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtDni.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtDni.Size = New System.Drawing.Size(440, 21)
        Me.txtDni.TabIndex = 6
        '
        'rbtnDni
        '
        Me.rbtnDni.AutoSize = True
        Me.rbtnDni.Checked = True
        Me.rbtnDni.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDni.Location = New System.Drawing.Point(5, 4)
        Me.rbtnDni.Name = "rbtnDni"
        Me.rbtnDni.Size = New System.Drawing.Size(83, 18)
        Me.rbtnDni.TabIndex = 0
        Me.rbtnDni.TabStop = True
        Me.rbtnDni.Text = "Cédula o Rif"
        Me.rbtnDni.UseVisualStyleBackColor = True
        '
        'btnRegisterClient
        '
        Me.btnRegisterClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegisterClient.BackColor = System.Drawing.Color.Transparent
        Me.btnRegisterClient.BackgroundImage = CType(resources.GetObject("btnRegisterClient.BackgroundImage"), System.Drawing.Image)
        Me.btnRegisterClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegisterClient.BackgroundOnClick = CType(resources.GetObject("btnRegisterClient.BackgroundOnClick"), System.Drawing.Image)
        Me.btnRegisterClient.BackgroundOnDisabled = CType(resources.GetObject("btnRegisterClient.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnRegisterClient.BackgroundOnHover = CType(resources.GetObject("btnRegisterClient.BackgroundOnHover"), System.Drawing.Image)
        Me.btnRegisterClient.BackgroundOnNormal = CType(resources.GetObject("btnRegisterClient.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnRegisterClient.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnRegisterClient.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnRegisterClient.Enabled = False
        Me.btnRegisterClient.FlatAppearance.BorderSize = 0
        Me.btnRegisterClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegisterClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegisterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterClient.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnRegisterClient.Location = New System.Drawing.Point(532, 0)
        Me.btnRegisterClient.Name = "btnRegisterClient"
        Me.btnRegisterClient.Size = New System.Drawing.Size(62, 25)
        Me.btnRegisterClient.TabIndex = 4
        Me.btnRegisterClient.Text = "Registrar"
        Me.btnRegisterClient.UseVisualStyleBackColor = False
        '
        'btnEditClient
        '
        Me.btnEditClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditClient.BackColor = System.Drawing.Color.Transparent
        Me.btnEditClient.BackgroundImage = CType(resources.GetObject("btnEditClient.BackgroundImage"), System.Drawing.Image)
        Me.btnEditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditClient.BackgroundOnClick = CType(resources.GetObject("btnEditClient.BackgroundOnClick"), System.Drawing.Image)
        Me.btnEditClient.BackgroundOnDisabled = CType(resources.GetObject("btnEditClient.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnEditClient.BackgroundOnHover = CType(resources.GetObject("btnEditClient.BackgroundOnHover"), System.Drawing.Image)
        Me.btnEditClient.BackgroundOnNormal = CType(resources.GetObject("btnEditClient.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnEditClient.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnEditClient.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnEditClient.Enabled = False
        Me.btnEditClient.FlatAppearance.BorderSize = 0
        Me.btnEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditClient.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnEditClient.Location = New System.Drawing.Point(599, 0)
        Me.btnEditClient.Name = "btnEditClient"
        Me.btnEditClient.Size = New System.Drawing.Size(62, 25)
        Me.btnEditClient.TabIndex = 5
        Me.btnEditClient.Text = "Modificar"
        Me.btnEditClient.UseVisualStyleBackColor = False
        '
        'dgvReports_license_plate
        '
        Me.dgvReports_license_plate.HeaderText = "VEHÍCULO"
        Me.dgvReports_license_plate.Name = "dgvReports_license_plate"
        Me.dgvReports_license_plate.ReadOnly = True
        Me.dgvReports_license_plate.Width = 94
        '
        'panelReports
        '
        Me.panelReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelReports.Controls.Add(Me.panelLoadingReports)
        Me.panelReports.Controls.Add(Me.dgvReports)
        Me.panelReports.Controls.Add(Me.gboxSearchReports)
        Me.panelReports.Controls.Add(Me.gboxInsertReport)
        Me.panelReports.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelReports.Location = New System.Drawing.Point(670, 3)
        Me.panelReports.Name = "panelReports"
        Me.panelReports.Size = New System.Drawing.Size(602, 794)
        Me.panelReports.TabIndex = 15
        '
        'panelLoadingReports
        '
        Me.panelLoadingReports.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelLoadingReports.Controls.Add(Me.lblLoadingReports)
        Me.panelLoadingReports.Controls.Add(Me.PictureBox3)
        Me.panelLoadingReports.Location = New System.Drawing.Point(4, 768)
        Me.panelLoadingReports.Name = "panelLoadingReports"
        Me.panelLoadingReports.Size = New System.Drawing.Size(595, 22)
        Me.panelLoadingReports.TabIndex = 20
        Me.panelLoadingReports.Visible = False
        '
        'lblLoadingReports
        '
        Me.lblLoadingReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoadingReports.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblLoadingReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLoadingReports.Location = New System.Drawing.Point(0, 0)
        Me.lblLoadingReports.Name = "lblLoadingReports"
        Me.lblLoadingReports.Size = New System.Drawing.Size(565, 22)
        Me.lblLoadingReports.TabIndex = 16
        Me.lblLoadingReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.VillaTracking.My.Resources.Resources.loading
        Me.PictureBox3.Location = New System.Drawing.Point(565, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'dgvReports
        '
        Me.dgvReports.AllowUserToAddRows = False
        Me.dgvReports.AllowUserToDeleteRows = False
        Me.dgvReports.AllowUserToResizeColumns = False
        Me.dgvReports.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        Me.dgvReports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReports.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvReports_date_time, Me.dgvReports_report_name, Me.dgvReports_description, Me.dgvReports_license_plate, Me.dgvReports_user_name, Me.dgvReports_communication_mode, Me.dgvReports_transmitter, Me.dgvReports_receiver, Me.dgvReports_report_id, Me.dgvReports_report_type_id, Me.dgvReports_vehicle_id, Me.dgvReports_user_id})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReports.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReports.EnableHeadersVisualStyles = False
        Me.dgvReports.GridColor = System.Drawing.SystemColors.Control
        Me.dgvReports.Location = New System.Drawing.Point(0, 248)
        Me.dgvReports.MultiSelect = False
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.ReadOnly = True
        Me.dgvReports.RowHeadersVisible = False
        Me.dgvReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReports.Size = New System.Drawing.Size(598, 542)
        Me.dgvReports.TabIndex = 3
        '
        'dgvReports_date_time
        '
        Me.dgvReports_date_time.HeaderText = "FECHA"
        Me.dgvReports_date_time.Name = "dgvReports_date_time"
        Me.dgvReports_date_time.ReadOnly = True
        '
        'dgvReports_report_name
        '
        Me.dgvReports_report_name.HeaderText = "TIPO REPORTE"
        Me.dgvReports_report_name.Name = "dgvReports_report_name"
        Me.dgvReports_report_name.ReadOnly = True
        Me.dgvReports_report_name.Width = 125
        '
        'dgvReports_description
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReports_description.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReports_description.HeaderText = "DESCRIPCIÓN"
        Me.dgvReports_description.Name = "dgvReports_description"
        Me.dgvReports_description.ReadOnly = True
        Me.dgvReports_description.Width = 275
        '
        'gboxInsertReport
        '
        Me.gboxInsertReport.Controls.Add(Me.cboxGeneralReport)
        Me.gboxInsertReport.Controls.Add(Me.btnMReceiverClient)
        Me.gboxInsertReport.Controls.Add(Me.btnMReceiverUser)
        Me.gboxInsertReport.Controls.Add(Me.btnMTransmitterClient)
        Me.gboxInsertReport.Controls.Add(Me.btnMTransmitterUser)
        Me.gboxInsertReport.Controls.Add(Me.btnMInsertReport)
        Me.gboxInsertReport.Controls.Add(Me.cboMValidation)
        Me.gboxInsertReport.Controls.Add(Me.numValidation)
        Me.gboxInsertReport.Controls.Add(Me.txtMDescription)
        Me.gboxInsertReport.Controls.Add(Me.txtMReceiver)
        Me.gboxInsertReport.Controls.Add(Me.txtMTransmitter)
        Me.gboxInsertReport.Controls.Add(Me.Label27)
        Me.gboxInsertReport.Controls.Add(Me.Label26)
        Me.gboxInsertReport.Controls.Add(Me.Label29)
        Me.gboxInsertReport.Controls.Add(Me.Label31)
        Me.gboxInsertReport.Controls.Add(Me.Label30)
        Me.gboxInsertReport.Controls.Add(Me.Label28)
        Me.gboxInsertReport.Controls.Add(Me.Label25)
        Me.gboxInsertReport.Controls.Add(Me.cboMVehicle)
        Me.gboxInsertReport.Controls.Add(Me.cboCommunicationMode)
        Me.gboxInsertReport.Controls.Add(Me.cboMReportType)
        Me.gboxInsertReport.Controls.Add(Me.rbtnInsertReports)
        Me.gboxInsertReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.gboxInsertReport.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxInsertReport.Location = New System.Drawing.Point(0, 0)
        Me.gboxInsertReport.Name = "gboxInsertReport"
        Me.gboxInsertReport.Size = New System.Drawing.Size(598, 149)
        Me.gboxInsertReport.TabIndex = 1
        Me.gboxInsertReport.TabStop = False
        '
        'cboxGeneralReport
        '
        Me.cboxGeneralReport.AutoSize = True
        Me.cboxGeneralReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cboxGeneralReport.ForeColor = System.Drawing.Color.Black
        Me.cboxGeneralReport.Location = New System.Drawing.Point(494, 22)
        Me.cboxGeneralReport.Name = "cboxGeneralReport"
        Me.cboxGeneralReport.Size = New System.Drawing.Size(102, 18)
        Me.cboxGeneralReport.TabIndex = 3
        Me.cboxGeneralReport.Text = "Reporte General"
        Me.cboxGeneralReport.UseVisualStyleBackColor = True
        '
        'btnMReceiverClient
        '
        Me.btnMReceiverClient.BackgroundImage = Global.VillaTracking.My.Resources.Resources.costumer_icon
        Me.btnMReceiverClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMReceiverClient.FlatAppearance.BorderSize = 0
        Me.btnMReceiverClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMReceiverClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMReceiverClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMReceiverClient.Location = New System.Drawing.Point(379, 69)
        Me.btnMReceiverClient.Name = "btnMReceiverClient"
        Me.btnMReceiverClient.Size = New System.Drawing.Size(20, 22)
        Me.btnMReceiverClient.TabIndex = 11
        Me.btnMReceiverClient.UseVisualStyleBackColor = True
        '
        'btnMReceiverUser
        '
        Me.btnMReceiverUser.BackgroundImage = Global.VillaTracking.My.Resources.Resources.user_icon
        Me.btnMReceiverUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMReceiverUser.FlatAppearance.BorderSize = 0
        Me.btnMReceiverUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMReceiverUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMReceiverUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMReceiverUser.Location = New System.Drawing.Point(353, 69)
        Me.btnMReceiverUser.Name = "btnMReceiverUser"
        Me.btnMReceiverUser.Size = New System.Drawing.Size(20, 22)
        Me.btnMReceiverUser.TabIndex = 10
        Me.btnMReceiverUser.UseVisualStyleBackColor = True
        '
        'btnMTransmitterClient
        '
        Me.btnMTransmitterClient.BackgroundImage = Global.VillaTracking.My.Resources.Resources.costumer_icon
        Me.btnMTransmitterClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMTransmitterClient.FlatAppearance.BorderSize = 0
        Me.btnMTransmitterClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMTransmitterClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMTransmitterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMTransmitterClient.Location = New System.Drawing.Point(80, 69)
        Me.btnMTransmitterClient.Name = "btnMTransmitterClient"
        Me.btnMTransmitterClient.Size = New System.Drawing.Size(20, 22)
        Me.btnMTransmitterClient.TabIndex = 8
        Me.btnMTransmitterClient.UseVisualStyleBackColor = True
        '
        'btnMTransmitterUser
        '
        Me.btnMTransmitterUser.BackgroundImage = Global.VillaTracking.My.Resources.Resources.user_icon
        Me.btnMTransmitterUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMTransmitterUser.FlatAppearance.BorderSize = 0
        Me.btnMTransmitterUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMTransmitterUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMTransmitterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMTransmitterUser.Location = New System.Drawing.Point(54, 69)
        Me.btnMTransmitterUser.Name = "btnMTransmitterUser"
        Me.btnMTransmitterUser.Size = New System.Drawing.Size(20, 22)
        Me.btnMTransmitterUser.TabIndex = 7
        Me.btnMTransmitterUser.UseVisualStyleBackColor = True
        '
        'btnMInsertReport
        '
        Me.btnMInsertReport.BackColor = System.Drawing.Color.Transparent
        Me.btnMInsertReport.BackgroundImage = CType(resources.GetObject("btnMInsertReport.BackgroundImage"), System.Drawing.Image)
        Me.btnMInsertReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMInsertReport.BackgroundOnClick = CType(resources.GetObject("btnMInsertReport.BackgroundOnClick"), System.Drawing.Image)
        Me.btnMInsertReport.BackgroundOnDisabled = CType(resources.GetObject("btnMInsertReport.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnMInsertReport.BackgroundOnHover = CType(resources.GetObject("btnMInsertReport.BackgroundOnHover"), System.Drawing.Image)
        Me.btnMInsertReport.BackgroundOnNormal = CType(resources.GetObject("btnMInsertReport.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnMInsertReport.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnMInsertReport.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnMInsertReport.FlatAppearance.BorderSize = 0
        Me.btnMInsertReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMInsertReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMInsertReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMInsertReport.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMInsertReport.Location = New System.Drawing.Point(518, 94)
        Me.btnMInsertReport.Name = "btnMInsertReport"
        Me.btnMInsertReport.Size = New System.Drawing.Size(78, 50)
        Me.btnMInsertReport.TabIndex = 14
        Me.btnMInsertReport.Text = "Ingresar Reporte"
        Me.btnMInsertReport.UseVisualStyleBackColor = False
        '
        'cboMValidation
        '
        Me.cboMValidation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMValidation.Enabled = False
        Me.cboMValidation.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMValidation.FormattingEnabled = True
        Me.cboMValidation.HintText = "Hint Text"
        Me.cboMValidation.HintTextColor = System.Drawing.Color.Gray
        Me.cboMValidation.HintTextEnabled = False
        Me.cboMValidation.Items.AddRange(New Object() {"MINUTO (S)", "HORA (S)", "DÍA (S)", "MES (ES)", "AÑO (S)"})
        Me.cboMValidation.Location = New System.Drawing.Point(486, 44)
        Me.cboMValidation.Name = "cboMValidation"
        Me.cboMValidation.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboMValidation.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboMValidation.Size = New System.Drawing.Size(110, 22)
        Me.cboMValidation.TabIndex = 6
        '
        'numValidation
        '
        Me.numValidation.Enabled = False
        Me.numValidation.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numValidation.Location = New System.Drawing.Point(423, 45)
        Me.numValidation.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numValidation.Name = "numValidation"
        Me.numValidation.Size = New System.Drawing.Size(57, 21)
        Me.numValidation.TabIndex = 5
        '
        'txtMDescription
        '
        Me.txtMDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMDescription.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMDescription.HintText = "Hint Text"
        Me.txtMDescription.HintTextColor = System.Drawing.Color.Gray
        Me.txtMDescription.HintTextEnabled = False
        Me.txtMDescription.Location = New System.Drawing.Point(76, 94)
        Me.txtMDescription.Multiline = True
        Me.txtMDescription.Name = "txtMDescription"
        Me.txtMDescription.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtMDescription.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtMDescription.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtMDescription.Size = New System.Drawing.Size(436, 49)
        Me.txtMDescription.TabIndex = 13
        '
        'txtMReceiver
        '
        Me.txtMReceiver.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtMReceiver.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMReceiver.HintText = "Hint Text"
        Me.txtMReceiver.HintTextColor = System.Drawing.Color.Gray
        Me.txtMReceiver.HintTextEnabled = False
        Me.txtMReceiver.Location = New System.Drawing.Point(405, 70)
        Me.txtMReceiver.Name = "txtMReceiver"
        Me.txtMReceiver.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtMReceiver.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtMReceiver.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtMReceiver.Size = New System.Drawing.Size(191, 21)
        Me.txtMReceiver.TabIndex = 12
        '
        'txtMTransmitter
        '
        Me.txtMTransmitter.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtMTransmitter.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTransmitter.HintText = "Hint Text"
        Me.txtMTransmitter.HintTextColor = System.Drawing.Color.Gray
        Me.txtMTransmitter.HintTextEnabled = False
        Me.txtMTransmitter.Location = New System.Drawing.Point(106, 70)
        Me.txtMTransmitter.Name = "txtMTransmitter"
        Me.txtMTransmitter.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtMTransmitter.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtMTransmitter.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtMTransmitter.Size = New System.Drawing.Size(195, 21)
        Me.txtMTransmitter.TabIndex = 9
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 14)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Tipo Reporte"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(105, 14)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Modo Comunicación"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(307, 73)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 14)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "Recibe"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(355, 47)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 14)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Válido Por:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 97)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 14)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Descripción"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 73)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 14)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Remite"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(304, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 14)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Vehículo"
        '
        'cboMVehicle
        '
        Me.cboMVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMVehicle.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMVehicle.FormattingEnabled = True
        Me.cboMVehicle.HintText = "Hint Text"
        Me.cboMVehicle.HintTextColor = System.Drawing.Color.Gray
        Me.cboMVehicle.HintTextEnabled = False
        Me.cboMVehicle.Location = New System.Drawing.Point(358, 19)
        Me.cboMVehicle.Name = "cboMVehicle"
        Me.cboMVehicle.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboMVehicle.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboMVehicle.Size = New System.Drawing.Size(126, 22)
        Me.cboMVehicle.TabIndex = 2
        '
        'cboCommunicationMode
        '
        Me.cboCommunicationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommunicationMode.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCommunicationMode.FormattingEnabled = True
        Me.cboCommunicationMode.HintText = "Hint Text"
        Me.cboCommunicationMode.HintTextColor = System.Drawing.Color.Gray
        Me.cboCommunicationMode.HintTextEnabled = False
        Me.cboCommunicationMode.Items.AddRange(New Object() {"LLAMADA", "SMS", "EMAIL", "PRESENCIAL", "SIN COMUNICACIÓN"})
        Me.cboCommunicationMode.Location = New System.Drawing.Point(118, 44)
        Me.cboCommunicationMode.Name = "cboCommunicationMode"
        Me.cboCommunicationMode.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboCommunicationMode.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboCommunicationMode.Size = New System.Drawing.Size(231, 22)
        Me.cboCommunicationMode.TabIndex = 4
        '
        'cboMReportType
        '
        Me.cboMReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMReportType.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMReportType.FormattingEnabled = True
        Me.cboMReportType.HintText = "Hint Text"
        Me.cboMReportType.HintTextColor = System.Drawing.Color.Gray
        Me.cboMReportType.HintTextEnabled = False
        Me.cboMReportType.Location = New System.Drawing.Point(81, 19)
        Me.cboMReportType.Name = "cboMReportType"
        Me.cboMReportType.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboMReportType.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboMReportType.Size = New System.Drawing.Size(214, 22)
        Me.cboMReportType.TabIndex = 1
        '
        'rbtnInsertReports
        '
        Me.rbtnInsertReports.AutoSize = True
        Me.rbtnInsertReports.Checked = True
        Me.rbtnInsertReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtnInsertReports.Location = New System.Drawing.Point(5, -1)
        Me.rbtnInsertReports.Name = "rbtnInsertReports"
        Me.rbtnInsertReports.Size = New System.Drawing.Size(104, 18)
        Me.rbtnInsertReports.TabIndex = 0
        Me.rbtnInsertReports.TabStop = True
        Me.rbtnInsertReports.Text = "Ingresar Reporte"
        Me.rbtnInsertReports.UseVisualStyleBackColor = True
        '
        'bgwGetClientById
        '
        Me.bgwGetClientById.WorkerReportsProgress = True
        Me.bgwGetClientById.WorkerSupportsCancellation = True
        '
        'bgwSavingClient
        '
        Me.bgwSavingClient.WorkerReportsProgress = True
        Me.bgwSavingClient.WorkerSupportsCancellation = True
        '
        'bgwDeletingClient
        '
        Me.bgwDeletingClient.WorkerReportsProgress = True
        Me.bgwDeletingClient.WorkerSupportsCancellation = True
        '
        'bgwSavingContacts
        '
        Me.bgwSavingContacts.WorkerReportsProgress = True
        Me.bgwSavingContacts.WorkerSupportsCancellation = True
        '
        'bgwDeletingContacts
        '
        Me.bgwDeletingContacts.WorkerReportsProgress = True
        Me.bgwDeletingContacts.WorkerSupportsCancellation = True
        '
        'bgwGetContacts
        '
        Me.bgwGetContacts.WorkerReportsProgress = True
        Me.bgwGetContacts.WorkerSupportsCancellation = True
        '
        'bgwGetDevices
        '
        Me.bgwGetDevices.WorkerReportsProgress = True
        Me.bgwGetDevices.WorkerSupportsCancellation = True
        '
        'ofdClientImage
        '
        Me.ofdClientImage.Title = "Seleccionar Imagen del Cliente"
        '
        'bgwGetDealers
        '
        Me.bgwGetDealers.WorkerReportsProgress = True
        Me.bgwGetDealers.WorkerSupportsCancellation = True
        '
        'bgwGetVehicles
        '
        Me.bgwGetVehicles.WorkerReportsProgress = True
        Me.bgwGetVehicles.WorkerSupportsCancellation = True
        '
        'bgwSavingVehicles
        '
        Me.bgwSavingVehicles.WorkerReportsProgress = True
        Me.bgwSavingVehicles.WorkerSupportsCancellation = True
        '
        'bgwDeletingVehicles
        '
        Me.bgwDeletingVehicles.WorkerReportsProgress = True
        Me.bgwDeletingVehicles.WorkerSupportsCancellation = True
        '
        'bgwFiller
        '
        Me.bgwFiller.WorkerReportsProgress = True
        Me.bgwFiller.WorkerSupportsCancellation = True
        '
        'bgwSearchingReports
        '
        Me.bgwSearchingReports.WorkerReportsProgress = True
        Me.bgwSearchingReports.WorkerSupportsCancellation = True
        '
        'pboxLoading
        '
        Me.pboxLoading.BackColor = System.Drawing.Color.White
        Me.pboxLoading.Location = New System.Drawing.Point(328, 122)
        Me.pboxLoading.Name = "pboxLoading"
        Me.pboxLoading.Size = New System.Drawing.Size(30, 25)
        Me.pboxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLoading.TabIndex = 13
        Me.pboxLoading.TabStop = False
        Me.pboxLoading.Visible = False
        '
        'bgwGetClientByDni
        '
        Me.bgwGetClientByDni.WorkerReportsProgress = True
        Me.bgwGetClientByDni.WorkerSupportsCancellation = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 14)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Observaciones"
        '
        'dgvVehicles_vehicle_id
        '
        Me.dgvVehicles_vehicle_id.HeaderText = "ID VEHICULO"
        Me.dgvVehicles_vehicle_id.Name = "dgvVehicles_vehicle_id"
        Me.dgvVehicles_vehicle_id.ReadOnly = True
        Me.dgvVehicles_vehicle_id.Visible = False
        Me.dgvVehicles_vehicle_id.Width = 111
        '
        'dgvVehicles_dealer_id
        '
        Me.dgvVehicles_dealer_id.HeaderText = "ID DEALER"
        Me.dgvVehicles_dealer_id.Name = "dgvVehicles_dealer_id"
        Me.dgvVehicles_dealer_id.ReadOnly = True
        Me.dgvVehicles_dealer_id.Visible = False
        Me.dgvVehicles_dealer_id.Width = 98
        '
        'cboxVehicleStatus
        '
        Me.cboxVehicleStatus.AutoSize = True
        Me.cboxVehicleStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cboxVehicleStatus.Enabled = False
        Me.cboxVehicleStatus.Location = New System.Drawing.Point(599, 102)
        Me.cboxVehicleStatus.Name = "cboxVehicleStatus"
        Me.cboxVehicleStatus.Size = New System.Drawing.Size(60, 18)
        Me.cboxVehicleStatus.TabIndex = 10
        Me.cboxVehicleStatus.Text = "Estado"
        Me.cboxVehicleStatus.UseVisualStyleBackColor = True
        '
        'btnCancelVehicle
        '
        Me.btnCancelVehicle.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelVehicle.BackgroundImage = CType(resources.GetObject("btnCancelVehicle.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelVehicle.BackgroundOnClick = CType(resources.GetObject("btnCancelVehicle.BackgroundOnClick"), System.Drawing.Image)
        Me.btnCancelVehicle.BackgroundOnDisabled = CType(resources.GetObject("btnCancelVehicle.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnCancelVehicle.BackgroundOnHover = CType(resources.GetObject("btnCancelVehicle.BackgroundOnHover"), System.Drawing.Image)
        Me.btnCancelVehicle.BackgroundOnNormal = CType(resources.GetObject("btnCancelVehicle.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnCancelVehicle.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnCancelVehicle.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnCancelVehicle.Enabled = False
        Me.btnCancelVehicle.FlatAppearance.BorderSize = 0
        Me.btnCancelVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelVehicle.Location = New System.Drawing.Point(488, 152)
        Me.btnCancelVehicle.Name = "btnCancelVehicle"
        Me.btnCancelVehicle.Size = New System.Drawing.Size(75, 25)
        Me.btnCancelVehicle.TabIndex = 20
        Me.btnCancelVehicle.Text = "Cancelar"
        Me.btnCancelVehicle.UseVisualStyleBackColor = False
        '
        'btnDeleteVehicle
        '
        Me.btnDeleteVehicle.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteVehicle.BackgroundImage = CType(resources.GetObject("btnDeleteVehicle.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteVehicle.BackgroundOnClick = CType(resources.GetObject("btnDeleteVehicle.BackgroundOnClick"), System.Drawing.Image)
        Me.btnDeleteVehicle.BackgroundOnDisabled = CType(resources.GetObject("btnDeleteVehicle.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnDeleteVehicle.BackgroundOnHover = CType(resources.GetObject("btnDeleteVehicle.BackgroundOnHover"), System.Drawing.Image)
        Me.btnDeleteVehicle.BackgroundOnNormal = CType(resources.GetObject("btnDeleteVehicle.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnDeleteVehicle.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnDeleteVehicle.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnDeleteVehicle.Enabled = False
        Me.btnDeleteVehicle.FlatAppearance.BorderSize = 0
        Me.btnDeleteVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteVehicle.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteVehicle.Location = New System.Drawing.Point(391, 152)
        Me.btnDeleteVehicle.Name = "btnDeleteVehicle"
        Me.btnDeleteVehicle.Size = New System.Drawing.Size(75, 25)
        Me.btnDeleteVehicle.TabIndex = 19
        Me.btnDeleteVehicle.Text = "Eliminar"
        Me.btnDeleteVehicle.UseVisualStyleBackColor = False
        '
        'btnSaveVehicle
        '
        Me.btnSaveVehicle.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveVehicle.BackgroundImage = CType(resources.GetObject("btnSaveVehicle.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveVehicle.BackgroundOnClick = CType(resources.GetObject("btnSaveVehicle.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSaveVehicle.BackgroundOnDisabled = CType(resources.GetObject("btnSaveVehicle.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSaveVehicle.BackgroundOnHover = CType(resources.GetObject("btnSaveVehicle.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSaveVehicle.BackgroundOnNormal = CType(resources.GetObject("btnSaveVehicle.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSaveVehicle.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSaveVehicle.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnSaveVehicle.Enabled = False
        Me.btnSaveVehicle.FlatAppearance.BorderSize = 0
        Me.btnSaveVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveVehicle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveVehicle.Location = New System.Drawing.Point(294, 152)
        Me.btnSaveVehicle.Name = "btnSaveVehicle"
        Me.btnSaveVehicle.Size = New System.Drawing.Size(75, 25)
        Me.btnSaveVehicle.TabIndex = 18
        Me.btnSaveVehicle.Text = "Guardar"
        Me.btnSaveVehicle.UseVisualStyleBackColor = False
        '
        'btnEditVehicle
        '
        Me.btnEditVehicle.BackColor = System.Drawing.Color.Transparent
        Me.btnEditVehicle.BackgroundImage = CType(resources.GetObject("btnEditVehicle.BackgroundImage"), System.Drawing.Image)
        Me.btnEditVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditVehicle.BackgroundOnClick = CType(resources.GetObject("btnEditVehicle.BackgroundOnClick"), System.Drawing.Image)
        Me.btnEditVehicle.BackgroundOnDisabled = CType(resources.GetObject("btnEditVehicle.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnEditVehicle.BackgroundOnHover = CType(resources.GetObject("btnEditVehicle.BackgroundOnHover"), System.Drawing.Image)
        Me.btnEditVehicle.BackgroundOnNormal = CType(resources.GetObject("btnEditVehicle.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnEditVehicle.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnEditVehicle.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnEditVehicle.Enabled = False
        Me.btnEditVehicle.FlatAppearance.BorderSize = 0
        Me.btnEditVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditVehicle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditVehicle.Location = New System.Drawing.Point(197, 152)
        Me.btnEditVehicle.Name = "btnEditVehicle"
        Me.btnEditVehicle.Size = New System.Drawing.Size(75, 25)
        Me.btnEditVehicle.TabIndex = 17
        Me.btnEditVehicle.Text = "Editar"
        Me.btnEditVehicle.UseVisualStyleBackColor = False
        '
        'btnNewVehicle
        '
        Me.btnNewVehicle.BackColor = System.Drawing.Color.Transparent
        Me.btnNewVehicle.BackgroundImage = CType(resources.GetObject("btnNewVehicle.BackgroundImage"), System.Drawing.Image)
        Me.btnNewVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewVehicle.BackgroundOnClick = CType(resources.GetObject("btnNewVehicle.BackgroundOnClick"), System.Drawing.Image)
        Me.btnNewVehicle.BackgroundOnDisabled = CType(resources.GetObject("btnNewVehicle.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnNewVehicle.BackgroundOnHover = CType(resources.GetObject("btnNewVehicle.BackgroundOnHover"), System.Drawing.Image)
        Me.btnNewVehicle.BackgroundOnNormal = CType(resources.GetObject("btnNewVehicle.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnNewVehicle.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnNewVehicle.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnNewVehicle.FlatAppearance.BorderSize = 0
        Me.btnNewVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNewVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewVehicle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewVehicle.Location = New System.Drawing.Point(100, 152)
        Me.btnNewVehicle.Name = "btnNewVehicle"
        Me.btnNewVehicle.Size = New System.Drawing.Size(75, 25)
        Me.btnNewVehicle.TabIndex = 16
        Me.btnNewVehicle.Text = "Nuevo"
        Me.btnNewVehicle.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(5, 128)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 14)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Observaciones"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 14)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Dispositivo Gps"
        '
        'dgvVehicles_device_id
        '
        Me.dgvVehicles_device_id.HeaderText = "ID DISPOSITIVO"
        Me.dgvVehicles_device_id.Name = "dgvVehicles_device_id"
        Me.dgvVehicles_device_id.ReadOnly = True
        Me.dgvVehicles_device_id.Visible = False
        Me.dgvVehicles_device_id.Width = 128
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Matrícula"
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpExpirationDate.Enabled = False
        Me.dtpExpirationDate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpirationDate.Location = New System.Drawing.Point(548, 73)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(111, 21)
        Me.dtpExpirationDate.TabIndex = 9
        '
        'dtpInstallationDate
        '
        Me.dtpInstallationDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpInstallationDate.Enabled = False
        Me.dtpInstallationDate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInstallationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInstallationDate.Location = New System.Drawing.Point(368, 73)
        Me.dtpInstallationDate.Name = "dtpInstallationDate"
        Me.dtpInstallationDate.Size = New System.Drawing.Size(107, 21)
        Me.dtpInstallationDate.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Marca"
        '
        'cboDevice
        '
        Me.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice.Enabled = False
        Me.cboDevice.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDevice.FormattingEnabled = True
        Me.cboDevice.HintText = "Hint Text"
        Me.cboDevice.HintTextColor = System.Drawing.Color.Gray
        Me.cboDevice.HintTextEnabled = False
        Me.cboDevice.Location = New System.Drawing.Point(93, 99)
        Me.cboDevice.Name = "cboDevice"
        Me.cboDevice.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboDevice.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboDevice.Size = New System.Drawing.Size(179, 22)
        Me.cboDevice.TabIndex = 14
        '
        'cboDealer
        '
        Me.cboDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDealer.Enabled = False
        Me.cboDealer.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDealer.FormattingEnabled = True
        Me.cboDealer.HintText = "Hint Text"
        Me.cboDealer.HintTextColor = System.Drawing.Color.Gray
        Me.cboDealer.HintTextEnabled = False
        Me.cboDealer.Location = New System.Drawing.Point(49, 73)
        Me.cboDealer.Name = "cboDealer"
        Me.cboDealer.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboDealer.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboDealer.Size = New System.Drawing.Size(247, 22)
        Me.cboDealer.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Modelo"
        '
        'txtSpeedLimit
        '
        Me.txtSpeedLimit.CaracterDecimal = False
        Me.txtSpeedLimit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSpeedLimit.Enabled = False
        Me.txtSpeedLimit.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeedLimit.HintText = "Hint Text"
        Me.txtSpeedLimit.HintTextColor = System.Drawing.Color.Gray
        Me.txtSpeedLimit.HintTextEnabled = False
        Me.txtSpeedLimit.Location = New System.Drawing.Point(579, 48)
        Me.txtSpeedLimit.MaxLength = 3
        Me.txtSpeedLimit.Name = "txtSpeedLimit"
        Me.txtSpeedLimit.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtSpeedLimit.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtSpeedLimit.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtSpeedLimit.Size = New System.Drawing.Size(80, 21)
        Me.txtSpeedLimit.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tipo"
        '
        'txtYear
        '
        Me.txtYear.CaracterDecimal = False
        Me.txtYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtYear.Enabled = False
        Me.txtYear.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.HintText = "Hint Text"
        Me.txtYear.HintTextColor = System.Drawing.Color.Gray
        Me.txtYear.HintTextEnabled = False
        Me.txtYear.Location = New System.Drawing.Point(597, 25)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtYear.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtYear.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtYear.Size = New System.Drawing.Size(62, 21)
        Me.txtYear.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(565, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Año"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(253, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Color"
        '
        'dgvVehicles_observations
        '
        Me.dgvVehicles_observations.HeaderText = "OBSERVACIONES"
        Me.dgvVehicles_observations.Name = "dgvVehicles_observations"
        Me.dgvVehicles_observations.ReadOnly = True
        Me.dgvVehicles_observations.Visible = False
        Me.dgvVehicles_observations.Width = 136
        '
        'tabConsole
        '
        Me.tabConsole.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabConsole.Controls.Add(Me.tpageClient)
        Me.tabConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabConsole.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabConsole.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabConsole.ItemSize = New System.Drawing.Size(140, 21)
        Me.tabConsole.Location = New System.Drawing.Point(0, 0)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.SelectedIndex = 0
        Me.tabConsole.Size = New System.Drawing.Size(1283, 829)
        Me.tabConsole.TabIndex = 1
        '
        'tpageClient
        '
        Me.tpageClient.Controls.Add(Me.panelHeaderVehicles)
        Me.tpageClient.Controls.Add(Me.panelHeaderContacts)
        Me.tpageClient.Controls.Add(Me.panelCenterPersonal)
        Me.tpageClient.Controls.Add(Me.panelHeaderPersonal)
        Me.tpageClient.Controls.Add(Me.panelReports)
        Me.tpageClient.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpageClient.Location = New System.Drawing.Point(4, 25)
        Me.tpageClient.Name = "tpageClient"
        Me.tpageClient.Padding = New System.Windows.Forms.Padding(3)
        Me.tpageClient.Size = New System.Drawing.Size(1275, 800)
        Me.tpageClient.TabIndex = 0
        Me.tpageClient.Text = "DATOS PERSONALES"
        Me.tpageClient.UseVisualStyleBackColor = True
        '
        'panelHeaderVehicles
        '
        Me.panelHeaderVehicles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelHeaderVehicles.Controls.Add(Me.panelLoadingVehicles)
        Me.panelHeaderVehicles.Controls.Add(Me.Label35)
        Me.panelHeaderVehicles.Controls.Add(Me.txtVehicleObservations)
        Me.panelHeaderVehicles.Controls.Add(Me.dgvVehicles)
        Me.panelHeaderVehicles.Controls.Add(Me.cboxVehicleStatus)
        Me.panelHeaderVehicles.Controls.Add(Me.btnCancelVehicle)
        Me.panelHeaderVehicles.Controls.Add(Me.btnDeleteVehicle)
        Me.panelHeaderVehicles.Controls.Add(Me.btnSaveVehicle)
        Me.panelHeaderVehicles.Controls.Add(Me.btnEditVehicle)
        Me.panelHeaderVehicles.Controls.Add(Me.btnNewVehicle)
        Me.panelHeaderVehicles.Controls.Add(Me.Label24)
        Me.panelHeaderVehicles.Controls.Add(Me.Label16)
        Me.panelHeaderVehicles.Controls.Add(Me.Label4)
        Me.panelHeaderVehicles.Controls.Add(Me.dtpExpirationDate)
        Me.panelHeaderVehicles.Controls.Add(Me.dtpInstallationDate)
        Me.panelHeaderVehicles.Controls.Add(Me.Label7)
        Me.panelHeaderVehicles.Controls.Add(Me.cboDevice)
        Me.panelHeaderVehicles.Controls.Add(Me.cboDealer)
        Me.panelHeaderVehicles.Controls.Add(Me.Label8)
        Me.panelHeaderVehicles.Controls.Add(Me.txtSpeedLimit)
        Me.panelHeaderVehicles.Controls.Add(Me.Label9)
        Me.panelHeaderVehicles.Controls.Add(Me.txtYear)
        Me.panelHeaderVehicles.Controls.Add(Me.Label10)
        Me.panelHeaderVehicles.Controls.Add(Me.txtModel)
        Me.panelHeaderVehicles.Controls.Add(Me.Label11)
        Me.panelHeaderVehicles.Controls.Add(Me.txtColor)
        Me.panelHeaderVehicles.Controls.Add(Me.Label12)
        Me.panelHeaderVehicles.Controls.Add(Me.txtCallPass)
        Me.panelHeaderVehicles.Controls.Add(Me.Label13)
        Me.panelHeaderVehicles.Controls.Add(Me.txtType)
        Me.panelHeaderVehicles.Controls.Add(Me.Label14)
        Me.panelHeaderVehicles.Controls.Add(Me.txtBrand)
        Me.panelHeaderVehicles.Controls.Add(Me.Label34)
        Me.panelHeaderVehicles.Controls.Add(Me.Label15)
        Me.panelHeaderVehicles.Controls.Add(Me.txtLicensePlate)
        Me.panelHeaderVehicles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelHeaderVehicles.Location = New System.Drawing.Point(3, 445)
        Me.panelHeaderVehicles.Name = "panelHeaderVehicles"
        Me.panelHeaderVehicles.Size = New System.Drawing.Size(667, 352)
        Me.panelHeaderVehicles.TabIndex = 17
        '
        'panelLoadingVehicles
        '
        Me.panelLoadingVehicles.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelLoadingVehicles.Controls.Add(Me.lblLoadingVehicles)
        Me.panelLoadingVehicles.Controls.Add(Me.PictureBox1)
        Me.panelLoadingVehicles.Location = New System.Drawing.Point(8, 323)
        Me.panelLoadingVehicles.Name = "panelLoadingVehicles"
        Me.panelLoadingVehicles.Size = New System.Drawing.Size(651, 22)
        Me.panelLoadingVehicles.TabIndex = 22
        Me.panelLoadingVehicles.Visible = False
        '
        'lblLoadingVehicles
        '
        Me.lblLoadingVehicles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoadingVehicles.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblLoadingVehicles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLoadingVehicles.Location = New System.Drawing.Point(0, 0)
        Me.lblLoadingVehicles.Name = "lblLoadingVehicles"
        Me.lblLoadingVehicles.Size = New System.Drawing.Size(621, 22)
        Me.lblLoadingVehicles.TabIndex = 16
        Me.lblLoadingVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.VillaTracking.My.Resources.Resources.loading
        Me.PictureBox1.Location = New System.Drawing.Point(621, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label35.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(663, 20)
        Me.Label35.TabIndex = 21
        Me.Label35.Text = "VEHÍCULOS"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVehicleObservations
        '
        Me.txtVehicleObservations.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVehicleObservations.Enabled = False
        Me.txtVehicleObservations.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleObservations.HintText = "Hint Text"
        Me.txtVehicleObservations.HintTextColor = System.Drawing.Color.Gray
        Me.txtVehicleObservations.HintTextEnabled = False
        Me.txtVehicleObservations.Location = New System.Drawing.Point(86, 125)
        Me.txtVehicleObservations.Name = "txtVehicleObservations"
        Me.txtVehicleObservations.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtVehicleObservations.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtVehicleObservations.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtVehicleObservations.Size = New System.Drawing.Size(573, 21)
        Me.txtVehicleObservations.TabIndex = 15
        '
        'dgvVehicles
        '
        Me.dgvVehicles.AllowUserToAddRows = False
        Me.dgvVehicles.AllowUserToDeleteRows = False
        Me.dgvVehicles.AllowUserToResizeColumns = False
        Me.dgvVehicles.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        Me.dgvVehicles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVehicles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvVehicles_dealer_name, Me.dgvVehicles_imei, Me.dgvVehicles_license_plate, Me.dgvVehicles_brand, Me.dgvVehicles_model, Me.dgvVehicles_type, Me.dgvVehicles_year, Me.dgvVehicles_color, Me.dgvVehicles_speed_limit, Me.dgvVehicles_phone_pass, Me.dgvVehicles_installation_date, Me.dgvVehicles_expiration_date, Me.dgvVehicles_priority, Me.dgvVehicles_status, Me.dgvVehicles_observations, Me.dgvVehicles_vehicle_id, Me.dgvVehicles_device_id, Me.dgvVehicles_dealer_id})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVehicles.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvVehicles.EnableHeadersVisualStyles = False
        Me.dgvVehicles.GridColor = System.Drawing.SystemColors.Control
        Me.dgvVehicles.Location = New System.Drawing.Point(0, 186)
        Me.dgvVehicles.MultiSelect = False
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.ReadOnly = True
        Me.dgvVehicles.RowHeadersVisible = False
        Me.dgvVehicles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVehicles.Size = New System.Drawing.Size(663, 162)
        Me.dgvVehicles.TabIndex = 1
        '
        'dgvVehicles_dealer_name
        '
        Me.dgvVehicles_dealer_name.HeaderText = "DEALER"
        Me.dgvVehicles_dealer_name.Name = "dgvVehicles_dealer_name"
        Me.dgvVehicles_dealer_name.ReadOnly = True
        Me.dgvVehicles_dealer_name.Width = 72
        '
        'dgvVehicles_imei
        '
        Me.dgvVehicles_imei.HeaderText = "DISPOSITIVO GPS"
        Me.dgvVehicles_imei.Name = "dgvVehicles_imei"
        Me.dgvVehicles_imei.ReadOnly = True
        Me.dgvVehicles_imei.Width = 119
        '
        'dgvVehicles_license_plate
        '
        Me.dgvVehicles_license_plate.HeaderText = "MATRÍCULA"
        Me.dgvVehicles_license_plate.Name = "dgvVehicles_license_plate"
        Me.dgvVehicles_license_plate.ReadOnly = True
        Me.dgvVehicles_license_plate.Width = 91
        '
        'dgvVehicles_brand
        '
        Me.dgvVehicles_brand.HeaderText = "MARCA"
        Me.dgvVehicles_brand.Name = "dgvVehicles_brand"
        Me.dgvVehicles_brand.ReadOnly = True
        Me.dgvVehicles_brand.Width = 67
        '
        'dgvVehicles_model
        '
        Me.dgvVehicles_model.HeaderText = "MODELO"
        Me.dgvVehicles_model.Name = "dgvVehicles_model"
        Me.dgvVehicles_model.ReadOnly = True
        Me.dgvVehicles_model.Width = 74
        '
        'dgvVehicles_type
        '
        Me.dgvVehicles_type.HeaderText = "TIPO"
        Me.dgvVehicles_type.Name = "dgvVehicles_type"
        Me.dgvVehicles_type.ReadOnly = True
        Me.dgvVehicles_type.Visible = False
        Me.dgvVehicles_type.Width = 61
        '
        'dgvVehicles_year
        '
        Me.dgvVehicles_year.HeaderText = "AÑO"
        Me.dgvVehicles_year.Name = "dgvVehicles_year"
        Me.dgvVehicles_year.ReadOnly = True
        Me.dgvVehicles_year.Width = 52
        '
        'dgvVehicles_color
        '
        Me.dgvVehicles_color.HeaderText = "COLOR"
        Me.dgvVehicles_color.Name = "dgvVehicles_color"
        Me.dgvVehicles_color.ReadOnly = True
        Me.dgvVehicles_color.Width = 64
        '
        'dgvVehicles_speed_limit
        '
        Me.dgvVehicles_speed_limit.HeaderText = "VELOCIDAD"
        Me.dgvVehicles_speed_limit.Name = "dgvVehicles_speed_limit"
        Me.dgvVehicles_speed_limit.ReadOnly = True
        Me.dgvVehicles_speed_limit.Visible = False
        Me.dgvVehicles_speed_limit.Width = 102
        '
        'dgvVehicles_phone_pass
        '
        Me.dgvVehicles_phone_pass.HeaderText = "CLAVE TELEFÓNICA"
        Me.dgvVehicles_phone_pass.Name = "dgvVehicles_phone_pass"
        Me.dgvVehicles_phone_pass.ReadOnly = True
        Me.dgvVehicles_phone_pass.Visible = False
        Me.dgvVehicles_phone_pass.Width = 151
        '
        'dgvVehicles_installation_date
        '
        Me.dgvVehicles_installation_date.HeaderText = "FECHA INSTALACIÓN"
        Me.dgvVehicles_installation_date.Name = "dgvVehicles_installation_date"
        Me.dgvVehicles_installation_date.ReadOnly = True
        Me.dgvVehicles_installation_date.Visible = False
        Me.dgvVehicles_installation_date.Width = 158
        '
        'dgvVehicles_expiration_date
        '
        Me.dgvVehicles_expiration_date.HeaderText = "FECHA VENCIMIENTO"
        Me.dgvVehicles_expiration_date.Name = "dgvVehicles_expiration_date"
        Me.dgvVehicles_expiration_date.ReadOnly = True
        Me.dgvVehicles_expiration_date.Visible = False
        Me.dgvVehicles_expiration_date.Width = 161
        '
        'dgvVehicles_priority
        '
        Me.dgvVehicles_priority.HeaderText = "PRIORIDAD"
        Me.dgvVehicles_priority.Name = "dgvVehicles_priority"
        Me.dgvVehicles_priority.ReadOnly = True
        Me.dgvVehicles_priority.Visible = False
        Me.dgvVehicles_priority.Width = 101
        '
        'dgvVehicles_status
        '
        Me.dgvVehicles_status.HeaderText = "STATUS"
        Me.dgvVehicles_status.Name = "dgvVehicles_status"
        Me.dgvVehicles_status.ReadOnly = True
        Me.dgvVehicles_status.Visible = False
        Me.dgvVehicles_status.Width = 81
        '
        'txtModel
        '
        Me.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModel.Enabled = False
        Me.txtModel.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.HintText = "Hint Text"
        Me.txtModel.HintTextColor = System.Drawing.Color.Gray
        Me.txtModel.HintTextEnabled = False
        Me.txtModel.Location = New System.Drawing.Point(398, 25)
        Me.txtModel.MaxLength = 50
        Me.txtModel.Name = "txtModel"
        Me.txtModel.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtModel.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtModel.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtModel.Size = New System.Drawing.Size(161, 21)
        Me.txtModel.TabIndex = 2
        '
        'txtColor
        '
        Me.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColor.Enabled = False
        Me.txtColor.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.HintText = "Hint Text"
        Me.txtColor.HintTextColor = System.Drawing.Color.Gray
        Me.txtColor.HintTextEnabled = False
        Me.txtColor.Location = New System.Drawing.Point(292, 48)
        Me.txtColor.MaxLength = 50
        Me.txtColor.Name = "txtColor"
        Me.txtColor.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtColor.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtColor.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtColor.Size = New System.Drawing.Size(150, 21)
        Me.txtColor.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(448, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 14)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Velocidad Límite (Km/H)"
        '
        'txtCallPass
        '
        Me.txtCallPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCallPass.Enabled = False
        Me.txtCallPass.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallPass.HintText = "Hint Text"
        Me.txtCallPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtCallPass.HintTextEnabled = False
        Me.txtCallPass.Location = New System.Drawing.Point(367, 100)
        Me.txtCallPass.Name = "txtCallPass"
        Me.txtCallPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtCallPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtCallPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtCallPass.Size = New System.Drawing.Size(227, 21)
        Me.txtCallPass.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(277, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Clave Telefónica"
        '
        'txtType
        '
        Me.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtType.Enabled = False
        Me.txtType.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.HintText = "Hint Text"
        Me.txtType.HintTextColor = System.Drawing.Color.Gray
        Me.txtType.HintTextEnabled = False
        Me.txtType.Location = New System.Drawing.Point(39, 48)
        Me.txtType.MaxLength = 50
        Me.txtType.Name = "txtType"
        Me.txtType.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtType.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtType.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtType.Size = New System.Drawing.Size(208, 21)
        Me.txtType.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 14)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Dealer"
        '
        'txtBrand
        '
        Me.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrand.Enabled = False
        Me.txtBrand.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.HintText = "Hint Text"
        Me.txtBrand.HintTextColor = System.Drawing.Color.Gray
        Me.txtBrand.HintTextEnabled = False
        Me.txtBrand.Location = New System.Drawing.Point(185, 25)
        Me.txtBrand.MaxLength = 50
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtBrand.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtBrand.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtBrand.Size = New System.Drawing.Size(159, 21)
        Me.txtBrand.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(478, 76)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 14)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Fecha Venc."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(302, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 14)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Fecha Inst."
        '
        'txtLicensePlate
        '
        Me.txtLicensePlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLicensePlate.Enabled = False
        Me.txtLicensePlate.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicensePlate.HintText = "Hint Text"
        Me.txtLicensePlate.HintTextColor = System.Drawing.Color.Gray
        Me.txtLicensePlate.HintTextEnabled = False
        Me.txtLicensePlate.Location = New System.Drawing.Point(64, 25)
        Me.txtLicensePlate.MaxLength = 20
        Me.txtLicensePlate.Name = "txtLicensePlate"
        Me.txtLicensePlate.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtLicensePlate.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtLicensePlate.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtLicensePlate.Size = New System.Drawing.Size(73, 21)
        Me.txtLicensePlate.TabIndex = 0
        '
        'panelHeaderContacts
        '
        Me.panelHeaderContacts.Controls.Add(Me.Label36)
        Me.panelHeaderContacts.Controls.Add(Me.btnCancelContact)
        Me.panelHeaderContacts.Controls.Add(Me.btnDeleteContact)
        Me.panelHeaderContacts.Controls.Add(Me.btnSaveContact)
        Me.panelHeaderContacts.Controls.Add(Me.btnEditContact)
        Me.panelHeaderContacts.Controls.Add(Me.btnNewContact)
        Me.panelHeaderContacts.Controls.Add(Me.txtContactObservations)
        Me.panelHeaderContacts.Controls.Add(Me.txtContactName)
        Me.panelHeaderContacts.Controls.Add(Me.Label6)
        Me.panelHeaderContacts.Controls.Add(Me.Label3)
        Me.panelHeaderContacts.Controls.Add(Me.Label5)
        Me.panelHeaderContacts.Controls.Add(Me.Label2)
        Me.panelHeaderContacts.Controls.Add(Me.Label1)
        Me.panelHeaderContacts.Controls.Add(Me.txtContactPhoneNumber2)
        Me.panelHeaderContacts.Controls.Add(Me.txtContactPhoneNumber1)
        Me.panelHeaderContacts.Controls.Add(Me.txtContactDni)
        Me.panelHeaderContacts.Controls.Add(Me.panelLoadingContacts)
        Me.panelHeaderContacts.Controls.Add(Me.dgvContacts)
        Me.panelHeaderContacts.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderContacts.Location = New System.Drawing.Point(3, 230)
        Me.panelHeaderContacts.Name = "panelHeaderContacts"
        Me.panelHeaderContacts.Size = New System.Drawing.Size(667, 215)
        Me.panelHeaderContacts.TabIndex = 16
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label36.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(0, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(667, 20)
        Me.Label36.TabIndex = 10
        Me.Label36.Text = "CONTACTOS"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelContact
        '
        Me.btnCancelContact.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelContact.BackgroundImage = CType(resources.GetObject("btnCancelContact.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelContact.BackgroundOnClick = CType(resources.GetObject("btnCancelContact.BackgroundOnClick"), System.Drawing.Image)
        Me.btnCancelContact.BackgroundOnDisabled = CType(resources.GetObject("btnCancelContact.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnCancelContact.BackgroundOnHover = CType(resources.GetObject("btnCancelContact.BackgroundOnHover"), System.Drawing.Image)
        Me.btnCancelContact.BackgroundOnNormal = CType(resources.GetObject("btnCancelContact.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnCancelContact.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnCancelContact.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnCancelContact.Enabled = False
        Me.btnCancelContact.FlatAppearance.BorderSize = 0
        Me.btnCancelContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelContact.Location = New System.Drawing.Point(490, 97)
        Me.btnCancelContact.Name = "btnCancelContact"
        Me.btnCancelContact.Size = New System.Drawing.Size(75, 25)
        Me.btnCancelContact.TabIndex = 9
        Me.btnCancelContact.Text = "Cancelar"
        Me.btnCancelContact.UseVisualStyleBackColor = False
        '
        'btnDeleteContact
        '
        Me.btnDeleteContact.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteContact.BackgroundImage = CType(resources.GetObject("btnDeleteContact.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteContact.BackgroundOnClick = CType(resources.GetObject("btnDeleteContact.BackgroundOnClick"), System.Drawing.Image)
        Me.btnDeleteContact.BackgroundOnDisabled = CType(resources.GetObject("btnDeleteContact.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnDeleteContact.BackgroundOnHover = CType(resources.GetObject("btnDeleteContact.BackgroundOnHover"), System.Drawing.Image)
        Me.btnDeleteContact.BackgroundOnNormal = CType(resources.GetObject("btnDeleteContact.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnDeleteContact.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnDeleteContact.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleBlue
        Me.btnDeleteContact.Enabled = False
        Me.btnDeleteContact.FlatAppearance.BorderSize = 0
        Me.btnDeleteContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteContact.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteContact.Location = New System.Drawing.Point(393, 97)
        Me.btnDeleteContact.Name = "btnDeleteContact"
        Me.btnDeleteContact.Size = New System.Drawing.Size(75, 25)
        Me.btnDeleteContact.TabIndex = 8
        Me.btnDeleteContact.Text = "Eliminar"
        Me.btnDeleteContact.UseVisualStyleBackColor = False
        '
        'btnSaveContact
        '
        Me.btnSaveContact.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveContact.BackgroundImage = CType(resources.GetObject("btnSaveContact.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveContact.BackgroundOnClick = CType(resources.GetObject("btnSaveContact.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSaveContact.BackgroundOnDisabled = CType(resources.GetObject("btnSaveContact.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSaveContact.BackgroundOnHover = CType(resources.GetObject("btnSaveContact.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSaveContact.BackgroundOnNormal = CType(resources.GetObject("btnSaveContact.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSaveContact.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSaveContact.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnSaveContact.Enabled = False
        Me.btnSaveContact.FlatAppearance.BorderSize = 0
        Me.btnSaveContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveContact.Location = New System.Drawing.Point(296, 97)
        Me.btnSaveContact.Name = "btnSaveContact"
        Me.btnSaveContact.Size = New System.Drawing.Size(75, 25)
        Me.btnSaveContact.TabIndex = 7
        Me.btnSaveContact.Text = "Guardar"
        Me.btnSaveContact.UseVisualStyleBackColor = False
        '
        'btnEditContact
        '
        Me.btnEditContact.BackColor = System.Drawing.Color.Transparent
        Me.btnEditContact.BackgroundImage = CType(resources.GetObject("btnEditContact.BackgroundImage"), System.Drawing.Image)
        Me.btnEditContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditContact.BackgroundOnClick = CType(resources.GetObject("btnEditContact.BackgroundOnClick"), System.Drawing.Image)
        Me.btnEditContact.BackgroundOnDisabled = CType(resources.GetObject("btnEditContact.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnEditContact.BackgroundOnHover = CType(resources.GetObject("btnEditContact.BackgroundOnHover"), System.Drawing.Image)
        Me.btnEditContact.BackgroundOnNormal = CType(resources.GetObject("btnEditContact.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnEditContact.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnEditContact.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnEditContact.Enabled = False
        Me.btnEditContact.FlatAppearance.BorderSize = 0
        Me.btnEditContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditContact.Location = New System.Drawing.Point(199, 97)
        Me.btnEditContact.Name = "btnEditContact"
        Me.btnEditContact.Size = New System.Drawing.Size(75, 25)
        Me.btnEditContact.TabIndex = 6
        Me.btnEditContact.Text = "Editar"
        Me.btnEditContact.UseVisualStyleBackColor = False
        '
        'btnNewContact
        '
        Me.btnNewContact.BackColor = System.Drawing.Color.Transparent
        Me.btnNewContact.BackgroundImage = CType(resources.GetObject("btnNewContact.BackgroundImage"), System.Drawing.Image)
        Me.btnNewContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewContact.BackgroundOnClick = CType(resources.GetObject("btnNewContact.BackgroundOnClick"), System.Drawing.Image)
        Me.btnNewContact.BackgroundOnDisabled = CType(resources.GetObject("btnNewContact.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnNewContact.BackgroundOnHover = CType(resources.GetObject("btnNewContact.BackgroundOnHover"), System.Drawing.Image)
        Me.btnNewContact.BackgroundOnNormal = CType(resources.GetObject("btnNewContact.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnNewContact.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnNewContact.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleGreen
        Me.btnNewContact.FlatAppearance.BorderSize = 0
        Me.btnNewContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNewContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewContact.Location = New System.Drawing.Point(102, 97)
        Me.btnNewContact.Name = "btnNewContact"
        Me.btnNewContact.Size = New System.Drawing.Size(75, 25)
        Me.btnNewContact.TabIndex = 5
        Me.btnNewContact.Text = "Nuevo"
        Me.btnNewContact.UseVisualStyleBackColor = False
        '
        'txtContactObservations
        '
        Me.txtContactObservations.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactObservations.Enabled = False
        Me.txtContactObservations.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactObservations.HintText = "Hint Text"
        Me.txtContactObservations.HintTextColor = System.Drawing.Color.Gray
        Me.txtContactObservations.HintTextEnabled = False
        Me.txtContactObservations.Location = New System.Drawing.Point(86, 71)
        Me.txtContactObservations.Name = "txtContactObservations"
        Me.txtContactObservations.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtContactObservations.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtContactObservations.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtContactObservations.Size = New System.Drawing.Size(575, 21)
        Me.txtContactObservations.TabIndex = 4
        '
        'txtContactName
        '
        Me.txtContactName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactName.Enabled = False
        Me.txtContactName.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactName.HintText = "Hint Text"
        Me.txtContactName.HintTextColor = System.Drawing.Color.Gray
        Me.txtContactName.HintTextEnabled = False
        Me.txtContactName.Location = New System.Drawing.Point(214, 24)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtContactName.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtContactName.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtContactName.Size = New System.Drawing.Size(447, 21)
        Me.txtContactName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(325, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Teléfono 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Teléfono 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Observaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cédula"
        '
        'txtContactPhoneNumber2
        '
        Me.txtContactPhoneNumber2.CaracterDecimal = False
        Me.txtContactPhoneNumber2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPhoneNumber2.Enabled = False
        Me.txtContactPhoneNumber2.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPhoneNumber2.HintText = "Hint Text"
        Me.txtContactPhoneNumber2.HintTextColor = System.Drawing.Color.Gray
        Me.txtContactPhoneNumber2.HintTextEnabled = False
        Me.txtContactPhoneNumber2.Location = New System.Drawing.Point(388, 47)
        Me.txtContactPhoneNumber2.Name = "txtContactPhoneNumber2"
        Me.txtContactPhoneNumber2.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtContactPhoneNumber2.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtContactPhoneNumber2.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtContactPhoneNumber2.Size = New System.Drawing.Size(273, 21)
        Me.txtContactPhoneNumber2.TabIndex = 3
        '
        'txtContactPhoneNumber1
        '
        Me.txtContactPhoneNumber1.CaracterDecimal = False
        Me.txtContactPhoneNumber1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPhoneNumber1.Enabled = False
        Me.txtContactPhoneNumber1.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPhoneNumber1.HintText = "Hint Text"
        Me.txtContactPhoneNumber1.HintTextColor = System.Drawing.Color.Gray
        Me.txtContactPhoneNumber1.HintTextEnabled = False
        Me.txtContactPhoneNumber1.Location = New System.Drawing.Point(68, 48)
        Me.txtContactPhoneNumber1.Name = "txtContactPhoneNumber1"
        Me.txtContactPhoneNumber1.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtContactPhoneNumber1.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtContactPhoneNumber1.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtContactPhoneNumber1.Size = New System.Drawing.Size(251, 21)
        Me.txtContactPhoneNumber1.TabIndex = 2
        '
        'txtContactDni
        '
        Me.txtContactDni.CaracterDecimal = False
        Me.txtContactDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactDni.Enabled = False
        Me.txtContactDni.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactDni.HintText = "Hint Text"
        Me.txtContactDni.HintTextColor = System.Drawing.Color.Gray
        Me.txtContactDni.HintTextEnabled = False
        Me.txtContactDni.Location = New System.Drawing.Point(51, 24)
        Me.txtContactDni.Name = "txtContactDni"
        Me.txtContactDni.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtContactDni.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtContactDni.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtContactDni.Size = New System.Drawing.Size(106, 21)
        Me.txtContactDni.TabIndex = 0
        '
        'panelLoadingContacts
        '
        Me.panelLoadingContacts.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelLoadingContacts.Controls.Add(Me.lblLoadingContacts)
        Me.panelLoadingContacts.Controls.Add(Me.PictureBox2)
        Me.panelLoadingContacts.Location = New System.Drawing.Point(7, 191)
        Me.panelLoadingContacts.Name = "panelLoadingContacts"
        Me.panelLoadingContacts.Size = New System.Drawing.Size(654, 22)
        Me.panelLoadingContacts.TabIndex = 20
        Me.panelLoadingContacts.Visible = False
        '
        'lblLoadingContacts
        '
        Me.lblLoadingContacts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoadingContacts.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblLoadingContacts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLoadingContacts.Location = New System.Drawing.Point(0, 0)
        Me.lblLoadingContacts.Name = "lblLoadingContacts"
        Me.lblLoadingContacts.Size = New System.Drawing.Size(624, 22)
        Me.lblLoadingContacts.TabIndex = 16
        Me.lblLoadingContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.VillaTracking.My.Resources.Resources.loading
        Me.PictureBox2.Location = New System.Drawing.Point(624, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'dgvContacts
        '
        Me.dgvContacts.AllowUserToAddRows = False
        Me.dgvContacts.AllowUserToDeleteRows = False
        Me.dgvContacts.AllowUserToResizeColumns = False
        Me.dgvContacts.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray
        Me.dgvContacts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvContacts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContacts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContacts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvContacts_dni, Me.dgvContacts_name, Me.dgvContacts_phone_number1, Me.dgvContacts_phone_number2, Me.dgvContacts_observations, Me.dgvContacts_contact_id})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContacts.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvContacts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvContacts.EnableHeadersVisualStyles = False
        Me.dgvContacts.GridColor = System.Drawing.SystemColors.Control
        Me.dgvContacts.Location = New System.Drawing.Point(0, 128)
        Me.dgvContacts.MultiSelect = False
        Me.dgvContacts.Name = "dgvContacts"
        Me.dgvContacts.ReadOnly = True
        Me.dgvContacts.RowHeadersVisible = False
        Me.dgvContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContacts.Size = New System.Drawing.Size(667, 87)
        Me.dgvContacts.TabIndex = 1
        '
        'dgvContacts_dni
        '
        Me.dgvContacts_dni.HeaderText = "CÉDULA"
        Me.dgvContacts_dni.Name = "dgvContacts_dni"
        Me.dgvContacts_dni.ReadOnly = True
        Me.dgvContacts_dni.Width = 73
        '
        'dgvContacts_name
        '
        Me.dgvContacts_name.HeaderText = "NOMBRE"
        Me.dgvContacts_name.Name = "dgvContacts_name"
        Me.dgvContacts_name.ReadOnly = True
        Me.dgvContacts_name.Width = 75
        '
        'dgvContacts_phone_number1
        '
        Me.dgvContacts_phone_number1.HeaderText = "TELÉFONO 1"
        Me.dgvContacts_phone_number1.Name = "dgvContacts_phone_number1"
        Me.dgvContacts_phone_number1.ReadOnly = True
        Me.dgvContacts_phone_number1.Width = 94
        '
        'dgvContacts_phone_number2
        '
        Me.dgvContacts_phone_number2.HeaderText = "TELÉFONO 2"
        Me.dgvContacts_phone_number2.Name = "dgvContacts_phone_number2"
        Me.dgvContacts_phone_number2.ReadOnly = True
        Me.dgvContacts_phone_number2.Width = 94
        '
        'dgvContacts_observations
        '
        Me.dgvContacts_observations.HeaderText = "OBSERVACIONES"
        Me.dgvContacts_observations.Name = "dgvContacts_observations"
        Me.dgvContacts_observations.ReadOnly = True
        Me.dgvContacts_observations.Width = 117
        '
        'dgvContacts_contact_id
        '
        Me.dgvContacts_contact_id.HeaderText = "ID CONTACTO"
        Me.dgvContacts_contact_id.Name = "dgvContacts_contact_id"
        Me.dgvContacts_contact_id.ReadOnly = True
        Me.dgvContacts_contact_id.Visible = False
        Me.dgvContacts_contact_id.Width = 116
        '
        'panelCenterPersonal
        '
        Me.panelCenterPersonal.Controls.Add(Me.pboxLoading)
        Me.panelCenterPersonal.Controls.Add(Me.lblStatus)
        Me.panelCenterPersonal.Controls.Add(Me.btnSaveClient)
        Me.panelCenterPersonal.Controls.Add(Me.btnDeleteClient)
        Me.panelCenterPersonal.Controls.Add(Me.cboxClientStatus)
        Me.panelCenterPersonal.Controls.Add(Me.btnCancelClient)
        Me.panelCenterPersonal.Controls.Add(Me.Label20)
        Me.panelCenterPersonal.Controls.Add(Me.Label23)
        Me.panelCenterPersonal.Controls.Add(Me.Label22)
        Me.panelCenterPersonal.Controls.Add(Me.Label21)
        Me.panelCenterPersonal.Controls.Add(Me.Label19)
        Me.panelCenterPersonal.Controls.Add(Me.Label18)
        Me.panelCenterPersonal.Controls.Add(Me.Label17)
        Me.panelCenterPersonal.Controls.Add(Me.txtEmail)
        Me.panelCenterPersonal.Controls.Add(Me.txtObservations)
        Me.panelCenterPersonal.Controls.Add(Me.txtAddress)
        Me.panelCenterPersonal.Controls.Add(Me.txtLastName)
        Me.panelCenterPersonal.Controls.Add(Me.txtPhoneNumber2)
        Me.panelCenterPersonal.Controls.Add(Me.txtPhoneNumber1)
        Me.panelCenterPersonal.Controls.Add(Me.txtFirstName)
        Me.panelCenterPersonal.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCenterPersonal.Location = New System.Drawing.Point(3, 33)
        Me.panelCenterPersonal.Name = "panelCenterPersonal"
        Me.panelCenterPersonal.Size = New System.Drawing.Size(667, 197)
        Me.panelCenterPersonal.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(5, 57)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 14)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Correo Electrónico"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 82)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 14)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Dirección"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 14)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Teléfono 1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(342, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 14)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Apellidos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 14)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Nombres"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.HintText = "Correo Electrónico"
        Me.txtEmail.HintTextColor = System.Drawing.Color.Gray
        Me.txtEmail.HintTextEnabled = False
        Me.txtEmail.Location = New System.Drawing.Point(123, 54)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtEmail.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtEmail.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtEmail.Size = New System.Drawing.Size(538, 21)
        Me.txtEmail.TabIndex = 23
        '
        'txtObservations
        '
        Me.txtObservations.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservations.Enabled = False
        Me.txtObservations.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservations.HintText = "Observaciones"
        Me.txtObservations.HintTextColor = System.Drawing.Color.Gray
        Me.txtObservations.HintTextEnabled = False
        Me.txtObservations.Location = New System.Drawing.Point(102, 101)
        Me.txtObservations.Multiline = True
        Me.txtObservations.Name = "txtObservations"
        Me.txtObservations.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtObservations.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtObservations.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtObservations.Size = New System.Drawing.Size(478, 63)
        Me.txtObservations.TabIndex = 24
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.HintText = "Dirección"
        Me.txtAddress.HintTextColor = System.Drawing.Color.Gray
        Me.txtAddress.HintTextEnabled = False
        Me.txtAddress.Location = New System.Drawing.Point(72, 79)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtAddress.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtAddress.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtAddress.Size = New System.Drawing.Size(589, 19)
        Me.txtAddress.TabIndex = 22
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.HintText = "Apellidos"
        Me.txtLastName.HintTextColor = System.Drawing.Color.Gray
        Me.txtLastName.HintTextEnabled = False
        Me.txtLastName.Location = New System.Drawing.Point(406, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtLastName.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtLastName.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtLastName.Size = New System.Drawing.Size(255, 21)
        Me.txtLastName.TabIndex = 11
        '
        'txtPhoneNumber2
        '
        Me.txtPhoneNumber2.CaracterDecimal = False
        Me.txtPhoneNumber2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhoneNumber2.Enabled = False
        Me.txtPhoneNumber2.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber2.HintText = "Teléfono 2"
        Me.txtPhoneNumber2.HintTextColor = System.Drawing.Color.Gray
        Me.txtPhoneNumber2.HintTextEnabled = False
        Me.txtPhoneNumber2.Location = New System.Drawing.Point(399, 29)
        Me.txtPhoneNumber2.MaxLength = 10
        Me.txtPhoneNumber2.Name = "txtPhoneNumber2"
        Me.txtPhoneNumber2.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtPhoneNumber2.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtPhoneNumber2.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtPhoneNumber2.Size = New System.Drawing.Size(262, 21)
        Me.txtPhoneNumber2.TabIndex = 21
        '
        'txtPhoneNumber1
        '
        Me.txtPhoneNumber1.CaracterDecimal = False
        Me.txtPhoneNumber1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhoneNumber1.Enabled = False
        Me.txtPhoneNumber1.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber1.HintText = "Teléfono 1"
        Me.txtPhoneNumber1.HintTextColor = System.Drawing.Color.Gray
        Me.txtPhoneNumber1.HintTextEnabled = False
        Me.txtPhoneNumber1.Location = New System.Drawing.Point(78, 29)
        Me.txtPhoneNumber1.MaxLength = 10
        Me.txtPhoneNumber1.Name = "txtPhoneNumber1"
        Me.txtPhoneNumber1.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtPhoneNumber1.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtPhoneNumber1.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtPhoneNumber1.Size = New System.Drawing.Size(241, 21)
        Me.txtPhoneNumber1.TabIndex = 13
        '
        'txtFirstName
        '
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.HintText = "Nombres"
        Me.txtFirstName.HintTextColor = System.Drawing.Color.Gray
        Me.txtFirstName.HintTextEnabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(67, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtFirstName.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtFirstName.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtFirstName.Size = New System.Drawing.Size(269, 21)
        Me.txtFirstName.TabIndex = 10
        '
        'frmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 829)
        Me.Controls.Add(Me.tabConsole)
        Me.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.gboxSearchReports.ResumeLayout(False)
        Me.gboxSearchReports.PerformLayout()
        Me.panelHeaderPersonal.ResumeLayout(False)
        Me.panelHeaderPersonal.PerformLayout()
        Me.panelReports.ResumeLayout(False)
        Me.panelLoadingReports.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxInsertReport.ResumeLayout(False)
        Me.gboxInsertReport.PerformLayout()
        CType(Me.numValidation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsole.ResumeLayout(False)
        Me.tpageClient.ResumeLayout(False)
        Me.panelHeaderVehicles.ResumeLayout(False)
        Me.panelHeaderVehicles.PerformLayout()
        Me.panelLoadingVehicles.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelHeaderContacts.ResumeLayout(False)
        Me.panelHeaderContacts.PerformLayout()
        Me.panelLoadingContacts.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCenterPersonal.ResumeLayout(False)
        Me.panelCenterPersonal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label32 As Label
    Friend WithEvents btnFLastTen As ZUControls.ZUButton
    Friend WithEvents btnFSearch As ZUControls.ZUButton
    Friend WithEvents dtpFRangeTo As DateTimePicker
    Friend WithEvents dtpFRangeFrom As DateTimePicker
    Friend WithEvents dtpFByYear As ZUControls.ZUMonthPicker
    Friend WithEvents dtpFByMonth As ZUControls.ZUMonthPicker
    Friend WithEvents cboFUser As ZUControls.ZUComboBox
    Friend WithEvents cboFReportType As ZUControls.ZUComboBox
    Friend WithEvents rbtnFByRange As RadioButton
    Friend WithEvents dgvReports_transmitter As DataGridViewTextBoxColumn
    Friend WithEvents Label33 As Label
    Friend WithEvents dgvReports_receiver As DataGridViewTextBoxColumn
    Friend WithEvents dgvReports_report_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvReports_report_type_id As DataGridViewTextBoxColumn
    Friend WithEvents rbtnFByYear As RadioButton
    Friend WithEvents dgvReports_user_id As DataGridViewTextBoxColumn
    Friend WithEvents gboxSearchReports As GroupBox
    Friend WithEvents rbtnFByMonth As RadioButton
    Friend WithEvents rbtnFToday As RadioButton
    Friend WithEvents cboxFUser As CheckBox
    Friend WithEvents cboxFVehicle As CheckBox
    Friend WithEvents cboxFReportType As CheckBox
    Friend WithEvents rbtnSearchReports As RadioButton
    Friend WithEvents cboFVehicle As ZUControls.ZUComboBox
    Friend WithEvents dgvReports_communication_mode As DataGridViewTextBoxColumn
    Friend WithEvents dgvReports_vehicle_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvReports_user_name As DataGridViewTextBoxColumn
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnSaveClient As ZUControls.ZUButton
    Friend WithEvents btnDeleteClient As ZUControls.ZUButton
    Friend WithEvents cboxClientStatus As CheckBox
    Friend WithEvents btnCancelClient As ZUControls.ZUButton
    Friend WithEvents Label20 As Label
    Friend WithEvents bgwSavingReports As System.ComponentModel.BackgroundWorker
    Friend WithEvents panelHeaderPersonal As ZUControls.ZUPanel
    Friend WithEvents txtDni As ZUControls.ZUNumericBox
    Friend WithEvents rbtnDni As RadioButton
    Friend WithEvents btnRegisterClient As ZUControls.ZUButton
    Friend WithEvents btnEditClient As ZUControls.ZUButton
    Friend WithEvents dgvReports_license_plate As DataGridViewTextBoxColumn
    Friend WithEvents panelReports As ZUControls.ZUPanel
    Friend WithEvents panelLoadingReports As ZUControls.ZUPanel
    Friend WithEvents lblLoadingReports As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents dgvReports_date_time As DataGridViewTextBoxColumn
    Friend WithEvents dgvReports_report_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvReports_description As DataGridViewTextBoxColumn
    Friend WithEvents gboxInsertReport As GroupBox
    Friend WithEvents cboxGeneralReport As CheckBox
    Friend WithEvents btnMReceiverClient As Button
    Friend WithEvents btnMReceiverUser As Button
    Friend WithEvents btnMTransmitterClient As Button
    Friend WithEvents btnMTransmitterUser As Button
    Friend WithEvents btnMInsertReport As ZUControls.ZUButton
    Friend WithEvents cboMValidation As ZUControls.ZUComboBox
    Friend WithEvents numValidation As NumericUpDown
    Friend WithEvents txtMDescription As ZUControls.ZUTextBox
    Friend WithEvents txtMReceiver As ZUControls.ZUTextBox
    Friend WithEvents txtMTransmitter As ZUControls.ZUTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cboMVehicle As ZUControls.ZUComboBox
    Friend WithEvents cboCommunicationMode As ZUControls.ZUComboBox
    Friend WithEvents cboMReportType As ZUControls.ZUComboBox
    Friend WithEvents rbtnInsertReports As RadioButton
    Friend WithEvents bgwGetClientById As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSavingClient As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwDeletingClient As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSavingContacts As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwDeletingContacts As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGetContacts As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGetDevices As System.ComponentModel.BackgroundWorker
    Friend WithEvents ofdClientImage As OpenFileDialog
    Friend WithEvents bgwGetDealers As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGetVehicles As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSavingVehicles As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwDeletingVehicles As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwFiller As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSearchingReports As System.ComponentModel.BackgroundWorker
    Friend WithEvents pboxLoading As PictureBox
    Friend WithEvents bgwGetClientByDni As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label23 As Label
    Friend WithEvents dgvVehicles_vehicle_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_dealer_id As DataGridViewTextBoxColumn
    Friend WithEvents cboxVehicleStatus As CheckBox
    Friend WithEvents btnCancelVehicle As ZUControls.ZUButton
    Friend WithEvents btnDeleteVehicle As ZUControls.ZUButton
    Friend WithEvents btnSaveVehicle As ZUControls.ZUButton
    Friend WithEvents btnEditVehicle As ZUControls.ZUButton
    Friend WithEvents btnNewVehicle As ZUControls.ZUButton
    Friend WithEvents Label24 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvVehicles_device_id As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents dtpInstallationDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cboDevice As ZUControls.ZUComboBox
    Friend WithEvents cboDealer As ZUControls.ZUComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSpeedLimit As ZUControls.ZUNumericBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtYear As ZUControls.ZUNumericBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvVehicles_observations As DataGridViewTextBoxColumn
    Friend WithEvents tabConsole As TabControl
    Friend WithEvents tpageClient As TabPage
    Friend WithEvents panelHeaderVehicles As ZUControls.ZUPanel
    Friend WithEvents panelLoadingVehicles As ZUControls.ZUPanel
    Friend WithEvents lblLoadingVehicles As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtVehicleObservations As ZUControls.ZUTextBox
    Friend WithEvents dgvVehicles As DataGridView
    Friend WithEvents dgvVehicles_dealer_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_imei As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_license_plate As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_brand As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_model As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_type As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_year As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_color As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_speed_limit As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_phone_pass As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_installation_date As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_expiration_date As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_priority As DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicles_status As DataGridViewTextBoxColumn
    Friend WithEvents txtModel As ZUControls.ZUTextBox
    Friend WithEvents txtColor As ZUControls.ZUTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCallPass As ZUControls.ZUTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtType As ZUControls.ZUTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBrand As ZUControls.ZUTextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtLicensePlate As ZUControls.ZUTextBox
    Friend WithEvents panelHeaderContacts As ZUControls.ZUPanel
    Friend WithEvents Label36 As Label
    Friend WithEvents btnCancelContact As ZUControls.ZUButton
    Friend WithEvents btnDeleteContact As ZUControls.ZUButton
    Friend WithEvents btnSaveContact As ZUControls.ZUButton
    Friend WithEvents btnEditContact As ZUControls.ZUButton
    Friend WithEvents btnNewContact As ZUControls.ZUButton
    Friend WithEvents txtContactObservations As ZUControls.ZUTextBox
    Friend WithEvents txtContactName As ZUControls.ZUTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContactPhoneNumber2 As ZUControls.ZUNumericBox
    Friend WithEvents txtContactPhoneNumber1 As ZUControls.ZUNumericBox
    Friend WithEvents txtContactDni As ZUControls.ZUNumericBox
    Friend WithEvents panelLoadingContacts As ZUControls.ZUPanel
    Friend WithEvents lblLoadingContacts As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvContacts As DataGridView
    Friend WithEvents dgvContacts_dni As DataGridViewTextBoxColumn
    Friend WithEvents dgvContacts_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvContacts_phone_number1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvContacts_phone_number2 As DataGridViewTextBoxColumn
    Friend WithEvents dgvContacts_observations As DataGridViewTextBoxColumn
    Friend WithEvents dgvContacts_contact_id As DataGridViewTextBoxColumn
    Friend WithEvents panelCenterPersonal As ZUControls.ZUPanel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEmail As ZUControls.ZUTextBox
    Friend WithEvents txtObservations As ZUControls.ZUTextBox
    Friend WithEvents txtAddress As ZUControls.ZUTextBox
    Friend WithEvents txtLastName As ZUControls.ZUTextBox
    Friend WithEvents txtPhoneNumber2 As ZUControls.ZUNumericBox
    Friend WithEvents txtPhoneNumber1 As ZUControls.ZUNumericBox
    Friend WithEvents txtFirstName As ZUControls.ZUTextBox
End Class
