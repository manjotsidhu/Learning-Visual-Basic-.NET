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
        Dim Second As New DM_v1
        Second.TopLevel = False
        Second.Parent = TabControl1.TabPages(1)
        Second.Show()
        Dim Third As New DM_v2
        Third.TopLevel = False
        Third.Parent = TabControl1.TabPages(2)
        Third.Show()
        TabControl1.Size = New System.Drawing.Size(500, 330)
        If TabControl1.Visible Then
            GroupBox3.Height = 462
            RichTextBox2.Height = 435
            If CheckBox2.Checked Then
                Size = New System.Drawing.Size(750, 569)
            Else
                Size = New System.Drawing.Size(544, 569)
            End If
            GroupBox2.Location = New Point(13, 420)
        Else
            GroupBox3.Height = 233
            RichTextBox2.Height = 208
            If CheckBox2.Checked Then
                Size = New System.Drawing.Size(750, 339)
            Else
                Size = New System.Drawing.Size(544, 339)
            End If
            GroupBox2.Location = New Point(13, 195)
        End If
    End Sub

    Private Sub mn(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Text = System.IO.File.ReadAllText("iss.txt")
        RichTextBox2.Text = System.IO.File.ReadAllText("chnglog.txt")
    End Sub

    Private Sub bx(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.Click
        Dim ino As Integer
        ino = MsgBox("Now You Can Add Your Own Issue . Don't Forget To commit the changes . Good Luck ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly + MsgBoxStyle.SystemModal, "Issues")
    End Sub

    Private Sub sv(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        System.IO.File.WriteAllText("iss.txt", RichTextBox1.Text)
    End Sub

    Private Sub chnglog(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            Me.Width = 750
            GroupBox3.Show()
            Label1.Location = New Point(196, 9)
        Else
            Me.Width = 544
            GroupBox3.Hide()
            Label1.Location = New Point(96, 9)
        End If
    End Sub
End Class
