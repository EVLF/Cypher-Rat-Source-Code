<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inp
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BOXX = New System.Windows.Forms.Panel()
        Me.CheckHidden = New System.Windows.Forms.CheckBox()
        Me.CheckFolder = New System.Windows.Forms.CheckBox()
        Me.b_ok = New System.Windows.Forms.Button()
        Me.InputText = New System.Windows.Forms.TextBox()
        Me.LTitle = New System.Windows.Forms.Label()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.BOXX.SuspendLayout()
        Me.SuspendLayout()
           Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BOXX)
        Me.Panel1.Controls.Add(Me.b_ok)
        Me.Panel1.Controls.Add(Me.InputText)
        Me.Panel1.Controls.Add(Me.LTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 130)
        Me.Panel1.TabIndex = 0
           Me.BOXX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BOXX.Controls.Add(Me.CheckHidden)
        Me.BOXX.Controls.Add(Me.CheckFolder)
        Me.BOXX.Location = New System.Drawing.Point(12, 95)
        Me.BOXX.Name = "BOXX"
        Me.BOXX.Size = New System.Drawing.Size(326, 23)
        Me.BOXX.TabIndex = 4
        Me.BOXX.Visible = False
           Me.CheckHidden.AutoSize = True
        Me.CheckHidden.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckHidden.Location = New System.Drawing.Point(212, 0)
        Me.CheckHidden.Name = "CheckHidden"
        Me.CheckHidden.Size = New System.Drawing.Size(58, 23)
        Me.CheckHidden.TabIndex = 1
        Me.CheckHidden.Text = "hidden"
        Me.CheckHidden.UseVisualStyleBackColor = True
           Me.CheckFolder.AutoSize = True
        Me.CheckFolder.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckFolder.Location = New System.Drawing.Point(270, 0)
        Me.CheckFolder.Name = "CheckFolder"
        Me.CheckFolder.Size = New System.Drawing.Size(56, 23)
        Me.CheckFolder.TabIndex = 0
        Me.CheckFolder.Text = "Folder"
        Me.CheckFolder.UseVisualStyleBackColor = True
           Me.b_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ok.ForeColor = System.Drawing.Color.Black
        Me.b_ok.Location = New System.Drawing.Point(353, 95)
        Me.b_ok.Name = "b_ok"
        Me.b_ok.Size = New System.Drawing.Size(67, 23)
        Me.b_ok.TabIndex = 3
        Me.b_ok.Text = "OK"
        Me.b_ok.UseVisualStyleBackColor = False
           Me.InputText.BackColor = System.Drawing.Color.Black
        Me.InputText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InputText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.InputText.Location = New System.Drawing.Point(12, 56)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(408, 13)
        Me.InputText.TabIndex = 2
           Me.LTitle.AutoSize = True
        Me.LTitle.Location = New System.Drawing.Point(12, 23)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(23, 13)
        Me.LTitle.TabIndex = 1
        Me.LTitle.Text = "null"
           Me.TOpacity.Interval = 1
           Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 130)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inp"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "inp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BOXX.ResumeLayout(False)
        Me.BOXX.PerformLayout()
        Me.ResumeLayout(False)
     End Sub
     Friend WithEvents Panel1 As Panel
    Friend WithEvents LTitle As Label
    Friend WithEvents InputText As TextBox
    Friend WithEvents b_ok As Button
    Friend WithEvents BOXX As Panel
    Friend WithEvents CheckHidden As CheckBox
    Friend WithEvents CheckFolder As CheckBox
    Friend WithEvents TOpacity As Timer
End Class
