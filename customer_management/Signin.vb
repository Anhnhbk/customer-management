Imports System.Data.Odbc

Public Class Signin

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = HashPassword(txtPassw.Text.Trim())
        'Dim hashedPassword As String = HashPassword(password)
        Try
            ' Ensure the connection is initialized
            If connection Is Nothing Then
                connect_db()
            End If

            ' Open the connection if it is closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim sql As String = "SELECT COUNT(*) FROM users WHERE user_name = ? AND user_password = ?"

            Using command As New OdbcCommand(sql, connection)
                command.Parameters.Add("user_name", OdbcType.VarChar).Value = username
                command.Parameters.Add("user_password", OdbcType.VarChar).Value = password

                Dim count As Integer = CInt(command.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Đăng nhập thành công!")
                    Dim frmForm1 As New Form1()
                    frmForm1.ShowDialog()
                Else
                    MessageBox.Show("Sai username hoặc mật khẩu.")
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            ' Close the connection if it is open
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Handle signup button click
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim frmSignup As New Signup()
        frmSignup.ShowDialog()

    End Sub

    ' Close the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class