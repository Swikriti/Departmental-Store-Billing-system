<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(print))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sName = New System.Windows.Forms.Label()
        Me.lbillno = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LdATE = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CAddress = New System.Windows.Forms.Label()
        Me.Cphone = New System.Windows.Forms.Label()
        Me.CName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.sName)
        Me.GroupBox4.Controls.Add(Me.lbillno)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.BtnPrint)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.LdATE)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.CAddress)
        Me.GroupBox4.Controls.Add(Me.Cphone)
        Me.GroupBox4.Controls.Add(Me.CName)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Total)
        Me.GroupBox4.Controls.Add(Me.ListBox4)
        Me.GroupBox4.Controls.Add(Me.ListBox3)
        Me.GroupBox4.Controls.Add(Me.ListBox2)
        Me.GroupBox4.Controls.Add(Me.ListBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(453, 546)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Print Preview"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Total Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Rate"
        '
        'sName
        '
        Me.sName.AutoSize = True
        Me.sName.Location = New System.Drawing.Point(340, 510)
        Me.sName.Name = "sName"
        Me.sName.Size = New System.Drawing.Size(35, 13)
        Me.sName.TabIndex = 31
        Me.sName.Text = "Name"
        '
        'lbillno
        '
        Me.lbillno.AutoSize = True
        Me.lbillno.Location = New System.Drawing.Point(72, 19)
        Me.lbillno.Name = "lbillno"
        Me.lbillno.Size = New System.Drawing.Size(10, 13)
        Me.lbillno.TabIndex = 29
        Me.lbillno.Text = "."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Bill No:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 510)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Seller:"
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = Global.Store.My.Resources.Resources.print
        Me.BtnPrint.Location = New System.Drawing.Point(28, 486)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(79, 36)
        Me.BtnPrint.TabIndex = 27
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(305, 486)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Total Rs:"
        '
        'LdATE
        '
        Me.LdATE.AutoSize = True
        Me.LdATE.Location = New System.Drawing.Point(363, 16)
        Me.LdATE.Name = "LdATE"
        Me.LdATE.Size = New System.Drawing.Size(10, 13)
        Me.LdATE.TabIndex = 25
        Me.LdATE.Text = "."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(305, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Date:"
        '
        'CAddress
        '
        Me.CAddress.AutoSize = True
        Me.CAddress.Location = New System.Drawing.Point(78, 59)
        Me.CAddress.Name = "CAddress"
        Me.CAddress.Size = New System.Drawing.Size(10, 13)
        Me.CAddress.TabIndex = 23
        Me.CAddress.Text = "."
        '
        'Cphone
        '
        Me.Cphone.AutoSize = True
        Me.Cphone.Location = New System.Drawing.Point(77, 82)
        Me.Cphone.Name = "Cphone"
        Me.Cphone.Size = New System.Drawing.Size(10, 13)
        Me.Cphone.TabIndex = 22
        Me.Cphone.Text = "."
        '
        'CName
        '
        Me.CName.AutoSize = True
        Me.CName.Location = New System.Drawing.Point(117, 32)
        Me.CName.Name = "CName"
        Me.CName.Size = New System.Drawing.Size(10, 13)
        Me.CName.TabIndex = 21
        Me.CName.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Items"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Phone:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Customer Name:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(361, 486)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(13, 13)
        Me.Total.TabIndex = 13
        Me.Total.Text = "0"
        '
        'ListBox4
        '
        Me.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox4.Enabled = False
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(352, 150)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox4.Size = New System.Drawing.Size(77, 312)
        Me.ListBox4.TabIndex = 11
        '
        'ListBox3
        '
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.Enabled = False
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(290, 150)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox3.Size = New System.Drawing.Size(65, 312)
        Me.ListBox3.TabIndex = 10
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(235, 150)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox2.Size = New System.Drawing.Size(56, 312)
        Me.ListBox2.TabIndex = 9
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(28, 150)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(207, 312)
        Me.ListBox1.TabIndex = 8
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 551)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "print"
        Me.Text = "print"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents sName As System.Windows.Forms.Label
    Friend WithEvents lbillno As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LdATE As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CAddress As System.Windows.Forms.Label
    Friend WithEvents Cphone As System.Windows.Forms.Label
    Friend WithEvents CName As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
