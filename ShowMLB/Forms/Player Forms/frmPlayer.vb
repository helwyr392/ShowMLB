﻿Public Class frmPlayer
    'Form load
    Private Sub frmPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Button mouse enter event
    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter, btnCancel.MouseEnter

        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.White
            Case "btnCancel" : btnCancel.ForeColor = Color.White
        End Select
    End Sub

    'Button mouse leave event
    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave, btnCancel.MouseLeave

        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.Black
            Case "btnCancel" : btnCancel.ForeColor = Color.Black
        End Select
    End Sub

    'Cancel button click event
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close the form
        Me.Close()
    End Sub

End Class