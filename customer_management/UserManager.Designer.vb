<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManager
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
        txtSearch = New TextBox()
        Label1 = New Label()
        btnSearch = New Button()
        grUserView = New DataGridView()
        btnAddUser = New Button()
        btnEditUser = New Button()
        btnDeleteUser = New Button()
        btnExit = New Button()
        userId = New DataGridViewTextBoxColumn()
        userName = New DataGridViewTextBoxColumn()
        userMail = New DataGridViewTextBoxColumn()
        userRole = New DataGridViewTextBoxColumn()
        CType(grUserView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(101, 20)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(165, 23)
        txtSearch.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(23, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "User Name:"
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.Location = New Point(293, 20)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(90, 28)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' grUserView
        ' 
        grUserView.AllowUserToAddRows = False
        grUserView.AllowUserToDeleteRows = False
        grUserView.BackgroundColor = Color.White
        grUserView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grUserView.Columns.AddRange(New DataGridViewColumn() {userId, userName, userMail, userRole})
        grUserView.Location = New Point(23, 68)
        grUserView.Name = "grUserView"
        grUserView.ReadOnly = True
        grUserView.RowHeadersVisible = False
        grUserView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grUserView.Size = New Size(529, 259)
        grUserView.TabIndex = 3
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnAddUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnAddUser.Location = New Point(20, 352)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(75, 34)
        btnAddUser.TabIndex = 4
        btnAddUser.Text = "Add"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' btnEditUser
        ' 
        btnEditUser.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnEditUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnEditUser.Location = New Point(114, 352)
        btnEditUser.Name = "btnEditUser"
        btnEditUser.Size = New Size(76, 34)
        btnEditUser.TabIndex = 5
        btnEditUser.Text = "Edit"
        btnEditUser.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnDeleteUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnDeleteUser.Location = New Point(209, 352)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(75, 34)
        btnDeleteUser.TabIndex = 6
        btnDeleteUser.Text = "Delete"
        btnDeleteUser.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnExit.Location = New Point(304, 352)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 34)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' userId
        ' 
        userId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        userId.HeaderText = "User Id"
        userId.Name = "userId"
        userId.ReadOnly = True
        userId.Width = 68
        ' 
        ' userName
        ' 
        userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        userName.HeaderText = "User Name"
        userName.Name = "userName"
        userName.ReadOnly = True
        userName.Width = 90
        ' 
        ' userMail
        ' 
        userMail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        userMail.HeaderText = "Mail"
        userMail.Name = "userMail"
        userMail.ReadOnly = True
        ' 
        ' userRole
        ' 
        userRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        userRole.HeaderText = "Role"
        userRole.Name = "userRole"
        userRole.ReadOnly = True
        userRole.Resizable = DataGridViewTriState.True
        userRole.Width = 55
        ' 
        ' UserManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 424)
        Controls.Add(btnExit)
        Controls.Add(btnDeleteUser)
        Controls.Add(btnEditUser)
        Controls.Add(btnAddUser)
        Controls.Add(grUserView)
        Controls.Add(btnSearch)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Name = "UserManager"
        Text = "UserManager"
        CType(grUserView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents grUserView As DataGridView
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents userId As DataGridViewTextBoxColumn
    Friend WithEvents userName As DataGridViewTextBoxColumn
    Friend WithEvents userMail As DataGridViewTextBoxColumn
    Friend WithEvents userRole As DataGridViewTextBoxColumn
End Class
