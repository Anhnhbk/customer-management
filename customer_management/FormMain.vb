Public Class FormMain
    Private loggedInUser As String = ""
    Friend FormMainState As FormState

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Customer Management"
        Me.StartPosition = FormStartPosition.CenterScreen
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        btnAddCustomer.Visible = False
        btnEditCustomer.Visible = False
        btnSearch.Visible = False
        btnExit.Visible = True
        btnSignIn.Visible = True

        lblUserInfo.Text = ""

    End Sub

    Private Sub UpdateUIAfterLogin()
        btnAddCustomer.Visible = True
        btnEditCustomer.Visible = True
        btnSearch.Visible = True
        btnSignIn.Visible = False

        lblUserInfo.Text = "User: " & loggedInUser
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        ' Show Add Customer form
        FormMainState = FormState.Adding
        'UpdateUI()

        Dim frmCustomer As New Customer()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        ' Show Customer List form
        FormMainState = FormState.Editing
        'UpdateUI()
        Dim frmCustomer As New Customer()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Show Search form
        FormMainState = FormState.Searching
        'UpdateUI()
        Dim frmCustomer As New Customer()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit application
        Application.Exit()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim SigninForm As New Signin()
        If SigninForm.ShowDialog() = DialogResult.OK Then
            loggedInUser = SigninForm.SignInUser
            UpdateUIAfterLogin()
        End If
    End Sub
End Class