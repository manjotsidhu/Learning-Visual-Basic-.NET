Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "Hello ! This is my first Program"
        TextBox1.TextAlign = HorizontalAlignment.Center
        Button1.Text = "Press Me"
    End Sub

    Private Sub my1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mnj As String
        mnj = "My Name Is Manjot Sidhu"
        TextBox1.Text = mnj
        Button1.Text = "Thank You"
    End Sub

    Private Sub my2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        Dim press As String = "After Entering Press Me"
        Button1.Text = press
        Button1.TextAlign = ContentAlignment.MiddleCenter
        Button1.AutoSize = True
    End Sub
End Class
