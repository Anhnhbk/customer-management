Public Class MainForm
    ' Stores the username of the logged-in user
    Private loggedInUser As String = ""

    ' Represents the current state of the form
    Friend FormMainState As FormState

    ' Constants for user roles
    Private Const ROLE_ADMIN As Integer = 1
    Private Const ROLE_STAFF As Integer = 2
    Private Const ROLE_GUEST As Integer = 3
    Private Const ROLE_DEFAULT As Integer = 99

    ' Resets the UI to its default state
    Private Sub ResetUI()
        btnUser.Visible = False
        btnCustomerManager.Visible = False
        btnLogout.Visible = False
        btnLogin.Visible = True
        lblUserInfo.Text = ""
    End Sub

    ' Configures the UI based on the provided parameters
    Private Sub ConfigureUI(handleUser As Boolean, customerManager As Boolean, logout As Boolean, login As Boolean, role As String)
        btnUser.Visible = handleUser
        btnCustomerManager.Visible = customerManager
        btnLogout.Visible = logout
        btnLogin.Visible = login
        lblUserInfo.Text = If(String.IsNullOrEmpty(role), "", $"User: {loggedInUser} ({role})")
    End Sub

    ' Updates the UI based on the user's role after login
    Private Sub UpdateUIAfterLogin(userRoleId As Integer)
        ResetUI()

        ' Configure UI based on the role ID
        Select Case userRoleId
            Case ROLE_ADMIN
                ConfigureUI(True, True, True, False, "Admin")
            Case ROLE_STAFF
                ConfigureUI(False, True, True, False, "Staff")
            Case ROLE_GUEST
                ConfigureUI(False, False, True, True, "Guest")
            Case Else
                ConfigureUI(False, False, False, True, "")
        End Select
    End Sub

    ' Handles the form load event
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Me.Text = "Customer Management"
        Me.StartPosition = FormStartPosition.CenterScreen
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        ' Initialize UI to default state
        UpdateUIAfterLogin(ROLE_DEFAULT)
    End Sub

    ' Handles the login button click event
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim LoginForm As New LoginForm()
        Try
            ' Show the login form and handle the result
            If LoginForm.ShowDialog() = DialogResult.OK Then
                loggedInUser = LoginForm.LoginUser
                UpdateUIAfterLogin(LoginForm.userRoleId)
            Else
                MessageBox.Show("Đăng nhập bị hủy hoặc thất bại.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng nhập: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handles the customer manager button click event
    Private Sub btnCustomerManager_Click(sender As Object, e As EventArgs) Handles btnCustomerManager.Click
        Dim frmCustomer As New CustomerForm()
        frmCustomer.ShowDialog()
    End Sub

    ' Handles the logout button click event
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Reset the UI to its default state
        ResetUI()
    End Sub

    ' Handles the exit button click event
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application
        If MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim frmUserManager As New UserManagerForm()
        frmUserManager.ShowDialog()
    End Sub
End Class