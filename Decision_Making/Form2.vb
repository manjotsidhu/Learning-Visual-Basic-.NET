﻿Public Class Form2

    Private Sub inmn(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim valin As String = TextBox1.Text
        Select Case valin
            Case 1 To 40
                TextBox2.Text = "YOU ARE FAILED"
            Case 40 To 50
                TextBox2.Text = "Your Grade is C2"
            Case 50 To 60
                TextBox2.Text = "Your Grade is C1"
            Case 60 To 70
                TextBox2.Text = "Your Grade is B2"
            Case 70 To 80
                TextBox2.Text = "Your Grade is B1"
            Case 80 To 90
                TextBox2.Text = "Your Grade is A2"
            Case 90 To 101
                TextBox2.Text = "Your Grade is A1"
            Case Else
                TextBox2.Text = "INVALID NUMBER"
        End Select
    End Sub

    Private Sub outmn(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Valot As String = TextBox2.Text
    End Sub
End Class