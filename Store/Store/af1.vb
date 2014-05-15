Imports System.Data.OleDb

Public Class af1
    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Products.mdb")
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim a As Boolean = False



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sName.Text = loginform1.user
        If loginform1.security = "Administrator" Then
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton3.Enabled = True

        End If

        'for Bill No
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer", cnn)
        Dim dt As New DataTable
        da.Fill(dt)

        Dim a As Integer = dt.Rows.Count
        lbillno.Text = a + 3
        cnn.Close()





        GroupBox3.Location = New Point(350, 30)
        RefreshData()
        Me.BackColor = Color.Coral


    End Sub


    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT ProductID, ProductName, UnitPrice, pdate" & " FROM Products ORDER BY ProductID", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt

        'close connection
        cnn.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click

        Try

        

        DataGridView1.Enabled = 1
        'valid number
        Dim intValue As Integer
        If Not Integer.TryParse(TxPID.Text, intValue) And Not Integer.TryParse(TxUP.Text, intValue) Then

            ToolStripLabel1.Text = "Please insert valid Data"

        Else


            Dim cmd As New OleDb.OleDbCommand


            If Not cnn.State = ConnectionState.Open Then
                'open connection if it is not yet open
                cnn.Open()
            End If


            cmd.Connection = cnn
                cmd.CommandText = "INSERT INTO Products(ProductID, ProductName, UnitPrice, pdate) VALUES('" & TxPID.Text & "', '" & TxPN.Text.ToUpper & "', " & TxUP.Text & ", '" & Today.Date & "')"
            cmd.ExecuteNonQuery()


            RefreshData()
            ToolStripLabel1.Text = "New Data Is Added"
            TxPID.Text = ""
            TxPN.Text = ""
            TxUP.Text = ""

            TxPID.Focus()


            cnn.Close()
        End If



        Catch ex As Exception
            MsgBox("Product id repeat", MsgBoxStyle.Critical, "ERROR")
        End Try


        'update



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        GroupBox2.Visible = False
        GroupBox3.Visible = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click


        GroupBox2.Visible = 1
        GroupBox3.Visible = False
        Save.Visible = 1
        BtnUpdate.Visible = 0
        TxPID.Focus()
        TxPID.Text = ""
        TxPN.Text = ""
        TxUP.Text = ""
        pdate.Text = ""



    End Sub

    Private Sub TxPID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxPID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            If e.KeyChar <> ControlChars.Back Then

                'cancel keys

                e.Handled = True
            End If

        End If
    End Sub


    Private Sub TxPID_TextChanged(sender As Object, e As EventArgs) Handles TxPID.TextChanged
        Dim intValue As Integer
        If Not Integer.TryParse(TxPID.Text, intValue) Then
            Star1.Visible = 1

        End If

    End Sub

    Private Sub TxUP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxUP.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            If e.KeyChar <> ControlChars.Back Then

                'cancel keys

                e.Handled = True
            End If

        End If
    End Sub



    Private Sub TxUP_TextChanged(sender As Object, e As EventArgs) Handles TxUP.TextChanged
        Dim intValue As Integer
        If Not Integer.TryParse(TxUP.Text, intValue) Then
            Star2.Visible = 1
            AcceptButton = Save

        End If
    End Sub





    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        For Each SelectedRow As DataGridViewRow In DataGridView1.SelectedRows
            Dim value As String = (SelectedRow.Cells("ProductID").Value)



            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If



            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "DELETE FROM Products WHERE ProductID='" & value & "'"
            cmd.ExecuteNonQuery()
            'refresh data
            Me.RefreshData()
            ToolStripLabel1.Text = "Selected Record is Deleted"
            cnn.Close()
        Next
    End Sub





    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        ToolStripTextBox1.Text = ""
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown


        Try



            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                TxBuyOrder.Focus()

                'Do Stuff
            End If
            If e.KeyCode = Keys.Down Then



                If DataGridView1.RowCount > 0 Then

                    Dim MyDesiredIndex As Integer = 0

                    If DataGridView1.CurrentRow.Index < DataGridView1.RowCount - 1 Then
                        MyDesiredIndex = DataGridView1.CurrentRow.Index + 1
                    End If

                    DataGridView1.ClearSelection()
                    DataGridView1.CurrentCell = DataGridView1.Rows(MyDesiredIndex).Cells(0)
                    DataGridView1.Rows(MyDesiredIndex).Selected = True
                End If

            End If


            If e.KeyCode = Keys.Up Then



                If DataGridView1.RowCount > 0 Then

                    Dim MyDesiredIndex As Integer = 0

                    If DataGridView1.CurrentRow.Index < DataGridView1.RowCount Then
                        MyDesiredIndex = DataGridView1.CurrentRow.Index - 1
                    End If

                    DataGridView1.ClearSelection()
                    DataGridView1.CurrentCell = DataGridView1.Rows(MyDesiredIndex).Cells(0)
                    DataGridView1.Rows(MyDesiredIndex).Selected = True
                End If

            End If

        Catch ex As Exception

        End Try


        If e.KeyCode = Keys.Space Then
            Button2.PerformClick()

        End If

    End Sub







    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT ProductID, ProductName, UnitPrice" & " FROM Products" & " Where ProductName LIKE '%" & ToolStripTextBox1.Text & "%' Order by ProductID", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.DataGridView1.DataSource = dt

        'close connection
        cnn.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If DataGridView1.RowCount <= 0 Then


        Else


            BtnUpdate.Visible = 1
            GroupBox2.Visible = 1
            GroupBox3.Visible = 0
            Save.Visible = 0
            Dim i = DataGridView1.CurrentRow.Index
            If i = -1 Then
                MsgBox(" Can not be Update ")
            End If
            TxPID.Text = DataGridView1.Item(0, i).Value
            TxPN.Text = DataGridView1.Item(1, i).Value
            TxUP.Text = DataGridView1.Item(2, i).Value
            pdate.Text = DataGridView1.Item(3, i).Value
        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            Dim i = DataGridView1.CurrentRow.Index


            TxPID.Text = DataGridView1.Item(0, i).Value
            TxPN.Text = DataGridView1.Item(1, i).Value
            TxUP.Text = DataGridView1.Item(2, i).Value
            pdate.Text = DataGridView1.Item(3, i).Value
           
        Catch ex As Exception

        End Try
    End Sub





    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim i = DataGridView1.CurrentRow.Index


            ' TxPID.Text = DataGridView1.Item(0, i).Value
            ' TxPN.Text = DataGridView1.Item(1, i).Value
            ' TxUP.Text = DataGridView1.Item(2, i).Value

            TxBuyPName.Text = DataGridView1.Item(1, i).Value
            TxBuyPPrice.Text = DataGridView1.Item(2, i).Value
            TxBuyOrder.Text = ""
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click, BtnUpdate.Click
        Try

       
        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            'open connection if it is not yet open
            cnn.Open()
        End If

        cmd.Connection = cnn

            cmd.CommandText = "UPDATE Products SET ProductName='" & TxPN.Text.ToString & "', UnitPrice=" & TxUP.Text & ", pdate='" & DateTime.Now.ToString() & "' WHERE ProductID='" & TxPID.Text & "'"

        cmd.ExecuteNonQuery()
        cnn.Close()
        RefreshData()
        ToolStripLabel1.Text = "Record Updated"
        Catch ex As Exception
            MsgBox("something is wrong")
        End Try
    End Sub





    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnBuy.Click
        If TxBuyOrder.Text = "" Then
            MsgBox("How Much You Want " & TxBuyPName.Text, MsgBoxStyle.OkOnly)
        Else

            If TxCname.Text = "" Then
                MsgBox("Please Enter Customer Name")
            Else
                ListBox1.Items.Add(TxBuyPName.Text)
                ListBox2.Items.Add(TxUP.Text)
                ListBox3.Items.Add(TxBuyOrder.Text)

                ListBox4.Items.Add(Integer.Parse(TxBuyPPrice.Text) * Double.Parse(TxBuyOrder.Text))




                TxBuyOrder.Text = ""
                TxBuyPName.Text = ""
                TxBuyPPrice.Text = ""
                CName.Text = TxCname.Text.ToUpper
                CAddress.Text = TxCAddress.Text.ToUpper
                Cphone.Text = TxCPhone.Text

                LdATE.Text = Today.Date

            End If
        End If
        ToolStripTextBox1.Focus()
        ToolStripTextBox1.Text = ""
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        BtnPrint.Enabled = 1

        If ListBox4.Items.Count = 0 Then
            MsgBox("Nothing Added")
        Else

            Dim count As Integer
            Dim c As Integer
            Dim sum As Integer = 0
            count = ListBox4.Items.Count

            For c = 0 To count - 1
                sum = sum + ListBox4.Items(c)
                Total.Text = sum
            Next



            TxCAddress.Text = ""
            TxCname.Text = ""
            TxCPhone.Text = ""



            'saving
            Try

           

            'list box 1 to string

            Dim i As Integer = ListBox1.Items.Count - 1
            Dim PNlist As String = " "
            Dim BUnitPrice As String = " "
            Dim BOrder As String = " "

            For i = 0 To i
                Dim a As String = ListBox1.Items(i)
                Dim b As String = ListBox2.Items(i)
                Dim d As String = ListBox3.Items(i)
                PNlist = PNlist & "/" & a
                BUnitPrice = BUnitPrice & "/" & b
                BOrder = BOrder & "/" & d
            Next








            Dim cmd As New OleDb.OleDbCommand


            If Not cnn.State = ConnectionState.Open Then
                'open connection if it is not yet open
                cnn.Open()
            End If


            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO Customer(BillNo, CName, CAddress, CPhone, BProduct, BUnitPrice, BOrder, CDate, GT, seller) VALUES(" & lbillno.Text & ", '" & CName.Text & "', '" & CAddress.Text & "', '" & Cphone.Text & "', '" & PNlist & "', '" & BUnitPrice & "', '" & BOrder & "', '" & Today.Date & "', " & Total.Text & ", '" & sName.Text & "')"
            cmd.ExecuteNonQuery()


            ToolStripLabel1.Text = "New Data Is Added"



            cnn.Close()

            Catch ex As Exception

            End Try

        End If

    End Sub









    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print.Show()


       
    End Sub

    Private Sub TxBuyOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles TxBuyOrder.KeyDown






        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnBuy.PerformClick()


            'Do Stuff
        End If
    End Sub

    

    Private Sub TxCPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles TxCPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripTextBox1.Focus()
            e.SuppressKeyPress = True
            'Do Stuff
        End If
    End Sub

    Private Sub TxCname_KeyDown(sender As Object, e As KeyEventArgs) Handles TxCname.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxCAddress.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub









  
  
   
   
  
   
    Private Sub TxCAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles TxCAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxCPhone.Focus()
            e.SuppressKeyPress = True


        End If
    End Sub


    Public Sub clearbill()
        LdATE.Text = ""
        lbillno.Text = ""
        CName.Text = ""
        CAddress.Text = ""
        Cphone.Text = ""
        Total.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()


    End Sub

    Private Sub TxCPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxCPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            If e.KeyChar <> ControlChars.Back Then

                'cancel keys

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TxBuyOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxBuyOrder.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            If e.KeyChar <> ControlChars.Back Then

                'cancel keys

                e.Handled = True
            End If

        End If
    End Sub



    
   
   
   
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
