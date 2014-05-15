<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgUser = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.repassword = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgUser)
        Me.GroupBox2.Location = New System.Drawing.Point(250, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 243)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User"
        '
        'dgUser
        '
        Me.dgUser.AllowDrop = True
        Me.dgUser.AllowUserToAddRows = False
        Me.dgUser.AllowUserToDeleteRows = False
        Me.dgUser.AllowUserToResizeColumns = False
        Me.dgUser.AllowUserToResizeRows = False
        Me.dgUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUser.Location = New System.Drawing.Point(3, 16)
        Me.dgUser.MultiSelect = False
        Me.dgUser.Name = "dgUser"
        Me.dgUser.ReadOnly = True
        Me.dgUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgUser.RowHeadersVisible = False
        Me.dgUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUser.Size = New System.Drawing.Size(147, 224)
        Me.dgUser.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Btnsave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Type)
        Me.GroupBox1.Controls.Add(Me.repassword)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 243)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add User"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(53, 165)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(150, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Show Password character"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.Store.My.Resources.Resources.checkmark
        Me.btnupdate.Location = New System.Drawing.Point(84, 189)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(42, 34)
        Me.btnupdate.TabIndex = 15
        Me.btnupdate.UseVisualStyleBackColor = True
        Me.btnupdate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ID"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(75, 34)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(116, 20)
        Me.ID.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Image = Global.Store.My.Resources.Resources.delete
        Me.Button2.Location = New System.Drawing.Point(133, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 34)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.Image = Global.Store.My.Resources.Resources.checkmark
        Me.Btnsave.Location = New System.Drawing.Point(85, 189)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(42, 34)
        Me.Btnsave.TabIndex = 11
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "RePassword"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'Type
        '
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"Administrator", "User"})
        Me.Type.Location = New System.Drawing.Point(75, 138)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(116, 21)
        Me.Type.TabIndex = 6
        '
        'repassword
        '
        Me.repassword.Location = New System.Drawing.Point(75, 112)
        Me.repassword.Name = "repassword"
        Me.repassword.Size = New System.Drawing.Size(116, 20)
        Me.repassword.TabIndex = 5
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(75, 60)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(116, 20)
        Me.username.TabIndex = 3
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(75, 86)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(116, 20)
        Me.Password.TabIndex = 4
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(432, 333)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "user"
        Me.Text = "user"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgUser As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Type As System.Windows.Forms.ComboBox
    Friend WithEvents repassword As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
End Class
