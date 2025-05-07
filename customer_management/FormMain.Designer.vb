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
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(90, 95)
        Me.btnAddCustomer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(110, 41)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Location = New System.Drawing.Point(90, 150)
        Me.btnEditCustomer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(110, 41)
        Me.btnEditCustomer.TabIndex = 0
        Me.btnEditCustomer.Text = "Edit Customer"
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(90, 207)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 41)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(463, 323)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 41)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(348, 323)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 41)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(273, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 265)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.ForeColor = System.Drawing.Color.Red
        Me.lblUserInfo.Location = New System.Drawing.Point(492, 7)
        Me.lblUserInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblUserInfo.TabIndex = 2
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEditCustomer)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnEditCustomer As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUserInfo As Label
End Class
