Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = Form1.TextBox14.Text
        Label1.Text = "你可能是" + Form1.TextBox9.Text + "的受害者!"
        Label2.Text = "请更新" + Form1.TextBox13.Text + "以确保您使用的是正版"
        Button1.Text = Form1.TextBox11.Text
        Button2.Text = Form1.TextBox10.Text
        PictureBox1.BackgroundImage = Image.FromFile(Form1.TextBox12.Text)
    End Sub
End Class