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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.labelCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.labelPhone = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.labelGender = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 155)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(590, 252)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(441, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 6
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.ComboBox1.Location = New System.Drawing.Point(229, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 419)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.labelGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.labelEmail)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.labelPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.labelCustomerName)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents labelCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents labelAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents labelPhone As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents labelEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents labelGender As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
