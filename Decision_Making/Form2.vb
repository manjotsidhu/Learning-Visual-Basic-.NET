Public Class Form2

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clc1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim inmn As Integer = TextBox1.Text
        Dim otmn As String
        Select Case TextBox1.Text
            Case 1 To 40
                otmn = "YOU ARE FAILED"
            Case 40 To 50
                otmn = "YOUR GRADE IS C2"
            Case 50 To 60
                otmn = "YOUR GRADE IS C1"
            Case 60 To 70
                otmn = "YOUR GRADE IS B2"
            Case 70 To 80
                otmn = "YOUR GRADE IS B1"
            Case 80 To 90
                otmn = "YOUR GRADE IS A2"
            Case 90 To 100
                otmn = "YOUR GRADE IS A1"
            Case Else
                otmn = "INVALID NUMBER"
        End Select
        otmn = TextBox2.Text
    End Sub
End Class