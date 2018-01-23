<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleted))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbDeleted = New System.Windows.Forms.PictureBox()
        Me.lblDeleted = New System.Windows.Forms.Label()
        CType(Me.pbDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'pbDeleted
        '
        Me.pbDeleted.BackColor = System.Drawing.Color.White
        Me.pbDeleted.Location = New System.Drawing.Point(2, 2)
        Me.pbDeleted.Name = "pbDeleted"
        Me.pbDeleted.Size = New System.Drawing.Size(150, 80)
        Me.pbDeleted.TabIndex = 0
        Me.pbDeleted.TabStop = False
        '
        'lblDeleted
        '
        Me.lblDeleted.AutoSize = True
        Me.lblDeleted.BackColor = System.Drawing.Color.White
        Me.lblDeleted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDeleted.Location = New System.Drawing.Point(45, 33)
        Me.lblDeleted.Name = "lblDeleted"
        Me.lblDeleted.Size = New System.Drawing.Size(65, 19)
        Me.lblDeleted.TabIndex = 1
        Me.lblDeleted.Text = "Deleted!"
        '
        'frmDeleted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(154, 84)
        Me.Controls.Add(Me.lblDeleted)
        Me.Controls.Add(Me.pbDeleted)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDeleted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.pbDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbDeleted As PictureBox
    Friend WithEvents lblDeleted As Label
End Class
