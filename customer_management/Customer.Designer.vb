<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        labelCustomerName = New Label()
        txtCustomerName = New TextBox()
        labelAddress = New Label()
        txtAddress = New TextBox()
        labelPhone = New Label()
        txtPhone = New TextBox()
        labelEmail = New Label()
        txtEmail = New TextBox()
        labelGender = New Label()
        comboGender = New ComboBox()
        customerView = New DataGridView()
        btnSearch = New Button()
        btnAdd = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnExit = New Button()
        btnUpdate = New Button()
        CType(customerView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelCustomerName
        ' 
        labelCustomerName.AutoSize = True
        labelCustomerName.Location = New Point(20, 35)
        labelCustomerName.Margin = New Padding(4, 0, 4, 0)
        labelCustomerName.Name = "labelCustomerName"
        labelCustomerName.Size = New Size(91, 15)
        labelCustomerName.TabIndex = 1
        labelCustomerName.Text = "Tên khách hàng"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(20, 54)
        txtCustomerName.Margin = New Padding(4)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(242, 23)
        txtCustomerName.TabIndex = 2
        ' 
        ' labelAddress
        ' 
        labelAddress.AutoSize = True
        labelAddress.Location = New Point(20, 90)
        labelAddress.Margin = New Padding(4, 0, 4, 0)
        labelAddress.Name = "labelAddress"
        labelAddress.Size = New Size(43, 15)
        labelAddress.TabIndex = 3
        labelAddress.Text = "Địa chỉ"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(20, 109)
        txtAddress.Margin = New Padding(4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(242, 23)
        txtAddress.TabIndex = 4
        ' 
        ' labelPhone
        ' 
        labelPhone.AutoSize = True
        labelPhone.Location = New Point(269, 31)
        labelPhone.Margin = New Padding(4, 0, 4, 0)
        labelPhone.Name = "labelPhone"
        labelPhone.Size = New Size(76, 15)
        labelPhone.TabIndex = 5
        labelPhone.Text = "Số điện thoại"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(269, 54)
        txtPhone.Margin = New Padding(4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(242, 23)
        txtPhone.TabIndex = 6
        ' 
        ' labelEmail
        ' 
        labelEmail.AutoSize = True
        labelEmail.Location = New Point(269, 90)
        labelEmail.Margin = New Padding(4, 0, 4, 0)
        labelEmail.Name = "labelEmail"
        labelEmail.Size = New Size(36, 15)
        labelEmail.TabIndex = 7
        labelEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(269, 109)
        txtEmail.Margin = New Padding(4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(242, 23)
        txtEmail.TabIndex = 8
        ' 
        ' labelGender
        ' 
        labelGender.AutoSize = True
        labelGender.Location = New Point(518, 32)
        labelGender.Margin = New Padding(4, 0, 4, 0)
        labelGender.Name = "labelGender"
        labelGender.Size = New Size(52, 15)
        labelGender.TabIndex = 9
        labelGender.Text = "Giới tính"
        ' 
        ' comboGender
        ' 
        comboGender.FormattingEnabled = True
        comboGender.Items.AddRange(New Object() {"Nam", "Nữ"})
        comboGender.Location = New Point(518, 54)
        comboGender.Margin = New Padding(4)
        comboGender.Name = "comboGender"
        comboGender.Size = New Size(91, 23)
        comboGender.TabIndex = 10
        ' 
        ' customerView
        ' 
        customerView.AllowUserToAddRows = False
        customerView.AllowUserToDeleteRows = False
        customerView.BackgroundColor = Color.White
        customerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        customerView.Font = New Font("Tahoma", 12F)
        customerView.Location = New Point(14, 206)
        customerView.Margin = New Padding(4)
        customerView.Name = "customerView"
        customerView.ReadOnly = True
        customerView.RowHeadersVisible = False
        customerView.RowHeadersWidth = 51
        customerView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        customerView.Size = New Size(602, 276)
        customerView.TabIndex = 11
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.Location = New Point(13, 153)
        btnSearch.Margin = New Padding(4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(84, 36)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAdd.Location = New Point(116, 153)
        btnAdd.Margin = New Padding(4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(84, 36)
        btnAdd.TabIndex = 14
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDelete.Location = New Point(322, 153)
        btnDelete.Margin = New Padding(4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 36)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Xóa"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClear.Location = New Point(425, 153)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(84, 36)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnExit.Location = New Point(528, 153)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(84, 36)
        btnExit.TabIndex = 17
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUpdate.Location = New Point(219, 153)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(84, 36)
        btnUpdate.TabIndex = 18
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Customer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 495)
        Controls.Add(btnUpdate)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(btnSearch)
        Controls.Add(customerView)
        Controls.Add(comboGender)
        Controls.Add(labelGender)
        Controls.Add(txtEmail)
        Controls.Add(labelEmail)
        Controls.Add(txtPhone)
        Controls.Add(labelPhone)
        Controls.Add(txtAddress)
        Controls.Add(labelAddress)
        Controls.Add(txtCustomerName)
        Controls.Add(labelCustomerName)
        Margin = New Padding(4)
        Name = "Customer"
        Text = "Customer"
        CType(customerView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents labelCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents labelAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents labelPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents labelEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents labelGender As System.Windows.Forms.Label
    Friend WithEvents comboGender As System.Windows.Forms.ComboBox
    Friend WithEvents customerView As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
End Class
