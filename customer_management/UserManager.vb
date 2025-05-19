Imports System.Data.Odbc

Public Class UserManager
    Private repository As UserRepository
    Private Sub LoadUsers(Optional searchName As String = "")
        btnAddUser.Enabled = False
        btnEditUser.Enabled = False
        btnDeleteUser.Enabled = False
        Try
            Dim dt As New DataTable()
            Try
                If String.IsNullOrWhiteSpace(searchName) Then
                    dt = repository.GetAll()
                Else
                    dt = repository.SearchByUsername(searchName)
                End If

                grUserView.Rows.Clear()
                For Each row As DataRow In dt.Rows
                    grUserView.Rows.Add(
                        row("user_id"),
                        row("user_name"),
                        row("user_mail"),
                        row("role_name")
                    )
                Next
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        Finally
            btnAddUser.Enabled = True
            btnEditUser.Enabled = True
            btnDeleteUser.Enabled = True
        End Try
    End Sub

    Private Sub UserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()
        repository = New UserRepository(connection.ConnectionString)
        LoadUsers()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadUsers(txtSearch.Text.Trim())
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim addForm As New AddUser(connection)
        If addForm.ShowDialog() = DialogResult.OK Then
            LoadUsers()
        End If
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        If grUserView.SelectedRows.Count = 0 Then
            MessageBox.Show("Chọn user để sửa!")
            Return
        End If
        Dim row As DataGridViewRow = grUserView.SelectedRows(0)
        Dim userId As Integer = CInt(row.Cells("userId").Value)
        Dim addForm As New AddUser(connection, userId)
        If addForm.ShowDialog() = DialogResult.OK Then
            LoadUsers()
        End If

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If grUserView.SelectedRows.Count = 0 Then
            MessageBox.Show("Chọn user để xóa!")
            Return
        End If
        Dim user_Id As Integer = CInt(grUserView.SelectedRows(0).Cells("userId").Value)
        If MessageBox.Show("Bạn có chắc chắn muốn xóa user này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return
        Try
            repository.Delete(user_Id)
            MessageBox.Show("Xóa user thành công!")
            LoadUsers()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class