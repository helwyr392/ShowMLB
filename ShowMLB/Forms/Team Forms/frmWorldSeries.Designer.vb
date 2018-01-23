<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorldSeries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorldSeries))
        Me.grpSeason = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.grpGames = New System.Windows.Forms.GroupBox()
        Me.lblAt = New System.Windows.Forms.Label()
        Me.dgvGame = New System.Windows.Forms.DataGridView()
        Me.colTeams = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRuns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colErrors = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.grpTeams = New System.Windows.Forms.GroupBox()
        Me.radHomeNL = New System.Windows.Forms.RadioButton()
        Me.radHomeAL = New System.Windows.Forms.RadioButton()
        Me.cmbNL = New System.Windows.Forms.ComboBox()
        Me.lblNL = New System.Windows.Forms.Label()
        Me.cmbAL = New System.Windows.Forms.ComboBox()
        Me.lblAL = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMVP = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.grpSeason.SuspendLayout()
        Me.grpGames.SuspendLayout()
        CType(Me.dgvGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTeams.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSeason
        '
        Me.grpSeason.Controls.Add(Me.ComboBox5)
        Me.grpSeason.Location = New System.Drawing.Point(17, 25)
        Me.grpSeason.Name = "grpSeason"
        Me.grpSeason.Size = New System.Drawing.Size(201, 68)
        Me.grpSeason.TabIndex = 107
        Me.grpSeason.TabStop = False
        Me.grpSeason.Text = "Season"
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(22, 26)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(157, 27)
        Me.ComboBox5.TabIndex = 0
        '
        'grpGames
        '
        Me.grpGames.Controls.Add(Me.ComboBox2)
        Me.grpGames.Controls.Add(Me.lblMVP)
        Me.grpGames.Controls.Add(Me.lblAt)
        Me.grpGames.Controls.Add(Me.dgvGame)
        Me.grpGames.Controls.Add(Me.ComboBox1)
        Me.grpGames.Controls.Add(Me.lblGame)
        Me.grpGames.Location = New System.Drawing.Point(17, 299)
        Me.grpGames.Name = "grpGames"
        Me.grpGames.Size = New System.Drawing.Size(735, 202)
        Me.grpGames.TabIndex = 108
        Me.grpGames.TabStop = False
        Me.grpGames.Text = "Games"
        '
        'lblAt
        '
        Me.lblAt.AutoSize = True
        Me.lblAt.Location = New System.Drawing.Point(12, 158)
        Me.lblAt.Name = "lblAt"
        Me.lblAt.Size = New System.Drawing.Size(23, 19)
        Me.lblAt.TabIndex = 3
        Me.lblAt.Text = "@"
        '
        'dgvGame
        '
        Me.dgvGame.AllowUserToAddRows = False
        Me.dgvGame.AllowUserToDeleteRows = False
        Me.dgvGame.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGame.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTeams, Me.colInn1, Me.colInn2, Me.colInn3, Me.colInn4, Me.colInn5, Me.colInn6, Me.colInn7, Me.colInn8, Me.colInn9, Me.colRuns, Me.colHits, Me.colErrors})
        Me.dgvGame.Location = New System.Drawing.Point(41, 100)
        Me.dgvGame.Name = "dgvGame"
        Me.dgvGame.RowHeadersVisible = False
        Me.dgvGame.Size = New System.Drawing.Size(681, 81)
        Me.dgvGame.TabIndex = 2
        '
        'colTeams
        '
        Me.colTeams.HeaderText = ""
        Me.colTeams.MinimumWidth = 200
        Me.colTeams.Name = "colTeams"
        Me.colTeams.ReadOnly = True
        Me.colTeams.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTeams.Width = 200
        '
        'colInn1
        '
        Me.colInn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn1.HeaderText = "1"
        Me.colInn1.Name = "colInn1"
        Me.colInn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn2
        '
        Me.colInn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn2.HeaderText = "2"
        Me.colInn2.Name = "colInn2"
        Me.colInn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn3
        '
        Me.colInn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn3.HeaderText = "3"
        Me.colInn3.Name = "colInn3"
        Me.colInn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn4
        '
        Me.colInn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn4.HeaderText = "4"
        Me.colInn4.Name = "colInn4"
        Me.colInn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn5
        '
        Me.colInn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn5.HeaderText = "5"
        Me.colInn5.Name = "colInn5"
        Me.colInn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn6
        '
        Me.colInn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn6.HeaderText = "6"
        Me.colInn6.Name = "colInn6"
        Me.colInn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn7
        '
        Me.colInn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn7.HeaderText = "7"
        Me.colInn7.Name = "colInn7"
        Me.colInn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn8
        '
        Me.colInn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn8.HeaderText = "8"
        Me.colInn8.Name = "colInn8"
        Me.colInn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colInn9
        '
        Me.colInn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInn9.HeaderText = "9"
        Me.colInn9.Name = "colInn9"
        Me.colInn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colRuns
        '
        Me.colRuns.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRuns.HeaderText = "R"
        Me.colRuns.Name = "colRuns"
        Me.colRuns.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colHits
        '
        Me.colHits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colHits.HeaderText = "H"
        Me.colHits.Name = "colHits"
        Me.colHits.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colErrors
        '
        Me.colErrors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colErrors.HeaderText = "E"
        Me.colErrors.Name = "colErrors"
        Me.colErrors.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Game One", "Game Two", "Game Three", "Game Four", "Game Five", "Game Six", "Game Seven"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 27)
        Me.ComboBox1.TabIndex = 1
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Location = New System.Drawing.Point(12, 27)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(47, 19)
        Me.lblGame.TabIndex = 0
        Me.lblGame.Text = "Game"
        '
        'grpTeams
        '
        Me.grpTeams.Controls.Add(Me.radHomeNL)
        Me.grpTeams.Controls.Add(Me.radHomeAL)
        Me.grpTeams.Controls.Add(Me.cmbNL)
        Me.grpTeams.Controls.Add(Me.lblNL)
        Me.grpTeams.Controls.Add(Me.cmbAL)
        Me.grpTeams.Controls.Add(Me.lblAL)
        Me.grpTeams.Location = New System.Drawing.Point(17, 125)
        Me.grpTeams.Name = "grpTeams"
        Me.grpTeams.Size = New System.Drawing.Size(363, 142)
        Me.grpTeams.TabIndex = 109
        Me.grpTeams.TabStop = False
        Me.grpTeams.Text = "Teams"
        '
        'radHomeNL
        '
        Me.radHomeNL.AutoSize = True
        Me.radHomeNL.Location = New System.Drawing.Point(251, 99)
        Me.radHomeNL.Name = "radHomeNL"
        Me.radHomeNL.Size = New System.Drawing.Size(100, 23)
        Me.radHomeNL.TabIndex = 5
        Me.radHomeNL.Text = "Home Field"
        Me.radHomeNL.UseVisualStyleBackColor = True
        '
        'radHomeAL
        '
        Me.radHomeAL.AutoSize = True
        Me.radHomeAL.Checked = True
        Me.radHomeAL.Location = New System.Drawing.Point(251, 47)
        Me.radHomeAL.Name = "radHomeAL"
        Me.radHomeAL.Size = New System.Drawing.Size(100, 23)
        Me.radHomeAL.TabIndex = 4
        Me.radHomeAL.TabStop = True
        Me.radHomeAL.Text = "Home Field"
        Me.radHomeAL.UseVisualStyleBackColor = True
        '
        'cmbNL
        '
        Me.cmbNL.FormattingEnabled = True
        Me.cmbNL.Location = New System.Drawing.Point(15, 98)
        Me.cmbNL.Name = "cmbNL"
        Me.cmbNL.Size = New System.Drawing.Size(230, 27)
        Me.cmbNL.TabIndex = 3
        '
        'lblNL
        '
        Me.lblNL.AutoSize = True
        Me.lblNL.Location = New System.Drawing.Point(11, 76)
        Me.lblNL.Name = "lblNL"
        Me.lblNL.Size = New System.Drawing.Size(115, 19)
        Me.lblNL.TabIndex = 2
        Me.lblNL.Text = "National League"
        '
        'cmbAL
        '
        Me.cmbAL.FormattingEnabled = True
        Me.cmbAL.Location = New System.Drawing.Point(15, 46)
        Me.cmbAL.Name = "cmbAL"
        Me.cmbAL.Size = New System.Drawing.Size(230, 27)
        Me.cmbAL.TabIndex = 1
        '
        'lblAL
        '
        Me.lblAL.AutoSize = True
        Me.lblAL.Location = New System.Drawing.Point(11, 24)
        Me.lblAL.Name = "lblAL"
        Me.lblAL.Size = New System.Drawing.Size(121, 19)
        Me.lblAL.TabIndex = 0
        Me.lblAL.Text = "American League"
        '
        'btnSubmit
        '
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(656, 533)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(96, 36)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(554, 533)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 36)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(386, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 268)
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'lblMVP
        '
        Me.lblMVP.AutoSize = True
        Me.lblMVP.Location = New System.Drawing.Point(251, 27)
        Me.lblMVP.Name = "lblMVP"
        Me.lblMVP.Size = New System.Drawing.Size(124, 19)
        Me.lblMVP.TabIndex = 4
        Me.lblMVP.Text = "World Series MVP"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(255, 50)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(284, 27)
        Me.ComboBox2.TabIndex = 5
        '
        'frmWorldSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 594)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpTeams)
        Me.Controls.Add(Me.grpGames)
        Me.Controls.Add(Me.grpSeason)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmWorldSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MLB The Show | World Series"
        Me.grpSeason.ResumeLayout(False)
        Me.grpGames.ResumeLayout(False)
        Me.grpGames.PerformLayout()
        CType(Me.dgvGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTeams.ResumeLayout(False)
        Me.grpTeams.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSeason As GroupBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents grpGames As GroupBox
    Friend WithEvents grpTeams As GroupBox
    Friend WithEvents radHomeNL As RadioButton
    Friend WithEvents radHomeAL As RadioButton
    Friend WithEvents cmbNL As ComboBox
    Friend WithEvents lblNL As Label
    Friend WithEvents cmbAL As ComboBox
    Friend WithEvents lblAL As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblGame As Label
    Friend WithEvents dgvGame As DataGridView
    Friend WithEvents lblAt As Label
    Friend WithEvents colTeams As DataGridViewTextBoxColumn
    Friend WithEvents colInn1 As DataGridViewTextBoxColumn
    Friend WithEvents colInn2 As DataGridViewTextBoxColumn
    Friend WithEvents colInn3 As DataGridViewTextBoxColumn
    Friend WithEvents colInn4 As DataGridViewTextBoxColumn
    Friend WithEvents colInn5 As DataGridViewTextBoxColumn
    Friend WithEvents colInn6 As DataGridViewTextBoxColumn
    Friend WithEvents colInn7 As DataGridViewTextBoxColumn
    Friend WithEvents colInn8 As DataGridViewTextBoxColumn
    Friend WithEvents colInn9 As DataGridViewTextBoxColumn
    Friend WithEvents colRuns As DataGridViewTextBoxColumn
    Friend WithEvents colHits As DataGridViewTextBoxColumn
    Friend WithEvents colErrors As DataGridViewTextBoxColumn
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lblMVP As Label
End Class
