Imports System.Data.Odbc

Public Class UserManager

    Private Sub LoadUsers(Optional searchName As String = "")
        Dim dt As New DataTable()
        Try
            connection.Open()
            Dim sql As String = "SELECT user_id, user_name, user_mail, role_name 
                                 FROM users 
                                 INNER JOIN roles ON users.role_id = roles.role_id"
            If Not String.IsNullOrWhiteSpace(searchName) Then
                sql &= " WHERE user_name LIKE ?"
            End If
            Using cmd As New OdbcCommand(sql, connection)
                If Not String.IsNullOrWhiteSpace(searchName) Then
                    cmd.Parameters.AddWithValue("@user_name", "%" & searchName & "%")
                End If
                Using reader As OdbcDataReader = cmd.ExecuteReader()
                    'Delete old rows columns
                    grUserView.Rows.Clear()

                    'Fill data to gridview
                    While reader.Read()
                        grUserView.Rows.Add(reader.GetString(0),
                                            reader.GetString(1),
                                            reader.GetString(2),
                                            reader.GetString(3)
                        )
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub UserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()
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
        Dim userId As Integer = CInt(grUserView.SelectedRows(0).Cells("id").Value)
        If MessageBox.Show("Bạn có chắc chắn muốn xóa user này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return
        Try
            connection.Open()
            Dim sql As String = "DELETE FROM users WHERE id=?"
            Using cmd As New OdbcCommand(sql, connection)
                cmd.Parameters.AddWithValue("@id", userId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Xóa user thành công!")
                LoadUsers()
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class