' UserRepository handles CRUD operations for users in the database.
Imports System.Data.Odbc
Imports System.Data

Public Class UserRepository
    Inherits BaseRepository

    Public Sub New(connectionString As String)
        MyBase.New(connectionString)
    End Sub

    ' Retrieves all users with their roles.
    Public Function GetAll() As DataTable
        Return ExecuteQuery("SELECT user_id, user_name, user_mail, role_name FROM users INNER JOIN roles ON users.role_id = roles.role_id")
    End Function

    ' Searches users by username (partial match).
    Public Function SearchByUsername(username As String) As DataTable
        Dim sql As String = "SELECT user_id, user_name, user_mail, role_name FROM users INNER JOIN roles ON users.role_id = roles.role_id WHERE user_name LIKE ?"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("user_name", OdbcType.VarChar) With {.Value = "%" & username & "%"}
        }
        Return ExecuteQuery(sql, parameters)
    End Function

    ' Adds a new user.
    Public Sub Add(username As String, password As String, email As String, role As String)
        Dim sql As String = "INSERT INTO users (user_name, user_password, user_mail, role_id) VALUES (?, ?, ?, ?)"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("user_name", OdbcType.VarChar) With {.Value = username},
            New OdbcParameter("user_password", OdbcType.VarChar) With {.Value = password},
            New OdbcParameter("user_mail", OdbcType.VarChar) With {.Value = email},
            New OdbcParameter("role_id", OdbcType.VarChar) With {.Value = role}
        }
        ExecuteNonQuery(sql, parameters)
    End Sub

    ' Updates an existing user's email and role.
    Public Sub Update(id As Integer, email As String, role As String)
        Dim sql As String = "UPDATE users SET user_mail=?, role_id=? WHERE user_id=?"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("user_mail", OdbcType.VarChar) With {.Value = email},
            New OdbcParameter("role_id", OdbcType.VarChar) With {.Value = role},
            New OdbcParameter("user_id", OdbcType.Int) With {.Value = id}
        }
        ExecuteNonQuery(sql, parameters)
    End Sub

    ' Deletes a user by ID.
    Public Sub Delete(id As Integer)
        Dim sql As String = "DELETE FROM users WHERE user_id=?"
        Dim parameters = New List(Of OdbcParameter) From {
            New OdbcParameter("user_id", OdbcType.Int) With {.Value = id}
        }
        ExecuteNonQuery(sql, parameters)
    End Sub
End Class
