Imports System.Data.OleDb

Public Class loginform1


    Public a As Integer
    Public b As Integer
    Public security As String
    Public user As String


    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Products.mdb")
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click





        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM username where uname='" & UsernameTextBox.Text & "' and upassword='" & PasswordTextBox.Text & "'", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)
        a = dt.Rows.Count







        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM username where uname='" & UsernameTextBox.Text & "' and upassword='" & PasswordTextBox.Text & "' and type='administrator'", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa.Fill(dtt)
        b = dtt.Rows.Count



        user = UsernameTextBox.Text.ToUpper



        If a = 1 And b = 1 Then
            security = "Administrator"
        ElseIf a = 1 And b = 0 Then
            security = "User"

        End If


        If a = 1 Then

            af3.Show()


        Else
            MsgBox("Check your username password", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub






    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightBlue
    End Sub
End Class
