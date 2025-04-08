<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.labelCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.labelPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.labelGender = New System.Windows.Forms.Label()
        Me.comboGender = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.columName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelCustomerName
        '
        Me.labelCustomerName.AutoSize = True
        Me.labelCustomerName.Location = New System.Drawing.Point(9, 23)
        Me.labelCustomerName.Name = "labelCustomerName"
        Me.labelCustomerName.Size = New System.Drawing.Size(86, 13)
        Me.labelCustomerName.TabIndex = 1
        Me.labelCustomerName.Text = "Tên khách hàng"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(12, 39)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(151, 20)
        Me.txtCustomerName.TabIndex = 2
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Location = New System.Drawing.Point(226, 23)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(40, 13)
        Me.labelAddress.TabIndex = 3
        Me.labelAddress.Text = "Địa chỉ"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(229, 39)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(151, 20)
        Me.txtAddress.TabIndex = 4
        '
        'labelPhone
        '
        Me.labelPhone.AutoSize = True
        Me.labelPhone.Location = New System.Drawing.Point(438, 23)
        Me.labelPhone.Name = "labelPhone"
        Me.labelPhone.Size = New System.Drawing.Size(70, 13)
        Me.labelPhone.TabIndex = 5
        Me.labelPhone.Text = "Số điện thoại"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(441, 39)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(151, 20)
        Me.txtPhone.TabIndex = 6
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Location = New System.Drawing.Point(9, 96)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(32, 13)
        Me.labelEmail.TabIndex = 7
        Me.labelEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(12, 112)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(151, 20)
        Me.txtEmail.TabIndex = 8
        '
        'labelGender
        '
        Me.labelGender.AutoSize = True
        Me.labelGender.Location = New System.Drawing.Point(226, 96)
        Me.labelGender.Name = "labelGender"
        Me.labelGender.Size = New System.Drawing.Size(47, 13)
        Me.labelGender.TabIndex = 9
        Me.labelGender.Text = "Giới tính"
        '
        'comboGender
        '
        Me.comboGender.FormattingEnabled = True
        Me.comboGender.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.comboGender.Location = New System.Drawing.Point(229, 110)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(151, 21)
        Me.comboGender.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columName, Me.columnAddress, Me.columnPhone, Me.columnEmail, Me.columnGender})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(579, 239)
        Me.DataGridView1.TabIndex = 11
        '
        'columName
        '
        Me.columName.HeaderText = "Tên"
        Me.columName.Name = "columName"
        Me.columName.ReadOnly = True
        '
        'columnAddress
        '
        Me.columnAddress.HeaderText = "Địa chỉ"
        Me.columnAddress.Name = "columnAddress"
        Me.columnAddress.ReadOnly = True
        Me.columnAddress.Width = 150
        '
        'columnPhone
        '
        Me.columnPhone.HeaderText = "Số điện thoại"
        Me.columnPhone.Name = "columnPhone"
        Me.columnPhone.ReadOnly = True
        '
        'columnEmail
        '
        Me.columnEmail.HeaderText = "Email"
        Me.columnEmail.Name = "columnEmail"
        Me.columnEmail.ReadOnly = True
        '
        'columnGender
        '
        Me.columnGender.HeaderText = "Giới tính"
        Me.columnGender.Name = "columnGender"
        Me.columnGender.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 419)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(Me.labelGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.labelEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.labelPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.labelCustomerName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents columName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnGender As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
