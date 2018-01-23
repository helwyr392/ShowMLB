Public Class frmPitchers
    'Form load
    Private Sub frmPitchers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
    End Sub

    'Initialize form
    Private Sub InitForm()
        'Bring form to front
        Me.BringToFront()
    End Sub

    'Submit button mouse enter event
    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter,
            btnAddPitcher.MouseEnter, btnDeletePitcher.MouseEnter
        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.White
            Case "btnAddPlayer" : btnAddPitcher.ForeColor = Color.White
            Case "btnDeletePlayer" : btnDeletePitcher.ForeColor = Color.White
        End Select
    End Sub

    'Submit button mouse leave event
    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave,
            btnAddPitcher.MouseLeave, btnDeletePitcher.MouseLeave
        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.Black
            Case "btnAddPlayer" : btnAddPitcher.ForeColor = Color.Black
            Case "btnDeletePlayer" : btnDeletePitcher.ForeColor = Color.Black
        End Select
    End Sub

    'View Position Players button click event
    Private Sub btnPlayers_Click(sender As Object, e As EventArgs) Handles btnPlayers.Click
        frmRoster.BringToFront()
    End Sub

    'Add Player button click event
    Private Sub btnAddPitcher_Click(sender As Object, e As EventArgs) Handles btnAddPitcher.Click
        frmPlayer.ShowDialog()
    End Sub

End Class