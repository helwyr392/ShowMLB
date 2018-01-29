Imports System.Data.SqlClient

Module mdlStandings

    Public Sub PopulateSeason()

        Dim dr As SqlDataReader
        Dim dt As DataTable
        Dim query As String

        'Set SQL query
        query = "SELECT id, year 
                 FROM Season 
                 ORDER BY year DESC"

        Try

        Catch ex As Exception
            MsgBox("Error populating Season drop-down list." & vbCrLf & ex.ToString,
                    MsgBoxStyle.Critical, "Database Error")
            Console.WriteLine(ex.ToString)
        End Try

        Using conn As New SqlConnection(gstrConnString)
            conn.Open()
            Using comm As New SqlCommand(query, conn)
                'Load data into datatable
                dt = New DataTable
                dr = comm.ExecuteReader
                dt.Load(dr)

                'Populate the drop-down from the data stored in the datatable
                frmStandings.cmbSeason.DataSource = dt
                frmStandings.cmbSeason.ValueMember = "id"
                frmStandings.cmbSeason.DisplayMember = "year"
            End Using 'comm
        End Using 'conn

    End Sub

    Public Sub PopulateTeamLists()



    End Sub

    Private Sub PopulateDivision()

        Dim dr As SqlDataReader
        Dim dt As DataTable
        Dim query As String

        query = "SELECT id, city_name + ' ' + team_name AS 'Team' 
                 FROM Teams 
                 WHERE league = 'AL' 
                 AND division = 'Central' 
                 ORDER BY city_name ASC"

        Try
            Using conn As New SqlConnection(gstrConnString)
                conn.Open()
                Using comm As New SqlCommand(query, conn)
                    'Load data into datatable
                    dt = New DataTable
                    dr = comm.ExecuteReader
                    dt.Load(dr)

                    'Populate the drop-down from the data stored in the datatable
                    frmStandings.cmbSeason.DataSource = dt
                    frmStandings.cmbSeason.ValueMember = "id"
                    frmStandings.cmbSeason.DisplayMember = "year"
                End Using 'comm
            End Using 'conn

        Catch ex As Exception
            MsgBox("Error retrieving teams from the database." & vbCrLf & ex.ToString,
                    MsgBoxStyle.Critical, "Database Error")
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

End Module
