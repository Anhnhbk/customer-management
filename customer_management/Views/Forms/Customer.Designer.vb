<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        labelCustomerName = New Label()
        txtCustomerName = New TextBox()
        customerView = New DataGridView()
        btnSearch = New Button()
        btnExportReport = New Button()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnExit = New Button()
        CType(customerView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelCustomerName
        ' 
        labelCustomerName.AutoSize = True
        labelCustomerName.Location = New Point(23, 47)
        labelCustomerName.Margin = New Padding(5, 0, 5, 0)
        labelCustomerName.Name = "labelCustomerName"
        labelCustomerName.Size = New Size(111, 20)
        labelCustomerName.TabIndex = 1
        labelCustomerName.Text = "Tên khách hàng"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(23, 72)
        txtCustomerName.Margin = New Padding(5)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(276, 27)
        txtCustomerName.TabIndex = 2
        ' 
        ' customerView
        ' 
        customerView.AllowUserToAddRows = False
        customerView.AllowUserToDeleteRows = False
        customerView.BackgroundColor = Color.White
        customerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        customerView.Font = New Font("Tahoma", 12.0F)
        customerView.Location = New Point(16, 124)
        customerView.Margin = New Padding(5)
        customerView.Name = "customerView"
        customerView.ReadOnly = True
        customerView.RowHeadersVisible = False
        customerView.RowHeadersWidth = 51
        customerView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        customerView.Size = New Size(688, 368)
        customerView.TabIndex = 11
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSearch.Location = New Point(471, 64)
        btnSearch.Margin = New Padding(5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(96, 42)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnExportReport
        ' 
        btnExportReport.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnExportReport.Location = New Point(577, 64)
        btnExportReport.Margin = New Padding(5)
        btnExportReport.Name = "btnExportReport"
        btnExportReport.Size = New Size(127, 42)
        btnExportReport.TabIndex = 18
        btnExportReport.Text = "Export Report"
        btnExportReport.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnAdd.Location = New Point(111, 541)
        btnAdd.Margin = New Padding(5)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(96, 48)
        btnAdd.TabIndex = 19
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUpdate.Location = New Point(266, 541)
        btnUpdate.Margin = New Padding(5)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(96, 48)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnExit.Location = New Point(399, 541)
        btnExit.Margin = New Padding(5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(96, 48)
        btnExit.TabIndex = 21
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' CustomerForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(719, 660)
        Controls.Add(btnExit)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(btnExportReport)
        Controls.Add(btnSearch)
        Controls.Add(customerView)
        Controls.Add(txtCustomerName)
        Controls.Add(labelCustomerName)
        Margin = New Padding(5)
        Name = "CustomerForm"
        Text = "Customer"
        CType(customerView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents labelCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents customerView As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExportReport As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
