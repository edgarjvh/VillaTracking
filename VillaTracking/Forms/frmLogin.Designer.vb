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
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cédula Rif"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Contraseña"
        '
        'pboxLogo
        '
        Me.pboxLogo.Image = Global.VillaTracking.My.Resources.Resources.Logotipo
        Me.pboxLogo.Location = New System.Drawing.Point(28, 3)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(301, 67)
        Me.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLogo.TabIndex = 2
        Me.pboxLogo.TabStop = False
        '
        'txtDni
        '
        Me.txtDni.CaracterDecimal = False
        Me.txtDni.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.HintText = "Hint Text"
        Me.txtDni.HintTextColor = System.Drawing.Color.Gray
        Me.txtDni.HintTextEnabled = False
        Me.txtDni.Location = New System.Drawing.Point(93, 73)
        Me.txtDni.MaxLength = 10
        Me.txtDni.Name = "txtDni"
        Me.txtDni.OnEnterKeyPressed = ZUControls.ZUNumericBox.EnterKeyPressed.doNothing
        Me.txtDni.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtDni.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtDni.Size = New System.Drawing.Size(236, 21)
        Me.txtDni.TabIndex = 0
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.HintText = "Hint Text"
        Me.txtPass.HintTextColor = System.Drawing.Color.Gray
        Me.txtPass.HintTextEnabled = False
        Me.txtPass.Location = New System.Drawing.Point(93, 99)
        Me.txtPass.MaxLength = 20
        Me.txtPass.Name = "txtPass"
        Me.txtPass.OnEnterKeyPressed = ZUControls.ZUTextBox.EnterKeyPressed.doNothing
        Me.txtPass.OnFocusBackColor = System.Drawing.Color.Gold
        Me.txtPass.OnLeaveBackColor = System.Drawing.Color.White
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(236, 21)
        Me.txtPass.TabIndex = 1
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Location = New System.Drawing.Point(0, 159)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(356, 25)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pboxLoading
        '
        Me.pboxLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pboxLoading.Image = Global.VillaTracking.My.Resources.Resources.loading
        Me.pboxLoading.Location = New System.Drawing.Point(335, 159)
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
        Me.btnLogin.Location = New System.Drawing.Point(241, 126)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 30)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Acceder"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 184)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pboxLoading)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.pboxLogo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus)
        Me.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
