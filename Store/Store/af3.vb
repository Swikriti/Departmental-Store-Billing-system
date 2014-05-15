
Imports System.Data.OleDb
Public Class af3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ToolStripLabel2.Text = Today.Date

        username.Text = loginform1.user


        If loginform1.security = "Administrator" Then
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton4.Enabled = True
            BtnUser.Enabled = True
        ElseIf loginform1.security = "User" Then
            ToolStripButton1.Enabled = True
            ToolStripButton4.Enabled = True

        End If


        ToolStripLabel1.Text = loginform1.security



        Me.IsMdiContainer = True


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click


        af1.MdiParent = Me
        af2.Close()
        sell.Close()
        user.Close()
        af1.Show()




    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click


        af2.MdiParent = Me

        af1.Close()
        sell.Close()
        user.Close()
        af2.Show()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        loginform1.Show()

        Me.Close()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles BtnUser.Click


        user.MdiParent = Me

        af1.Close()
        sell.Close()

        af2.Close()



        user.Show()


    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click


        sell.MdiParent = Me

        af1.Close()

        user.Close()
        af2.Close()



        sell.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class