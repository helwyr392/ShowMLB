Imports System.Threading

Public Class frmDeleted
    'Form load
    Private Sub frmDeleted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    'Timer - Sleeps for 1 second then closes the form
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Thread.Sleep(1000)
        Me.Close()
    End Sub
End Class