Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Dim f, b, c, d As Int64
    Dim x, y As Int64
    Dim x1, x2 As Color
    Dim xr, xg, xb As Int64
    Dim c1 As Color
    Public title, button_1, button_2, filename, Ext, if_, closes As String

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim bmp As New Bitmap(256, 256)
        Dim r, g, b, a, q As Int64
        Dim fn As String
        Dim sfd As New SaveFileDialog
        sfd.Filter = ""
        sfd.FileName = "my picture"
        If sfd.ShowDialog() = DialogResult.OK Then
            fn = sfd.FileName
        End If
        With bmp
            For b = 0 To 255
                For r = 0 To 255
                    For g = 0 To 255
                        .SetPixel(r, g, Color.FromArgb(255, r, g, b))
                    Next g
                Next r
                bmp.Save(fn + CStr(b) + ".bmp")
            Next b
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If PB6.BackgroundImage Is Nothing Then
            MsgBox("error!")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PB6.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PB6.BackgroundImage)
            End If

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim bmp As New Bitmap(256, 65536)
        Dim r, g, b, a, q, d As Int64
        d = 1
        For a = 0 To 255
            For q = 0 To 65536
                d += 1
                For r = 0 To 255
                    For g = 0 To 255
                        For b = 0 To 255

                        Next
                    Next
                Next
            Next
        Next
    End Sub

    Private Sub SaveImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveImageToolStripMenuItem.Click
        If PictureBox5.BackgroundImage Is Nothing Then
            MsgBox("error!")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                textpicture.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(textpicture.BackgroundImage)
            End If

        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox12.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox8.BackgroundImage = sss
            Panel1.BackgroundImage = sss
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox4.BackgroundImage = sss
            PictureBox9.BackgroundImage = sss
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        Label22.Text = TextBox15.Text
        Label22.Left = (Panel1.Width - Label22.Width) / 2
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox10.BackgroundImage = sss
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If IsNumeric(wi.Text) = True Then
            If IsNumeric(he.Text) = True Then
                Dim bmp As New Bitmap(CInt(wi.Text), CInt(he.Text))
                With bmp
                    For x = 0 To CInt(wi.Text) - 1
                        For y = 0 To CInt(he.Text) - 1
                            .SetPixel(x, y, Color.FromArgb(255, 255 * Rnd(), 255 * Rnd(), 255 * Rnd()))
                            PB6.BackgroundImage = bmp
                        Next y
                    Next x
                End With
                PB6.BackgroundImage = bmp
            Else
                MsgBox("error")
            End If
        Else
            MsgBox("error")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox11.BackgroundImage = sss
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If PictureBox11.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim bmp As New Bitmap(PictureBox11.BackgroundImage)
            Dim bmp2 As New Bitmap(PictureBox11.BackgroundImage.Width, PictureBox11.BackgroundImage.Height)
            Dim bmp3 As New Bitmap(PictureBox11.BackgroundImage.Width, PictureBox11.BackgroundImage.Height)
            Dim bmp4 As New Bitmap(PictureBox11.BackgroundImage.Width, PictureBox11.BackgroundImage.Height)
            Dim bmp5 As New Bitmap(PictureBox11.BackgroundImage.Width, PictureBox11.BackgroundImage.Height)
            Dim bmp6 As New Bitmap(PictureBox11.BackgroundImage.Width, PictureBox11.BackgroundImage.Height)
            Dim bmp7 As New Bitmap(PictureBox11.BackgroundImage.Width, PictureBox11.BackgroundImage.Height)
            For x = 0 To PictureBox11.BackgroundImage.Width - 1
                For y = 0 To PictureBox11.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp2.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PictureBox12.BackgroundImage = bmp2
                Next y
            Next x
            PictureBox12.BackgroundImage = bmp2
            For x = 0 To PictureBox11.BackgroundImage.Width - 1
                For y = 0 To PictureBox11.BackgroundImage.Height - 1
                    x1 = bmp2.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp3.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PictureBox12.BackgroundImage = bmp3
                Next y
            Next x
            PictureBox12.BackgroundImage = bmp3
            For x = 0 To PictureBox11.BackgroundImage.Width - 1
                For y = 0 To PictureBox11.BackgroundImage.Height - 1
                    x1 = bmp3.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp4.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PictureBox12.BackgroundImage = bmp4
                Next y
            Next x
            PictureBox12.BackgroundImage = bmp4
            For x = 0 To PictureBox11.BackgroundImage.Width - 1
                For y = 0 To PictureBox11.BackgroundImage.Height - 1
                    x1 = bmp4.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp5.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PictureBox12.BackgroundImage = bmp5
                Next y
            Next x
            PictureBox12.BackgroundImage = bmp5
            For x = 0 To PictureBox11.BackgroundImage.Width - 1
                For y = 0 To PictureBox11.BackgroundImage.Height - 1
                    x1 = bmp5.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp6.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PictureBox12.BackgroundImage = bmp6
                Next y
            Next x
            PictureBox12.BackgroundImage = bmp6
            For x = 0 To PictureBox11.BackgroundImage.Width - 1
                For y = 0 To PictureBox11.BackgroundImage.Height - 1
                    x1 = bmp6.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 1 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp7.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PictureBox12.BackgroundImage = bmp7
                Next y
            Next x
            PictureBox12.BackgroundImage = bmp7
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If PictureBox12.BackgroundImage Is Nothing Then
            MsgBox("error!")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PictureBox12.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PictureBox12.BackgroundImage)
            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox13.BackgroundImage = sss
            ListBox1.Items.Add("openfile:<" + OpenFileDialog1.FileName + ">")
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If PictureBox13.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim bmp As New Bitmap(PictureBox13.BackgroundImage)
            Dim a, r, g, b As Int64
            With bmp
                For x = 0 To .Width - 1
                    For y = 0 To .Height - 1
                        x1 = .GetPixel(x, y)
                        a = x1.A
                        r = x1.R
                        g = x1.G
                        b = x1.B
                        ListBox1.Items.Add("<" + CStr(x) + "," + CStr(y) + ">" + "ARGB:<" + CStr(a) + "," + CStr(r) + "," + CStr(g) + "," + CStr(b) + ">")
                    Next
                Next
            End With
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox14.BackgroundImage = sss
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim bmp As New Bitmap(PictureBox14.BackgroundImage, NumericUpDown1.Value, NumericUpDown2.Value)
        PictureBox15.BackgroundImage = bmp
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If PictureBox15.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PictureBox15.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PictureBox15.BackgroundImage)
            End If
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox16.BackgroundImage = sss
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If PictureBox16.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim bmp As New Bitmap(PictureBox16.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            Dim r, g, b As Int64
            With bmp
                For x = 0 To .Width - 1
                    For y = 0 To .Height - 1
                        x1 = .GetPixel(x, y)
                        r = x1.R
                        g = x1.G
                        b = x1.B
                        r = 255 - r
                        g = 255 - g
                        b = 255 - b
                        bmp2.SetPixel(x, y, Color.FromArgb(255, r, g, b))
                        PictureBox17.BackgroundImage = bmp2
                    Next y
                Next x
            End With
            PictureBox17.BackgroundImage = bmp2
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If PictureBox17.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PictureBox17.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PictureBox17.BackgroundImage)
            End If
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim a As Integer = 4 * Rnd()
        If a = 1 Then
            ListBox2.Items.Add(First.Items(119 * Rnd()))
        End If
        If a = 2 Then
            ListBox2.Items.Add(Thens.Items(119 * Rnd()))
        End If
        If a = 3 Then
            ListBox2.Items.Add(Nexts.Items(71 * Rnd()))
        End If
        If a = 4 Then
            ListBox2.Items.Add(Finallys.Items(29 * Rnd()))
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox19.BackgroundImage = sss
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If PictureBox19.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim bmp As New Bitmap(PictureBox19.BackgroundImage)
            Dim bmp2 As New Bitmap(PictureBox19.BackgroundImage.Width, PictureBox19.BackgroundImage.Height)
            Dim bmp3 As New Bitmap(PictureBox19.BackgroundImage.Width, PictureBox19.BackgroundImage.Height)
            Dim bmp4 As New Bitmap(PictureBox19.BackgroundImage.Width, PictureBox19.BackgroundImage.Height)
            Dim bmp5 As New Bitmap(PictureBox19.BackgroundImage.Width, PictureBox19.BackgroundImage.Height)
            Dim bmp6 As New Bitmap(PictureBox19.BackgroundImage.Width, PictureBox19.BackgroundImage.Height)
            Dim bmp7 As New Bitmap(PictureBox19.BackgroundImage.Width, PictureBox19.BackgroundImage.Height)
            For x = 0 To PictureBox19.BackgroundImage.Width - 1
                For y = 0 To PictureBox19.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 2 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 3 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp2.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PB18.BackgroundImage = bmp2
                Next y
            Next x
            PB18.BackgroundImage = bmp2
            For x = 0 To PictureBox19.BackgroundImage.Width - 1
                For y = 0 To PictureBox19.BackgroundImage.Height - 1
                    x1 = bmp2.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 2 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 3 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp3.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PB18.BackgroundImage = bmp3
                Next y
            Next x
            PB18.BackgroundImage = bmp3
            For x = 0 To PictureBox19.BackgroundImage.Width - 1
                For y = 0 To PictureBox19.BackgroundImage.Height - 1
                    x1 = bmp3.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 2 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 3 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp4.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PB18.BackgroundImage = bmp4
                Next y
            Next x
            PB18.BackgroundImage = bmp4
            For x = 0 To PictureBox19.BackgroundImage.Width - 1
                For y = 0 To PictureBox19.BackgroundImage.Height - 1
                    x1 = bmp4.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 2 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 3 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp5.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PB18.BackgroundImage = bmp5
                Next y
            Next x
            PB18.BackgroundImage = bmp5
            For x = 0 To PictureBox19.BackgroundImage.Width - 1
                For y = 0 To PictureBox19.BackgroundImage.Height - 1
                    x1 = bmp5.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 2 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 3 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp6.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PB18.BackgroundImage = bmp6
                Next y
            Next x
            PB18.BackgroundImage = bmp6
            For x = 0 To PictureBox19.BackgroundImage.Width - 1
                For y = 0 To PictureBox19.BackgroundImage.Height - 1
                    x1 = bmp6.GetPixel(x, y)
                    Dim a As Int64
                    Dim r, g, b, al As Int64
                    a = 3 * Rnd()
                    If a = 1 Then
                        al = x1.A
                        r = 255 * Rnd()
                        g = x1.G
                        b = x1.B
                    End If
                    If a = 2 Then
                        al = x1.A
                        r = x1.R
                        g = 255 * Rnd()
                        b = x1.B
                    End If
                    If a = 3 Then
                        al = x1.A
                        r = x1.R
                        g = x1.G
                        b = 255 * Rnd()
                    End If
                    bmp7.SetPixel(x, y, Color.FromArgb(al, r, g, b))
                    PB18.BackgroundImage = bmp7
                Next y
            Next x
            PB18.BackgroundImage = bmp7
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If PB18.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PB18.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PB18.BackgroundImage)
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip4_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip4.Opening

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox18.BackgroundImage = sss
            If PictureBox18.BackgroundImage.Width = 128 Then

            Else
                MsgBox("error")
            End If
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If PictureBox18.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim a As String
            a = "ffmpeg -r 12 -f image2 -i %d.png -crf 1 output.avi"
            Dim g, f As Int64
            Dim b As New Bitmap(PictureBox18.BackgroundImage)
            f = 1
            For g = 1 To 24
                Dim bmp As New Bitmap(b.Width, b.Height)
                For x = 0 To b.Width
                    For y = 0 To b.Height

                    Next
                Next
                f += 1
            Next
            'Process.Start(Application. + "\ffmpeg.exe", a)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If PictureBox20.BackgroundImage IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            For x = 0 To PictureBox20.BackgroundImage.Width - 1
                For y = 0 To PictureBox20.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    x1 = Color.FromArgb(255, CInt(x1.R + x1.G + x1.B) / 3, CInt(x1.R + x1.G + x1.B) / 3, CInt(x1.R + x1.G + x1.B) / 3)
                    bmp2.SetPixel(x, y, x1)
                Next y
            Next x
            PictureBox21.BackgroundImage = bmp2
        Else
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox20.BackgroundImage = sss
            RadioButton1.Checked = False
            RadioButton5.Checked = False
            RadioButton7.Checked = False
            RadioButton11.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton4.Checked = False
            RadioButton12.Checked = False
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If PictureBox21.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PictureBox21.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PictureBox21.BackgroundImage)
            End If
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If PictureBox20.BackgroundImage IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            For x = 0 To PictureBox20.BackgroundImage.Width - 1
                For y = 0 To PictureBox20.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    x1 = Color.FromArgb(255, CInt(255 - x1.R), CInt(255 - x1.G), CInt(255 - x1.B))
                    bmp2.SetPixel(x, y, x1)
                Next y
            Next x
            PictureBox21.BackgroundImage = bmp2
        Else
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Dim a As Int32 = 3 * Rnd()
        If a = 1 Then
            If PictureBox20.BackgroundImage IsNot Nothing Then
                Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
                Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
                For x = 0 To PictureBox20.BackgroundImage.Width - 1
                    For y = 0 To PictureBox20.BackgroundImage.Height - 1
                        x1 = bmp.GetPixel(x, y)
                        x1 = Color.FromArgb(255, x1.R, 0, 0)
                        bmp2.SetPixel(x, y, x1)
                    Next y
                Next x
                PictureBox21.BackgroundImage = bmp2
            Else
            End If
        End If
        If a = 2 Then
            If PictureBox20.BackgroundImage IsNot Nothing Then
                Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
                Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
                For x = 0 To PictureBox20.BackgroundImage.Width - 1
                    For y = 0 To PictureBox20.BackgroundImage.Height - 1
                        x1 = bmp.GetPixel(x, y)
                        x1 = Color.FromArgb(255, 0, x1.G, 0)
                        bmp2.SetPixel(x, y, x1)
                    Next y
                Next x
                PictureBox21.BackgroundImage = bmp2
            Else
            End If
        End If
        If a = 3 Then
            If PictureBox20.BackgroundImage IsNot Nothing Then
                Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
                Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
                For x = 0 To PictureBox20.BackgroundImage.Width - 1
                    For y = 0 To PictureBox20.BackgroundImage.Height - 1
                        x1 = bmp.GetPixel(x, y)
                        x1 = Color.FromArgb(255, 0, 0, x1.B)
                        bmp2.SetPixel(x, y, x1)
                    Next y
                Next x
                PictureBox21.BackgroundImage = bmp2
            Else
            End If
        End If
        If a = 0 Then
            If PictureBox20.BackgroundImage IsNot Nothing Then
                Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
                Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
                For x = 0 To PictureBox20.BackgroundImage.Width - 1
                    For y = 0 To PictureBox20.BackgroundImage.Height - 1
                        x1 = bmp.GetPixel(x, y)
                        x1 = Color.FromArgb(255, x1.R, 0, 0)
                        bmp2.SetPixel(x, y, x1)
                    Next y
                Next x
                PictureBox21.BackgroundImage = bmp2
            Else
            End If
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If PictureBox20.BackgroundImage IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            Dim r, g, b, r2, g2, b2 As Int32
            For x = 0 To PictureBox20.BackgroundImage.Width - 1
                For y = 0 To PictureBox20.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    r = x1.R
                    g = x1.G
                    b = x1.B
                    r2 = r * 128 / (g + b + 1)
                    g2 = g * 128 / (r + b + 1)
                    b2 = b * 128 / (g + r + 1)
                    If r2 >= 256 Then r2 = 255
                    If g2 >= 256 Then g2 = 255
                    If b2 >= 256 Then b2 = 255
                    If r2 <= 0 Then r2 = 0
                    If g2 <= 0 Then g2 = 0
                    If b2 <= 0 Then b2 = 0
                    x1 = Color.FromArgb(255, r2, g2, b2)
                    bmp2.SetPixel(x, y, x1)
                Next y
            Next x
            PictureBox21.BackgroundImage = bmp2
        Else
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If PictureBox20.BackgroundImage IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            Dim r, g, b, r2, g2, b2 As Int32
            For x = 0 To PictureBox20.BackgroundImage.Width - 1
                For y = 0 To PictureBox20.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    r = x1.R
                    g = x1.G
                    b = x1.B
                    r2 = (r - g - b) * 3 / 2
                    g2 = (g - r - b) * 3 / 2
                    b2 = (b - g - r) * 3 / 2
                    If r2 >= 256 Then r2 = 255
                    If g2 >= 256 Then g2 = 255
                    If b2 >= 256 Then b2 = 255
                    If r2 <= 0 Then r2 = 0
                    If g2 <= 0 Then g2 = 0
                    If b2 <= 0 Then b2 = 0
                    x1 = Color.FromArgb(255, r2, g2, b2)
                    bmp2.SetPixel(x, y, x1)
                Next y
            Next x
            PictureBox21.BackgroundImage = bmp2
        Else
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If PictureBox20.BackgroundImage IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            Dim r, g, b, r2, g2, b2 As Int32
            For x = 0 To PictureBox20.BackgroundImage.Width - 1
                For y = 0 To PictureBox20.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    r = x1.R
                    g = x1.G
                    b = x1.B
                    r2 = Math.Abs(g - b + g + r) * r / 256
                    g2 = Math.Abs(b - g + b + r) * r / 256
                    b2 = Math.Abs(b - g + b + r) * g / 256
                    If r2 >= 256 Then r2 = 255
                    If g2 >= 256 Then g2 = 255
                    If b2 >= 256 Then b2 = 255
                    If r2 <= 0 Then r2 = 0
                    If g2 <= 0 Then g2 = 0
                    If b2 <= 0 Then b2 = 0
                    x1 = Color.FromArgb(255, r2, g2, b2)
                    bmp2.SetPixel(x, y, x1)
                Next y
            Next x
            PictureBox21.BackgroundImage = bmp2
        Else
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If PictureBox20.BackgroundImage IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            Dim r, g, b, r2, g2, b2 As Int32
            For x = 0 To PictureBox20.BackgroundImage.Width - 1
                For y = 0 To PictureBox20.BackgroundImage.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    r = x1.R
                    g = x1.G
                    b = x1.B
                    r2 = r * 0.393 + g * 0.769 + b * 0.189
                    g2 = r * 0.349 + g * 0.686 + b * 0.168
                    b2 = r * 0.272 + g * 0.534 + b * 0.131
                    If r2 >= 256 Then r2 = 255
                    If g2 >= 256 Then g2 = 255
                    If b2 >= 256 Then b2 = 255
                    If r2 <= 0 Then r2 = 0
                    If g2 <= 0 Then g2 = 0
                    If b2 <= 0 Then b2 = 0
                    x1 = Color.FromArgb(255, r2, g2, b2)
                    bmp2.SetPixel(x, y, x1)
                Next y
            Next x
            PictureBox21.BackgroundImage = bmp2
        Else
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If PictureBox20.BackgroundImage IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
            Dim r, g, b, r2, g2, b2 As Int32
            For x = 0 To PictureBox20.BackgroundImage.Width - 2
                For y = 0 To PictureBox20.BackgroundImage.Height - 2
                    x1 = bmp.GetPixel(x, y)
                    x2 = bmp.GetPixel(x + 1, y + 1)
                    r = x1.R
                    g = x1.G
                    b = x1.B
                    r2 = Math.Min(Math.Abs(CInt(x1.R) - CInt(x2.R) + 128), 255)
                    g2 = Math.Min(Math.Abs(CInt(x1.G) - CInt(x2.G) + 128), 255)
                    b2 = Math.Min(Math.Abs(CInt(x1.B) - CInt(x2.B) + 128), 255)
                    If r2 >= 256 Then r2 = 255
                    If g2 >= 256 Then g2 = 255
                    If b2 >= 256 Then b2 = 255
                    If r2 <= 0 Then r2 = 0
                    If g2 <= 0 Then g2 = 0
                    If b2 <= 0 Then b2 = 0
                    x1 = Color.FromArgb(255, r2, g2, b2)
                    bmp2.SetPixel(x, y, x1)
                Next y
            Next x
            PictureBox21.BackgroundImage = bmp2
        Else
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        AAA.ShowDialog()
        AAA.Label1.Text = TextBox23.Text
        AAA.Text = TextBox24.Text
        AAA.Label2.Text = TextBox25.Text
        AAA.ComboBox1.Items.Clear()
        If TextBox26.Text IsNot Nothing Then AAA.ComboBox1.Items.Add(TextBox26.Text)
        If TextBox27.Text IsNot Nothing Then AAA.ComboBox1.Items.Add(TextBox27.Text)
        If TextBox28.Text IsNot Nothing Then AAA.ComboBox1.Items.Add(TextBox28.Text)
        If TextBox29.Text IsNot Nothing Then AAA.ComboBox1.Items.Add(TextBox29.Text)
        If TextBox30.Text IsNot Nothing Then AAA.ComboBox1.Items.Add(TextBox30.Text)
        If TextBox31.Text IsNot Nothing Then AAA.ComboBox1.Items.Add(TextBox31.Text)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            If sss.Width * 3 > 28000 Then
                MsgBox("error")
            Else
                If sss.Height * 3 > 28000 Then
                    MsgBox("error")
                Else
                    PictureBox22.Image = sss
                End If
            End If
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If PictureBox22.Image Is Nothing Then
            MsgBox("error")
        Else
            Dim bmp As New Bitmap(PictureBox22.Image)
            Dim tbmp As New Bitmap(bmp.Width * 4, bmp.Height * 4)

            'Dim tbmp As New Bitmap(5000, 5000)
            Dim r, g, b As Int32
            Dim rr, gg, bb As Color
            For x = 0 To bmp.Width - 1
                For y = 0 To bmp.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    r = x1.R
                    g = x1.G
                    b = x1.B
                    rr = Color.FromArgb(r, 0, 0)
                    gg = Color.FromArgb(0, g, 0)
                    bb = Color.FromArgb(0, 0, b)
                    'red
                    tbmp.SetPixel(x + x * 3, y + y * 3, rr)
                    tbmp.SetPixel(x + x * 3, y + y * 3 + 1, rr)
                    tbmp.SetPixel(x + x * 3, y + y * 3 + 2, rr)
                    'green
                    tbmp.SetPixel(x + x * 3 + 1, y + y * 3, gg)
                    tbmp.SetPixel(x + x * 3 + 1, y + y * 3 + 1, gg)
                    tbmp.SetPixel(x + x * 3 + 1, y + y * 3 + 2, gg)
                    'blue
                    tbmp.SetPixel(x + x * 3 + 2, y + y * 3, bb)
                    tbmp.SetPixel(x + x * 3 + 2, y + y * 3 + 1, bb)
                    tbmp.SetPixel(x + x * 3 + 2, y + y * 3 + 2, bb)

                    PictureBox23.BackgroundImage = tbmp
                Next
            Next
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If PictureBox23.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PictureBox23.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PictureBox23.BackgroundImage)
            End If
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            If sss.Width < 100 Then
                MsgBox("error")
            Else '
                If sss.Height < 100 Then
                    MsgBox("error")
                Else
                    PictureBox25.Image = sss
                End If
            End If
            PictureBox25.Image = sss
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim bmp As New Bitmap(PictureBox25.Image)
        Dim bmp2 As New Bitmap(bmp.Width, bmp.Height)
        Dim r, g, b As Int32
        For x = 1 To bmp.Width - 1
            For y = 1 To bmp.Height - 1
                x1 = bmp.GetPixel(x, y)
                x2 = bmp2.GetPixel(x, y)
                r = x1.R
                g = x1.G
                b = x1.B
                'bmp2.SetPixel(x, y, Color.FromArgb(0, g, 0))
                If x - bmp.Width / 50 < 0 Then
                Else
                    bmp2.SetPixel(x - bmp.Width / 50, y, Color.FromArgb(x2.R, x2.G, b))
                End If
                If x + bmp.Width / 50 > bmp.Width Then
                Else
                    bmp2.SetPixel(x + bmp.Width / 50 - 1, y, Color.FromArgb(r, x2.G, x2.B))
                End If
                PictureBox24.BackgroundImage = bmp2
            Next
        Next
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If PictureBox24.BackgroundImage Is Nothing Then
            MsgBox("error")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PictureBox24.BackgroundImage.Save(sfd.FileName, Imaging.ImageFormat.Png)
                Clipboard.SetImage(PictureBox24.BackgroundImage)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("Media Boom" + vbCrLf + "MMCjelly 2021-2023" + vbCrLf + "v1.2.3")
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        ListBox3.Items.Clear()
        ListBox5.Items.Clear()
        Dim a As New OpenFileDialog
        a.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
        a.Multiselect = True
        a.Title = "OPEN"
        If a.ShowDialog() = DialogResult.OK Then
            For Each FN In a.SafeFileNames
                ListBox3.Items.Add(FN)
            Next
            For Each filename In a.FileNames
                ListBox5.Items.Add(filename)
            Next
        End If
    End Sub


    Public images() As Bitmap

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click

        If ListBox3.Items.Count = 0 Then
            MsgBox("error")
            Exit Sub
        End If
        Dim asd As String
        Dim a As New SaveFileDialog
        a.Filter = ""
        a.Title = "save"
        If a.ShowDialog() = DialogResult.OK Then
            asd = a.FileName
            ReDim images(ListBox3.Items.Count)
            Dim bb As Integer = 0
            ListBox4.Items.Clear()
            For Each item As String In ListBox3.Items
                ListBox4.Items.Add("OUTPUT_" + item)
            Next
            For Each item As String In ListBox5.Items
                Dim image As New Bitmap(item)
                Dim bmp2 As New Bitmap(image.Width, image.Height)
                Dim r, g, b As Int32
                Dim c As Int64 = 0
                For x = 1 To image.Width - 1
                    For y = 1 To image.Height - 1
                        x1 = image.GetPixel(x, y)
                        x2 = bmp2.GetPixel(x, y)
                        r = x1.R
                        g = x1.G
                        b = x1.B
                        'bmp2.SetPixel(x, y, Color.FromArgb(0, g, 0))
                        If x - image.Width / 50 < 0 Then
                        Else
                            bmp2.SetPixel(x - image.Width / 50, y, Color.FromArgb(x2.R, x2.G, b))
                        End If
                        If x + image.Width / 50 > image.Width Then
                        Else
                            bmp2.SetPixel(x + image.Width / 50 - 1, y, Color.FromArgb(r, x2.G, x2.B))
                        End If
                    Next
                Next
                Dim FNP As String
                FNP = asd + bb.ToString() + ".png"
                bmp2.Save(FNP)
                bb += 1
            Next
        Else
            Exit Sub
        End If
        'Dim images(ListBox3.Items.Count) As Bitmap

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Dim R, G, B, RGB As Int64
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim tbmp As New Bitmap(bmp.Width, bmp.Height)
            For x = 0 To bmp.Width - 1
                For y = 0 To bmp.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    R = x1.R
                    G = x1.G
                    B = x1.B
                    RGB = (R + G + B) / 3
                    tbmp.SetPixel(x, y, Color.FromArgb(RGB, RGB, RGB))
                Next
            Next
            PictureBox21.BackgroundImage = tbmp
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Dim R, G, B, RGB As Int64
            Dim bmp As New Bitmap(PictureBox20.BackgroundImage)
            Dim tbmp As New Bitmap(bmp.Width, bmp.Height)
            For x = 0 To bmp.Width - 1
                For y = 0 To bmp.Height - 1
                    x1 = bmp.GetPixel(x, y)
                    R = x1.R
                    G = x1.G
                    B = x1.B
                    RGB = (R + G + B)
                    If RGB > 256 Then
                        x2 = Color.Black
                    End If
                    If RGB = 256 Then
                        x2 = Color.FromArgb(128, 128, 128)
                    End If
                    If RGB < 256 Then
                        x2 = Color.White
                    End If
                    tbmp.SetPixel(x, y, x2)
                Next
            Next
            PictureBox21.BackgroundImage = tbmp
        End If
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If TextBox34.Text Is "" Then
            MsgBox("error")
        Else
            Dim bmp As New Bitmap(TextBox34.Text)
            Dim a As New SaveFileDialog()
            a.Title = "Save"
            If RbPNG.Checked = True Then
                a.Filter = "PNG|*.png"
            Else
                If RbBMP.Checked = True Then
                    a.Filter = "BMP|*.bmp"
                Else
                    If RbJPG.Checked = True Then
                        a.Filter = "JPG|*.jpg"
                    Else
                        If RbICO.Checked = True Then
                            a.Filter = "icon|*.ico"
                        Else
                            If RbTIFF.Checked = True Then
                                a.Filter = "TIFF|*.tiff"
                            Else
                                If RbWMF.Checked = True Then
                                    a.Filter = "WMF|*.wmf"
                                Else
                                    If RbJPEG.Checked = True Then
                                        a.Filter = "Jpeg|*.jpeg"
                                    Else
                                        If RbMBMP.Checked = True Then
                                            a.Filter = "Memorybmp|*.bmp"
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If a.ShowDialog() = DialogResult.OK Then
                Dim ab As Imaging.ImageFormat
                If RbPNG.Checked = True Then
                    ab = Imaging.ImageFormat.Png
                    bmp.Save(a.FileName, ab)
                Else
                    If RbBMP.Checked = True Then
                        ab = Imaging.ImageFormat.Bmp
                        bmp.Save(a.FileName, ab)
                    Else
                        If RbJPG.Checked = True Then
                            ab = Imaging.ImageFormat.Png
                            bmp.Save(a.FileName, ab)
                        Else
                            If RbICO.Checked = True Then
                                ab = Imaging.ImageFormat.Icon
                                bmp.Save(a.FileName, ab)
                            Else
                                If RbTIFF.Checked = True Then
                                    ab = Imaging.ImageFormat.Tiff
                                    bmp.Save(a.FileName, ab)
                                Else
                                    If RbWMF.Checked = True Then
                                        ab = Imaging.ImageFormat.Wmf
                                        bmp.Save(a.FileName, ab)
                                    Else
                                        If RbJPEG.Checked = True Then
                                            ab = Imaging.ImageFormat.Jpeg
                                            bmp.Save(a.FileName, ab)
                                        Else
                                            If RbMBMP.Checked = True Then
                                                ab = Imaging.ImageFormat.MemoryBmp
                                                bmp.Save(a.FileName, ab)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox34.Text = OpenFileDialog1.FileName
            OpenFileDialog1.FileName = ""
        End If
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim a As New SaveFileDialog()
        a.Filter = "MOD FILE|*.mod"
        a.FileName = "example mod"
        If a.ShowDialog() = DialogResult.OK Then
            Dim b As String
            b = TextBox35.Text
            My.Computer.FileSystem.WriteAllText(a.FileName, b, False)
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox34.Text = OpenFileDialog1.FileName
            OpenFileDialog1.FileName = ""
        End If
    End Sub

    Public Function GetAllThePixelInThePicture(Picture As Bitmap) As Color(,)
        Dim Colors(Picture.Width, Picture.Height) As Color
        For x = 0 To Picture.Width - 1
            For y = 0 To Picture.Height - 1
                x1 = Picture.GetPixel(x, y)
                Colors(x, y) = x1
            Next
        Next
        Return Colors
    End Function

    Public Function GetPixelFromImage(Picture As Bitmap, X As Integer, Y As Integer) As Color
        Dim colorx As Color
        colorx = Picture.GetPixel(X, Y)
        Return colorx
    End Function

    Public Function SetPixelToTheImage(Picture As Bitmap, X As Integer, Y As Integer, color As Color)
        Dim AAA As Boolean = True
        Try
            Picture.SetPixel(X, Y, color)
        Catch ex As Exception
            AAA = False
        End Try
        Return AAA
    End Function

    Public Function ADD(A As Single, B As Single) As Single
        Dim LAST As Single = A + B
        Return LAST
    End Function

    Public Function Plus(A As Single, B As Single) As Single
        Dim LAST As Single = A - B
        Return LAST
    End Function
    Public Function Cheng(A As Single, B As Single) As Single
        Dim LAST As Single = A * B
        Return LAST
    End Function

    Public Function Chu(A As Single, B As Single) As Single
        Dim LAST As Single = A / B
        Return LAST
    End Function

    Public Function ABS(A As Single) As Single
        Dim LAST As Single = Math.Abs(A)
        Return LAST
    End Function
    Public Function Sin(A As Single) As Single
        Dim LAST As Single = Math.Sin(A)
        Return LAST
    End Function

    Public Function COS(A As Single) As Single
        Dim LAST As Single = Math.Cos(A)
        Return LAST
    End Function

    Public Const PI As Double = 3.1415926535897931
    Public Const JBW As Double = 785.78578578578583

    Public Function GetPixelR(Picture As Bitmap, X As Integer, Y As Integer) As Int32
        Dim r As Int32
        r = Picture.GetPixel(X, Y).R
        Return R
    End Function

    Public Function GetPixelG(Picture As Bitmap, X As Integer, Y As Integer) As Int32
        Dim G As Int32
        G = Picture.GetPixel(X, Y).G
        Return G
    End Function

    Public Function GetPixelB(Picture As Bitmap, X As Integer, Y As Integer) As Int32
        Dim B As Int32
        B = Picture.GetPixel(X, Y).B
        Return b
    End Function

    Public Function GetPixelA(Picture As Bitmap, X As Integer, Y As Integer) As Int32
        Dim A As Int32
        A = Picture.GetPixel(X, Y).A
        Return A
    End Function

    Public Function MakeColor(A As Int32, R As Int32, G As Int32, B As Int32) As Color
        Return Color.FromArgb(A, R, G, B)
    End Function

    Public Function GetWidth(Picture As Bitmap) As Integer
        Return Picture.Width
    End Function
    Public Function GetHeight(Picture As Bitmap) As Integer
        Return Picture.Height
    End Function

    'Public function


    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        If TextBox36.Text Is Nothing Then
            MsgBox("ERROR!!!")
        Else
            If PictureBox26.BackgroundImage IsNot Nothing Then
                MsgBox("ERROR!!!")
            Else
                Dim Bitmaps(5) As Bitmap
                Bitmaps(0) = PictureBox26.BackgroundImage
                Bitmaps(1) = New Bitmap(PictureBox26.BackgroundImage.Width, PictureBox26.BackgroundImage.Height)
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox6.BackgroundImage = sss
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim image As New Bitmap(PictureBox6.BackgroundImage)
        Dim a, b As Integer
        Dim q As Int64
        If image.Height Mod 2 = 1 Then
            b = image.Height + 1
        Else
            b = image.Height
        End If
        a = image.Width
        Dim bmp As New Bitmap(a, CInt(b / 2))
        q = 0
        For y = 0 To bmp.Height / 2 Step 2
            For x = 0 To image.Width - 1
                x1 = image.GetPixel(x, y)
                bmp.SetPixel(x, q, x1)
            Next
            q += 1
        Next
        PictureBox7.BackgroundImage = bmp
    End Sub

    Private Sub Blue_Scroll(sender As Object, e As EventArgs) Handles Blue.Scroll
        Bb.Text = Blue.Value
        c1 = Color.FromArgb(255, CInt(Rr.Text), CInt(Gg.Text), CInt(Bb.Text))
        Pr.BackColor = c1
    End Sub

    Private Sub Green_Scroll(sender As Object, e As EventArgs) Handles Green.Scroll
        Gg.Text = Green.Value
        c1 = Color.FromArgb(255, CInt(Rr.Text), CInt(Gg.Text), CInt(Bb.Text))
        Pr.BackColor = c1
    End Sub
    Private Sub Red_Scroll(sender As Object, e As EventArgs) Handles Red.Scroll

        Rr.Text = Red.Value
        c1 = Color.FromArgb(255, CInt(Rr.Text), CInt(Gg.Text), CInt(Bb.Text))
        Pr.BackColor = c1
    End Sub

    Private Sub SaveIamgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveIamgeToolStripMenuItem.Click
        If PictureBox2.BackgroundImage Is Nothing Then
            MsgBox("error!")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "images|*.png;*.jpg;*.bmp;*.jpeg"
            sfd.FileName = "my picture.png"
            If sfd.ShowDialog() = DialogResult.OK Then
                PictureBox2.BackgroundImage.Save(sfd.FileName)
                Clipboard.SetImage(PictureBox2.BackgroundImage)
            End If

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text Is Nothing Then
            MsgBox("error")
        Else
            Dim text As String
            Dim c, leng As Int64
            Dim thc As Char
            Dim x2 As Color
            Dim cochr As Int64
            Dim rrgb As Int64
            Dim aaa, rrr, ggg, bbb As Integer
            text = RTrim(TextBox1.Text)
            leng = text.Length
            Dim bmp As New Bitmap(CInt(leng + 1), 1)
            For x = 0 To leng
                thc = Mid(text, x + 1, 1)
                rrgb = 255000000000 + (Asc(thc))
                x2 = Color.FromArgb(rrgb)
                bmp.SetPixel(x, 0, x2)
                textpicture.BackgroundImage = bmp
            Next
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        title = TextBox2.Text
        filename = TextBox3.Text
        Ext = TextBox4.Text
        if_ = TextBox5.Text
        button_1 = TextBox6.Text
        closes = TextBox7.Text
        button_2 = TextBox8.Text
        win11sytle.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PictureBox1.BackgroundImage Is Nothing Then
            MsgBox("error!")
        Else
            Dim ee As New Bitmap(PictureBox1.BackgroundImage)
            Dim ee2 As New Bitmap(ee.Width, ee.Height)
            Dim colormap(ee.Width, ee.Height) As Color
            a = (ee2.Width) * (ee2.Height) * 2 + 20
            ProgressBar1.Maximum = a
            ProgressBar1.Value = 0
            With ee
                For x = 0 To .Width - 1
                    For y = 0 To .Height - 1
                        x1 = .GetPixel(x, y)
                        colormap(ee.Width - x, ee.Height - y) = x1
                        ProgressBar1.Value = ProgressBar1.Value + 1
                    Next
                Next
            End With
            With ee2
                For x = 0 To .Width - 1
                    For y = 0 To .Height - 1
                        x1 = colormap(x, y)
                        ee2.SetPixel(x, y, x1)
                        colormap(ee.Width - x, ee.Height - y) = x1
                        ProgressBar1.Value = ProgressBar1.Value + 1
                    Next
                Next
            End With
        End If
        ProgressBar1.Value = 0
    End Sub

    Dim a As Int64
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Month(Now()).ToString() + "月" + DateAndTime.Day(Now()).ToString() + "日"
        If ToolStripStatusLabel1.Text = "4月1日" Then
            Dim FN As Int64 = CInt(InputBox("你最喜欢的整数数字?" + vbCrLf + "(别输太大!)"))
            For a As Int64 = 0 To FN
                MsgBox("反正是你爱的数字,和我没关系!")
            Next
        End If
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sss As New Bitmap(OpenFileDialog1.FileName)
            PictureBox1.BackgroundImage = sss
            Button2.Enabled = True
        End If
    End Sub

    Private Sub GroupBox6_Click(sender As Object, e As EventArgs) Handles GroupBox6.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = DialogResult.OK Then
            GroupBox6.BackColor = cd.Color
        End If
    End Sub
End Class