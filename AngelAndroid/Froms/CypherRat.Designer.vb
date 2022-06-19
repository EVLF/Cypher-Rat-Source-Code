<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CypherRat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CypherRat))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.notfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Mainpanel = New System.Windows.Forms.Panel()
        Me.clientsflow = New System.Windows.Forms.FlowLayoutPanel()
        Me.StatusPanel = New System.Windows.Forms.Panel()
        Me.OnlinText = New System.Windows.Forms.Label()
        Me.PortText = New System.Windows.Forms.Label()
        Me.SntText = New System.Windows.Forms.Label()
        Me.RcvText = New System.Windows.Forms.Label()
        Me.DataLog = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Bldbtn = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.Mainpanel.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        CType(Me.DataLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.SuspendLayout()



        Me.notfi.Icon = CType(resources.GetObject("notfi.Icon"), System.Drawing.Icon)
        Me.notfi.Text = "Cypher Rat - t.me/evlfev"
        Me.notfi.Visible = True



        Me.TOpacity.Interval = 10



        Me.Mainpanel.Controls.Add(Me.clientsflow)
        Me.Mainpanel.Controls.Add(Me.StatusPanel)
        Me.Mainpanel.Controls.Add(Me.DataLog)
        Me.Mainpanel.Controls.Add(Me.Panel1)
        Me.Mainpanel.Controls.Add(Me.LeftPanel)
        Me.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mainpanel.Location = New System.Drawing.Point(0, 0)
        Me.Mainpanel.Name = "Mainpanel"
        Me.Mainpanel.Size = New System.Drawing.Size(1086, 550)
        Me.Mainpanel.TabIndex = 3



        Me.clientsflow.AutoScroll = True
        Me.clientsflow.BackColor = System.Drawing.Color.Black
        Me.clientsflow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clientsflow.Location = New System.Drawing.Point(178, 35)
        Me.clientsflow.Name = "clientsflow"
        Me.clientsflow.Size = New System.Drawing.Size(908, 487)
        Me.clientsflow.TabIndex = 3



        Me.StatusPanel.BackColor = System.Drawing.Color.Black
        Me.StatusPanel.Controls.Add(Me.OnlinText)
        Me.StatusPanel.Controls.Add(Me.PortText)
        Me.StatusPanel.Controls.Add(Me.SntText)
        Me.StatusPanel.Controls.Add(Me.RcvText)
        Me.StatusPanel.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusPanel.ForeColor = System.Drawing.Color.White
        Me.StatusPanel.Location = New System.Drawing.Point(178, 522)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(908, 28)
        Me.StatusPanel.TabIndex = 2



        Me.OnlinText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OnlinText.AutoSize = True
        Me.OnlinText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnlinText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.OnlinText.Location = New System.Drawing.Point(708, 4)
        Me.OnlinText.Name = "OnlinText"
        Me.OnlinText.Size = New System.Drawing.Size(56, 19)
        Me.OnlinText.TabIndex = 9
        Me.OnlinText.Text = "Online"



        Me.PortText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PortText.AutoSize = True
        Me.PortText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PortText.Location = New System.Drawing.Point(833, 4)
        Me.PortText.Name = "PortText"
        Me.PortText.Size = New System.Drawing.Size(36, 19)
        Me.PortText.TabIndex = 8
        Me.PortText.Text = "Port"



        Me.SntText.AutoSize = True
        Me.SntText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SntText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SntText.Location = New System.Drawing.Point(153, 3)
        Me.SntText.Name = "SntText"
        Me.SntText.Size = New System.Drawing.Size(39, 19)
        Me.SntText.TabIndex = 7
        Me.SntText.Text = "Sent"



        Me.RcvText.AutoSize = True
        Me.RcvText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RcvText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RcvText.Location = New System.Drawing.Point(3, 3)
        Me.RcvText.Name = "RcvText"
        Me.RcvText.Size = New System.Drawing.Size(68, 19)
        Me.RcvText.TabIndex = 6
        Me.RcvText.Text = "Received"



        Me.DataLog.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataLog.AllowUserToAddRows = False
        Me.DataLog.AllowUserToDeleteRows = False
        Me.DataLog.AllowUserToResizeColumns = False
        Me.DataLog.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataLog.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7})
        Me.DataLog.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataLog.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataLog.EnableHeadersVisualStyles = False
        Me.DataLog.GridColor = System.Drawing.Color.Black
        Me.DataLog.Location = New System.Drawing.Point(178, 35)
        Me.DataLog.Name = "DataLog"
        Me.DataLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataLog.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataLog.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataLog.ShowCellToolTips = False
        Me.DataLog.Size = New System.Drawing.Size(908, 515)
        Me.DataLog.TabIndex = 2
        Me.DataLog.Tag = "b"



        Me.DataGridViewImageColumn2.HeaderText = "Flag"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"



        Me.DataGridViewTextBoxColumn5.HeaderText = "ip"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"



        Me.DataGridViewTextBoxColumn4.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"



        Me.DataGridViewTextBoxColumn7.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"



        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(178, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 35)
        Me.Panel1.TabIndex = 2



        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "By EVLF"



        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(856, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False



        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(882, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False



        Me.LeftPanel.BackColor = System.Drawing.Color.Black
        Me.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LeftPanel.Controls.Add(Me.clearbtn)
        Me.LeftPanel.Controls.Add(Me.Button3)
        Me.LeftPanel.Controls.Add(Me.Button5)
        Me.LeftPanel.Controls.Add(Me.Bldbtn)
        Me.LeftPanel.Controls.Add(Me.Button6)
        Me.LeftPanel.Controls.Add(Me.Button7)
        Me.LeftPanel.Controls.Add(Me.Button4)
        Me.LeftPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(178, 550)
        Me.LeftPanel.TabIndex = 2
        Me.LeftPanel.Tag = "off"



        Me.clearbtn.BackColor = System.Drawing.Color.Black
        Me.clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.clearbtn.FlatAppearance.BorderSize = 0
        Me.clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.clearbtn.ForeColor = System.Drawing.Color.Red
        Me.clearbtn.Image = CType(resources.GetObject("clearbtn.Image"), System.Drawing.Image)
        Me.clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearbtn.Location = New System.Drawing.Point(0, 409)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(178, 47)
        Me.clearbtn.TabIndex = 7
        Me.clearbtn.Text = "Clear Log"
        Me.clearbtn.UseVisualStyleBackColor = False
        Me.clearbtn.Visible = False



        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 456)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(178, 47)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Settings"
        Me.Button3.UseVisualStyleBackColor = False



        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 503)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(178, 47)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "About"
        Me.Button5.UseVisualStyleBackColor = False



        Me.Bldbtn.BackColor = System.Drawing.Color.Black
        Me.Bldbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bldbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bldbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bldbtn.FlatAppearance.BorderSize = 0
        Me.Bldbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Bldbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Bldbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bldbtn.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Bldbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Bldbtn.Image = CType(resources.GetObject("Bldbtn.Image"), System.Drawing.Image)
        Me.Bldbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bldbtn.Location = New System.Drawing.Point(0, 185)
        Me.Bldbtn.Name = "Bldbtn"
        Me.Bldbtn.Size = New System.Drawing.Size(178, 47)
        Me.Bldbtn.TabIndex = 4
        Me.Bldbtn.Text = "Build"
        Me.Bldbtn.UseVisualStyleBackColor = False



        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 138)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(178, 47)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Logs"
        Me.Button6.UseVisualStyleBackColor = False



        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Palatino Linotype", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 97)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(178, 41)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Cypher Rat"
        Me.Button7.UseVisualStyleBackColor = False



        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.BackgroundImage = Global.AngelAndroid_v2.My.Resources.Resources.LOGO
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(178, 97)
        Me.Button4.TabIndex = 8
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False



        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.BackColor = System.Drawing.Color.Black
        Me.ToolTip1.ForeColor = System.Drawing.Color.White



        Me.Timer1.Interval = 1000



        Me.RightPanel.BackColor = System.Drawing.Color.Black
        Me.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightPanel.Location = New System.Drawing.Point(1086, 0)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(7, 550)
        Me.RightPanel.TabIndex = 10



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1093, 550)
        Me.Controls.Add(Me.Mainpanel)
        Me.Controls.Add(Me.RightPanel)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(551, 77)
        Me.Name = "CypherRat"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spy Max"
        Me.Mainpanel.ResumeLayout(False)
        Me.StatusPanel.ResumeLayout(False)
        Me.StatusPanel.PerformLayout()
        CType(Me.DataLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.LeftPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents notfi As NotifyIcon
    Friend WithEvents TOpacity As Timer
    Friend WithEvents Mainpanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Bldbtn As Button
    Friend WithEvents StatusPanel As Panel
    Friend WithEvents OnlinText As Label
    Friend WithEvents PortText As Label
    Friend WithEvents SntText As Label
    Friend WithEvents RcvText As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RightPanel As Panel
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Button6 As Button
    Public WithEvents DataLog As DataGridView
    Friend WithEvents clearbtn As Button
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents clientsflow As FlowLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
End Class
