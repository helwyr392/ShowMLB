Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitForm()

    End Sub

    Private Sub InitForm()

        'Initialize status bar
        stlblCopyright.Text = My.Application.Info.Copyright.ToString
        stlblUser.Text = String.Format("Current user: {0}", Environment.UserName.ToString)
        stlblVersion.Text = String.Format("Version: {0}.{1}.{2}",
                                           My.Application.Info.Version.Major.ToString,
                                           My.Application.Info.Version.Minor.ToString,
                                           My.Application.Info.Version.Build.ToString)

    End Sub

    Private Sub btnStandings_MouseEnter(sender As Object, e As EventArgs) Handles btnStandings.MouseEnter ',
        'btnPostSeason.MouseEnter, btnWorldSeries.MouseEnter, btnRoster.MouseEnter, btnAwards.MouseEnter

        btnStandings.ForeColor = Color.White

    End Sub

    Private Sub btnStandings_MouseLeave(sender As Object, e As EventArgs) Handles btnStandings.MouseLeave ',
        'btnPostSeason.MouseEnter, btnWorldSeries.MouseEnter, btnRoster.MouseEnter, btnAwards.MouseEnter

        btnStandings.ForeColor = Color.Black

    End Sub

End Class
