<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenShoter
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
        Me.Save = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FPSBOX = New MetroSet_UI.Controls.MetroSetComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Qualtibox = New MetroSet_UI.Controls.MetroSetComboBox()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.vewpnl = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.textsend = New System.Windows.Forms.TextBox()
        Me.Enterbutton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DrakeUIToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.presstimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.vewpnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()



        Me.Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save.Font = New System.Drawing.Font("Roboto Black", 9.0!)
        Me.Save.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Save.Location = New System.Drawing.Point(226, 3)
        Me.Save.Name = "Save"
        Me.Save.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.Save.Size = New System.Drawing.Size(105, 38)
        Me.Save.TabIndex = 19
        Me.Save.Text = "Record"
        Me.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter



        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(206, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "FPS"



        Me.FPSBOX.AllowDrop = True
        Me.FPSBOX.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.FPSBOX.BackColor = System.Drawing.Color.Transparent
        Me.FPSBOX.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FPSBOX.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.FPSBOX.CausesValidation = False
        Me.FPSBOX.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FPSBOX.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FPSBOX.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FPSBOX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FPSBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FPSBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.FPSBOX.FormattingEnabled = True
        Me.FPSBOX.IsDerivedStyle = True
        Me.FPSBOX.ItemHeight = 20
        Me.FPSBOX.Items.AddRange(New Object() {"5", "10", "15", "30"})
        Me.FPSBOX.Location = New System.Drawing.Point(243, 44)
        Me.FPSBOX.Name = "FPSBOX"
        Me.FPSBOX.SelectedItemBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.FPSBOX.SelectedItemForeColor = System.Drawing.Color.White
        Me.FPSBOX.Size = New System.Drawing.Size(71, 26)
        Me.FPSBOX.Style = MetroSet_UI.Enums.Style.Dark
        Me.FPSBOX.StyleManager = Nothing
        Me.FPSBOX.TabIndex = 17
        Me.FPSBOX.ThemeAuthor = "Narwin"
        Me.FPSBOX.ThemeName = "MetroDark"



        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Qualty"



        Me.Qualtibox.AllowDrop = True
        Me.Qualtibox.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Qualtibox.BackColor = System.Drawing.Color.Transparent
        Me.Qualtibox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Qualtibox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Qualtibox.CausesValidation = False
        Me.Qualtibox.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Qualtibox.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Qualtibox.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Qualtibox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Qualtibox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Qualtibox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Qualtibox.FormattingEnabled = True
        Me.Qualtibox.IsDerivedStyle = True
        Me.Qualtibox.ItemHeight = 20
        Me.Qualtibox.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90"})
        Me.Qualtibox.Location = New System.Drawing.Point(80, 44)
        Me.Qualtibox.Name = "Qualtibox"
        Me.Qualtibox.SelectedItemBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Qualtibox.SelectedItemForeColor = System.Drawing.Color.White
        Me.Qualtibox.Size = New System.Drawing.Size(77, 26)
        Me.Qualtibox.Style = MetroSet_UI.Enums.Style.Dark
        Me.Qualtibox.StyleManager = Nothing
        Me.Qualtibox.TabIndex = 2
        Me.Qualtibox.ThemeAuthor = "Narwin"
        Me.Qualtibox.ThemeName = "MetroDark"



        Me.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Roboto Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.StopButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.StopButton.Location = New System.Drawing.Point(108, 12)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(83, 26)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True



        Me.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Roboto Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.StartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.StartButton.Location = New System.Drawing.Point(17, 12)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(83, 26)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True



        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(331, 545)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False



        Me.vewpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vewpnl.Controls.Add(Me.PictureBox1)
        Me.vewpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vewpnl.Location = New System.Drawing.Point(0, 0)
        Me.vewpnl.Name = "vewpnl"
        Me.vewpnl.Size = New System.Drawing.Size(331, 545)
        Me.vewpnl.TabIndex = 2



        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Roboto Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(235, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 28)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "⇶"
        Me.DrakeUIToolTip1.SetToolTip(Me.Button7, "Recent")
        Me.Button7.UseVisualStyleBackColor = False



        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Roboto Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(124, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 28)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "●"
        Me.DrakeUIToolTip1.SetToolTip(Me.Button6, "Home")
        Me.Button6.UseVisualStyleBackColor = True



        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Roboto Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(12, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 28)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "↩"
        Me.DrakeUIToolTip1.SetToolTip(Me.Button5, "Return")
        Me.Button5.UseVisualStyleBackColor = True



        Me.textsend.BackColor = System.Drawing.Color.Black
        Me.textsend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textsend.ForeColor = System.Drawing.Color.White
        Me.textsend.Location = New System.Drawing.Point(11, 45)
        Me.textsend.Name = "textsend"
        Me.textsend.Size = New System.Drawing.Size(197, 20)
        Me.textsend.TabIndex = 11
        Me.DrakeUIToolTip1.SetToolTip(Me.textsend, "Type Text in phone")



        Me.Enterbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Enterbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Enterbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Enterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enterbutton.Font = New System.Drawing.Font("Roboto Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Enterbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Enterbutton.Location = New System.Drawing.Point(235, 41)
        Me.Enterbutton.Name = "Enterbutton"
        Me.Enterbutton.Size = New System.Drawing.Size(84, 24)
        Me.Enterbutton.TabIndex = 10
        Me.Enterbutton.Text = "Enter"
        Me.Enterbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DrakeUIToolTip1.SetToolTip(Me.Enterbutton, "Enter Text")
        Me.Enterbutton.UseVisualStyleBackColor = True



        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.vewpnl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 545)
        Me.Panel1.TabIndex = 2



        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.FPSBOX)
        Me.Panel2.Controls.Add(Me.Qualtibox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.StartButton)
        Me.Panel2.Controls.Add(Me.StopButton)
        Me.Panel2.Controls.Add(Me.Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 80)
        Me.Panel2.TabIndex = 2



        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.textsend)
        Me.Panel5.Controls.Add(Me.Enterbutton)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.Button7)
        Me.Panel5.Controls.Add(Me.Button6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 625)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(331, 73)
        Me.Panel5.TabIndex = 4



        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(331, 698)
        Me.Panel6.TabIndex = 2



        Me.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.DrakeUIToolTip1.OwnerDraw = True



        Me.presstimer.Interval = 1000



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(331, 698)
        Me.Controls.Add(Me.Panel6)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(332, 490)
        Me.Name = "ScreenShoter"
        Me.ShowIcon = False
        Me.Text = "ScreenShoter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.vewpnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StopButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents Qualtibox As MetroSet_UI.Controls.MetroSetComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FPSBOX As MetroSet_UI.Controls.MetroSetComboBox
    Friend WithEvents vewpnl As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Enterbutton As Button
    Friend WithEvents textsend As TextBox
    Friend WithEvents Save As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DrakeUIToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents presstimer As Timer
End Class
