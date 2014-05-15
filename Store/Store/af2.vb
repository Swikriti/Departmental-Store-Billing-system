Imports System.Data.OleDb
Public Class af2
    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Products.mdb")
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim a As String = ""
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("select * FROM Customer", cnn)

        Dim dt As New DataTable


        'fill data to datatable
        da.Fill(dt)


        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt
        'close connection
        cnn.Close()
    End Sub




    Public Sub search()



        Dim d As Integer = ToolStripComboBox1.SelectedIndex



        If d = 0 Then
            a = Today.Date
        ElseIf d = 1 Then
            a = Today.Month

        ElseIf d = 2 Then
            a = Today.Year

        ElseIf d = 3 Then


            a = ""


        End If













        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer WHERE CDate LIKE'%" & a & "%'", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt

        'close connection
        cnn.Close()







    End Sub

    Private Sub Ref()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT ProductID, ProductName, UnitPrice, pdate" & " FROM Products ORDER BY ProductID", cnn)
        Dim dt As New DataTable



        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView2.DataSource = dt

        'close connection
        cnn.Close()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Ref()
        RefreshData()



    End Sub

    Private Sub ToolStripTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ToolStripTextBox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            If e.KeyChar <> ControlChars.Back Then

                'cancel keys

                e.Handled = True
            End If

        End If
    End Sub


 



    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged


        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer WHERE BillNo LIKE'" & ToolStripTextBox1.Text & "'", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt

        'close connection
        cnn.Close()




    End Sub













  

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        search()

    End Sub

    Private Sub ToolStripComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.TextChanged
        a = ToolStripComboBox1.Text


        search()

    End Sub

    
   
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class