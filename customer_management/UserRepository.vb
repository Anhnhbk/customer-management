Imports System.Data.Odbc
Imports System.Data

Public Class UserRepository
    Private ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Function GetAll() As DataTable
        Dim dt As New DataTable()
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "SELECT user_id, user_name, user_mail, role_name 
                                 FROM users 
                                 INNER JOIN roles ON users.role_id = roles.role_id"
            Using dml As New OdbcCommand(sql, conn)
                Using adapter As New OdbcDataAdapter(dml)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function SearchByUsername(username As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "SELECT user_id, user_name, user_mail, role_name 
                                 FROM users 
                                 INNER JOIN roles ON users.role_id = roles.role_id
                                 WHERE user_name LIKE ?"
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.Add(New OdbcParameter("user_name", OdbcType.VarChar)).Value = "%" & username & "%"
                Using adapter As New OdbcDataAdapter(dml)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub Add(username As String, password As String, email As String, role As String)
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO users (user_name, user_password, user_mail, role_id) VALUES (?, ?, ?, ?)"
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.Add(New OdbcParameter("user_name", OdbcType.VarChar)).Value = username
                dml.Parameters.Add(New OdbcParameter("user_password", OdbcType.VarChar)).Value = password
                dml.Parameters.Add(New OdbcParameter("user_mail", OdbcType.VarChar)).Value = email
                dml.Parameters.Add(New OdbcParameter("role_id", OdbcType.VarChar)).Value = role
                dml.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update(id As Integer, email As String, role As String)
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            ' Dim sql As String = "UPDATE users SET user_name=?, user_password=?, user_mail=?, role_id=? WHERE user_id=?"
            Dim sql As String = "UPDATE users SET user_mail=?, role_id=? WHERE user_id=?"
            Using dml As New OdbcCommand(sql, conn)
                'dml.Parameters.Add(New OdbcParameter("user_name", OdbcType.VarChar)).Value = username
                'dml.Parameters.Add(New OdbcParameter("user_password", OdbcType.VarChar)).Value = password
                dml.Parameters.Add(New OdbcParameter("user_mail", OdbcType.VarChar)).Value = email
                dml.Parameters.Add(New OdbcParameter("role_id", OdbcType.VarChar)).Value = role
                dml.Parameters.Add(New OdbcParameter("user_id", OdbcType.Int)).Value = id
                dml.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete(id As Integer)
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "DELETE FROM users WHERE user_id=?"
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.Add(New OdbcParameter("user_id", OdbcType.Int)).Value = id
                dml.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
