<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.bt1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.name2 = New System.Windows.Forms.TextBox()
        Me.times = New System.Windows.Forms.TextBox()
        Me.stopm = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.sos = New System.Windows.Forms.Label()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.ck1 = New System.Windows.Forms.CheckBox()
        Me.ck2 = New System.Windows.Forms.CheckBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.bt4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.White
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt1.Location = New System.Drawing.Point(193, 98)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(110, 67)
        Me.bt1.TabIndex = 1
        Me.bt1.Text = "Bắt đầu"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tên ảnh (kèm số tự động phía sau)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Thời gian cách nhau mỗi lần chụp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tự động ngưng khi đủ số lần"
        '
        'name2
        '
        Me.name2.Location = New System.Drawing.Point(193, 9)
        Me.name2.Name = "name2"
        Me.name2.Size = New System.Drawing.Size(463, 20)
        Me.name2.TabIndex = 5
        Me.name2.Text = "data"
        '
        'times
        '
        Me.times.Location = New System.Drawing.Point(193, 37)
        Me.times.Name = "times"
        Me.times.Size = New System.Drawing.Size(463, 20)
        Me.times.TabIndex = 6
        Me.times.Text = "1000"
        '
        'stopm
        '
        Me.stopm.Location = New System.Drawing.Point(193, 63)
        Me.stopm.Name = "stopm"
        Me.stopm.Size = New System.Drawing.Size(463, 20)
        Me.stopm.TabIndex = 7
        Me.stopm.Text = "100"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'sos
        '
        Me.sos.AutoSize = True
        Me.sos.BackColor = System.Drawing.Color.Transparent
        Me.sos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sos.Location = New System.Drawing.Point(131, 26)
        Me.sos.Name = "sos"
        Me.sos.Size = New System.Drawing.Size(21, 24)
        Me.sos.TabIndex = 8
        Me.sos.Text = "0"
        Me.sos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.White
        Me.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt2.Location = New System.Drawing.Point(425, 98)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(110, 67)
        Me.bt2.TabIndex = 9
        Me.bt2.Text = "Xoá ảnh trong thư mục data"
        Me.bt2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(442, 366)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 10)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tiến trình:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(502, 124)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "*Chú thích:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - data là tên tập tin mặc định" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 1000 tức là 1 giây" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 100 là số" &
    " lần sẽ chụp cách nhau 1 giây"
        '
        'bt3
        '
        Me.bt3.BackColor = System.Drawing.Color.White
        Me.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt3.Location = New System.Drawing.Point(309, 98)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(110, 67)
        Me.bt3.TabIndex = 12
        Me.bt3.Text = "&Dừng lại " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Huỷ bỏ tiến trình)"
        Me.bt3.UseVisualStyleBackColor = False
        '
        'ck1
        '
        Me.ck1.AutoSize = True
        Me.ck1.BackColor = System.Drawing.Color.Transparent
        Me.ck1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ck1.Location = New System.Drawing.Point(13, 23)
        Me.ck1.Name = "ck1"
        Me.ck1.Size = New System.Drawing.Size(124, 17)
        Me.ck1.TabIndex = 13
        Me.ck1.Text = "Chất lượng thấp (.jpg)"
        Me.ck1.UseVisualStyleBackColor = False
        '
        'ck2
        '
        Me.ck2.AutoSize = True
        Me.ck2.BackColor = System.Drawing.Color.Transparent
        Me.ck2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ck2.Location = New System.Drawing.Point(12, 46)
        Me.ck2.Name = "ck2"
        Me.ck2.Size = New System.Drawing.Size(125, 17)
        Me.ck2.TabIndex = 14
        Me.ck2.Text = "Chất lượng cao (.png)"
        Me.ck2.UseVisualStyleBackColor = False
        '
        'gb1
        '
        Me.gb1.BackColor = System.Drawing.Color.Transparent
        Me.gb1.Controls.Add(Me.ck2)
        Me.gb1.Controls.Add(Me.ck1)
        Me.gb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gb1.Location = New System.Drawing.Point(15, 98)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(172, 67)
        Me.gb1.TabIndex = 15
        Me.gb1.TabStop = False
        Me.gb1.Text = "Chỉnh chất lượng ảnh"
        '
        'gb2
        '
        Me.gb2.BackColor = System.Drawing.Color.Transparent
        Me.gb2.Controls.Add(Me.Label4)
        Me.gb2.Controls.Add(Me.sos)
        Me.gb2.Controls.Add(Me.Label5)
        Me.gb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gb2.Location = New System.Drawing.Point(15, 184)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(641, 208)
        Me.gb2.TabIndex = 16
        Me.gb2.TabStop = False
        Me.gb2.Text = "Tiến trình"
        '
        'bt4
        '
        Me.bt4.BackColor = System.Drawing.Color.White
        Me.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt4.Location = New System.Drawing.Point(546, 98)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(110, 67)
        Me.bt4.TabIndex = 17
        Me.bt4.Text = "Mở thư mục"
        Me.bt4.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AutoPrintScreen.My.Resources.Resources.dff
        Me.ClientSize = New System.Drawing.Size(681, 400)
        Me.Controls.Add(Me.bt4)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.bt3)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.stopm)
        Me.Controls.Add(Me.times)
        Me.Controls.Add(Me.name2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoPrintScreen - Me09112001 -  Make by Nguyễn Trung Nhẫn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents name2 As TextBox
    Friend WithEvents times As TextBox
    Friend WithEvents stopm As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents sos As Label
    Friend WithEvents bt2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bt3 As Button
    Friend WithEvents ck1 As CheckBox
    Friend WithEvents ck2 As CheckBox
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents gb2 As GroupBox
    Friend WithEvents bt4 As Button
End Class
