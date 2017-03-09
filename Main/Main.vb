Public Class Main
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub my1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        First_program.Text = "First Program"
        First_program.Show()
    End Sub

    Private Sub my2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DM_v1.Text = "Decision Making with Select Case"
        DM_v1.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DM_v2.Text = "Decision Making with Loop"
        DM_v2.Show()
    End Sub

    Private Sub chnge(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            GroupBox1.Hide()
            TabControl1.Show()
        Else
            GroupBox1.Show()
            TabControl1.Hide()
        End If
    End Sub

    Private Sub first(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.VisibleChanged
        Dim first As New First_program
        first.TopLevel = False
        first.Parent = TabControl1.TabPages(0)
        first.Show()
        TabControl1.Size = New System.Drawing.Size(500, 330)
        If TabControl1.Visible Then
            Size = New System.Drawing.Size(544, 569)
            GroupBox2.Location = New Point(13, 420)
        Else
            Size = New System.Drawing.Size(544, 339)
            GroupBox2.Location = New Point(13, 195)
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
