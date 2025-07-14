Imports System.Data.Odbc

Public Class CustomerEditForm
    Private repository As CustomerRepository
    Private customerId As Integer = -1
    Public Sub New(Optional id As Integer = -1)
        MyBase.New()
        InitializeComponent()
        customerId = id
    End Sub
    Private Sub CustomerEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()
        repository = New CustomerRepository(connection.ConnectionString)
        If customerId <> -1 Then
            ' Load customer info for editing
            Dim customer = repository.GetById(customerId)
            If customer IsNot Nothing Then
                txtCustomerName.Text = customer("name").ToString()
                txtAddress.Text = customer("address").ToString()
                txtPhone.Text = customer("phone").ToString()
                txtEmail.Text = customer("email").ToString()
                comboGender.Text = customer("gender").ToString()
            End If
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) OrElse String.IsNullOrWhiteSpace(txtAddress.Text) OrElse String.IsNullOrWhiteSpace(txtPhone.Text) OrElse String.IsNullOrWhiteSpace(txtEmail.Text) OrElse comboGender.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng nh?p ??y ?? thông tin!")
            Return
        End If
        Try
            If customerId = -1 Then
                repository.Add(txtCustomerName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, comboGender.Text)
                MessageBox.Show("Thêm khách hàng thành công!")
            Else
                repository.Update(customerId, txtCustomerName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, comboGender.Text)
                MessageBox.Show("C?p nh?t khách hàng thành công!")
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("L?i: " & ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
