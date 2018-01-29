Public Class frmMain

    'Form load
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmSplash.ShowDialog()
        InitForm()
        Me.BringToFront()

        'Set database connection
        mdlGlobals.SetConnection()
    End Sub

    'Initialize form
    Private Sub InitForm()
        'Initialize status bar
        stlblCopyright.Text = My.Application.Info.Copyright.ToString
        stlblUser.Text = String.Format("Current user: {0}", Environment.UserName.ToString)
        stlblVersion.Text = String.Format("Version: {0}.{1}.{2}",
                                           My.Application.Info.Version.Major.ToString,
                                           My.Application.Info.Version.Minor.ToString,
                                           My.Application.Info.Version.Build.ToString)
    End Sub

    'Button mouse-enter event
    Private Sub btnStandings_MouseEnter(sender As Object, e As EventArgs) Handles btnStandings.MouseEnter,
        btnPostSeason.MouseEnter, btnWorldSeries.MouseEnter, btnRoster.MouseEnter, btnAwards.MouseEnter

        'Selected button
        Dim btn As Button = CType(sender, Button)

        'Change font color to white when mouse enters button
        Select Case btn.Name
            Case "btnStandings" : btnStandings.ForeColor = Color.White
            Case "btnPostSeason" : btnPostSeason.ForeColor = Color.White
            Case "btnWorldSeries" : btnWorldSeries.ForeColor = Color.White
            Case "btnRoster" : btnRoster.ForeColor = Color.White
            Case "btnAwards" : btnAwards.ForeColor = Color.White
        End Select

    End Sub

    'Button mouse-leave event
    Private Sub btnStandings_MouseLeave(sender As Object, e As EventArgs) Handles btnStandings.MouseLeave,
        btnPostSeason.MouseLeave, btnWorldSeries.MouseLeave, btnRoster.MouseLeave, btnAwards.MouseLeave

        'Selected button
        Dim btn As Button = CType(sender, Button)

        'Change font color back to black when mouse leaves button
        Select Case btn.Name
            Case "btnStandings" : btnStandings.ForeColor = Color.Black
            Case "btnPostSeason" : btnPostSeason.ForeColor = Color.Black
            Case "btnWorldSeries" : btnWorldSeries.ForeColor = Color.Black
            Case "btnRoster" : btnRoster.ForeColor = Color.Black
            Case "btnAwards" : btnAwards.ForeColor = Color.Black
        End Select

    End Sub

    'Standings button click event
    Private Sub btnStandings_Click(sender As Object, e As EventArgs) Handles btnStandings.Click
        frmStandings.ShowDialog()
    End Sub

    'Postseason button click event
    Private Sub btnPostSeason_Click(sender As Object, e As EventArgs) Handles btnPostSeason.Click
        frmPostseason.ShowDialog()
    End Sub

    'World Series button click event
    Private Sub btnWorldSeries_Click(sender As Object, e As EventArgs) Handles btnWorldSeries.Click
        frmWorldSeries.ShowDialog()
    End Sub

    'Roster button click event
    Private Sub btnRoster_Click(sender As Object, e As EventArgs) Handles btnRoster.Click
        frmPitchers.Show()
        frmRoster.Show()
        frmRoster.BringToFront()
    End Sub

    'Awards button click event
    Private Sub btnAwards_Click(sender As Object, e As EventArgs) Handles btnAwards.Click
        frmAwardsNL.Show()
        frmAwardsAL.Show()
        frmAwardsAL.BringToFront()
    End Sub

End Class
