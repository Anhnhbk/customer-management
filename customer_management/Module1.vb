Imports System.Data.Odbc
Module Module1
    Public sql As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public connection As OdbcConnection
    Public Sub connect_db()
        connection = New OdbcConnection("DSN=db_customer;")
        'If connection.State = ConnectionState.Closed Then
        '    connection.Open()
        'End If
    End Sub
End Module
