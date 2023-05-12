Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Form1.GroupBox6.BackColor
        Label1.Text = Form1.TextBox18.Text
        Label2.Text = Form1.TextBox17.Text
        Label3.Text = Form1.TextBox19.Text
        Label4.Text = Form1.TextBox20.Text
        Label5.Text = Form1.TextBox21.Text
        Label6.Text = "停止代码:" + Form1.TextBox16.Text
        PictureBox1.BackgroundImage = Form1.PictureBox10.BackgroundImage
    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click
        Close()
    End Sub
End Class