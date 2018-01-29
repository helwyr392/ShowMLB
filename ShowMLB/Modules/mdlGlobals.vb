Imports System.IO

Module mdlGlobals

    '------ Global Variables

    'Database connection string
    Public gstrConnString As String

    'Keeps track of the current selected season by season ID
    Public gstrSeasonID As String

    'Set true if there are changes on a form that haven't been saved
    Public gblnNeedSave As Boolean

    'Set database connection string
    Public Sub SetConnection()
        Dim strServer As String
        Dim strDatabase As String
        Dim strFile As String

        'Set .ini file path
        strFile = Application.StartupPath() & "\data.ini"

        ' Create new StreamReader
        Using sr As StreamReader = New StreamReader(strFile)
            ' Read from file
            strServer = sr.ReadLine
            strDatabase = sr.ReadLine
        End Using

        'Set connection string
        gstrConnString = String.Format("Server= {0}; Database= {1}; Integrated Security= SSPI;",
                                        strServer, strDatabase)

    End Sub

End Module
