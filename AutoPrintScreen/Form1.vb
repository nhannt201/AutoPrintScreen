Imports System.IO
' soft by Nguyen Trung Nhan . Please no edit "ma nguon cua trang!!!"
Public Class home

    Dim a As String = 0

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\savedata\")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\savedata\")
        End If
        ck1.Checked = True

    End Sub

    'capture specific location
    Function captureScreen(ByVal locX As Integer, ByVal locY As Integer, ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim NewImage As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(NewImage)
            g.CopyFromScreen(locX, locY, 0, 0, NewImage.Size)
        End Using
        Return NewImage
    End Function
    'Example 
    'save picturebox as jpeg
    Sub SavePicturebox()
        Dim bit As Bitmap = captureScreen(PictureBox1.Location.X, PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        bit.Save(Application.StartupPath & "\savedata\fileName.jpg", Imaging.ImageFormat.Jpeg)
    End Sub
    'save the whole form as jpeg format
    Sub SaveWholeForm()
        Dim bit As Bitmap = captureScreen(Me.Location.X, Me.Location.Y, Me.Width, Me.Height)
        bit.Save(Application.StartupPath & "\savedata\fileName.jpg", Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click

        If ck1.Checked = True Then
            Timer1.Interval = times.Text
            Timer1.Start()
        ElseIf ck2.Checked = True Then
            Timer2.Interval = times.Text
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If a = stopm.Text Then
                sos.Text = "Hoàn thành!"
                bt1.Enabled = True

                Timer1.Stop()
            Else
                bt1.Enabled = False
                a = a + 1
                sos.Text = a
                SendKeys.Send("{PRTSC}")
                Dim Screenshot As Image = Clipboard.GetImage()
                Screenshot.Save(Application.StartupPath & "\savedata\" + name2.Text + a + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        Catch
            sos.Text = "Hoàn thành! (Tốc độ quá nhanh dẫn đến ngừng.)"
            bt1.Enabled = True
            Timer1.Stop()
        End Try

    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        ' DeleteFilesFromFolder(Application.StartupPath & "\savedata")
        Dim path As String = Application.StartupPath & "\savedata\"
        DeleteDirectory(path)
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\savedata\")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\savedata\")
        End If
    End Sub
    Private Sub DeleteDirectory(path As String)
        If Directory.Exists(path) Then
            'Delete all files from the Directory
            For Each filepath As String In Directory.GetFiles(path)
                File.Delete(filepath)
            Next
            'Delete all child Directories
            For Each dir As String In Directory.GetDirectories(path)
                DeleteDirectory(dir)
            Next
            'Delete a Directory
            Directory.Delete(path)
        End If
    End Sub

    Private Sub times_TextChanged(sender As Object, e As EventArgs) Handles times.TextChanged

    End Sub

    Private Sub times_KeyPress(sender As Object, e As KeyPressEventArgs) Handles times.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then Beep() : e.Handled = True
        ' nếu phím nhấn không phải là số hoặc phím     
        'control (nhấn "Backspace" để xóa số) -> thì beep cảnh báo và hủy sự kiện (không có phím được nhấn)
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        a = 0
        Timer1.Stop()
        Timer1.Enabled = False
        Timer2.Stop()
        Timer2.Enabled = False
        bt1.Enabled = True
        sos.Text = 0

    End Sub

    Private Sub ck1_CheckedChanged(sender As Object, e As EventArgs) Handles ck1.CheckedChanged
        If ck1.Checked = True Then
            ck2.Checked = False
        End If
    End Sub

    Private Sub ck2_CheckedChanged(sender As Object, e As EventArgs) Handles ck2.CheckedChanged
        If ck2.Checked = True Then
            ck1.Checked = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If a = stopm.Text Then
                sos.Text = "Hoàn thành!"
                bt1.Enabled = True
                '   Process.Start("explorer.exe", Application.StartupPath & "\savedata\")

                Timer1.Stop()
            Else
                bt1.Enabled = False
                a = a + 1
                sos.Text = a
                SendKeys.Send("{PRTSC}")
                Dim Screenshot As Image = Clipboard.GetImage()
                Screenshot.Save(Application.StartupPath & "\savedata\" + name2.Text + a + ".png", System.Drawing.Imaging.ImageFormat.Png)
            End If
        Catch
            sos.Text = "Hoàn thành! (Tốc độ quá nhanh dẫn đến ngừng.)"
            bt1.Enabled = True
            Timer1.Stop()
        End Try

    End Sub
    Sub OpenFolder()
        Process.Start("explorer.exe", Application.StartupPath & "\savedata\")
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        OpenFolder()
    End Sub
End Class
