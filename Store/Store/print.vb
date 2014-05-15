Public Class print

    Private Sub print_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With af1
            lbillno.Text = .lbillno.Text
            CName.Text = .CName.Text
            CAddress.Text = .CAddress.Text
            LdATE.Text = .LdATE.Text
            Cphone.Text = .Cphone.Text
            Total.Text = .Total.Text
            sName.Text = .sName.Text


            For i As Int32 = 0 To .ListBox1.Items.Count - 1
                ListBox1.Items.Add(.ListBox1.Items(i).ToString.ToUpper)
                ListBox2.Items.Add(.ListBox2.Items(i).ToString.ToUpper)
                ListBox3.Items.Add(.ListBox3.Items(i).ToString.ToUpper)
                ListBox4.Items.Add(.ListBox4.Items(i).ToString.ToUpper)
            Next



        End With





       
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        BtnPrint.Visible = False
       



        PrintForm1.Print()

    End Sub

  

    

   

   
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class