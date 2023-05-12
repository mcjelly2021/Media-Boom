Public Class win11sytle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub win11sytle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.CheckBox1.Checked = True Then
            Label1.Text = Form1.TextBox3.Text + "." + Form1.TextBox4.Text + "没有响应."
        Else
            Label1.Text = Form1.TextBox3.Text + "." + Form1.TextBox4.Text
        End If
        ' Label1.Text = Form1.TextBox3.Text + "." + Form1.TextBox4.Text + "没有响应."
        Me.Text = Form1.TextBox2.Text
        Button1.Text = Form1.TextBox8.Text
        Button2.Text = Form1.TextBox6.Text
        Label2.Text = Form1.TextBox5.Text + Form1.TextBox7.Text
        'Label3.Text = 
    End Sub

    Private Sub win11sytle_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub
End Class