﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "Hello ! This is my first Program"
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub my1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mnj As String
        mnj = "My Name Is Manjot Sidhu"
        TextBox1.Text = mnj
    End Sub
End Class
