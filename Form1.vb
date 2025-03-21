Public Class Form1
    Dim flag As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If flag = "Log In" Then
            Dim sqlconn As New SqlConnection("Data Source=R6\SQLEXPRESS;Initial Catalog=ADONET;Integrated Security=True;Encrypt=False")
            sqlconn.Open()
            Dim sql As String
            sql = "SELECT FirstName, Password from Forms WHERE FirstName= '" & Me.TextBox1.Text & "', Password= '" & Me.TextBox2.Text & "')"


        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
