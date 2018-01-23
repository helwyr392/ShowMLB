Imports System.Threading

Public Class frmSaved

    'Form load
    Private Sub frmSaved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    'Timer - Sleep for 1 second, then closes form
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Thread.Sleep(1000)
        Me.Close()
    End Sub

End Class