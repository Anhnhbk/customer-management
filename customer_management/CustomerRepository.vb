Imports System.Data.Odbc
Imports System.Data

Public Class CustomerRepository
    Inherits BaseRepository

    Public Sub New(connectionString As String)
        MyBase.New(connectionString)
    End Sub

    Public Function GetAll() As DataTable
        Return ExecuteQuery("SELECT * FROM customers")
    End Function

    Public Function SearchByName(name As String) As DataTable
        Dim sql As String = "SELECT * FROM customers WHERE name LIKE ?"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("name", OdbcType.VarChar) With {.Value = "%" & name & "%"}
        }
        Return ExecuteQuery(sql, parameters)
    End Function

    Public Sub Add(name As String, address As String, phone As String, email As String, gender As String)
        Dim sql As String = "INSERT INTO customers (name, address, phone, email, gender) VALUES (?, ?, ?, ?, ?)"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("name", OdbcType.VarChar) With {.Value = name},
            New OdbcParameter("address", OdbcType.VarChar) With {.Value = address},
            New OdbcParameter("phone", OdbcType.VarChar) With {.Value = phone},
            New OdbcParameter("email", OdbcType.VarChar) With {.Value = email},
            New OdbcParameter("gender", OdbcType.VarChar) With {.Value = gender}
        }
        ExecuteNonQuery(sql, parameters)
    End Sub

    Public Sub Delete(id As Integer)
        Dim sql As String = "DELETE FROM customers WHERE id= ?"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("id", OdbcType.Int) With {.Value = id}
        }
        ExecuteNonQuery(sql, parameters)
    End Sub

    Public Sub Update(id As Integer, name As String, address As String, phone As String, email As String, gender As String)
        Dim sql As String = "UPDATE customers SET name = ?, address = ?, phone = ?, email = ?, gender = ? WHERE id = ?"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("name", OdbcType.VarChar) With {.Value = name},
            New OdbcParameter("address", OdbcType.VarChar) With {.Value = address},
            New OdbcParameter("phone", OdbcType.VarChar) With {.Value = phone},
            New OdbcParameter("email", OdbcType.VarChar) With {.Value = email},
            New OdbcParameter("gender", OdbcType.VarChar) With {.Value = gender},
            New OdbcParameter("id", OdbcType.Int) With {.Value = id}
        }
        ExecuteNonQuery(sql, parameters)
    End Sub
End Class
