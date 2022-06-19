<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ports
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
        Me.pnl0 = New System.Windows.Forms.Panel()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.po = New System.Windows.Forms.NumericUpDown()
        Me.b_ok = New System.Windows.Forms.Button()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.notpass = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnl0.SuspendLayout()
        Me.pnl1.SuspendLayout()
        CType(Me.po, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.pnl0.BackColor = System.Drawing.Color.Black
        Me.pnl0.Controls.Add(Me.pnl1)
        Me.pnl0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnl0.Location = New System.Drawing.Point(0, 0)
        Me.pnl0.Name = "pnl0"
        Me.pnl0.Size = New System.Drawing.Size(585, 207)
        Me.pnl0.TabIndex = 0



        Me.pnl1.BackColor = System.Drawing.Color.Black
        Me.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.Button1)
        Me.pnl1.Controls.Add(Me.Label1)
        Me.pnl1.Controls.Add(Me.passtxt)
        Me.pnl1.Controls.Add(Me.po)
        Me.pnl1.Controls.Add(Me.b_ok)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl1.ForeColor = System.Drawing.Color.White
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(585, 207)
        Me.pnl1.TabIndex = 5



        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 50.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 90)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Welcome"



        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(358, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 37)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Port"



        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(191, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 49)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False



        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(366, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Key"



        Me.passtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.ForeColor = System.Drawing.Color.White
        Me.passtxt.Location = New System.Drawing.Point(450, 54)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(102, 23)
        Me.passtxt.TabIndex = 17
        Me.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center



        Me.po.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.po.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.po.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.po.ForeColor = System.Drawing.Color.White
        Me.po.Location = New System.Drawing.Point(450, 130)
        Me.po.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.po.Name = "po"
        Me.po.Size = New System.Drawing.Size(102, 26)
        Me.po.TabIndex = 6
        Me.po.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.po.Value = New Decimal(New Integer() {7744, 0, 0, 0})



        Me.b_ok.BackColor = System.Drawing.Color.Black
        Me.b_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.b_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ok.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.b_ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.b_ok.Location = New System.Drawing.Point(44, 123)
        Me.b_ok.Name = "b_ok"
        Me.b_ok.Size = New System.Drawing.Size(123, 49)
        Me.b_ok.TabIndex = 0
        Me.b_ok.Text = "Enter"
        Me.b_ok.UseVisualStyleBackColor = False



        Me.TOpacity.Interval = 1



        Me.notpass.Text = "NotifyIcon1"
        Me.notpass.Visible = True



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(585, 207)
        Me.Controls.Add(Me.pnl0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ports"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ports"
        Me.pnl0.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.po, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl0 As Panel
    Friend WithEvents b_ok As Button
    Friend WithEvents pnl1 As Panel
    Friend WithEvents TOpacity As Timer
    Friend WithEvents passtxt As TextBox
    Friend WithEvents notpass As NotifyIcon
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents po As NumericUpDown
End Class
