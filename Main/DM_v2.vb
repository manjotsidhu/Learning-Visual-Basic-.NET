Public Class DM_v2

    Private Sub lp1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intx1 As String = TextBox1.Text
        Dim intx2 As String = TextBox2.Text
        Dim tes As Integer
        For tes = 1 To TextBox2.Text
            RichTextBox1.Text &= "     " & TextBox1.Text
        Next tes
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
End Class