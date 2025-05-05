Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Signup

    ' Clear input fields
    Private Sub ClearFields()
        txtUsername.Clear()
        txtPassw.Clear()
        txtMail.Clear()
    End Sub

    ' Validate email format
    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(email, pattern)
    End Function

    ' Check if username exists
    Private Function IsUsernameTaken(ByVal username As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM users WHERE user_name = ?"
        Try
            ' Ensure the connection is initialized
            If connection Is Nothing Then
                connect_db()
            End If

            ' Open the connection if it is closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using command As New OdbcCommand(sql, connection)
                command.Parameters.Add("user_name", OdbcType.VarChar).Value = username
                Return CInt(command.ExecuteScalar()) > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking username: " & ex.Message)
            Return False
        Finally
            ' Close the connection if it is open
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

    End Function

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassw.Text.Trim()
        Dim email As String = txtMail.Text.Trim()

        ' Validate inputs
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Username, Password, Email không được để trống!")
            Return
        End If

        ' Check email format
        If Not IsValidEmail(email) Then
            MessageBox.Show("E-mail không hợp lệ!")
            Return
        End If

        ' Check password length
        If password.Length < 6 Then
            MessageBox.Show("Password phải có từ 6 ký tự trở lên!")
            Return
        End If

        ' Check if username already exists
        If IsUsernameTaken(username) Then
            MessageBox.Show("Username đã tồn tại. Vui lòng chọn tên khác!")
            Return
        End If

        ' Hash the password
        Dim hashedPassword As String = HashPassword(password)

        ' Insert user into database
        Dim sql As String = "INSERT INTO users (user_name, user_password, user_mail) VALUES (?, ?, ?)"
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using command As New OdbcCommand(sql, connection)
                command.Parameters.Add("user_name", OdbcType.VarChar).Value = username
                command.Parameters.Add("user_password", OdbcType.VarChar).Value = hashedPassword
                command.Parameters.Add("user_mail", OdbcType.VarChar).Value = email

                command.ExecuteNonQuery()
                MessageBox.Show("Đăng ký thành công!")
                ClearFields()
                Dim signinForm As New Signin()
                signinForm.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Close the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
