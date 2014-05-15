Imports System.Data.OleDb

Public Class sell
    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Products.mdb")

    Dim s As String = ""

    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT * from customer", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt

        'close connection
        cnn.Close()
    End Sub

    Private Sub sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripComboBox1.SelectedText = Today.Date


        txuser.Text = loginform1.UsernameTextBox.Text.ToUpper
        If loginform1.security = "User" Then
            txuser.Enabled = False




        End If
        search()

    End Sub





    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        search()


    End Sub


    Public Sub search()



        Dim dt As Integer = ToolStripComboBox1.SelectedIndex



        If dt = 0 Then
            s = Today.Date


        ElseIf dt = 1 Then
            s = Today.Month

        ElseIf dt = 2 Then
            s = Today.Year

        End If

        'If LoginForm1.security = "Administrator" Then




        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If


       


        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer where seller='" & txuser.Text & "' and cdate like '%" & s & "%' ", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        da.Fill(dtt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dtt

        'close connection
        cnn.Close()




        '  End If





    End Sub




   

    Private Sub txuser_TextChanged(sender As Object, e As EventArgs) Handles txuser.TextChanged
        search()

    End Sub

   

    Private Sub ToolStripComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.TextChanged
        s = ToolStripComboBox1.Text
        search()

    End Sub

   
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class