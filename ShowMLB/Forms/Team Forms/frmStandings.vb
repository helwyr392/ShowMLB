Public Class frmStandings

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter, btnCancel.MouseEnter

        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.White
            Case "btnCancel" : btnCancel.ForeColor = Color.White
        End Select

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave, btnCancel.MouseLeave

        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.Black
            Case "btnCancel" : btnCancel.ForeColor = Color.Black
        End Select

    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

End Class