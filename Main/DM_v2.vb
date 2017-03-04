Public Class DM_v2

    Private Sub lp1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intx1 As String = TextBox1.Text
        Dim intx2 As String = TextBox2.Text
        Dim tes As Integer
        For tes = 1 To TextBox2.Text
            RichTextBox1.Text &= Environment.NewLine & TextBox1.Text
        Next tes
    End Sub
End Class