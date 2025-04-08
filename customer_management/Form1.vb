Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connStr As String = "server=localhost;port=3306;username=root;password=;database=customer"
    Dim conn As New MySqlConnection(connStr)

    Private Sub txtCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerName.TextChanged

    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub comboGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboGender.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles customerView.CellContentClick

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "INSERT INTO customers (name, address, phone, email, gender) VALUES (@name, @address, @phone, @email, @gender)"
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@name", txtCustomerName.Text)
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@gender", comboGender.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Lưu thành công!")
                    LoadData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadData()
        Dim dt As New DataTable()
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT * FROM customers", conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                        customerView.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim dt As New DataTable()
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "SELECT * FROM customers WHERE name LIKE @name"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", "%" & txtCustomerName.Text & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                        customerView.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If customerView.SelectedRows.Count > 0 Then
            Dim id As Integer = customerView.SelectedRows(0).Cells("id").Value
            Try
                Using conn As New MySqlConnection(connStr)
                    conn.Open()
                    Using cmd As New MySqlCommand("DELETE FROM customers WHERE id=@id", conn)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Đã xóa!")
                        LoadData()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Chọn một dòng để xóa!")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        comboGender.SelectedIndex = -1
    End Sub

    Private Sub customerView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles customerView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = customerView.Rows(e.RowIndex)
            txtCustomerName.Text = row.Cells("name").Value.ToString()
            txtAddress.Text = row.Cells("address").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()
            comboGender.Text = row.Cells("gender").Value.ToString()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class
