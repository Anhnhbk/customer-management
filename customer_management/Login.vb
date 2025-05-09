Imports System.Data.Odbc

Public Class Login
    Public Property LoginUser As String
    Public Property userRoleId As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = HashPassword(txtPassw.Text.Trim())
        Try
            ' Ensure the connection is initialized
            If connection Is Nothing Then
                connect_db()
            End If
            ' Open the connection if it is closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim sql As String = "SELECT role_Id FROM users WHERE user_name = ? AND user_password = ?"

            Using command As New OdbcCommand(sql, connection)
                command.Parameters.Add("user_name", OdbcType.VarChar).Value = username
                command.Parameters.Add("user_password", OdbcType.VarChar).Value = password

                Dim roleId As Object = command.ExecuteScalar()
                If roleId IsNot Nothing Then
                    MessageBox.Show("Đăng nhập thành công!")
                    LoginUser = username
                    userRoleId = Convert.ToInt32(roleId)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
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

    ' Close the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub
End Class