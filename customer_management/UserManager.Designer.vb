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
        userId = New DataGridViewTextBoxColumn()
        userName = New DataGridViewTextBoxColumn()
        userMail = New DataGridViewTextBoxColumn()
        userRole = New DataGridViewTextBoxColumn()
        btnAddUser = New Button()
        btnEditUser = New Button()
        btnDeleteUser = New Button()
        btnExit = New Button()
        btnExportReport = New Button()
        CType(grUserView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(115, 27)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(188, 27)
        txtSearch.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(26, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 1
        Label1.Text = "User Name:"
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.Location = New Point(335, 27)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(103, 37)
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
        grUserView.Location = New Point(26, 91)
        grUserView.Margin = New Padding(3, 4, 3, 4)
        grUserView.Name = "grUserView"
        grUserView.ReadOnly = True
        grUserView.RowHeadersVisible = False
        grUserView.RowHeadersWidth = 51
        grUserView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grUserView.Size = New Size(605, 345)
        grUserView.TabIndex = 3
        ' 
        ' userId
        ' 
        userId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        userId.HeaderText = "User Id"
        userId.MinimumWidth = 6
        userId.Name = "userId"
        userId.ReadOnly = True
        userId.Width = 84
        ' 
        ' userName
        ' 
        userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        userName.HeaderText = "User Name"
        userName.MinimumWidth = 6
        userName.Name = "userName"
        userName.ReadOnly = True
        userName.Width = 111
        ' 
        ' userMail
        ' 
        userMail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        userMail.HeaderText = "Mail"
        userMail.MinimumWidth = 6
        userMail.Name = "userMail"
        userMail.ReadOnly = True
        ' 
        ' userRole
        ' 
        userRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        userRole.HeaderText = "Role"
        userRole.MinimumWidth = 6
        userRole.Name = "userRole"
        userRole.ReadOnly = True
        userRole.Resizable = DataGridViewTriState.True
        userRole.Width = 68
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnAddUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnAddUser.Location = New Point(100, 470)
        btnAddUser.Margin = New Padding(3, 4, 3, 4)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(86, 45)
        btnAddUser.TabIndex = 4
        btnAddUser.Text = "Add"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' btnEditUser
        ' 
        btnEditUser.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnEditUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnEditUser.Location = New Point(207, 470)
        btnEditUser.Margin = New Padding(3, 4, 3, 4)
        btnEditUser.Name = "btnEditUser"
        btnEditUser.Size = New Size(87, 45)
        btnEditUser.TabIndex = 5
        btnEditUser.Text = "Edit"
        btnEditUser.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnDeleteUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnDeleteUser.Location = New Point(316, 470)
        btnDeleteUser.Margin = New Padding(3, 4, 3, 4)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(86, 45)
        btnDeleteUser.TabIndex = 6
        btnDeleteUser.Text = "Delete"
        btnDeleteUser.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnExit.Location = New Point(422, 470)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(86, 45)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnExportReport
        ' 
        btnExportReport.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnExportReport.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportReport.Location = New Point(482, 27)
        btnExportReport.Name = "btnExportReport"
        btnExportReport.Size = New Size(149, 37)
        btnExportReport.TabIndex = 8
        btnExportReport.Text = "Export User List"
        btnExportReport.UseVisualStyleBackColor = False
        ' 
        ' UserManager
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 565)
        Controls.Add(btnExportReport)
        Controls.Add(btnExit)
        Controls.Add(btnDeleteUser)
        Controls.Add(btnEditUser)
        Controls.Add(btnAddUser)
        Controls.Add(grUserView)
        Controls.Add(btnSearch)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents btnExportReport As Button
End Class
