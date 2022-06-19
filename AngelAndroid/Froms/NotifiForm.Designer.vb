<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotifiForm
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
        Me.notifitext = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
           Me.notifitext.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.notifitext.Dock = System.Windows.Forms.DockStyle.Top
        Me.notifitext.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notifitext.ForeColor = System.Drawing.Color.White
        Me.notifitext.Location = New System.Drawing.Point(0, 0)
        Me.notifitext.Multiline = True
        Me.notifitext.Name = "notifitext"
        Me.notifitext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.notifitext.Size = New System.Drawing.Size(287, 404)
        Me.notifitext.TabIndex = 0
        Me.notifitext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
           Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto Slab", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
           Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.notifitext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NotifiForm"
        Me.Text = "Notifications"
        Me.ResumeLayout(False)
        Me.PerformLayout()
     End Sub
     Friend WithEvents notifitext As TextBox
    Friend WithEvents Button1 As Button
End Class
