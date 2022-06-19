<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CameraManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CameraManager))
        Me.CAM0 = New System.Windows.Forms.PictureBox()
        Me.TP = New System.Windows.Forms.Timer(Me.components)
        Me.Frames = New System.Windows.Forms.Timer(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.statustext = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbofoucs = New System.Windows.Forms.ComboBox()
        Me.combqulty = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Sbtn = New System.Windows.Forms.Button()
        Me.Bbtn = New System.Windows.Forms.Button()
        Me.Fbtn = New System.Windows.Forms.Button()
        Me.ClientPic = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New AngelAndroid_v2.PBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.CAM0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ClientPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()



        Me.CAM0.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CAM0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CAM0.Location = New System.Drawing.Point(0, 0)
        Me.CAM0.Name = "CAM0"
        Me.CAM0.Size = New System.Drawing.Size(528, 404)
        Me.CAM0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CAM0.TabIndex = 0
        Me.CAM0.TabStop = False



        Me.TP.Interval = 1



        Me.Frames.Interval = 1000



        Me.TOpacity.Interval = 1



        Me.Panel1.Controls.Add(Me.CAM0)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 428)
        Me.Panel1.TabIndex = 3



        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.statustext)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 404)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(528, 24)
        Me.Panel4.TabIndex = 1



        Me.statustext.AutoSize = True
        Me.statustext.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.statustext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.statustext.Location = New System.Drawing.Point(3, 3)
        Me.statustext.Name = "statustext"
        Me.statustext.Size = New System.Drawing.Size(114, 19)
        Me.statustext.TabIndex = 15
        Me.statustext.Text = "Select Camera..."



        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(101, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Focus"



        Me.cmbofoucs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbofoucs.BackColor = System.Drawing.Color.Black
        Me.cmbofoucs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbofoucs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbofoucs.ForeColor = System.Drawing.Color.White
        Me.cmbofoucs.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbofoucs.Location = New System.Drawing.Point(12, 295)
        Me.cmbofoucs.Name = "cmbofoucs"
        Me.cmbofoucs.Size = New System.Drawing.Size(83, 21)
        Me.cmbofoucs.TabIndex = 16



        Me.combqulty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.combqulty.BackColor = System.Drawing.Color.Black
        Me.combqulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combqulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combqulty.ForeColor = System.Drawing.Color.White
        Me.combqulty.Items.AddRange(New Object() {"Auto", "High Quality"})
        Me.combqulty.Location = New System.Drawing.Point(12, 257)
        Me.combqulty.Name = "combqulty"
        Me.combqulty.Size = New System.Drawing.Size(83, 21)
        Me.combqulty.TabIndex = 17



        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(101, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Qualty"



        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.Sbtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Bbtn)
        Me.Panel2.Controls.Add(Me.cmbofoucs)
        Me.Panel2.Controls.Add(Me.Fbtn)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.combqulty)
        Me.Panel2.Controls.Add(Me.ClientPic)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(528, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 428)
        Me.Panel2.TabIndex = 1



        Me.Sbtn.BackColor = System.Drawing.Color.Black
        Me.Sbtn.Enabled = False
        Me.Sbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Sbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sbtn.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Sbtn.Location = New System.Drawing.Point(19, 188)
        Me.Sbtn.Name = "Sbtn"
        Me.Sbtn.Size = New System.Drawing.Size(121, 25)
        Me.Sbtn.TabIndex = 18
        Me.Sbtn.Text = "Stop"
        Me.Sbtn.UseVisualStyleBackColor = False



        Me.Bbtn.BackColor = System.Drawing.Color.Black
        Me.Bbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Bbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbtn.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Bbtn.Location = New System.Drawing.Point(19, 157)
        Me.Bbtn.Name = "Bbtn"
        Me.Bbtn.Size = New System.Drawing.Size(121, 25)
        Me.Bbtn.TabIndex = 13
        Me.Bbtn.Tag = "off"
        Me.Bbtn.Text = "Back"
        Me.Bbtn.UseVisualStyleBackColor = False



        Me.Fbtn.BackColor = System.Drawing.Color.Black
        Me.Fbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Fbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fbtn.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Fbtn.Location = New System.Drawing.Point(19, 126)
        Me.Fbtn.Name = "Fbtn"
        Me.Fbtn.Size = New System.Drawing.Size(121, 25)
        Me.Fbtn.TabIndex = 12
        Me.Fbtn.Tag = "off"
        Me.Fbtn.Text = "Front"
        Me.Fbtn.UseVisualStyleBackColor = False



        Me.ClientPic.BackColor = System.Drawing.Color.Black
        Me.ClientPic.Location = New System.Drawing.Point(46, 26)
        Me.ClientPic.Name = "ClientPic"
        Me.ClientPic.Size = New System.Drawing.Size(67, 72)
        Me.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClientPic.TabIndex = 11
        Me.ClientPic.TabStop = False



        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(0, 364)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Rotate"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Button4, "Rotate")
        Me.Button4.UseVisualStyleBackColor = False



        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(0, 396)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Tag = "off"
        Me.Button3.Text = "Record"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Button3, "Save")
        Me.Button3.UseVisualStyleBackColor = False






        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 428)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(693, 9)
        Me.Panel3.TabIndex = 1



        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(693, 9)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 2



        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.DarkTurquoise



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 437)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(709, 323)
        Me.Name = "CameraManager"
        Me.Opacity = 0R
        Me.Text = "CameraManager"
        CType(Me.CAM0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ClientPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CAM0 As PictureBox
    Friend WithEvents TP As Timer
    Friend WithEvents Frames As Timer
    Friend WithEvents TOpacity As Timer
    Friend WithEvents ProgressBar1 As PBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SaveTimer As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ClientPic As PictureBox
    Friend WithEvents Bbtn As Button
    Friend WithEvents Fbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbofoucs As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents combqulty As ComboBox
    Friend WithEvents Sbtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents statustext As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
