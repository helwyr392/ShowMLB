<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaved
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaved))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbSaved = New System.Windows.Forms.PictureBox()
        Me.lblSaved = New System.Windows.Forms.Label()
        CType(Me.pbSaved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'pbSaved
        '
        Me.pbSaved.BackColor = System.Drawing.Color.White
        Me.pbSaved.Location = New System.Drawing.Point(2, 2)
        Me.pbSaved.Name = "pbSaved"
        Me.pbSaved.Size = New System.Drawing.Size(150, 80)
        Me.pbSaved.TabIndex = 0
        Me.pbSaved.TabStop = False
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.BackColor = System.Drawing.Color.White
        Me.lblSaved.ForeColor = System.Drawing.Color.Green
        Me.lblSaved.Location = New System.Drawing.Point(51, 33)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(52, 19)
        Me.lblSaved.TabIndex = 1
        Me.lblSaved.Text = "Saved!"
        '
        'frmSaved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(154, 84)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.pbSaved)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSaved"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Saved"
        CType(Me.pbSaved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbSaved As PictureBox
    Friend WithEvents lblSaved As Label
End Class
