Public Class Main

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub my1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Text = "First Program"
        Form1.Show()
    End Sub

    Private Sub my2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Text = "Decision Making with Select Case"
        Form2.Show()
    End Sub
End Class
