<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoster))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpSeason = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.grpTeam = New System.Windows.Forms.GroupBox()
        Me.cmbTeams = New System.Windows.Forms.ComboBox()
        Me.pbField = New System.Windows.Forms.PictureBox()
        Me.grpPlayers = New System.Windows.Forms.GroupBox()
        Me.lblLF = New System.Windows.Forms.Label()
        Me.lblRF = New System.Windows.Forms.Label()
        Me.lblCF = New System.Windows.Forms.Label()
        Me.dgvLF = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlayerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRF = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCF = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv2B = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl2B = New System.Windows.Forms.Label()
        Me.dgvCatch = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCatch = New System.Windows.Forms.Label()
        Me.dgvSS = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSS = New System.Windows.Forms.Label()
        Me.dgv1B = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl1B = New System.Windows.Forms.Label()
        Me.dgv3B = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl3B = New System.Windows.Forms.Label()
        Me.grpOutfielders = New System.Windows.Forms.GroupBox()
        Me.grpInfielders = New System.Windows.Forms.GroupBox()
        Me.grpCatchers = New System.Windows.Forms.GroupBox()
        Me.grpPitchers = New System.Windows.Forms.GroupBox()
        Me.btnPitchers = New System.Windows.Forms.Button()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpSeason.SuspendLayout()
        Me.grpTeam.SuspendLayout()
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlayers.SuspendLayout()
        CType(Me.dgvLF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv3B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPitchers.SuspendLayout()
        Me.grpControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSeason
        '
        Me.grpSeason.Controls.Add(Me.ComboBox5)
        Me.grpSeason.Location = New System.Drawing.Point(24, 12)
        Me.grpSeason.Name = "grpSeason"
        Me.grpSeason.Size = New System.Drawing.Size(201, 68)
        Me.grpSeason.TabIndex = 108
        Me.grpSeason.TabStop = False
        Me.grpSeason.Text = "Season"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(22, 26)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(157, 27)
        Me.ComboBox5.TabIndex = 0
        '
        'grpTeam
        '
        Me.grpTeam.Controls.Add(Me.cmbTeams)
        Me.grpTeam.Location = New System.Drawing.Point(252, 12)
        Me.grpTeam.Name = "grpTeam"
        Me.grpTeam.Size = New System.Drawing.Size(326, 68)
        Me.grpTeam.TabIndex = 109
        Me.grpTeam.TabStop = False
        Me.grpTeam.Text = "Team"
        '
        'cmbTeams
        '
        Me.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeams.FormattingEnabled = True
        Me.cmbTeams.Location = New System.Drawing.Point(24, 26)
        Me.cmbTeams.Name = "cmbTeams"
        Me.cmbTeams.Size = New System.Drawing.Size(278, 27)
        Me.cmbTeams.TabIndex = 0
        '
        'pbField
        '
        Me.pbField.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbField.BackgroundImage = CType(resources.GetObject("pbField.BackgroundImage"), System.Drawing.Image)
        Me.pbField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbField.Location = New System.Drawing.Point(24, 98)
        Me.pbField.Name = "pbField"
        Me.pbField.Size = New System.Drawing.Size(977, 747)
        Me.pbField.TabIndex = 110
        Me.pbField.TabStop = False
        '
        'grpPlayers
        '
        Me.grpPlayers.Controls.Add(Me.grpCatchers)
        Me.grpPlayers.Controls.Add(Me.grpOutfielders)
        Me.grpPlayers.Controls.Add(Me.grpInfielders)
        Me.grpPlayers.Location = New System.Drawing.Point(1019, 12)
        Me.grpPlayers.Name = "grpPlayers"
        Me.grpPlayers.Size = New System.Drawing.Size(432, 833)
        Me.grpPlayers.TabIndex = 111
        Me.grpPlayers.TabStop = False
        Me.grpPlayers.Text = "Players"
        '
        'lblLF
        '
        Me.lblLF.AutoSize = True
        Me.lblLF.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblLF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLF.Location = New System.Drawing.Point(136, 230)
        Me.lblLF.Name = "lblLF"
        Me.lblLF.Size = New System.Drawing.Size(89, 19)
        Me.lblLF.TabIndex = 112
        Me.lblLF.Text = "Left Fielders"
        '
        'lblRF
        '
        Me.lblRF.AutoSize = True
        Me.lblRF.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRF.Location = New System.Drawing.Point(701, 230)
        Me.lblRF.Name = "lblRF"
        Me.lblRF.Size = New System.Drawing.Size(98, 19)
        Me.lblRF.TabIndex = 113
        Me.lblRF.Text = "Right Fielders"
        '
        'lblCF
        '
        Me.lblCF.AutoSize = True
        Me.lblCF.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCF.Location = New System.Drawing.Point(429, 129)
        Me.lblCF.Name = "lblCF"
        Me.lblCF.Size = New System.Drawing.Size(107, 19)
        Me.lblCF.TabIndex = 114
        Me.lblCF.Text = "Center Fielders"
        '
        'dgvLF
        '
        Me.dgvLF.AllowDrop = True
        Me.dgvLF.AllowUserToAddRows = False
        Me.dgvLF.AllowUserToDeleteRows = False
        Me.dgvLF.AllowUserToOrderColumns = True
        Me.dgvLF.AllowUserToResizeColumns = False
        Me.dgvLF.AllowUserToResizeRows = False
        Me.dgvLF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvLF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLF.ColumnHeadersVisible = False
        Me.dgvLF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colPlayerName})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLF.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvLF.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvLF.Location = New System.Drawing.Point(135, 252)
        Me.dgvLF.Name = "dgvLF"
        Me.dgvLF.RowHeadersVisible = False
        Me.dgvLF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvLF.Size = New System.Drawing.Size(190, 85)
        Me.dgvLF.TabIndex = 115
        '
        'colID
        '
        Me.colID.HeaderText = "PlayerID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colID.Visible = False
        '
        'colPlayerName
        '
        Me.colPlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPlayerName.HeaderText = "PlayerName"
        Me.colPlayerName.Name = "colPlayerName"
        Me.colPlayerName.ReadOnly = True
        Me.colPlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dgvRF
        '
        Me.dgvRF.AllowDrop = True
        Me.dgvRF.AllowUserToAddRows = False
        Me.dgvRF.AllowUserToDeleteRows = False
        Me.dgvRF.AllowUserToOrderColumns = True
        Me.dgvRF.AllowUserToResizeColumns = False
        Me.dgvRF.AllowUserToResizeRows = False
        Me.dgvRF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvRF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRF.ColumnHeadersVisible = False
        Me.dgvRF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRF.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRF.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvRF.Location = New System.Drawing.Point(700, 252)
        Me.dgvRF.Name = "dgvRF"
        Me.dgvRF.RowHeadersVisible = False
        Me.dgvRF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRF.Size = New System.Drawing.Size(190, 85)
        Me.dgvRF.TabIndex = 116
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "PlayerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "PlayerName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dgvCF
        '
        Me.dgvCF.AllowDrop = True
        Me.dgvCF.AllowUserToAddRows = False
        Me.dgvCF.AllowUserToDeleteRows = False
        Me.dgvCF.AllowUserToOrderColumns = True
        Me.dgvCF.AllowUserToResizeColumns = False
        Me.dgvCF.AllowUserToResizeRows = False
        Me.dgvCF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCF.ColumnHeadersVisible = False
        Me.dgvCF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCF.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCF.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvCF.Location = New System.Drawing.Point(428, 151)
        Me.dgvCF.Name = "dgvCF"
        Me.dgvCF.RowHeadersVisible = False
        Me.dgvCF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCF.Size = New System.Drawing.Size(190, 85)
        Me.dgvCF.TabIndex = 117
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "PlayerID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "PlayerName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dgv2B
        '
        Me.dgv2B.AllowDrop = True
        Me.dgv2B.AllowUserToAddRows = False
        Me.dgv2B.AllowUserToDeleteRows = False
        Me.dgv2B.AllowUserToOrderColumns = True
        Me.dgv2B.AllowUserToResizeColumns = False
        Me.dgv2B.AllowUserToResizeRows = False
        Me.dgv2B.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv2B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2B.ColumnHeadersVisible = False
        Me.dgv2B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv2B.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv2B.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv2B.Location = New System.Drawing.Point(563, 440)
        Me.dgv2B.Name = "dgv2B"
        Me.dgv2B.RowHeadersVisible = False
        Me.dgv2B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv2B.Size = New System.Drawing.Size(190, 85)
        Me.dgv2B.TabIndex = 119
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "PlayerID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.HeaderText = "PlayerName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lbl2B
        '
        Me.lbl2B.AutoSize = True
        Me.lbl2B.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl2B.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl2B.Location = New System.Drawing.Point(564, 418)
        Me.lbl2B.Name = "lbl2B"
        Me.lbl2B.Size = New System.Drawing.Size(97, 19)
        Me.lbl2B.TabIndex = 118
        Me.lbl2B.Text = "2nd Basemen"
        '
        'dgvCatch
        '
        Me.dgvCatch.AllowDrop = True
        Me.dgvCatch.AllowUserToAddRows = False
        Me.dgvCatch.AllowUserToDeleteRows = False
        Me.dgvCatch.AllowUserToOrderColumns = True
        Me.dgvCatch.AllowUserToResizeColumns = False
        Me.dgvCatch.AllowUserToResizeRows = False
        Me.dgvCatch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatch.ColumnHeadersVisible = False
        Me.dgvCatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCatch.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCatch.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvCatch.Location = New System.Drawing.Point(423, 642)
        Me.dgvCatch.Name = "dgvCatch"
        Me.dgvCatch.RowHeadersVisible = False
        Me.dgvCatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCatch.Size = New System.Drawing.Size(190, 85)
        Me.dgvCatch.TabIndex = 121
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "PlayerID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.HeaderText = "PlayerName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lblCatch
        '
        Me.lblCatch.AutoSize = True
        Me.lblCatch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCatch.Location = New System.Drawing.Point(424, 620)
        Me.lblCatch.Name = "lblCatch"
        Me.lblCatch.Size = New System.Drawing.Size(66, 19)
        Me.lblCatch.TabIndex = 120
        Me.lblCatch.Text = "Catchers"
        '
        'dgvSS
        '
        Me.dgvSS.AllowDrop = True
        Me.dgvSS.AllowUserToAddRows = False
        Me.dgvSS.AllowUserToDeleteRows = False
        Me.dgvSS.AllowUserToOrderColumns = True
        Me.dgvSS.AllowUserToResizeColumns = False
        Me.dgvSS.AllowUserToResizeRows = False
        Me.dgvSS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSS.ColumnHeadersVisible = False
        Me.dgvSS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSS.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvSS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvSS.Location = New System.Drawing.Point(276, 440)
        Me.dgvSS.Name = "dgvSS"
        Me.dgvSS.RowHeadersVisible = False
        Me.dgvSS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSS.Size = New System.Drawing.Size(190, 85)
        Me.dgvSS.TabIndex = 123
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "PlayerID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = "PlayerName"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lblSS
        '
        Me.lblSS.AutoSize = True
        Me.lblSS.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSS.Location = New System.Drawing.Point(277, 418)
        Me.lblSS.Name = "lblSS"
        Me.lblSS.Size = New System.Drawing.Size(77, 19)
        Me.lblSS.TabIndex = 122
        Me.lblSS.Text = "Shortstops"
        '
        'dgv1B
        '
        Me.dgv1B.AllowDrop = True
        Me.dgv1B.AllowUserToAddRows = False
        Me.dgv1B.AllowUserToDeleteRows = False
        Me.dgv1B.AllowUserToOrderColumns = True
        Me.dgv1B.AllowUserToResizeColumns = False
        Me.dgv1B.AllowUserToResizeRows = False
        Me.dgv1B.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv1B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1B.ColumnHeadersVisible = False
        Me.dgv1B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1B.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgv1B.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv1B.Location = New System.Drawing.Point(738, 582)
        Me.dgv1B.Name = "dgv1B"
        Me.dgv1B.RowHeadersVisible = False
        Me.dgv1B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv1B.Size = New System.Drawing.Size(190, 85)
        Me.dgv1B.TabIndex = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "PlayerID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.HeaderText = "PlayerName"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lbl1B
        '
        Me.lbl1B.AutoSize = True
        Me.lbl1B.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl1B.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl1B.Location = New System.Drawing.Point(739, 560)
        Me.lbl1B.Name = "lbl1B"
        Me.lbl1B.Size = New System.Drawing.Size(93, 19)
        Me.lbl1B.TabIndex = 124
        Me.lbl1B.Text = "1st Basemen"
        '
        'dgv3B
        '
        Me.dgv3B.AllowDrop = True
        Me.dgv3B.AllowUserToAddRows = False
        Me.dgv3B.AllowUserToDeleteRows = False
        Me.dgv3B.AllowUserToOrderColumns = True
        Me.dgv3B.AllowUserToResizeColumns = False
        Me.dgv3B.AllowUserToResizeRows = False
        Me.dgv3B.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv3B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3B.ColumnHeadersVisible = False
        Me.dgv3B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv3B.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgv3B.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv3B.Location = New System.Drawing.Point(92, 582)
        Me.dgv3B.Name = "dgv3B"
        Me.dgv3B.RowHeadersVisible = False
        Me.dgv3B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv3B.Size = New System.Drawing.Size(190, 85)
        Me.dgv3B.TabIndex = 127
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "PlayerID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.HeaderText = "PlayerName"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lbl3B
        '
        Me.lbl3B.AutoSize = True
        Me.lbl3B.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl3B.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl3B.Location = New System.Drawing.Point(93, 560)
        Me.lbl3B.Name = "lbl3B"
        Me.lbl3B.Size = New System.Drawing.Size(106, 19)
        Me.lbl3B.TabIndex = 126
        Me.lbl3B.Text = "Third Basemen"
        '
        'grpOutfielders
        '
        Me.grpOutfielders.Location = New System.Drawing.Point(19, 296)
        Me.grpOutfielders.Name = "grpOutfielders"
        Me.grpOutfielders.Size = New System.Drawing.Size(394, 240)
        Me.grpOutfielders.TabIndex = 0
        Me.grpOutfielders.TabStop = False
        Me.grpOutfielders.Text = "Outfielders"
        '
        'grpInfielders
        '
        Me.grpInfielders.Location = New System.Drawing.Point(19, 18)
        Me.grpInfielders.Name = "grpInfielders"
        Me.grpInfielders.Size = New System.Drawing.Size(394, 240)
        Me.grpInfielders.TabIndex = 1
        Me.grpInfielders.TabStop = False
        Me.grpInfielders.Text = "Infielders"
        '
        'grpCatchers
        '
        Me.grpCatchers.Location = New System.Drawing.Point(19, 574)
        Me.grpCatchers.Name = "grpCatchers"
        Me.grpCatchers.Size = New System.Drawing.Size(394, 240)
        Me.grpCatchers.TabIndex = 1
        Me.grpCatchers.TabStop = False
        Me.grpCatchers.Text = "Catchers"
        '
        'grpPitchers
        '
        Me.grpPitchers.Controls.Add(Me.btnPitchers)
        Me.grpPitchers.Location = New System.Drawing.Point(599, 12)
        Me.grpPitchers.Name = "grpPitchers"
        Me.grpPitchers.Size = New System.Drawing.Size(154, 68)
        Me.grpPitchers.TabIndex = 128
        Me.grpPitchers.TabStop = False
        Me.grpPitchers.Text = "Pitchers"
        '
        'btnPitchers
        '
        Me.btnPitchers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPitchers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPitchers.Location = New System.Drawing.Point(12, 22)
        Me.btnPitchers.Name = "btnPitchers"
        Me.btnPitchers.Size = New System.Drawing.Size(131, 36)
        Me.btnPitchers.TabIndex = 0
        Me.btnPitchers.Text = "View Pitchers"
        Me.btnPitchers.UseVisualStyleBackColor = True
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.btnSubmit)
        Me.grpControls.Controls.Add(Me.btnCancel)
        Me.grpControls.Location = New System.Drawing.Point(768, 12)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(233, 68)
        Me.grpControls.TabIndex = 129
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Controls"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(17, 22)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 36)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(119, 22)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(96, 36)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmRoster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1466, 857)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.grpPitchers)
        Me.Controls.Add(Me.dgv3B)
        Me.Controls.Add(Me.lbl3B)
        Me.Controls.Add(Me.dgv1B)
        Me.Controls.Add(Me.lbl1B)
        Me.Controls.Add(Me.dgvSS)
        Me.Controls.Add(Me.lblSS)
        Me.Controls.Add(Me.dgvCatch)
        Me.Controls.Add(Me.lblCatch)
        Me.Controls.Add(Me.dgv2B)
        Me.Controls.Add(Me.lbl2B)
        Me.Controls.Add(Me.dgvCF)
        Me.Controls.Add(Me.dgvRF)
        Me.Controls.Add(Me.dgvLF)
        Me.Controls.Add(Me.lblCF)
        Me.Controls.Add(Me.lblRF)
        Me.Controls.Add(Me.lblLF)
        Me.Controls.Add(Me.grpPlayers)
        Me.Controls.Add(Me.pbField)
        Me.Controls.Add(Me.grpTeam)
        Me.Controls.Add(Me.grpSeason)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRoster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MLB The Show | Roster"
        Me.grpSeason.ResumeLayout(False)
        Me.grpTeam.ResumeLayout(False)
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlayers.ResumeLayout(False)
        CType(Me.dgvLF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv3B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPitchers.ResumeLayout(False)
        Me.grpControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSeason As GroupBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents grpTeam As GroupBox
    Friend WithEvents cmbTeams As ComboBox
    Friend WithEvents pbField As PictureBox
    Friend WithEvents grpPlayers As GroupBox
    Friend WithEvents lblLF As Label
    Friend WithEvents lblRF As Label
    Friend WithEvents lblCF As Label
    Friend WithEvents dgvLF As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colPlayerName As DataGridViewTextBoxColumn
    Friend WithEvents dgvRF As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dgvCF As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents dgv2B As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents lbl2B As Label
    Friend WithEvents dgvCatch As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents lblCatch As Label
    Friend WithEvents dgvSS As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents lblSS As Label
    Friend WithEvents dgv1B As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents lbl1B As Label
    Friend WithEvents dgv3B As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents lbl3B As Label
    Friend WithEvents grpCatchers As GroupBox
    Friend WithEvents grpOutfielders As GroupBox
    Friend WithEvents grpInfielders As GroupBox
    Friend WithEvents grpPitchers As GroupBox
    Friend WithEvents btnPitchers As Button
    Friend WithEvents grpControls As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class
