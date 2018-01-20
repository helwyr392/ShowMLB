Imports System.Threading

Public Class frmSplash

    'Reduces opacity to zero, then disposes itself
    Private Sub Timer1_Tick(ByVal sender As System.Object,
                ByVal e As EventArgs) Handles Timer1.Tick
        Me.Opacity -= 0.06
        If Me.Opacity = 0 Then Me.Dispose()
    End Sub

    'Increases opacity to 1 incrementally
    Private Sub Timer2_Tick(ByVal sender As System.Object,
                ByVal e As EventArgs) Handles Timer2.Tick
        For i = 0 To 1 Step 0.01
            Me.Opacity = i
            Me.Refresh()
            Thread.Sleep(10)
        Next i
        Me.Opacity = 1
        Timer2.Enabled = False
    End Sub

    'Calls Timer 1, reducing opacity to zero
    Private Sub Form1_FormClosing(ByVal sender As System.Object,
                ByVal e As FormClosingEventArgs) _
                Handles MyBase.FormClosing
        Timer1.Enabled = True
        e.Cancel = True
    End Sub

    'Calls Timer 2, increasing opacity to 1
    Private Sub Form1_Load(ByVal sender As System.Object,
                ByVal e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

End Class