Public Class frmRoster
    'Form load
    Private Sub frmWorldSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
    End Sub

    'Initialize form
    Private Sub InitForm()
        'Bring form to front
        Me.BringToFront()
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

    'View Pitchers button click event
    Private Sub btnPitchers_Click(sender As Object, e As EventArgs) Handles btnPitchers.Click
        frmPitchers.BringToFront()
    End Sub

    'Add Player button click event
    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click
        frmPlayer.ShowDialog()
    End Sub

End Class