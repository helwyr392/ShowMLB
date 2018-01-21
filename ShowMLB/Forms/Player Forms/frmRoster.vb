Public Class frmRoster
    'Form load
    Private Sub frmWorldSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Submit button mouse enter event
    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        btnSubmit.ForeColor = Color.White
    End Sub

    'Submit button mouse leave event
    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        btnSubmit.ForeColor = Color.Black
    End Sub

End Class