<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerEditForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.comboGender = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' txtCustomerName
        Me.txtCustomerName.Location = New System.Drawing.Point(30, 30)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(200, 23)
        Me.txtCustomerName.TabIndex = 0
        ' txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(30, 70)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 23)
        Me.txtAddress.TabIndex = 1
        ' txtPhone
        Me.txtPhone.Location = New System.Drawing.Point(30, 110)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 23)
        Me.txtPhone.TabIndex = 2
        ' txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(30, 150)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 23)
        Me.txtEmail.TabIndex = 3
        ' comboGender
        Me.comboGender.Location = New System.Drawing.Point(30, 190)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(200, 23)
        Me.comboGender.TabIndex = 4
        Me.comboGender.Items.AddRange(New Object() {"Nam", "N?"})
        ' btnSave
        Me.btnSave.Location = New System.Drawing.Point(30, 230)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        ' btnExit
        Me.btnExit.Location = New System.Drawing.Point(155, 230)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        ' CustomerEditForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 280)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "CustomerEditForm"
        Me.Text = "Add/Update Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents comboGender As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
End Class
