Imports System.Data.OleDb
Public Class user

    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Products.mdb")
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If


        Dim du As New OleDb.OleDbDataAdapter("select * from username", cnn)
        Dim dut As New DataTable

        'fill data to datatable
        du.Fill(dut)

        'offer data in data table into datagridview

        Me.dgUser.DataSource = dut
        'close connection
        cnn.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Coral
        Password.UseSystemPasswordChar = True
        repassword.UseSystemPasswordChar = True
        RefreshData()



    End Sub


   



   


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Me.ID.Tag & "" = "" Then  'checking update or add new


            'add

            Try


                If repassword.Text = Password.Text Then



                    Dim cmd As New OleDb.OleDbCommand


                    If Not cnn.State = ConnectionState.Open Then
                        'open connection if it is not yet open
                        cnn.Open()
                    End If


                    cmd.Connection = cnn
                    cmd.CommandText = "INSERT INTO username( id, uname, upassword, type) VALUES(" & ID.Text & ", '" & username.Text & "', '" & Password.Text & "', '" & Type.Text & "')"
                    cmd.ExecuteNonQuery()




                    cnn.Close()
                    RefreshData()


                Else
                    MsgBox("Please enter valid password combination")
                End If




            Catch ex As Exception
                MsgBox("cann't add new user somthing is wrong")
            End Try

        Else
            'update




        End If

        ID.Text = ""
        username.Text = ""
        Password.Text = ""
        repassword.Text = ""
        Type.Text = ""



    End Sub

    Private Sub dgUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUser.CellDoubleClick
        Try

            Dim count As Integer = dgUser.CurrentRow.Index
            ID.Text = dgUser.Item(0, count).Value
            username.Text = dgUser.Item(1, count).Value
            Password.Text = dgUser.Item(2, count).Value
            repassword.Text = dgUser.Item(2, count).Value
            Type.Text = dgUser.Item(3, count).Value

            btnupdate.Visible = 1
            Btnsave.Visible = 0

        Catch ex As Exception
            MsgBox("somthing is wrong")
        End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btnupdate.Visible = False
        Btnsave.Visible = True
        username.Text = ""
        Password.Text = ""
        repassword.Text = ""
        ID.Text = ""
        Type.Text = ""
    End Sub

    Private Sub dgUser_KeyDown(sender As Object, e As KeyEventArgs) Handles dgUser.KeyDown






        Try
            If e.KeyCode = Keys.Delete Then


                Dim result As DialogResult = MsgBox("Do you want to delete !!!", MsgBoxStyle.OkCancel)
                If result = Windows.Forms.DialogResult.OK Then




                    Dim i As Integer = dgUser.CurrentRow.Index
                    Dim id As Integer = dgUser.Item(0, i).Value



                    If Not cnn.State = ConnectionState.Open Then
                        'open connection if it is not yet open
                        cnn.Open()
                    End If


                    Dim cmd As New OleDbCommand
                    cmd.Connection = cnn
                    cmd.CommandText = "delete * from username where id=" & id & ""
                    cmd.ExecuteNonQuery()


                    RefreshData()

                    cnn.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox("somthing is wrong")
        End Try


    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If Password.Text = repassword.Text Then


            Try
                cnn.Open()
                Dim cmd As New OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "UPDATE username set uname='" & username.Text & "', upassword='" & Password.Text & "', type='" & Type.Text & "' where id=" & ID.Text & ""

                cmd.ExecuteNonQuery()
                cnn.Close()
                RefreshData()
                btnupdate.Visible = False
                Btnsave.Visible = True

            Catch ex As Exception
                MsgBox("something is wrong!!")

            End Try
            ID.Text = ""
            username.Text = ""
            Password.Text = ""
            repassword.Text = ""
            Type.Text = ""
        Else
            MsgBox("password do not match!!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            Password.UseSystemPasswordChar = False
            repassword.UseSystemPasswordChar = False
        Else
            Password.UseSystemPasswordChar = True
            repassword.UseSystemPasswordChar = True

        End If


    End Sub

    Private Sub ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            If e.KeyChar <> ControlChars.Back Then

                'cancel keys

                e.Handled = True
            End If

        End If
    End Sub


    
    Private Sub ID_TextChanged(sender As Object, e As EventArgs) Handles ID.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class