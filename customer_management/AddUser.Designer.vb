<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        btnSave = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtPassw = New TextBox()
        txtUsername = New TextBox()
        txtMail = New TextBox()
        Label3 = New Label()
        btnExit = New Button()
        Label4 = New Label()
        cmbRole = New ComboBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(58, 245)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(88, 38)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 17)
        Label2.TabIndex = 6
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 17)
        Label1.TabIndex = 7
        Label1.Text = "User name:"
        ' 
        ' txtPassw
        ' 
        txtPassw.Location = New Point(153, 81)
        txtPassw.Margin = New Padding(3, 2, 3, 2)
        txtPassw.Multiline = True
        txtPassw.Name = "txtPassw"
        txtPassw.PasswordChar = "*"c
        txtPassw.Size = New Size(209, 30)
        txtPassw.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(153, 28)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(209, 30)
        txtUsername.TabIndex = 0
        ' 
        ' txtMail
        ' 
        txtMail.Location = New Point(153, 143)
        txtMail.Margin = New Padding(3, 2, 3, 2)
        txtMail.Multiline = True
        txtMail.Name = "txtMail"
        txtMail.Size = New Size(209, 30)
        txtMail.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(55, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 17)
        Label3.TabIndex = 6
        Label3.Text = "E-mail:"
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(264, 245)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(98, 38)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(55, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 17)
        Label4.TabIndex = 6
        Label4.Text = "Role:"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(153, 193)
        cmbRole.Margin = New Padding(4)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(136, 23)
        cmbRole.TabIndex = 8
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClear.Location = New Point(169, 245)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(89, 38)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(483, 326)
        Controls.Add(btnClear)
        Controls.Add(cmbRole)
        Controls.Add(btnExit)
        Controls.Add(btnSave)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMail)
        Controls.Add(txtPassw)
        Controls.Add(txtUsername)
        Margin = New Padding(3, 2, 3, 2)
        Name = "AddUser"
        Text = "Add User"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassw As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnClear As Button
End Class
