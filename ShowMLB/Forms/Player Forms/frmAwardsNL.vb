Public Class frmAwardsNL

    'Form load
    Private Sub frmAwardsNL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Submit button mouse enter event
    Private Sub btnSubmit_Enter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        btnSubmit.ForeColor = Color.White
    End Sub

    'Submit button mouse leave event
    Private Sub btnSubmit_Leave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        btnSubmit.ForeColor = Color.Black
    End Sub

    'American League button click event
    Private Sub btnAmerican_Click(sender As Object, e As EventArgs) Handles btnAmerican.Click
        frmAwardsAL.BringToFront()
    End Sub

End Class