Imports System.Data.Odbc
Public Class Customer
    Private repository As CustomerRepository
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Tên khách hàng không được để trống!")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Địa chỉ không được để trống!")
            Return False
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            MessageBox.Show("Email không hợp lệ!")
            Return False
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "^\d{10,11}$") Then
            MessageBox.Show("Số điện thoại không hợp lệ!")
            Return False
        End If
        If comboGender.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng chọn giới tính!")
            Return False
        End If
        Return True
    End Function

    Private Sub ClearFields()
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtCustomerName.Focus()
        comboGender.SelectedIndex = -1
    End Sub

    Friend currentState As FormState

    Private Sub ConfigureUI(bSearch As Boolean, bAdd As Boolean, bUpdate As Boolean,
                            bDelete As Boolean, bClear As Boolean,
                            tCustomerName As Boolean, tAddress As String, tPhone As String,
                            tEmail As String, coGender As String, vcustomerView As String)
        btnSearch.Enabled = bSearch
        btnAdd.Enabled = bAdd
        btnUpdate.Enabled = bUpdate
        btnDelete.Enabled = bDelete
        btnClear.Enabled = bClear
        txtCustomerName.Enabled = tCustomerName
        txtAddress.Enabled = tAddress
        txtPhone.Enabled = tPhone
        txtEmail.Enabled = tEmail
        comboGender.Enabled = coGender
        customerView.Enabled = vcustomerView
    End Sub
    Public Sub UpdateUI(currentState)
        Select Case currentState
            Case FormState.Searching
                ConfigureUI(True, False, False, False, True, True, False, False, False, False, False)
            Case FormState.Adding
                ConfigureUI(False, True, False, False, True, True, True, True, True, True, False)
            Case FormState.Editing
                ConfigureUI(True, False, True, True, True, True, True, True, True, True, True)
        End Select
    End Sub

    Private Sub LoadData()
        Try
            customerView.DataSource = repository.GetAll()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_db()
        repository = New CustomerRepository(connection.ConnectionString)
        currentState = FormMain.FormMainState
        UpdateUI(currentState)
        LoadData()

        ' Highlight selected row
        customerView.DefaultCellStyle.SelectionBackColor = Color.LightBlue
        customerView.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not ValidateInput() Then Return

        Try
            repository.Add(txtCustomerName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, comboGender.Text)
            MessageBox.Show("Lưu thành công!")
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            customerView.DataSource = repository.SearchByName(txtCustomerName.Text)
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If
        If customerView.SelectedRows.Count > 0 AndAlso customerView.Columns.Contains("id") Then
            Dim id As Integer = customerView.SelectedRows(0).Cells("id").Value
            Try
                repository.Delete(id)
                MessageBox.Show("Đã xóa!")
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Chọn một dòng để xóa!")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub customerView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles customerView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = customerView.Rows(e.RowIndex)
            If customerView.Columns.Contains("name") Then
                txtCustomerName.Text = row.Cells("name").Value.ToString()
            End If
            If customerView.Columns.Contains("address") Then
                txtAddress.Text = row.Cells("address").Value.ToString()
            End If
            If customerView.Columns.Contains("phone") Then
                txtPhone.Text = row.Cells("phone").Value.ToString()
            End If
            If customerView.Columns.Contains("email") Then
                txtEmail.Text = row.Cells("email").Value.ToString()
            End If
            If customerView.Columns.Contains("gender") Then
                comboGender.Text = row.Cells("gender").Value.ToString()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If customerView.SelectedRows.Count = 0 OrElse Not customerView.Columns.Contains("id") Then
            MessageBox.Show("Chọn một khách hàng để cập nhật!")
            Return
        End If

        If Not ValidateInput() Then Return

        Dim id As Integer = CInt(customerView.SelectedRows(0).Cells("id").Value)
        Try
            repository.Update(
                id,
                txtCustomerName.Text,
                txtAddress.Text,
                txtPhone.Text,
                txtEmail.Text,
                comboGender.Text
            )
            MessageBox.Show("Cập nhật thành công!")
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub
End Class
