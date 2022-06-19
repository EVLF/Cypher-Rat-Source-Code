<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Mytext = New System.Windows.Forms.TextBox()
        Me.Mytitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
           Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.OK_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.OK_Button.Location = New System.Drawing.Point(340, 46)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 25)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
           Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Cancel_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Cancel_Button.Location = New System.Drawing.Point(425, 46)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 25)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
           Me.Mytext.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Mytext.Location = New System.Drawing.Point(12, 46)
        Me.Mytext.Name = "Mytext"
        Me.Mytext.Size = New System.Drawing.Size(309, 25)
        Me.Mytext.TabIndex = 1
           Me.Mytitle.AutoSize = True
        Me.Mytitle.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mytitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Mytitle.Location = New System.Drawing.Point(12, 6)
        Me.Mytitle.Name = "Mytitle"
        Me.Mytitle.Size = New System.Drawing.Size(160, 37)
        Me.Mytitle.TabIndex = 3
        Me.Mytitle.Text = "Cypher Rat"
           Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(504, 88)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Mytitle)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Mytext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Selecter"
        Me.ResumeLayout(False)
        Me.PerformLayout()
     End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Mytext As TextBox
    Friend WithEvents Mytitle As Label
End Class
