Public Class FormMain
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
        btnAddUser.Visible = False
        btnAddCustomer.Visible = False
        btnEditCustomer.Visible = False
        btnSearch.Visible = False
        btnLogout.Visible = False
        btnLogin.Visible = True
        lblUserInfo.Text = ""
    End Sub

    ' Configures the UI based on the provided parameters
    Private Sub ConfigureUI(addUser As Boolean, addCustomer As Boolean, editCustomer As Boolean, search As Boolean, logout As Boolean, login As Boolean, role As String)
        btnAddUser.Visible = addUser
        btnAddCustomer.Visible = addCustomer
        btnEditCustomer.Visible = editCustomer
        btnSearch.Visible = search
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
                ConfigureUI(True, True, True, True, True, False, "Admin")
            Case ROLE_STAFF
                ConfigureUI(False, True, True, True, True, False, "Staff")
            Case ROLE_GUEST
                ConfigureUI(False, False, False, True, True, False, "Guest")
            Case Else
                ConfigureUI(False, False, False, False, False, True, "")
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
        Dim LoginForm As New Login()
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

    ' Handles the add user button click event
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Show the Add User form
        Dim frmAddUser As New AddUser()
        frmAddUser.ShowDialog()
    End Sub

    ' Handles the add customer button click event
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        ' Set the form state to Adding and show the Customer form
        FormMainState = FormState.Adding
        Dim frmCustomer As New Customer()
        frmCustomer.ShowDialog()
    End Sub

    ' Handles the edit customer button click event
    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        ' Set the form state to Editing and show the Customer form
        FormMainState = FormState.Editing
        Dim frmCustomer As New Customer()
        frmCustomer.ShowDialog()
    End Sub

    ' Handles the search button click event
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Set the form state to Searching and show the Customer form
        FormMainState = FormState.Searching
        Dim frmCustomer As New Customer()
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
        Application.Exit()
    End Sub

End Class