
Imports System.Data.Odbc
Imports System.IO
Imports Newtonsoft.Json

Module Module1
    '    Public sql As String
    '    Public dml As OdbcCommand
    '    Public dr As OdbcDataReader
    Public connection As OdbcConnection

    '    ' Class to map the JSON structure
    '    Private Class AppConfig
    '        Public Property ConnectionStrings As Dictionary(Of String, String)
    '    End Class

    '    ' Method to load the connection string from JSON
    '    Private Function GetConnectionString() As String
    '        Dim jsonFilePath As String = "application.json" ' Path to your JSON file
    '        Dim jsonContent As String = File.ReadAllText(jsonFilePath)
    '        Dim config As AppConfig = JsonConvert.DeserializeObject(Of AppConfig)(jsonContent)
    '        Return config.ConnectionStrings("CustomerDB")
    '    End Function

    '    ' Method to initialize the database connection
    '    Public Sub connect_db()
    '        Dim connectionString As String = GetConnectionString()
    '        connection = New OdbcConnection(connectionString)
    '    End Sub
    Public Sub connect_db()
        Dim connectionString As String = ConfigManager.GetConnectionString("CustomerDB")
        connection = New OdbcConnection(connectionString)
    End Sub
End Module
