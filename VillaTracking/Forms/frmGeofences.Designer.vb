<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeofences
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeofences))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAsigns_client_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxSearchAsigned = New System.Windows.Forms.GroupBox()
        Me.btnUnAsign = New ZUControls.ZUButton()
        Me.btnSearchAsigns = New ZUControls.ZUButton()
        Me.rbtnSearchByClient = New System.Windows.Forms.RadioButton()
        Me.cboSearchAsigns = New ZUControls.ZUComboBox()
        Me.rbtnSearchByGeofence = New System.Windows.Forms.RadioButton()
        Me.rbtnSearchAllAsigns = New System.Windows.Forms.RadioButton()
        Me.rbtnSearchAsigned = New System.Windows.Forms.RadioButton()
        Me.panelHeader = New ZUControls.ZUPanel()
        Me.gboxAsignGeofence = New System.Windows.Forms.GroupBox()
        Me.rbtnAsignGeofence = New System.Windows.Forms.RadioButton()
        Me.btnAsign = New ZUControls.ZUButton()
        Me.cboGeofenceToAsign = New ZUControls.ZUComboBox()
        Me.cboVehicleToAsign = New ZUControls.ZUComboBox()
        Me.cboClientToAsign = New ZUControls.ZUComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbarMapAsign = New XComponent.SliderBar.ZUTrackBar()
        Me.btnHybridAsign = New ZUControls.ZUButton()
        Me.btnSatteliteAsign = New ZUControls.ZUButton()
        Me.btnMapAsign = New ZUControls.ZUButton()
        Me.mapAsigns = New ZUControls.ZUMapa()
        Me.dgvAsigns_geofence_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_vehicle_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_client_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_geofence_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAsigns_license_plate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgwSearchAsigns = New System.ComponentModel.BackgroundWorker()
        Me.bgwUnAsigning = New System.ComponentModel.BackgroundWorker()
        Me.bgwAsigning = New System.ComponentModel.BackgroundWorker()
        Me.bgwGetClients = New System.ComponentModel.BackgroundWorker()
        Me.bgwDeletingGeofences = New System.ComponentModel.BackgroundWorker()
        Me.bgwSavingGeofences = New System.ComponentModel.BackgroundWorker()
        Me.bgwGetGeofences = New System.ComponentModel.BackgroundWorker()
        Me.dgvAsigns = New System.Windows.Forms.DataGridView()
        Me.splitHorizontalAsign1 = New System.Windows.Forms.SplitContainer()
        Me.gboxGeofenceList = New System.Windows.Forms.GroupBox()
        Me.dgvGeofences = New System.Windows.Forms.DataGridView()
        Me.dgvGeofences_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_asigns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_points = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGeofences_geofence_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHeaderPanel2Collapsing = New System.Windows.Forms.Button()
        Me.lblGeofenceStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelGeofence = New ZUControls.ZUButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.splitHeader = New System.Windows.Forms.SplitContainer()
        Me.gboxGeofenceMantainer = New System.Windows.Forms.GroupBox()
        Me.btnDeleteGeofence = New ZUControls.ZUButton()
        Me.txtName = New ZUControls.ZUTextBox()
        Me.btnSaveGeofence = New ZUControls.ZUButton()
        Me.txtDescription = New ZUControls.ZUTextBox()
        Me.btnEditGeofence = New ZUControls.ZUButton()
        Me.cboxGeofenceStatus = New System.Windows.Forms.CheckBox()
        Me.btnNewGeofence = New ZUControls.ZUButton()
        Me.splitHorizontal = New System.Windows.Forms.SplitContainer()
        Me.tbarMapZoom = New XComponent.SliderBar.ZUTrackBar()
        Me.btnHybrid = New ZUControls.ZUButton()
        Me.btnSatellite = New ZUControls.ZUButton()
        Me.btnRemoveLast = New ZUControls.ZUButton()
        Me.btnClean = New ZUControls.ZUButton()
        Me.btnDraw = New ZUControls.ZUButton()
        Me.btnMap = New ZUControls.ZUButton()
        Me.mapMainGeofence = New ZUControls.ZUMapa()
        Me.panelLoading = New ZUControls.ZUPanel()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.pboxLoading = New System.Windows.Forms.PictureBox()
        Me.tpageMaintenance = New System.Windows.Forms.TabPage()
        Me.tabConsole = New System.Windows.Forms.TabControl()
        Me.tpageAsigns = New System.Windows.Forms.TabPage()
        Me.panelLoadingAsigns = New ZUControls.ZUPanel()
        Me.lblLoadingAsigns = New System.Windows.Forms.Label()
        Me.pboxLoadingAsigns = New System.Windows.Forms.PictureBox()
        Me.gboxSearchAsigned.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        Me.gboxAsignGeofence.SuspendLayout()
        CType(Me.dgvAsigns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitHorizontalAsign1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitHorizontalAsign1.Panel1.SuspendLayout()
        Me.splitHorizontalAsign1.Panel2.SuspendLayout()
        Me.splitHorizontalAsign1.SuspendLayout()
        Me.gboxGeofenceList.SuspendLayout()
        CType(Me.dgvGeofences, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitHeader.Panel1.SuspendLayout()
        Me.splitHeader.Panel2.SuspendLayout()
        Me.splitHeader.SuspendLayout()
        Me.gboxGeofenceMantainer.SuspendLayout()
        CType(Me.splitHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitHorizontal.Panel1.SuspendLayout()
        Me.splitHorizontal.Panel2.SuspendLayout()
        Me.splitHorizontal.SuspendLayout()
        Me.panelLoading.SuspendLayout()
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpageMaintenance.SuspendLayout()
        Me.tabConsole.SuspendLayout()
        Me.tpageAsigns.SuspendLayout()
        Me.panelLoadingAsigns.SuspendLayout()
        CType(Me.pboxLoadingAsigns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsigns_client_name
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvAsigns_client_name.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAsigns_client_name.HeaderText = "CLIENTE"
        Me.dgvAsigns_client_name.Name = "dgvAsigns_client_name"
        Me.dgvAsigns_client_name.ReadOnly = True
        Me.dgvAsigns_client_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_client_name.Width = 56
        '
        'gboxSearchAsigned
        '
        Me.gboxSearchAsigned.Controls.Add(Me.btnUnAsign)
        Me.gboxSearchAsigned.Controls.Add(Me.btnSearchAsigns)
        Me.gboxSearchAsigned.Controls.Add(Me.rbtnSearchByClient)
        Me.gboxSearchAsigned.Controls.Add(Me.cboSearchAsigns)
        Me.gboxSearchAsigned.Controls.Add(Me.rbtnSearchByGeofence)
        Me.gboxSearchAsigned.Controls.Add(Me.rbtnSearchAllAsigns)
        Me.gboxSearchAsigned.Controls.Add(Me.rbtnSearchAsigned)
        Me.gboxSearchAsigned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboxSearchAsigned.Enabled = False
        Me.gboxSearchAsigned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxSearchAsigned.Location = New System.Drawing.Point(0, 48)
        Me.gboxSearchAsigned.Name = "gboxSearchAsigned"
        Me.gboxSearchAsigned.Size = New System.Drawing.Size(1007, 61)
        Me.gboxSearchAsigned.TabIndex = 2
        Me.gboxSearchAsigned.TabStop = False
        '
        'btnUnAsign
        '
        Me.btnUnAsign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUnAsign.BackColor = System.Drawing.Color.Transparent
        Me.btnUnAsign.BackgroundImage = CType(resources.GetObject("btnUnAsign.BackgroundImage"), System.Drawing.Image)
        Me.btnUnAsign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUnAsign.BackgroundOnClick = CType(resources.GetObject("btnUnAsign.BackgroundOnClick"), System.Drawing.Image)
        Me.btnUnAsign.BackgroundOnDisabled = CType(resources.GetObject("btnUnAsign.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnUnAsign.BackgroundOnHover = CType(resources.GetObject("btnUnAsign.BackgroundOnHover"), System.Drawing.Image)
        Me.btnUnAsign.BackgroundOnNormal = CType(resources.GetObject("btnUnAsign.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnUnAsign.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnUnAsign.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnUnAsign.Enabled = False
        Me.btnUnAsign.FlatAppearance.BorderSize = 0
        Me.btnUnAsign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUnAsign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUnAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnAsign.ForeColor = System.Drawing.Color.Black
        Me.btnUnAsign.Location = New System.Drawing.Point(914, 25)
        Me.btnUnAsign.Name = "btnUnAsign"
        Me.btnUnAsign.Size = New System.Drawing.Size(87, 24)
        Me.btnUnAsign.TabIndex = 8
        Me.btnUnAsign.Text = "Desasignar"
        Me.btnUnAsign.UseVisualStyleBackColor = False
        '
        'btnSearchAsigns
        '
        Me.btnSearchAsigns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchAsigns.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchAsigns.BackgroundImage = CType(resources.GetObject("btnSearchAsigns.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchAsigns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchAsigns.BackgroundOnClick = CType(resources.GetObject("btnSearchAsigns.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSearchAsigns.BackgroundOnDisabled = CType(resources.GetObject("btnSearchAsigns.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSearchAsigns.BackgroundOnHover = CType(resources.GetObject("btnSearchAsigns.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSearchAsigns.BackgroundOnNormal = CType(resources.GetObject("btnSearchAsigns.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSearchAsigns.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSearchAsigns.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnSearchAsigns.FlatAppearance.BorderSize = 0
        Me.btnSearchAsigns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearchAsigns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSearchAsigns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchAsigns.ForeColor = System.Drawing.Color.Black
        Me.btnSearchAsigns.Location = New System.Drawing.Point(849, 25)
        Me.btnSearchAsigns.Name = "btnSearchAsigns"
        Me.btnSearchAsigns.Size = New System.Drawing.Size(59, 24)
        Me.btnSearchAsigns.TabIndex = 8
        Me.btnSearchAsigns.Text = "Buscar"
        Me.btnSearchAsigns.UseVisualStyleBackColor = False
        '
        'rbtnSearchByClient
        '
        Me.rbtnSearchByClient.AutoSize = True
        Me.rbtnSearchByClient.ForeColor = System.Drawing.Color.Black
        Me.rbtnSearchByClient.Location = New System.Drawing.Point(220, 26)
        Me.rbtnSearchByClient.Name = "rbtnSearchByClient"
        Me.rbtnSearchByClient.Size = New System.Drawing.Size(78, 18)
        Me.rbtnSearchByClient.TabIndex = 4
        Me.rbtnSearchByClient.Text = "Por Cliente"
        Me.rbtnSearchByClient.UseVisualStyleBackColor = True
        '
        'cboSearchAsigns
        '
        Me.cboSearchAsigns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSearchAsigns.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSearchAsigns.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearchAsigns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchAsigns.Enabled = False
        Me.cboSearchAsigns.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchAsigns.ForeColor = System.Drawing.Color.Black
        Me.cboSearchAsigns.FormattingEnabled = True
        Me.cboSearchAsigns.HintText = "Hint Text"
        Me.cboSearchAsigns.HintTextColor = System.Drawing.Color.Gray
        Me.cboSearchAsigns.HintTextEnabled = False
        Me.cboSearchAsigns.Location = New System.Drawing.Point(304, 25)
        Me.cboSearchAsigns.Name = "cboSearchAsigns"
        Me.cboSearchAsigns.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboSearchAsigns.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboSearchAsigns.Size = New System.Drawing.Size(538, 22)
        Me.cboSearchAsigns.TabIndex = 5
        '
        'rbtnSearchByGeofence
        '
        Me.rbtnSearchByGeofence.AutoSize = True
        Me.rbtnSearchByGeofence.ForeColor = System.Drawing.Color.Black
        Me.rbtnSearchByGeofence.Location = New System.Drawing.Point(126, 27)
        Me.rbtnSearchByGeofence.Name = "rbtnSearchByGeofence"
        Me.rbtnSearchByGeofence.Size = New System.Drawing.Size(88, 18)
        Me.rbtnSearchByGeofence.TabIndex = 6
        Me.rbtnSearchByGeofence.Text = "Por Geocerca"
        Me.rbtnSearchByGeofence.UseVisualStyleBackColor = True
        '
        'rbtnSearchAllAsigns
        '
        Me.rbtnSearchAllAsigns.AutoSize = True
        Me.rbtnSearchAllAsigns.Checked = True
        Me.rbtnSearchAllAsigns.ForeColor = System.Drawing.Color.Black
        Me.rbtnSearchAllAsigns.Location = New System.Drawing.Point(14, 26)
        Me.rbtnSearchAllAsigns.Name = "rbtnSearchAllAsigns"
        Me.rbtnSearchAllAsigns.Size = New System.Drawing.Size(106, 18)
        Me.rbtnSearchAllAsigns.TabIndex = 7
        Me.rbtnSearchAllAsigns.TabStop = True
        Me.rbtnSearchAllAsigns.Text = "Todas Asignadas"
        Me.rbtnSearchAllAsigns.UseVisualStyleBackColor = True
        '
        'rbtnSearchAsigned
        '
        Me.rbtnSearchAsigned.AutoSize = True
        Me.rbtnSearchAsigned.Location = New System.Drawing.Point(6, 0)
        Me.rbtnSearchAsigned.Name = "rbtnSearchAsigned"
        Me.rbtnSearchAsigned.Size = New System.Drawing.Size(161, 18)
        Me.rbtnSearchAsigned.TabIndex = 0
        Me.rbtnSearchAsigned.Text = "Buscar Geocercas Asignadas"
        Me.rbtnSearchAsigned.UseVisualStyleBackColor = True
        '
        'panelHeader
        '
        Me.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelHeader.Controls.Add(Me.gboxSearchAsigned)
        Me.panelHeader.Controls.Add(Me.gboxAsignGeofence)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelHeader.Location = New System.Drawing.Point(3, 3)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1011, 113)
        Me.panelHeader.TabIndex = 1
        '
        'gboxAsignGeofence
        '
        Me.gboxAsignGeofence.Controls.Add(Me.rbtnAsignGeofence)
        Me.gboxAsignGeofence.Controls.Add(Me.btnAsign)
        Me.gboxAsignGeofence.Controls.Add(Me.cboGeofenceToAsign)
        Me.gboxAsignGeofence.Controls.Add(Me.cboVehicleToAsign)
        Me.gboxAsignGeofence.Controls.Add(Me.cboClientToAsign)
        Me.gboxAsignGeofence.Controls.Add(Me.label3)
        Me.gboxAsignGeofence.Controls.Add(Me.Label4)
        Me.gboxAsignGeofence.Controls.Add(Me.Label5)
        Me.gboxAsignGeofence.Dock = System.Windows.Forms.DockStyle.Top
        Me.gboxAsignGeofence.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxAsignGeofence.Location = New System.Drawing.Point(0, 0)
        Me.gboxAsignGeofence.Name = "gboxAsignGeofence"
        Me.gboxAsignGeofence.Size = New System.Drawing.Size(1007, 48)
        Me.gboxAsignGeofence.TabIndex = 1
        Me.gboxAsignGeofence.TabStop = False
        '
        'rbtnAsignGeofence
        '
        Me.rbtnAsignGeofence.AutoSize = True
        Me.rbtnAsignGeofence.Checked = True
        Me.rbtnAsignGeofence.Location = New System.Drawing.Point(6, -1)
        Me.rbtnAsignGeofence.Name = "rbtnAsignGeofence"
        Me.rbtnAsignGeofence.Size = New System.Drawing.Size(107, 18)
        Me.rbtnAsignGeofence.TabIndex = 0
        Me.rbtnAsignGeofence.TabStop = True
        Me.rbtnAsignGeofence.Text = "Asignar Geocerca"
        Me.rbtnAsignGeofence.UseVisualStyleBackColor = True
        '
        'btnAsign
        '
        Me.btnAsign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAsign.BackColor = System.Drawing.Color.Transparent
        Me.btnAsign.BackgroundImage = CType(resources.GetObject("btnAsign.BackgroundImage"), System.Drawing.Image)
        Me.btnAsign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsign.BackgroundOnClick = CType(resources.GetObject("btnAsign.BackgroundOnClick"), System.Drawing.Image)
        Me.btnAsign.BackgroundOnDisabled = CType(resources.GetObject("btnAsign.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnAsign.BackgroundOnHover = CType(resources.GetObject("btnAsign.BackgroundOnHover"), System.Drawing.Image)
        Me.btnAsign.BackgroundOnNormal = CType(resources.GetObject("btnAsign.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnAsign.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnAsign.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnAsign.FlatAppearance.BorderSize = 0
        Me.btnAsign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAsign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsign.ForeColor = System.Drawing.Color.Black
        Me.btnAsign.Location = New System.Drawing.Point(942, 18)
        Me.btnAsign.Name = "btnAsign"
        Me.btnAsign.Size = New System.Drawing.Size(59, 23)
        Me.btnAsign.TabIndex = 10
        Me.btnAsign.Text = "Asignar"
        Me.btnAsign.UseVisualStyleBackColor = False
        '
        'cboGeofenceToAsign
        '
        Me.cboGeofenceToAsign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGeofenceToAsign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGeofenceToAsign.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGeofenceToAsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGeofenceToAsign.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGeofenceToAsign.ForeColor = System.Drawing.Color.Black
        Me.cboGeofenceToAsign.FormattingEnabled = True
        Me.cboGeofenceToAsign.HintText = "Hint Text"
        Me.cboGeofenceToAsign.HintTextColor = System.Drawing.Color.Gray
        Me.cboGeofenceToAsign.HintTextEnabled = False
        Me.cboGeofenceToAsign.Location = New System.Drawing.Point(761, 18)
        Me.cboGeofenceToAsign.Name = "cboGeofenceToAsign"
        Me.cboGeofenceToAsign.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboGeofenceToAsign.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboGeofenceToAsign.Size = New System.Drawing.Size(175, 22)
        Me.cboGeofenceToAsign.TabIndex = 7
        '
        'cboVehicleToAsign
        '
        Me.cboVehicleToAsign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVehicleToAsign.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVehicleToAsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicleToAsign.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleToAsign.ForeColor = System.Drawing.Color.Black
        Me.cboVehicleToAsign.FormattingEnabled = True
        Me.cboVehicleToAsign.HintText = "Hint Text"
        Me.cboVehicleToAsign.HintTextColor = System.Drawing.Color.Gray
        Me.cboVehicleToAsign.HintTextEnabled = False
        Me.cboVehicleToAsign.Location = New System.Drawing.Point(447, 18)
        Me.cboVehicleToAsign.Name = "cboVehicleToAsign"
        Me.cboVehicleToAsign.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboVehicleToAsign.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboVehicleToAsign.Size = New System.Drawing.Size(244, 22)
        Me.cboVehicleToAsign.TabIndex = 8
        '
        'cboClientToAsign
        '
        Me.cboClientToAsign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClientToAsign.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClientToAsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClientToAsign.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClientToAsign.ForeColor = System.Drawing.Color.Black
        Me.cboClientToAsign.FormattingEnabled = True
        Me.cboClientToAsign.HintText = "Hint Text"
        Me.cboClientToAsign.HintTextColor = System.Drawing.Color.Gray
        Me.cboClientToAsign.HintTextEnabled = False
        Me.cboClientToAsign.Location = New System.Drawing.Point(57, 18)
        Me.cboClientToAsign.Name = "cboClientToAsign"
        Me.cboClientToAsign.OnFocusBackColor = System.Drawing.Color.Gold
        Me.cboClientToAsign.OnLeaveBackColor = System.Drawing.Color.White
        Me.cboClientToAsign.Size = New System.Drawing.Size(323, 22)
        Me.cboClientToAsign.TabIndex = 9
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(705, 22)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(50, 14)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Geocerca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(393, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Vehículo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cliente"
        '
        'tbarMapAsign
        '
        Me.tbarMapAsign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbarMapAsign.BackColor = System.Drawing.Color.Transparent
        Me.tbarMapAsign.BorderColor = System.Drawing.Color.Transparent
        Me.tbarMapAsign.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbarMapAsign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.tbarMapAsign.IndentHeight = 3
        Me.tbarMapAsign.Location = New System.Drawing.Point(827, 36)
        Me.tbarMapAsign.Maximum = 19
        Me.tbarMapAsign.Minimum = 3
        Me.tbarMapAsign.Name = "tbarMapAsign"
        Me.tbarMapAsign.Size = New System.Drawing.Size(177, 25)
        Me.tbarMapAsign.TabIndex = 28
        Me.tbarMapAsign.TextTickStyle = System.Windows.Forms.TickStyle.None
        Me.tbarMapAsign.TickColor = System.Drawing.Color.Red
        Me.tbarMapAsign.TickHeight = 2
        Me.tbarMapAsign.TrackerColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.tbarMapAsign.TrackerSize = New System.Drawing.Size(16, 16)
        Me.tbarMapAsign.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.tbarMapAsign.TrackLineHeight = 3
        Me.tbarMapAsign.Value = 3
        '
        'btnHybridAsign
        '
        Me.btnHybridAsign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHybridAsign.BackColor = System.Drawing.Color.Transparent
        Me.btnHybridAsign.BackgroundImage = CType(resources.GetObject("btnHybridAsign.BackgroundImage"), System.Drawing.Image)
        Me.btnHybridAsign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHybridAsign.BackgroundOnClick = CType(resources.GetObject("btnHybridAsign.BackgroundOnClick"), System.Drawing.Image)
        Me.btnHybridAsign.BackgroundOnDisabled = CType(resources.GetObject("btnHybridAsign.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnHybridAsign.BackgroundOnHover = CType(resources.GetObject("btnHybridAsign.BackgroundOnHover"), System.Drawing.Image)
        Me.btnHybridAsign.BackgroundOnNormal = CType(resources.GetObject("btnHybridAsign.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnHybridAsign.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnHybridAsign.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnHybridAsign.FlatAppearance.BorderSize = 0
        Me.btnHybridAsign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHybridAsign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHybridAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHybridAsign.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHybridAsign.Location = New System.Drawing.Point(947, 6)
        Me.btnHybridAsign.Name = "btnHybridAsign"
        Me.btnHybridAsign.Size = New System.Drawing.Size(54, 25)
        Me.btnHybridAsign.TabIndex = 25
        Me.btnHybridAsign.Text = "Híbrido"
        Me.btnHybridAsign.UseVisualStyleBackColor = False
        '
        'btnSatteliteAsign
        '
        Me.btnSatteliteAsign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSatteliteAsign.BackColor = System.Drawing.Color.Transparent
        Me.btnSatteliteAsign.BackgroundImage = CType(resources.GetObject("btnSatteliteAsign.BackgroundImage"), System.Drawing.Image)
        Me.btnSatteliteAsign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSatteliteAsign.BackgroundOnClick = CType(resources.GetObject("btnSatteliteAsign.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSatteliteAsign.BackgroundOnDisabled = CType(resources.GetObject("btnSatteliteAsign.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSatteliteAsign.BackgroundOnHover = CType(resources.GetObject("btnSatteliteAsign.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSatteliteAsign.BackgroundOnNormal = CType(resources.GetObject("btnSatteliteAsign.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSatteliteAsign.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSatteliteAsign.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnSatteliteAsign.FlatAppearance.BorderSize = 0
        Me.btnSatteliteAsign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSatteliteAsign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSatteliteAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSatteliteAsign.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSatteliteAsign.Location = New System.Drawing.Point(887, 6)
        Me.btnSatteliteAsign.Name = "btnSatteliteAsign"
        Me.btnSatteliteAsign.Size = New System.Drawing.Size(54, 25)
        Me.btnSatteliteAsign.TabIndex = 26
        Me.btnSatteliteAsign.Text = "Satélite"
        Me.btnSatteliteAsign.UseVisualStyleBackColor = False
        '
        'btnMapAsign
        '
        Me.btnMapAsign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMapAsign.BackColor = System.Drawing.Color.Transparent
        Me.btnMapAsign.BackgroundImage = CType(resources.GetObject("btnMapAsign.BackgroundImage"), System.Drawing.Image)
        Me.btnMapAsign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMapAsign.BackgroundOnClick = CType(resources.GetObject("btnMapAsign.BackgroundOnClick"), System.Drawing.Image)
        Me.btnMapAsign.BackgroundOnDisabled = CType(resources.GetObject("btnMapAsign.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnMapAsign.BackgroundOnHover = CType(resources.GetObject("btnMapAsign.BackgroundOnHover"), System.Drawing.Image)
        Me.btnMapAsign.BackgroundOnNormal = CType(resources.GetObject("btnMapAsign.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnMapAsign.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnMapAsign.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnMapAsign.FlatAppearance.BorderSize = 0
        Me.btnMapAsign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMapAsign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMapAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMapAsign.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapAsign.Location = New System.Drawing.Point(827, 6)
        Me.btnMapAsign.Name = "btnMapAsign"
        Me.btnMapAsign.Size = New System.Drawing.Size(54, 25)
        Me.btnMapAsign.TabIndex = 27
        Me.btnMapAsign.Text = "Mapa"
        Me.btnMapAsign.UseVisualStyleBackColor = False
        '
        'mapAsigns
        '
        Me.mapAsigns.Bearing = 0!
        Me.mapAsigns.CanDragMap = True
        Me.mapAsigns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mapAsigns.EmptyTileColor = System.Drawing.Color.Navy
        Me.mapAsigns.GrayScaleMode = False
        Me.mapAsigns.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.mapAsigns.LevelsKeepInMemmory = 5
        Me.mapAsigns.Location = New System.Drawing.Point(0, 0)
        Me.mapAsigns.MarkersEnabled = True
        Me.mapAsigns.MaxZoom = 19
        Me.mapAsigns.MinZoom = 3
        Me.mapAsigns.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.mapAsigns.Name = "mapAsigns"
        Me.mapAsigns.NegativeMode = False
        Me.mapAsigns.PolygonsEnabled = True
        Me.mapAsigns.RetryLoadTile = 0
        Me.mapAsigns.RoutesEnabled = True
        Me.mapAsigns.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.mapAsigns.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.mapAsigns.ShowTileGridLines = False
        Me.mapAsigns.Size = New System.Drawing.Size(1007, 329)
        Me.mapAsigns.TabIndex = 0
        Me.mapAsigns.Zoom = 12.0R
        '
        'dgvAsigns_geofence_id
        '
        Me.dgvAsigns_geofence_id.HeaderText = "ID GEOCERCA"
        Me.dgvAsigns_geofence_id.Name = "dgvAsigns_geofence_id"
        Me.dgvAsigns_geofence_id.ReadOnly = True
        Me.dgvAsigns_geofence_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_geofence_id.Visible = False
        Me.dgvAsigns_geofence_id.Width = 84
        '
        'dgvAsigns_vehicle_id
        '
        Me.dgvAsigns_vehicle_id.HeaderText = "ID VEHICULO"
        Me.dgvAsigns_vehicle_id.Name = "dgvAsigns_vehicle_id"
        Me.dgvAsigns_vehicle_id.ReadOnly = True
        Me.dgvAsigns_vehicle_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_vehicle_id.Visible = False
        Me.dgvAsigns_vehicle_id.Width = 82
        '
        'dgvAsigns_client_id
        '
        Me.dgvAsigns_client_id.HeaderText = "ID CLIENTE"
        Me.dgvAsigns_client_id.Name = "dgvAsigns_client_id"
        Me.dgvAsigns_client_id.ReadOnly = True
        Me.dgvAsigns_client_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_client_id.Visible = False
        Me.dgvAsigns_client_id.Width = 73
        '
        'dgvAsigns_geofence_name
        '
        Me.dgvAsigns_geofence_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvAsigns_geofence_name.HeaderText = "GEOCERCA"
        Me.dgvAsigns_geofence_name.Name = "dgvAsigns_geofence_name"
        Me.dgvAsigns_geofence_name.ReadOnly = True
        Me.dgvAsigns_geofence_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvAsigns_color
        '
        Me.dgvAsigns_color.HeaderText = "COLOR"
        Me.dgvAsigns_color.Name = "dgvAsigns_color"
        Me.dgvAsigns_color.ReadOnly = True
        Me.dgvAsigns_color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_color.Width = 45
        '
        'dgvAsigns_year
        '
        Me.dgvAsigns_year.HeaderText = "AÑO"
        Me.dgvAsigns_year.Name = "dgvAsigns_year"
        Me.dgvAsigns_year.ReadOnly = True
        Me.dgvAsigns_year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_year.Width = 33
        '
        'dgvAsigns_type
        '
        Me.dgvAsigns_type.HeaderText = "TIPO"
        Me.dgvAsigns_type.Name = "dgvAsigns_type"
        Me.dgvAsigns_type.ReadOnly = True
        Me.dgvAsigns_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_type.Width = 35
        '
        'dgvAsigns_model
        '
        Me.dgvAsigns_model.HeaderText = "MODELO"
        Me.dgvAsigns_model.Name = "dgvAsigns_model"
        Me.dgvAsigns_model.ReadOnly = True
        Me.dgvAsigns_model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_model.Width = 55
        '
        'dgvAsigns_brand
        '
        Me.dgvAsigns_brand.HeaderText = "MARCA"
        Me.dgvAsigns_brand.Name = "dgvAsigns_brand"
        Me.dgvAsigns_brand.ReadOnly = True
        Me.dgvAsigns_brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_brand.Width = 48
        '
        'dgvAsigns_license_plate
        '
        Me.dgvAsigns_license_plate.HeaderText = "MATRÍCULA"
        Me.dgvAsigns_license_plate.Name = "dgvAsigns_license_plate"
        Me.dgvAsigns_license_plate.ReadOnly = True
        Me.dgvAsigns_license_plate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvAsigns_license_plate.Width = 72
        '
        'bgwSearchAsigns
        '
        Me.bgwSearchAsigns.WorkerReportsProgress = True
        Me.bgwSearchAsigns.WorkerSupportsCancellation = True
        '
        'bgwUnAsigning
        '
        Me.bgwUnAsigning.WorkerReportsProgress = True
        Me.bgwUnAsigning.WorkerSupportsCancellation = True
        '
        'bgwAsigning
        '
        Me.bgwAsigning.WorkerReportsProgress = True
        Me.bgwAsigning.WorkerSupportsCancellation = True
        '
        'bgwGetClients
        '
        Me.bgwGetClients.WorkerReportsProgress = True
        Me.bgwGetClients.WorkerSupportsCancellation = True
        '
        'bgwDeletingGeofences
        '
        Me.bgwDeletingGeofences.WorkerReportsProgress = True
        Me.bgwDeletingGeofences.WorkerSupportsCancellation = True
        '
        'bgwSavingGeofences
        '
        Me.bgwSavingGeofences.WorkerReportsProgress = True
        Me.bgwSavingGeofences.WorkerSupportsCancellation = True
        '
        'bgwGetGeofences
        '
        Me.bgwGetGeofences.WorkerReportsProgress = True
        Me.bgwGetGeofences.WorkerSupportsCancellation = True
        '
        'dgvAsigns
        '
        Me.dgvAsigns.AllowUserToAddRows = False
        Me.dgvAsigns.AllowUserToDeleteRows = False
        Me.dgvAsigns.AllowUserToResizeColumns = False
        Me.dgvAsigns.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        Me.dgvAsigns.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAsigns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAsigns.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAsigns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAsigns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAsigns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsigns.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAsigns.ColumnHeadersHeight = 17
        Me.dgvAsigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAsigns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvAsigns_client_name, Me.dgvAsigns_license_plate, Me.dgvAsigns_brand, Me.dgvAsigns_model, Me.dgvAsigns_type, Me.dgvAsigns_year, Me.dgvAsigns_color, Me.dgvAsigns_geofence_name, Me.dgvAsigns_client_id, Me.dgvAsigns_vehicle_id, Me.dgvAsigns_geofence_id})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsigns.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAsigns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAsigns.EnableHeadersVisualStyles = False
        Me.dgvAsigns.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAsigns.Location = New System.Drawing.Point(0, 0)
        Me.dgvAsigns.MultiSelect = False
        Me.dgvAsigns.Name = "dgvAsigns"
        Me.dgvAsigns.ReadOnly = True
        Me.dgvAsigns.RowHeadersVisible = False
        Me.dgvAsigns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAsigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAsigns.Size = New System.Drawing.Size(1007, 151)
        Me.dgvAsigns.TabIndex = 6
        '
        'splitHorizontalAsign1
        '
        Me.splitHorizontalAsign1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitHorizontalAsign1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitHorizontalAsign1.Location = New System.Drawing.Point(3, 116)
        Me.splitHorizontalAsign1.Name = "splitHorizontalAsign1"
        Me.splitHorizontalAsign1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitHorizontalAsign1.Panel1
        '
        Me.splitHorizontalAsign1.Panel1.Controls.Add(Me.dgvAsigns)
        '
        'splitHorizontalAsign1.Panel2
        '
        Me.splitHorizontalAsign1.Panel2.Controls.Add(Me.tbarMapAsign)
        Me.splitHorizontalAsign1.Panel2.Controls.Add(Me.btnHybridAsign)
        Me.splitHorizontalAsign1.Panel2.Controls.Add(Me.btnSatteliteAsign)
        Me.splitHorizontalAsign1.Panel2.Controls.Add(Me.btnMapAsign)
        Me.splitHorizontalAsign1.Panel2.Controls.Add(Me.mapAsigns)
        Me.splitHorizontalAsign1.Size = New System.Drawing.Size(1011, 492)
        Me.splitHorizontalAsign1.SplitterDistance = 155
        Me.splitHorizontalAsign1.TabIndex = 0
        '
        'gboxGeofenceList
        '
        Me.gboxGeofenceList.Controls.Add(Me.dgvGeofences)
        Me.gboxGeofenceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboxGeofenceList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxGeofenceList.Location = New System.Drawing.Point(0, 0)
        Me.gboxGeofenceList.Name = "gboxGeofenceList"
        Me.gboxGeofenceList.Size = New System.Drawing.Size(1007, 83)
        Me.gboxGeofenceList.TabIndex = 0
        Me.gboxGeofenceList.TabStop = False
        Me.gboxGeofenceList.Text = "Geocercas"
        '
        'dgvGeofences
        '
        Me.dgvGeofences.AllowUserToAddRows = False
        Me.dgvGeofences.AllowUserToDeleteRows = False
        Me.dgvGeofences.AllowUserToResizeColumns = False
        Me.dgvGeofences.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        Me.dgvGeofences.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvGeofences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGeofences.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvGeofences.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGeofences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGeofences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGeofences.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvGeofences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGeofences.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvGeofences_name, Me.dgvGeofences_description, Me.dgvGeofences_asigns, Me.dgvGeofences_status, Me.dgvGeofences_points, Me.dgvGeofences_geofence_id})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGeofences.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvGeofences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGeofences.EnableHeadersVisualStyles = False
        Me.dgvGeofences.GridColor = System.Drawing.SystemColors.Control
        Me.dgvGeofences.Location = New System.Drawing.Point(3, 17)
        Me.dgvGeofences.MultiSelect = False
        Me.dgvGeofences.Name = "dgvGeofences"
        Me.dgvGeofences.ReadOnly = True
        Me.dgvGeofences.RowHeadersVisible = False
        Me.dgvGeofences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGeofences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGeofences.Size = New System.Drawing.Size(1001, 63)
        Me.dgvGeofences.TabIndex = 0
        '
        'dgvGeofences_name
        '
        Me.dgvGeofences_name.HeaderText = "NOMBRE"
        Me.dgvGeofences_name.Name = "dgvGeofences_name"
        Me.dgvGeofences_name.ReadOnly = True
        Me.dgvGeofences_name.Width = 75
        '
        'dgvGeofences_description
        '
        Me.dgvGeofences_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvGeofences_description.HeaderText = "DESCRIPCIÓN"
        Me.dgvGeofences_description.Name = "dgvGeofences_description"
        Me.dgvGeofences_description.ReadOnly = True
        '
        'dgvGeofences_asigns
        '
        Me.dgvGeofences_asigns.HeaderText = "ASIGNACIONES"
        Me.dgvGeofences_asigns.Name = "dgvGeofences_asigns"
        Me.dgvGeofences_asigns.ReadOnly = True
        Me.dgvGeofences_asigns.Width = 108
        '
        'dgvGeofences_status
        '
        Me.dgvGeofences_status.HeaderText = "ESTADO"
        Me.dgvGeofences_status.Name = "dgvGeofences_status"
        Me.dgvGeofences_status.ReadOnly = True
        Me.dgvGeofences_status.Visible = False
        Me.dgvGeofences_status.Width = 82
        '
        'dgvGeofences_points
        '
        Me.dgvGeofences_points.HeaderText = "PUNTOS"
        Me.dgvGeofences_points.Name = "dgvGeofences_points"
        Me.dgvGeofences_points.ReadOnly = True
        Me.dgvGeofences_points.Visible = False
        Me.dgvGeofences_points.Width = 83
        '
        'dgvGeofences_geofence_id
        '
        Me.dgvGeofences_geofence_id.HeaderText = "ID GEOCERCA"
        Me.dgvGeofences_geofence_id.Name = "dgvGeofences_geofence_id"
        Me.dgvGeofences_geofence_id.ReadOnly = True
        Me.dgvGeofences_geofence_id.Visible = False
        Me.dgvGeofences_geofence_id.Width = 116
        '
        'btnHeaderPanel2Collapsing
        '
        Me.btnHeaderPanel2Collapsing.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHeaderPanel2Collapsing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHeaderPanel2Collapsing.FlatAppearance.BorderSize = 0
        Me.btnHeaderPanel2Collapsing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHeaderPanel2Collapsing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHeaderPanel2Collapsing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeaderPanel2Collapsing.Location = New System.Drawing.Point(973, 94)
        Me.btnHeaderPanel2Collapsing.Name = "btnHeaderPanel2Collapsing"
        Me.btnHeaderPanel2Collapsing.Size = New System.Drawing.Size(28, 25)
        Me.btnHeaderPanel2Collapsing.TabIndex = 17
        Me.btnHeaderPanel2Collapsing.UseVisualStyleBackColor = True
        '
        'lblGeofenceStatus
        '
        Me.lblGeofenceStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGeofenceStatus.BackColor = System.Drawing.Color.LightCoral
        Me.lblGeofenceStatus.Enabled = False
        Me.lblGeofenceStatus.Location = New System.Drawing.Point(83, 65)
        Me.lblGeofenceStatus.Name = "lblGeofenceStatus"
        Me.lblGeofenceStatus.Size = New System.Drawing.Size(918, 19)
        Me.lblGeofenceStatus.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'btnCancelGeofence
        '
        Me.btnCancelGeofence.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelGeofence.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelGeofence.BackgroundImage = CType(resources.GetObject("btnCancelGeofence.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelGeofence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelGeofence.BackgroundOnClick = CType(resources.GetObject("btnCancelGeofence.BackgroundOnClick"), System.Drawing.Image)
        Me.btnCancelGeofence.BackgroundOnDisabled = CType(resources.GetObject("btnCancelGeofence.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnCancelGeofence.BackgroundOnHover = CType(resources.GetObject("btnCancelGeofence.BackgroundOnHover"), System.Drawing.Image)
        Me.btnCancelGeofence.BackgroundOnNormal = CType(resources.GetObject("btnCancelGeofence.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnCancelGeofence.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnCancelGeofence.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnCancelGeofence.Enabled = False
        Me.btnCancelGeofence.FlatAppearance.BorderSize = 0
        Me.btnCancelGeofence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelGeofence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelGeofence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelGeofence.ForeColor = System.Drawing.Color.Black
        Me.btnCancelGeofence.Location = New System.Drawing.Point(660, 86)
        Me.btnCancelGeofence.Name = "btnCancelGeofence"
        Me.btnCancelGeofence.Size = New System.Drawing.Size(75, 25)
        Me.btnCancelGeofence.TabIndex = 15
        Me.btnCancelGeofence.Text = "Cancelar"
        Me.btnCancelGeofence.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción"
        '
        'splitHeader
        '
        Me.splitHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitHeader.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitHeader.IsSplitterFixed = True
        Me.splitHeader.Location = New System.Drawing.Point(0, 0)
        Me.splitHeader.Name = "splitHeader"
        Me.splitHeader.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitHeader.Panel1
        '
        Me.splitHeader.Panel1.Controls.Add(Me.gboxGeofenceMantainer)
        Me.splitHeader.Panel1MinSize = 115
        '
        'splitHeader.Panel2
        '
        Me.splitHeader.Panel2.Controls.Add(Me.gboxGeofenceList)
        Me.splitHeader.Size = New System.Drawing.Size(1011, 206)
        Me.splitHeader.SplitterDistance = 115
        Me.splitHeader.TabIndex = 17
        '
        'gboxGeofenceMantainer
        '
        Me.gboxGeofenceMantainer.Controls.Add(Me.btnHeaderPanel2Collapsing)
        Me.gboxGeofenceMantainer.Controls.Add(Me.lblGeofenceStatus)
        Me.gboxGeofenceMantainer.Controls.Add(Me.Label1)
        Me.gboxGeofenceMantainer.Controls.Add(Me.btnCancelGeofence)
        Me.gboxGeofenceMantainer.Controls.Add(Me.Label2)
        Me.gboxGeofenceMantainer.Controls.Add(Me.btnDeleteGeofence)
        Me.gboxGeofenceMantainer.Controls.Add(Me.txtName)
        Me.gboxGeofenceMantainer.Controls.Add(Me.btnSaveGeofence)
        Me.gboxGeofenceMantainer.Controls.Add(Me.txtDescription)
        Me.gboxGeofenceMantainer.Controls.Add(Me.btnEditGeofence)
        Me.gboxGeofenceMantainer.Controls.Add(Me.cboxGeofenceStatus)
        Me.gboxGeofenceMantainer.Controls.Add(Me.btnNewGeofence)
        Me.gboxGeofenceMantainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboxGeofenceMantainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gboxGeofenceMantainer.Location = New System.Drawing.Point(0, 0)
        Me.gboxGeofenceMantainer.Name = "gboxGeofenceMantainer"
        Me.gboxGeofenceMantainer.Size = New System.Drawing.Size(1007, 111)
        Me.gboxGeofenceMantainer.TabIndex = 17
        Me.gboxGeofenceMantainer.TabStop = False
        Me.gboxGeofenceMantainer.Text = "Mantenedor"
        '
        'btnDeleteGeofence
        '
        Me.btnDeleteGeofence.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeleteGeofence.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteGeofence.BackgroundImage = CType(resources.GetObject("btnDeleteGeofence.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteGeofence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteGeofence.BackgroundOnClick = CType(resources.GetObject("btnDeleteGeofence.BackgroundOnClick"), System.Drawing.Image)
        Me.btnDeleteGeofence.BackgroundOnDisabled = CType(resources.GetObject("btnDeleteGeofence.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnDeleteGeofence.BackgroundOnHover = CType(resources.GetObject("btnDeleteGeofence.BackgroundOnHover"), System.Drawing.Image)
        Me.btnDeleteGeofence.BackgroundOnNormal = CType(resources.GetObject("btnDeleteGeofence.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnDeleteGeofence.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnDeleteGeofence.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnDeleteGeofence.Enabled = False
        Me.btnDeleteGeofence.FlatAppearance.BorderSize = 0
        Me.btnDeleteGeofence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteGeofence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteGeofence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteGeofence.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteGeofence.Location = New System.Drawing.Point(563, 86)
        Me.btnDeleteGeofence.Name = "btnDeleteGeofence"
        Me.btnDeleteGeofence.Size = New System.Drawing.Size(75, 25)
        Me.btnDeleteGeofence.TabIndex = 14
        Me.btnDeleteGeofence.Text = "Eliminar"
        Me.btnDeleteGeofence.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HintText = "Hint Text"
        Me.txtName.HintTextColor = System.Drawing.Color.Gray
        Me.txtName.HintTextEnabled = False
        Me.txtName.Location = New System.Drawing.Point(69, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtName.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtName.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtName.Size = New System.Drawing.Size(932, 21)
        Me.txtName.TabIndex = 1
        '
        'btnSaveGeofence
        '
        Me.btnSaveGeofence.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveGeofence.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveGeofence.BackgroundImage = CType(resources.GetObject("btnSaveGeofence.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveGeofence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveGeofence.BackgroundOnClick = CType(resources.GetObject("btnSaveGeofence.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSaveGeofence.BackgroundOnDisabled = CType(resources.GetObject("btnSaveGeofence.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSaveGeofence.BackgroundOnHover = CType(resources.GetObject("btnSaveGeofence.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSaveGeofence.BackgroundOnNormal = CType(resources.GetObject("btnSaveGeofence.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSaveGeofence.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSaveGeofence.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnSaveGeofence.Enabled = False
        Me.btnSaveGeofence.FlatAppearance.BorderSize = 0
        Me.btnSaveGeofence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveGeofence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveGeofence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveGeofence.ForeColor = System.Drawing.Color.Black
        Me.btnSaveGeofence.Location = New System.Drawing.Point(466, 86)
        Me.btnSaveGeofence.Name = "btnSaveGeofence"
        Me.btnSaveGeofence.Size = New System.Drawing.Size(75, 25)
        Me.btnSaveGeofence.TabIndex = 13
        Me.btnSaveGeofence.Text = "Guardar"
        Me.btnSaveGeofence.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.HintText = "Hint Text"
        Me.txtDescription.HintTextColor = System.Drawing.Color.Gray
        Me.txtDescription.HintTextEnabled = False
        Me.txtDescription.Location = New System.Drawing.Point(93, 40)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtDescription.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtDescription.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtDescription.Size = New System.Drawing.Size(908, 21)
        Me.txtDescription.TabIndex = 1
        '
        'btnEditGeofence
        '
        Me.btnEditGeofence.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditGeofence.BackColor = System.Drawing.Color.Transparent
        Me.btnEditGeofence.BackgroundImage = CType(resources.GetObject("btnEditGeofence.BackgroundImage"), System.Drawing.Image)
        Me.btnEditGeofence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditGeofence.BackgroundOnClick = CType(resources.GetObject("btnEditGeofence.BackgroundOnClick"), System.Drawing.Image)
        Me.btnEditGeofence.BackgroundOnDisabled = CType(resources.GetObject("btnEditGeofence.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnEditGeofence.BackgroundOnHover = CType(resources.GetObject("btnEditGeofence.BackgroundOnHover"), System.Drawing.Image)
        Me.btnEditGeofence.BackgroundOnNormal = CType(resources.GetObject("btnEditGeofence.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnEditGeofence.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnEditGeofence.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnEditGeofence.Enabled = False
        Me.btnEditGeofence.FlatAppearance.BorderSize = 0
        Me.btnEditGeofence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditGeofence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditGeofence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditGeofence.ForeColor = System.Drawing.Color.Black
        Me.btnEditGeofence.Location = New System.Drawing.Point(369, 86)
        Me.btnEditGeofence.Name = "btnEditGeofence"
        Me.btnEditGeofence.Size = New System.Drawing.Size(75, 25)
        Me.btnEditGeofence.TabIndex = 12
        Me.btnEditGeofence.Text = "Editar"
        Me.btnEditGeofence.UseVisualStyleBackColor = False
        '
        'cboxGeofenceStatus
        '
        Me.cboxGeofenceStatus.AutoSize = True
        Me.cboxGeofenceStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cboxGeofenceStatus.Enabled = False
        Me.cboxGeofenceStatus.ForeColor = System.Drawing.Color.Black
        Me.cboxGeofenceStatus.Location = New System.Drawing.Point(12, 66)
        Me.cboxGeofenceStatus.Name = "cboxGeofenceStatus"
        Me.cboxGeofenceStatus.Size = New System.Drawing.Size(60, 18)
        Me.cboxGeofenceStatus.TabIndex = 2
        Me.cboxGeofenceStatus.Text = "Estado"
        Me.cboxGeofenceStatus.UseVisualStyleBackColor = True
        '
        'btnNewGeofence
        '
        Me.btnNewGeofence.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNewGeofence.BackColor = System.Drawing.Color.Transparent
        Me.btnNewGeofence.BackgroundImage = CType(resources.GetObject("btnNewGeofence.BackgroundImage"), System.Drawing.Image)
        Me.btnNewGeofence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewGeofence.BackgroundOnClick = CType(resources.GetObject("btnNewGeofence.BackgroundOnClick"), System.Drawing.Image)
        Me.btnNewGeofence.BackgroundOnDisabled = CType(resources.GetObject("btnNewGeofence.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnNewGeofence.BackgroundOnHover = CType(resources.GetObject("btnNewGeofence.BackgroundOnHover"), System.Drawing.Image)
        Me.btnNewGeofence.BackgroundOnNormal = CType(resources.GetObject("btnNewGeofence.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnNewGeofence.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnNewGeofence.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnNewGeofence.FlatAppearance.BorderSize = 0
        Me.btnNewGeofence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNewGeofence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNewGeofence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewGeofence.ForeColor = System.Drawing.Color.Black
        Me.btnNewGeofence.Location = New System.Drawing.Point(272, 86)
        Me.btnNewGeofence.Name = "btnNewGeofence"
        Me.btnNewGeofence.Size = New System.Drawing.Size(75, 25)
        Me.btnNewGeofence.TabIndex = 11
        Me.btnNewGeofence.Text = "Nuevo"
        Me.btnNewGeofence.UseVisualStyleBackColor = False
        '
        'splitHorizontal
        '
        Me.splitHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitHorizontal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitHorizontal.Location = New System.Drawing.Point(3, 3)
        Me.splitHorizontal.Name = "splitHorizontal"
        Me.splitHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitHorizontal.Panel1
        '
        Me.splitHorizontal.Panel1.Controls.Add(Me.splitHeader)
        '
        'splitHorizontal.Panel2
        '
        Me.splitHorizontal.Panel2.Controls.Add(Me.tbarMapZoom)
        Me.splitHorizontal.Panel2.Controls.Add(Me.btnHybrid)
        Me.splitHorizontal.Panel2.Controls.Add(Me.btnSatellite)
        Me.splitHorizontal.Panel2.Controls.Add(Me.btnRemoveLast)
        Me.splitHorizontal.Panel2.Controls.Add(Me.btnClean)
        Me.splitHorizontal.Panel2.Controls.Add(Me.btnDraw)
        Me.splitHorizontal.Panel2.Controls.Add(Me.btnMap)
        Me.splitHorizontal.Panel2.Controls.Add(Me.mapMainGeofence)
        Me.splitHorizontal.Panel2.Controls.Add(Me.panelLoading)
        Me.splitHorizontal.Size = New System.Drawing.Size(1011, 605)
        Me.splitHorizontal.SplitterDistance = 206
        Me.splitHorizontal.TabIndex = 0
        '
        'tbarMapZoom
        '
        Me.tbarMapZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbarMapZoom.BackColor = System.Drawing.Color.Transparent
        Me.tbarMapZoom.BorderColor = System.Drawing.Color.Transparent
        Me.tbarMapZoom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbarMapZoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.tbarMapZoom.IndentHeight = 3
        Me.tbarMapZoom.Location = New System.Drawing.Point(765, 37)
        Me.tbarMapZoom.Maximum = 19
        Me.tbarMapZoom.Minimum = 3
        Me.tbarMapZoom.Name = "tbarMapZoom"
        Me.tbarMapZoom.Size = New System.Drawing.Size(237, 25)
        Me.tbarMapZoom.TabIndex = 24
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
        Me.btnHybrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHybrid.BackColor = System.Drawing.Color.Transparent
        Me.btnHybrid.BackgroundImage = CType(resources.GetObject("btnHybrid.BackgroundImage"), System.Drawing.Image)
        Me.btnHybrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHybrid.BackgroundOnClick = CType(resources.GetObject("btnHybrid.BackgroundOnClick"), System.Drawing.Image)
        Me.btnHybrid.BackgroundOnDisabled = CType(resources.GetObject("btnHybrid.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnHybrid.BackgroundOnHover = CType(resources.GetObject("btnHybrid.BackgroundOnHover"), System.Drawing.Image)
        Me.btnHybrid.BackgroundOnNormal = CType(resources.GetObject("btnHybrid.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnHybrid.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnHybrid.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnHybrid.FlatAppearance.BorderSize = 0
        Me.btnHybrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHybrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHybrid.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHybrid.Location = New System.Drawing.Point(947, 8)
        Me.btnHybrid.Name = "btnHybrid"
        Me.btnHybrid.Size = New System.Drawing.Size(54, 25)
        Me.btnHybrid.TabIndex = 21
        Me.btnHybrid.Text = "Híbrido"
        Me.btnHybrid.UseVisualStyleBackColor = False
        '
        'btnSatellite
        '
        Me.btnSatellite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSatellite.BackColor = System.Drawing.Color.Transparent
        Me.btnSatellite.BackgroundImage = CType(resources.GetObject("btnSatellite.BackgroundImage"), System.Drawing.Image)
        Me.btnSatellite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSatellite.BackgroundOnClick = CType(resources.GetObject("btnSatellite.BackgroundOnClick"), System.Drawing.Image)
        Me.btnSatellite.BackgroundOnDisabled = CType(resources.GetObject("btnSatellite.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnSatellite.BackgroundOnHover = CType(resources.GetObject("btnSatellite.BackgroundOnHover"), System.Drawing.Image)
        Me.btnSatellite.BackgroundOnNormal = CType(resources.GetObject("btnSatellite.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnSatellite.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnSatellite.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnSatellite.FlatAppearance.BorderSize = 0
        Me.btnSatellite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSatellite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSatellite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSatellite.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSatellite.Location = New System.Drawing.Point(887, 8)
        Me.btnSatellite.Name = "btnSatellite"
        Me.btnSatellite.Size = New System.Drawing.Size(54, 25)
        Me.btnSatellite.TabIndex = 22
        Me.btnSatellite.Text = "Satélite"
        Me.btnSatellite.UseVisualStyleBackColor = False
        '
        'btnRemoveLast
        '
        Me.btnRemoveLast.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveLast.BackgroundImage = CType(resources.GetObject("btnRemoveLast.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoveLast.BackgroundOnClick = CType(resources.GetObject("btnRemoveLast.BackgroundOnClick"), System.Drawing.Image)
        Me.btnRemoveLast.BackgroundOnDisabled = CType(resources.GetObject("btnRemoveLast.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnRemoveLast.BackgroundOnHover = CType(resources.GetObject("btnRemoveLast.BackgroundOnHover"), System.Drawing.Image)
        Me.btnRemoveLast.BackgroundOnNormal = CType(resources.GetObject("btnRemoveLast.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnRemoveLast.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnRemoveLast.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnRemoveLast.Enabled = False
        Me.btnRemoveLast.FlatAppearance.BorderSize = 0
        Me.btnRemoveLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemoveLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveLast.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveLast.Location = New System.Drawing.Point(124, 8)
        Me.btnRemoveLast.Name = "btnRemoveLast"
        Me.btnRemoveLast.Size = New System.Drawing.Size(54, 25)
        Me.btnRemoveLast.TabIndex = 23
        Me.btnRemoveLast.Text = "Quitar"
        Me.btnRemoveLast.UseVisualStyleBackColor = False
        '
        'btnClean
        '
        Me.btnClean.BackColor = System.Drawing.Color.Transparent
        Me.btnClean.BackgroundImage = CType(resources.GetObject("btnClean.BackgroundImage"), System.Drawing.Image)
        Me.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClean.BackgroundOnClick = CType(resources.GetObject("btnClean.BackgroundOnClick"), System.Drawing.Image)
        Me.btnClean.BackgroundOnDisabled = CType(resources.GetObject("btnClean.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnClean.BackgroundOnHover = CType(resources.GetObject("btnClean.BackgroundOnHover"), System.Drawing.Image)
        Me.btnClean.BackgroundOnNormal = CType(resources.GetObject("btnClean.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnClean.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnClean.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnClean.Enabled = False
        Me.btnClean.FlatAppearance.BorderSize = 0
        Me.btnClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClean.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClean.Location = New System.Drawing.Point(64, 8)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(54, 25)
        Me.btnClean.TabIndex = 23
        Me.btnClean.Text = "Limpiar"
        Me.btnClean.UseVisualStyleBackColor = False
        '
        'btnDraw
        '
        Me.btnDraw.BackColor = System.Drawing.Color.Transparent
        Me.btnDraw.BackgroundImage = CType(resources.GetObject("btnDraw.BackgroundImage"), System.Drawing.Image)
        Me.btnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDraw.BackgroundOnClick = CType(resources.GetObject("btnDraw.BackgroundOnClick"), System.Drawing.Image)
        Me.btnDraw.BackgroundOnDisabled = CType(resources.GetObject("btnDraw.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnDraw.BackgroundOnHover = CType(resources.GetObject("btnDraw.BackgroundOnHover"), System.Drawing.Image)
        Me.btnDraw.BackgroundOnNormal = CType(resources.GetObject("btnDraw.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnDraw.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnDraw.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleRed
        Me.btnDraw.Enabled = False
        Me.btnDraw.FlatAppearance.BorderSize = 0
        Me.btnDraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDraw.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDraw.Location = New System.Drawing.Point(4, 8)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(54, 25)
        Me.btnDraw.TabIndex = 23
        Me.btnDraw.Text = "Dibujar"
        Me.btnDraw.UseVisualStyleBackColor = False
        '
        'btnMap
        '
        Me.btnMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMap.BackColor = System.Drawing.Color.Transparent
        Me.btnMap.BackgroundImage = CType(resources.GetObject("btnMap.BackgroundImage"), System.Drawing.Image)
        Me.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMap.BackgroundOnClick = CType(resources.GetObject("btnMap.BackgroundOnClick"), System.Drawing.Image)
        Me.btnMap.BackgroundOnDisabled = CType(resources.GetObject("btnMap.BackgroundOnDisabled"), System.Drawing.Image)
        Me.btnMap.BackgroundOnHover = CType(resources.GetObject("btnMap.BackgroundOnHover"), System.Drawing.Image)
        Me.btnMap.BackgroundOnNormal = CType(resources.GetObject("btnMap.BackgroundOnNormal"), System.Drawing.Image)
        Me.btnMap.BackgroundStyle = ZUControls.ZUButton.styleType.Native
        Me.btnMap.ButtonStyle = ZUControls.ZUButton.buttonStyles.StyleOrange
        Me.btnMap.FlatAppearance.BorderSize = 0
        Me.btnMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMap.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMap.Location = New System.Drawing.Point(827, 8)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(54, 25)
        Me.btnMap.TabIndex = 23
        Me.btnMap.Text = "Mapa"
        Me.btnMap.UseVisualStyleBackColor = False
        '
        'mapMainGeofence
        '
        Me.mapMainGeofence.Bearing = 0!
        Me.mapMainGeofence.CanDragMap = True
        Me.mapMainGeofence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mapMainGeofence.EmptyTileColor = System.Drawing.Color.Navy
        Me.mapMainGeofence.GrayScaleMode = False
        Me.mapMainGeofence.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.mapMainGeofence.LevelsKeepInMemmory = 5
        Me.mapMainGeofence.Location = New System.Drawing.Point(0, 0)
        Me.mapMainGeofence.MarkersEnabled = True
        Me.mapMainGeofence.MaxZoom = 19
        Me.mapMainGeofence.MinZoom = 3
        Me.mapMainGeofence.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.mapMainGeofence.Name = "mapMainGeofence"
        Me.mapMainGeofence.NegativeMode = False
        Me.mapMainGeofence.PolygonsEnabled = True
        Me.mapMainGeofence.RetryLoadTile = 0
        Me.mapMainGeofence.RoutesEnabled = True
        Me.mapMainGeofence.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.mapMainGeofence.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.mapMainGeofence.ShowTileGridLines = False
        Me.mapMainGeofence.Size = New System.Drawing.Size(1007, 369)
        Me.mapMainGeofence.TabIndex = 20
        Me.mapMainGeofence.Zoom = 12.0R
        '
        'panelLoading
        '
        Me.panelLoading.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelLoading.Controls.Add(Me.lblLoading)
        Me.panelLoading.Controls.Add(Me.pboxLoading)
        Me.panelLoading.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelLoading.Location = New System.Drawing.Point(0, 369)
        Me.panelLoading.Name = "panelLoading"
        Me.panelLoading.Size = New System.Drawing.Size(1007, 22)
        Me.panelLoading.TabIndex = 19
        Me.panelLoading.Visible = False
        '
        'lblLoading
        '
        Me.lblLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoading.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLoading.Location = New System.Drawing.Point(0, 0)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(977, 22)
        Me.lblLoading.TabIndex = 16
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboxLoading
        '
        Me.pboxLoading.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pboxLoading.Dock = System.Windows.Forms.DockStyle.Right
        Me.pboxLoading.Location = New System.Drawing.Point(977, 0)
        Me.pboxLoading.Name = "pboxLoading"
        Me.pboxLoading.Size = New System.Drawing.Size(30, 22)
        Me.pboxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLoading.TabIndex = 15
        Me.pboxLoading.TabStop = False
        '
        'tpageMaintenance
        '
        Me.tpageMaintenance.Controls.Add(Me.splitHorizontal)
        Me.tpageMaintenance.Location = New System.Drawing.Point(4, 26)
        Me.tpageMaintenance.Name = "tpageMaintenance"
        Me.tpageMaintenance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpageMaintenance.Size = New System.Drawing.Size(1017, 611)
        Me.tpageMaintenance.TabIndex = 0
        Me.tpageMaintenance.Text = "MANTENIMIENTO"
        Me.tpageMaintenance.UseVisualStyleBackColor = True
        '
        'tabConsole
        '
        Me.tabConsole.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabConsole.Controls.Add(Me.tpageMaintenance)
        Me.tabConsole.Controls.Add(Me.tpageAsigns)
        Me.tabConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabConsole.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabConsole.Location = New System.Drawing.Point(0, 0)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.SelectedIndex = 0
        Me.tabConsole.Size = New System.Drawing.Size(1025, 641)
        Me.tabConsole.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabConsole.TabIndex = 1
        '
        'tpageAsigns
        '
        Me.tpageAsigns.Controls.Add(Me.panelLoadingAsigns)
        Me.tpageAsigns.Controls.Add(Me.splitHorizontalAsign1)
        Me.tpageAsigns.Controls.Add(Me.panelHeader)
        Me.tpageAsigns.Location = New System.Drawing.Point(4, 26)
        Me.tpageAsigns.Name = "tpageAsigns"
        Me.tpageAsigns.Padding = New System.Windows.Forms.Padding(3)
        Me.tpageAsigns.Size = New System.Drawing.Size(1017, 611)
        Me.tpageAsigns.TabIndex = 1
        Me.tpageAsigns.Text = "ASIGNAR"
        Me.tpageAsigns.UseVisualStyleBackColor = True
        '
        'panelLoadingAsigns
        '
        Me.panelLoadingAsigns.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelLoadingAsigns.Controls.Add(Me.lblLoadingAsigns)
        Me.panelLoadingAsigns.Controls.Add(Me.pboxLoadingAsigns)
        Me.panelLoadingAsigns.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelLoadingAsigns.Location = New System.Drawing.Point(3, 586)
        Me.panelLoadingAsigns.Name = "panelLoadingAsigns"
        Me.panelLoadingAsigns.Size = New System.Drawing.Size(1011, 22)
        Me.panelLoadingAsigns.TabIndex = 20
        Me.panelLoadingAsigns.Visible = False
        '
        'lblLoadingAsigns
        '
        Me.lblLoadingAsigns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoadingAsigns.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingAsigns.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLoadingAsigns.Location = New System.Drawing.Point(0, 0)
        Me.lblLoadingAsigns.Name = "lblLoadingAsigns"
        Me.lblLoadingAsigns.Size = New System.Drawing.Size(981, 22)
        Me.lblLoadingAsigns.TabIndex = 16
        Me.lblLoadingAsigns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboxLoadingAsigns
        '
        Me.pboxLoadingAsigns.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pboxLoadingAsigns.Dock = System.Windows.Forms.DockStyle.Right
        Me.pboxLoadingAsigns.Location = New System.Drawing.Point(981, 0)
        Me.pboxLoadingAsigns.Name = "pboxLoadingAsigns"
        Me.pboxLoadingAsigns.Size = New System.Drawing.Size(30, 22)
        Me.pboxLoadingAsigns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLoadingAsigns.TabIndex = 15
        Me.pboxLoadingAsigns.TabStop = False
        '
        'frmGeofences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 641)
        Me.Controls.Add(Me.tabConsole)
        Me.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGeofences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geocercas"
        Me.gboxSearchAsigned.ResumeLayout(False)
        Me.gboxSearchAsigned.PerformLayout()
        Me.panelHeader.ResumeLayout(False)
        Me.gboxAsignGeofence.ResumeLayout(False)
        Me.gboxAsignGeofence.PerformLayout()
        CType(Me.dgvAsigns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorizontalAsign1.Panel1.ResumeLayout(False)
        Me.splitHorizontalAsign1.Panel2.ResumeLayout(False)
        Me.splitHorizontalAsign1.Panel2.PerformLayout()
        CType(Me.splitHorizontalAsign1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorizontalAsign1.ResumeLayout(False)
        Me.gboxGeofenceList.ResumeLayout(False)
        CType(Me.dgvGeofences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHeader.Panel1.ResumeLayout(False)
        Me.splitHeader.Panel2.ResumeLayout(False)
        CType(Me.splitHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHeader.ResumeLayout(False)
        Me.gboxGeofenceMantainer.ResumeLayout(False)
        Me.gboxGeofenceMantainer.PerformLayout()
        Me.splitHorizontal.Panel1.ResumeLayout(False)
        Me.splitHorizontal.Panel2.ResumeLayout(False)
        Me.splitHorizontal.Panel2.PerformLayout()
        CType(Me.splitHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorizontal.ResumeLayout(False)
        Me.panelLoading.ResumeLayout(False)
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpageMaintenance.ResumeLayout(False)
        Me.tabConsole.ResumeLayout(False)
        Me.tpageAsigns.ResumeLayout(False)
        Me.panelLoadingAsigns.ResumeLayout(False)
        CType(Me.pboxLoadingAsigns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAsigns_client_name As DataGridViewTextBoxColumn
    Friend WithEvents gboxSearchAsigned As GroupBox
    Private WithEvents btnUnAsign As ZUControls.ZUButton
    Private WithEvents btnSearchAsigns As ZUControls.ZUButton
    Private WithEvents rbtnSearchByClient As RadioButton
    Private WithEvents cboSearchAsigns As ZUControls.ZUComboBox
    Private WithEvents rbtnSearchByGeofence As RadioButton
    Private WithEvents rbtnSearchAllAsigns As RadioButton
    Friend WithEvents rbtnSearchAsigned As RadioButton
    Friend WithEvents panelHeader As ZUControls.ZUPanel
    Friend WithEvents gboxAsignGeofence As GroupBox
    Friend WithEvents rbtnAsignGeofence As RadioButton
    Private WithEvents btnAsign As ZUControls.ZUButton
    Private WithEvents cboGeofenceToAsign As ZUControls.ZUComboBox
    Private WithEvents cboVehicleToAsign As ZUControls.ZUComboBox
    Private WithEvents cboClientToAsign As ZUControls.ZUComboBox
    Private WithEvents label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents tbarMapAsign As XComponent.SliderBar.ZUTrackBar
    Friend WithEvents btnHybridAsign As ZUControls.ZUButton
    Friend WithEvents btnSatteliteAsign As ZUControls.ZUButton
    Friend WithEvents btnMapAsign As ZUControls.ZUButton
    Friend WithEvents mapAsigns As ZUControls.ZUMapa
    Friend WithEvents dgvAsigns_geofence_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_vehicle_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_client_id As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_geofence_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_color As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_year As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_type As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_model As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_brand As DataGridViewTextBoxColumn
    Friend WithEvents dgvAsigns_license_plate As DataGridViewTextBoxColumn
    Friend WithEvents bgwSearchAsigns As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwUnAsigning As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwAsigning As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGetClients As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwDeletingGeofences As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSavingGeofences As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGetGeofences As System.ComponentModel.BackgroundWorker
    Private WithEvents dgvAsigns As DataGridView
    Friend WithEvents splitHorizontalAsign1 As SplitContainer
    Friend WithEvents gboxGeofenceList As GroupBox
    Friend WithEvents dgvGeofences As DataGridView
    Friend WithEvents dgvGeofences_name As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_description As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_asigns As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_status As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_points As DataGridViewTextBoxColumn
    Friend WithEvents dgvGeofences_geofence_id As DataGridViewTextBoxColumn
    Friend WithEvents btnHeaderPanel2Collapsing As Button
    Friend WithEvents lblGeofenceStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelGeofence As ZUControls.ZUButton
    Friend WithEvents Label2 As Label
    Friend WithEvents splitHeader As SplitContainer
    Friend WithEvents gboxGeofenceMantainer As GroupBox
    Friend WithEvents btnDeleteGeofence As ZUControls.ZUButton
    Friend WithEvents txtName As ZUControls.ZUTextBox
    Friend WithEvents btnSaveGeofence As ZUControls.ZUButton
    Friend WithEvents txtDescription As ZUControls.ZUTextBox
    Friend WithEvents btnEditGeofence As ZUControls.ZUButton
    Friend WithEvents cboxGeofenceStatus As CheckBox
    Friend WithEvents btnNewGeofence As ZUControls.ZUButton
    Friend WithEvents splitHorizontal As SplitContainer
    Friend WithEvents tbarMapZoom As XComponent.SliderBar.ZUTrackBar
    Friend WithEvents btnHybrid As ZUControls.ZUButton
    Friend WithEvents btnSatellite As ZUControls.ZUButton
    Friend WithEvents btnRemoveLast As ZUControls.ZUButton
    Friend WithEvents btnClean As ZUControls.ZUButton
    Friend WithEvents btnDraw As ZUControls.ZUButton
    Friend WithEvents btnMap As ZUControls.ZUButton
    Friend WithEvents mapMainGeofence As ZUControls.ZUMapa
    Friend WithEvents panelLoading As ZUControls.ZUPanel
    Friend WithEvents lblLoading As Label
    Friend WithEvents pboxLoading As PictureBox
    Friend WithEvents tpageMaintenance As TabPage
    Friend WithEvents tabConsole As TabControl
    Friend WithEvents tpageAsigns As TabPage
    Friend WithEvents panelLoadingAsigns As ZUControls.ZUPanel
    Friend WithEvents lblLoadingAsigns As Label
    Friend WithEvents pboxLoadingAsigns As PictureBox
End Class
