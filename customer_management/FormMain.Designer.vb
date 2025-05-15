<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        btnAddCustomer = New Button()
        btnEditCustomer = New Button()
        btnSearch = New Button()
        btnExit = New Button()
        btnLogin = New Button()
        PictureBox1 = New PictureBox()
        lblUserInfo = New Label()
        btnLogout = New Button()
        btnUser = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.Location = New Point(105, 110)
        btnAddCustomer.Margin = New Padding(2)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(128, 47)
        btnAddCustomer.TabIndex = 0
        btnAddCustomer.Text = "Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = True
        ' 
        ' btnEditCustomer
        ' 
        btnEditCustomer.Location = New Point(105, 173)
        btnEditCustomer.Margin = New Padding(2)
        btnEditCustomer.Name = "btnEditCustomer"
        btnEditCustomer.Size = New Size(128, 47)
        btnEditCustomer.TabIndex = 0
        btnEditCustomer.Text = "Edit Customer"
        btnEditCustomer.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(105, 239)
        btnSearch.Margin = New Padding(2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(128, 47)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(540, 373)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(128, 47)
        btnExit.TabIndex = 0
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(406, 373)
        btnLogin.Margin = New Padding(2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(128, 47)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(318, 61)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(350, 306)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblUserInfo
        ' 
        lblUserInfo.AutoSize = True
        lblUserInfo.ForeColor = Color.Red
        lblUserInfo.Location = New Point(574, 8)
        lblUserInfo.Margin = New Padding(2, 0, 2, 0)
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(0, 15)
        lblUserInfo.TabIndex = 2
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(278, 373)
        btnLogout.Margin = New Padding(4, 3, 4, 3)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(122, 47)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnUser
        ' 
        btnUser.Location = New Point(105, 52)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(128, 40)
        btnUser.TabIndex = 5
        btnUser.Text = "User Management"
        btnUser.UseVisualStyleBackColor = True
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 422)
        Controls.Add(btnUser)
        Controls.Add(btnLogout)
        Controls.Add(lblUserInfo)
        Controls.Add(PictureBox1)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(btnSearch)
        Controls.Add(btnEditCustomer)
        Controls.Add(btnAddCustomer)
        Margin = New Padding(2)
        Name = "FormMain"
        Text = "FormMain"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnEditCustomer As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUser As Button
End Class
