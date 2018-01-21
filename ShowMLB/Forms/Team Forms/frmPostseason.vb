Public Class frmPostseason

    'Form load
    Private Sub frmPostseason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------
        InitForm()
    End Sub

    'Initialize form
    Private Sub InitForm()
        '------------------------------------------------
        'Set score text boxes to a max length of 2
        txtAwayScore1.MaxLength = 2
        txtHomeScore1.MaxLength = 2
        txtAwayScore2.MaxLength = 2
        txtHomeScore2.MaxLength = 2
        txtAwayScore3.MaxLength = 2
        txtHomeScore3.MaxLength = 2
        txtAwayScore4.MaxLength = 2
        txtHomeScore4.MaxLength = 2
        txtAwayScore5.MaxLength = 2
        txtHomeScore5.MaxLength = 2
        txtAwayScore6.MaxLength = 2
        txtHomeScore6.MaxLength = 2
        txtAwayScore7.MaxLength = 2
        txtHomeScore7.MaxLength = 2
    End Sub

End Class