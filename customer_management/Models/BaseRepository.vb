Imports System.Data.Odbc
Imports System.Data

' BaseRepository provides shared DB helpers for all repositories.
Public MustInherit Class BaseRepository
    Protected ReadOnly _connectionString As String
    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Protected Function ExecuteQuery(sql As String, Optional parameters As List(Of OdbcParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Using dml As New OdbcCommand(sql, conn)
                If parameters IsNot Nothing Then dml.Parameters.AddRange(parameters.ToArray())
                Using adapter As New OdbcDataAdapter(dml)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Protected Sub ExecuteNonQuery(sql As String, parameters As List(Of OdbcParameter))
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.AddRange(parameters.ToArray())
                dml.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
