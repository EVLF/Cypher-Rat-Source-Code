<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faker
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.plat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.platfromtext = New MetroSet_UI.Controls.MetroSetComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Checkalert = New MetroSet_UI.Controls.MetroSetSwitch()
        Me.MetroSetButton1 = New MetroSet_UI.Controls.MetroSetButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.plat, Me.n, Me.pass})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(354, 214)
        Me.DataGridView1.TabIndex = 0



        Me.plat.HeaderText = "Platform"
        Me.plat.Name = "plat"



        Me.n.HeaderText = "User Name"
        Me.n.Name = "n"



        Me.pass.HeaderText = "Password"
        Me.pass.Name = "pass"



        Me.platfromtext.AllowDrop = True
        Me.platfromtext.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.platfromtext.BackColor = System.Drawing.Color.Transparent
        Me.platfromtext.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.platfromtext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.platfromtext.CausesValidation = False
        Me.platfromtext.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.platfromtext.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.platfromtext.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.platfromtext.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.platfromtext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.platfromtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.platfromtext.FormattingEnabled = True
        Me.platfromtext.IsDerivedStyle = True
        Me.platfromtext.ItemHeight = 20
        Me.platfromtext.Items.AddRange(New Object() {"Facebook", "Gmail", "google authenticator"})
        Me.platfromtext.Location = New System.Drawing.Point(101, 5)
        Me.platfromtext.Name = "platfromtext"
        Me.platfromtext.SelectedItemBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.platfromtext.SelectedItemForeColor = System.Drawing.Color.White
        Me.platfromtext.Size = New System.Drawing.Size(241, 26)
        Me.platfromtext.Style = MetroSet_UI.Enums.Style.Dark
        Me.platfromtext.StyleManager = Nothing
        Me.platfromtext.TabIndex = 1
        Me.platfromtext.ThemeAuthor = "Narwin"
        Me.platfromtext.ThemeName = "MetroDark"



        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Platform"



        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Show Alert"



        Me.Checkalert.BackColor = System.Drawing.Color.Transparent
        Me.Checkalert.BackgroundColor = System.Drawing.Color.Empty
        Me.Checkalert.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Checkalert.CheckColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Checkalert.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.Checkalert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Checkalert.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Checkalert.DisabledCheckColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Checkalert.DisabledUnCheckColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Checkalert.IsDerivedStyle = True
        Me.Checkalert.Location = New System.Drawing.Point(101, 37)
        Me.Checkalert.Name = "Checkalert"
        Me.Checkalert.Size = New System.Drawing.Size(58, 22)
        Me.Checkalert.Style = MetroSet_UI.Enums.Style.Dark
        Me.Checkalert.StyleManager = Nothing
        Me.Checkalert.Switched = False
        Me.Checkalert.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Checkalert.TabIndex = 21
        Me.Checkalert.Text = "MetroSetSwitch1"
        Me.Checkalert.ThemeAuthor = "Narwin"
        Me.Checkalert.ThemeName = "MetroDark"
        Me.Checkalert.UnCheckColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))



        Me.MetroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.DisabledForeColor = System.Drawing.Color.Gray
        Me.MetroSetButton1.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.MetroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroSetButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroSetButton1.HoverTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.IsDerivedStyle = True
        Me.MetroSetButton1.Location = New System.Drawing.Point(12, 65)
        Me.MetroSetButton1.Name = "MetroSetButton1"
        Me.MetroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.NormalTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.MetroSetButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.MetroSetButton1.PressTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.Size = New System.Drawing.Size(333, 33)
        Me.MetroSetButton1.Style = MetroSet_UI.Enums.Style.Dark
        Me.MetroSetButton1.StyleManager = Nothing
        Me.MetroSetButton1.TabIndex = 22
        Me.MetroSetButton1.Text = "Show Form"
        Me.MetroSetButton1.ThemeAuthor = "Narwin"
        Me.MetroSetButton1.ThemeName = "MetroDark"



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(354, 318)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroSetButton1)
        Me.Controls.Add(Me.Checkalert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.platfromtext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Faker"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Faker"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents plat As DataGridViewTextBoxColumn
    Friend WithEvents n As DataGridViewTextBoxColumn
    Friend WithEvents pass As DataGridViewTextBoxColumn
    Friend WithEvents platfromtext As MetroSet_UI.Controls.MetroSetComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Checkalert As MetroSet_UI.Controls.MetroSetSwitch
    Friend WithEvents MetroSetButton1 As MetroSet_UI.Controls.MetroSetButton
End Class
