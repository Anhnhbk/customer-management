Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Public Class AddUser

    Private connection As OdbcConnection
    Private userId As Integer = -1

    Public Sub New(conn As OdbcConnection, Optional editUserId As Integer = -1)
        InitializeComponent()
        connection = conn
        userId = editUserId
    End Sub

    ' Clear input fields
    Private Sub ClearFields()
        txtUsername.Clear()
        txtPassw.Clear()
        txtMail.Clear()
        LoadRoles()
    End Sub

    ' Populate comboRole with data from the roles table
    Private Sub LoadRoles(Optional roleID As Integer = 2)
        Dim sql As String = "SELECT role_id, role_name FROM roles"
        Dim dt As New DataTable()
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
                dt.Load(command.ExecuteReader())
                cmbRole.DataSource = dt
                cmbRole.DisplayMember = "role_name"
                cmbRole.ValueMember = "role_id"
            End Using

            ' Set default role to role_name = "staff"
            For i As Integer = 0 To cmbRole.Items.Count - 1
                Dim row As DataRowView = CType(cmbRole.Items(i), DataRowView)
                'If roleID Then
                If row("role_id") = roleID Then
                    cmbRole.SelectedIndex = i
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message)
        Finally
            ' Close the connection if it is open
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
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

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassw.Text.Trim()
        Dim email As String = txtMail.Text.Trim()
        Dim roleid As Integer = Convert.ToInt32(cmbRole.SelectedValue)

        ' Validate inputs
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(roleid) Then
            MessageBox.Show("Username, Password, Email, and Role không được để trống!")
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
        Dim sql As String = "INSERT INTO users (user_name, user_password, user_mail, role_id) VALUES (?, ?, ?, ?)"
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using command As New OdbcCommand(sql, connection)
                command.Parameters.Add("user_name", OdbcType.VarChar).Value = username
                command.Parameters.Add("user_password", OdbcType.VarChar).Value = hashedPassword
                command.Parameters.Add("user_mail", OdbcType.VarChar).Value = email
                command.Parameters.Add("role_id", OdbcType.VarChar).Value = roleid

                command.ExecuteNonQuery()
                MessageBox.Show("Đăng ký thành công!")
                ClearFields()
                Me.Close()
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
        Me.Close()
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If userId <> -1 Then
            ' Load user info for editing
            Try
                connection.Open()
                Dim sql As String = "SELECT user_name, user_mail, role_id FROM users WHERE user_id = ?"
                Using cmd As New OdbcCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@id", userId)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtUsername.Text = reader("user_name").ToString()
                            txtMail.Text = reader("user_mail").ToString()
                            LoadRoles(reader("role_id"))
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            LoadRoles()
        End If

    End Sub
End Class
