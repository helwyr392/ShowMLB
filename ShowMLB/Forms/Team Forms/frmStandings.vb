Public Class frmStandings

    'Form load
    Private Sub frmStandings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdlStandings.PopulateSeason()
    End Sub

    'Submit button mouse enter event
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter

        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.White
            Case "btnCancel" : btnCancel.ForeColor = Color.White
        End Select

    End Sub

    'Submit button mouse leave event
    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave

        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnSubmit" : btnSubmit.ForeColor = Color.Black
            Case "btnCancel" : btnCancel.ForeColor = Color.Black
        End Select

    End Sub

    'Submit button click event
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub

    'Cancel button click event
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Season drop-down list selection change event
    Private Sub cmbSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSeason.SelectedIndexChanged
        Dim i As Integer = cmbSeason.SelectedIndex
        gstrSeasonID = cmbSeason.Items(i)(0).ToString.ToUpper
    End Sub

End Class