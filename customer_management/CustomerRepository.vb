Imports System.Data.Odbc
Imports System.Data

Public Class CustomerRepository
    Private ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Function GetAll() As DataTable
        Dim dt As New DataTable()
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "SELECT * FROM customers"
            Using dml As New OdbcCommand(sql, conn)
                Using adapter As New OdbcDataAdapter(dml)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function SearchByName(name As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "SELECT * FROM customers WHERE name LIKE ?"
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.AddWithValue("@name", "%" & name & "%")
                Using adapter As New OdbcDataAdapter(dml)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub Add(name As String, address As String, phone As String, email As String, gender As String)
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO customers (name, address, phone, email, gender) VALUES (?, ?, ?, ?, ?)"
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.Add(New OdbcParameter("name", OdbcType.VarChar)).Value = name
                dml.Parameters.Add(New OdbcParameter("address", OdbcType.VarChar)).Value = address
                dml.Parameters.Add(New OdbcParameter("phone", OdbcType.VarChar)).Value = phone
                dml.Parameters.Add(New OdbcParameter("email", OdbcType.VarChar)).Value = email
                dml.Parameters.Add(New OdbcParameter("gender", OdbcType.VarChar)).Value = gender
                dml.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete(id As Integer)
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "DELETE FROM customers WHERE id= ?"
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.Add(New OdbcParameter("id", OdbcType.Int)).Value = id
                dml.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update(id As Integer, name As String, address As String, phone As String, email As String, gender As String)
        Using conn As New OdbcConnection(_connectionString)
            conn.Open()
            Dim sql As String = "UPDATE customers SET name = ?, address = ?, phone = ?, email = ?, gender = ? WHERE id = ?"
            Using dml As New OdbcCommand(sql, conn)
                dml.Parameters.Add(New OdbcParameter("name", OdbcType.VarChar)).Value = name
                dml.Parameters.Add(New OdbcParameter("address", OdbcType.VarChar)).Value = address
                dml.Parameters.Add(New OdbcParameter("phone", OdbcType.VarChar)).Value = phone
                dml.Parameters.Add(New OdbcParameter("email", OdbcType.VarChar)).Value = email
                dml.Parameters.Add(New OdbcParameter("gender", OdbcType.VarChar)).Value = gender
                dml.Parameters.Add(New OdbcParameter("id", OdbcType.Int)).Value = id
                dml.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
