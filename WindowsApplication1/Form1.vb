Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "Hello ! This is my first Program"
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub
    Sub Main()
        Dim mnj As String
        mnj = "My Name Is Manjot Sidhu"
        System.Console.WriteLine(mnj)
    End Sub
End Class
