﻿Public Class frmRoster
    'Form load
    Private Sub frmWorldSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Submit button mouse enter event
    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter,
            btnAddPlayer.MouseEnter, btnDeletePlayer.MouseEnter
        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.White
            Case "btnAddPlayer" : btnAddPlayer.ForeColor = Color.White
            Case "btnDeletePlayer" : btnDeletePlayer.ForeColor = Color.White
        End Select
    End Sub

    'Submit button mouse leave event
    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave,
            btnAddPlayer.MouseLeave, btnDeletePlayer.MouseLeave
        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.Black
            Case "btnAddPlayer" : btnAddPlayer.ForeColor = Color.Black
            Case "btnDeletePlayer" : btnDeletePlayer.ForeColor = Color.Black
        End Select
    End Sub

End Class