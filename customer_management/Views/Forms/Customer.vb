Imports System.Data.Odbc

Public Class CustomerForm
    Inherits System.Windows.Forms.Form

    Private repository As CustomerRepository

    Friend currentState As FormState

    ' Load all customer data into the grid
    Private Sub LoadData()
        Try
            customerView.DataSource = repository.GetAll()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    ' Form load event: initialize repository and UI
    Private Sub CustomerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_db()
        repository = New CustomerRepository(connection.ConnectionString)
        currentState = MainForm.FormMainState
        LoadData()
        customerView.DefaultCellStyle.SelectionBackColor = Color.LightBlue
        customerView.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub

    ' Search customers by name
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Try
            customerView.DataSource = repository.SearchByName(txtCustomerName.Text)
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    ' Export customer data to CSV report
    Private Sub btnExportReport_Click(sender As Object, e As EventArgs) Handles btnExportReport.Click
        If customerView.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để xuất báo cáo.")
            Return
        End If
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV files (*.csv)|*.csv"
        sfd.FileName = "CustomerList.csv"
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using sw As New IO.StreamWriter(sfd.FileName, False, System.Text.Encoding.UTF8)
                    Dim headers = customerView.Columns.Cast(Of DataGridViewColumn)().Select(Function(c) c.HeaderText)
                    sw.WriteLine(String.Join(",", headers))
                    For Each row As DataGridViewRow In customerView.Rows
                        If Not row.IsNewRow Then
                            Dim cells = row.Cells.Cast(Of DataGridViewCell)().Select(Function(c) If(c.Value IsNot Nothing, c.Value.ToString().Replace(",", " "), ""))
                            sw.WriteLine(String.Join(",", cells))
                        End If
                    Next
                End Using
                MessageBox.Show("Xuất báo cáo thành công!")
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xuất báo cáo: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim editForm As New CustomerEditForm(-1)
        If editForm.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim customerId As Integer = -1
        If customerView.SelectedRows.Count > 0 Then
            customerId = CInt(customerView.SelectedRows(0).Cells("id").Value)
        Else
            MessageBox.Show("Chọn khách hàng để cập nhật!")
            Return
        End If
        Dim editForm As New CustomerEditForm(customerId)
        If editForm.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
