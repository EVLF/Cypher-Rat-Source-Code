<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileManager))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV0 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileDat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnZipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaySoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderDownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesUpload = New System.Windows.Forms.OpenFileDialog()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.BoxTitle = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.viwimage = New AngelAndroid_v2.ZoomPictureBox()
        Me.ThumbsCont = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVDATA = New System.Windows.Forms.DataGridView()
        Me.N = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VRBAR = New System.Windows.Forms.VScrollBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.thumb_chk = New AngelAndroid_v2.Toggle()
        Me.usrnetwork = New System.Windows.Forms.PictureBox()
        Me.RotateButton = New System.Windows.Forms.Button()
        Me.Usrbtry = New System.Windows.Forms.PictureBox()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.ClientPic = New System.Windows.Forms.PictureBox()
        Me.UserButton = New System.Windows.Forms.Button()
        Me.usrscreen = New System.Windows.Forms.PictureBox()
        Me.Cliflag = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dcimbutton = New System.Windows.Forms.Button()
        Me.sdcardbutton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.pathtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Downpic = New MetroSet_UI.Controls.MetroSetBadge()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.usrnetwork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usrbtry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usrscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliflag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()



        Me.DGV0.AllowUserToAddRows = False
        Me.DGV0.AllowUserToDeleteRows = False
        Me.DGV0.AllowUserToResizeColumns = False
        Me.DGV0.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DGV0.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV0.BackgroundColor = System.Drawing.Color.Black
        Me.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV0.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column6, Me.FileDat, Me.Column3})
        Me.DGV0.ContextMenuStrip = Me.ctxMenu
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV0.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV0.EnableHeadersVisualStyles = False
        Me.DGV0.GridColor = System.Drawing.Color.White
        Me.DGV0.Location = New System.Drawing.Point(0, 0)
        Me.DGV0.Name = "DGV0"
        Me.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV0.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV0.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DGV0.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV0.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV0.Size = New System.Drawing.Size(659, 462)
        Me.DGV0.TabIndex = 4



        Me.Column1.FillWeight = 80.78922!
        Me.Column1.HeaderText = "Type"
        Me.Column1.Name = "Column1"



        Me.Column4.FillWeight = 180.5775!
        Me.Column4.HeaderText = "Name"
        Me.Column4.Name = "Column4"



        Me.Column2.FillWeight = 79.27826!
        Me.Column2.HeaderText = "Size"
        Me.Column2.Name = "Column2"



        Me.Column6.FillWeight = 168.6296!
        Me.Column6.HeaderText = "Modified-date"
        Me.Column6.Name = "Column6"



        Me.FileDat.FillWeight = 62.16447!
        Me.FileDat.HeaderText = "Date"
        Me.FileDat.Name = "FileDat"



        Me.Column3.FillWeight = 47.09663!
        Me.Column3.HeaderText = " "
        Me.Column3.Name = "Column3"



        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.UploadToolStripMenuItem, Me.EncryptToolStripMenuItem, Me.DecodeToolStripMenuItem, Me.ZipToolStripMenuItem, Me.UnZipToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AddFilesToolStripMenuItem, Me.RenameToolStripMenuItem, Me.EditToolStripMenuItem, Me.HideToolStripMenuItem, Me.ShowToolStripMenuItem, Me.SetWallpaperToolStripMenuItem, Me.PlaySoundToolStripMenuItem, Me.FolderDownloadsToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(145, 422)



        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OpenToolStripMenuItem.Text = "Open"



        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"



        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cut"



        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"



        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DownloadToolStripMenuItem.Text = "Download"



        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UploadToolStripMenuItem.Text = "Upload"



        Me.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem"
        Me.EncryptToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EncryptToolStripMenuItem.Text = "Encrypt"



        Me.DecodeToolStripMenuItem.Name = "DecodeToolStripMenuItem"
        Me.DecodeToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DecodeToolStripMenuItem.Text = "Decode"



        Me.ZipToolStripMenuItem.Name = "ZipToolStripMenuItem"
        Me.ZipToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ZipToolStripMenuItem.Text = "Zip"



        Me.UnZipToolStripMenuItem.Name = "UnZipToolStripMenuItem"
        Me.UnZipToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UnZipToolStripMenuItem.Text = "UnZip"



        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"



        Me.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem"
        Me.AddFilesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AddFilesToolStripMenuItem.Text = "Add Files"



        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"



        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EditToolStripMenuItem.Text = "Edit"



        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.HideToolStripMenuItem.Text = "Hidden"



        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ShowToolStripMenuItem.Text = "UnHidden"



        Me.SetWallpaperToolStripMenuItem.Name = "SetWallpaperToolStripMenuItem"
        Me.SetWallpaperToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SetWallpaperToolStripMenuItem.Text = "Set wallpaper"



        Me.PlaySoundToolStripMenuItem.Name = "PlaySoundToolStripMenuItem"
        Me.PlaySoundToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PlaySoundToolStripMenuItem.Text = "Play sound"



        Me.FolderDownloadsToolStripMenuItem.Name = "FolderDownloadsToolStripMenuItem"
        Me.FolderDownloadsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FolderDownloadsToolStripMenuItem.Text = "Downloads"



        Me.FilesUpload.FileName = "OpenFileDialog1"



        Me.TOpacity.Interval = 1



        Me.BoxTitle.BackColor = System.Drawing.Color.Black
        Me.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxTitle.ErrorImage = Nothing
        Me.BoxTitle.InitialImage = Nothing
        Me.BoxTitle.Location = New System.Drawing.Point(0, 462)
        Me.BoxTitle.Name = "BoxTitle"
        Me.BoxTitle.Size = New System.Drawing.Size(671, 22)
        Me.BoxTitle.TabIndex = 6
        Me.BoxTitle.TabStop = False



        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 1000



        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(13, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 38)
        Me.Button5.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button5, "Back")
        Me.Button5.UseVisualStyleBackColor = False



        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(57, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 37)
        Me.Button7.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button7, "Refresh")
        Me.Button7.UseVisualStyleBackColor = False



        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClearButton.Enabled = False
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Roboto Slab", 12.0!)
        Me.ClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClearButton.Location = New System.Drawing.Point(572, 60)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(91, 28)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear Finished Download")
        Me.ClearButton.UseVisualStyleBackColor = False
        Me.ClearButton.Visible = False



        Me.cancelbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelbtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cancelbtn.Enabled = False
        Me.cancelbtn.FlatAppearance.BorderSize = 0
        Me.cancelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.cancelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.Font = New System.Drawing.Font("Roboto Slab", 12.0!)
        Me.cancelbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cancelbtn.Location = New System.Drawing.Point(475, 61)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(91, 28)
        Me.cancelbtn.TabIndex = 19
        Me.cancelbtn.Text = "Stop"
        Me.ToolTip1.SetToolTip(Me.cancelbtn, "Stop Running Downloads")
        Me.cancelbtn.UseVisualStyleBackColor = False
        Me.cancelbtn.Visible = False



        Me.viwimage.BackColor = System.Drawing.Color.Black
        Me.viwimage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.viwimage.Image = Nothing
        Me.viwimage.ImagePosition = New System.Drawing.Point(0, 0)
        Me.viwimage.Location = New System.Drawing.Point(0, 197)
        Me.viwimage.Name = "viwimage"
        Me.viwimage.Size = New System.Drawing.Size(187, 300)
        Me.viwimage.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.viwimage, "Tap And Hold to View Video" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Scroll bottom To Zoom")
        Me.viwimage.ZoomFactor = 0R



        Me.ThumbsCont.AutoSize = True
        Me.ThumbsCont.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ThumbsCont.Font = New System.Drawing.Font("Roboto Slab", 9.0!)
        Me.ThumbsCont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ThumbsCont.Location = New System.Drawing.Point(80, 3)
        Me.ThumbsCont.Name = "ThumbsCont"
        Me.ThumbsCont.Size = New System.Drawing.Size(59, 17)
        Me.ThumbsCont.TabIndex = 8
        Me.ThumbsCont.Text = "Use Seen"



        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DGV0)
        Me.Panel1.Controls.Add(Me.DGVDATA)
        Me.Panel1.Controls.Add(Me.VRBAR)
        Me.Panel1.Controls.Add(Me.BoxTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(187, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 484)
        Me.Panel1.TabIndex = 0



        Me.DGVDATA.AllowUserToAddRows = False
        Me.DGVDATA.AllowUserToDeleteRows = False
        Me.DGVDATA.AllowUserToResizeColumns = False
        Me.DGVDATA.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DGVDATA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVDATA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DGVDATA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVDATA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVDATA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGVDATA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDATA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDATA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.N, Me.P, Me.S, Me.D, Me.ST})
        Me.DGVDATA.ContextMenuStrip = Me.ctxMenu
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDATA.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVDATA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDATA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVDATA.EnableHeadersVisualStyles = False
        Me.DGVDATA.GridColor = System.Drawing.Color.White
        Me.DGVDATA.Location = New System.Drawing.Point(0, 0)
        Me.DGVDATA.Name = "DGVDATA"
        Me.DGVDATA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDATA.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVDATA.RowHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.DGVDATA.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVDATA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDATA.Size = New System.Drawing.Size(659, 462)
        Me.DGVDATA.TabIndex = 7



        Me.N.HeaderText = "Name"
        Me.N.Name = "N"



        Me.P.HeaderText = "Path"
        Me.P.Name = "P"



        Me.S.HeaderText = "Size"
        Me.S.Name = "S"



        Me.D.HeaderText = "Downloaded"
        Me.D.Name = "D"



        Me.ST.HeaderText = "Status"
        Me.ST.Name = "ST"



        Me.VRBAR.Dock = System.Windows.Forms.DockStyle.Right
        Me.VRBAR.Location = New System.Drawing.Point(659, 0)
        Me.VRBAR.Name = "VRBAR"
        Me.VRBAR.Size = New System.Drawing.Size(12, 462)
        Me.VRBAR.TabIndex = 8



        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.usrnetwork)
        Me.Panel3.Controls.Add(Me.viwimage)
        Me.Panel3.Controls.Add(Me.RotateButton)
        Me.Panel3.Controls.Add(Me.Usrbtry)
        Me.Panel3.Controls.Add(Me.DownloadButton)
        Me.Panel3.Controls.Add(Me.ClientPic)
        Me.Panel3.Controls.Add(Me.UserButton)
        Me.Panel3.Controls.Add(Me.usrscreen)
        Me.Panel3.Controls.Add(Me.Cliflag)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(187, 581)
        Me.Panel3.TabIndex = 0



        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ThumbsCont)
        Me.Panel4.Controls.Add(Me.thumb_chk)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 174)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(187, 23)
        Me.Panel4.TabIndex = 18



        Me.thumb_chk.Checked = True
        Me.thumb_chk.Location = New System.Drawing.Point(37, 3)
        Me.thumb_chk.Name = "thumb_chk"
        Me.thumb_chk.Size = New System.Drawing.Size(37, 14)
        Me.thumb_chk.TabIndex = 9



        Me.usrnetwork.Location = New System.Drawing.Point(95, 123)
        Me.usrnetwork.Name = "usrnetwork"
        Me.usrnetwork.Size = New System.Drawing.Size(33, 33)
        Me.usrnetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.usrnetwork.TabIndex = 18
        Me.usrnetwork.TabStop = False



        Me.RotateButton.BackColor = System.Drawing.Color.Black
        Me.RotateButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RotateButton.FlatAppearance.BorderSize = 0
        Me.RotateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RotateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.RotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RotateButton.Font = New System.Drawing.Font("Roboto Slab", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RotateButton.Image = CType(resources.GetObject("RotateButton.Image"), System.Drawing.Image)
        Me.RotateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RotateButton.Location = New System.Drawing.Point(0, 497)
        Me.RotateButton.Name = "RotateButton"
        Me.RotateButton.Size = New System.Drawing.Size(187, 28)
        Me.RotateButton.TabIndex = 10
        Me.RotateButton.Text = "Roatate Image"
        Me.RotateButton.UseVisualStyleBackColor = False



        Me.Usrbtry.Location = New System.Drawing.Point(95, 89)
        Me.Usrbtry.Name = "Usrbtry"
        Me.Usrbtry.Size = New System.Drawing.Size(33, 33)
        Me.Usrbtry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Usrbtry.TabIndex = 17
        Me.Usrbtry.TabStop = False



        Me.DownloadButton.BackColor = System.Drawing.Color.Black
        Me.DownloadButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownloadButton.FlatAppearance.BorderSize = 0
        Me.DownloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.DownloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownloadButton.Font = New System.Drawing.Font("Roboto Slab", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DownloadButton.Image = CType(resources.GetObject("DownloadButton.Image"), System.Drawing.Image)
        Me.DownloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DownloadButton.Location = New System.Drawing.Point(0, 525)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(187, 28)
        Me.DownloadButton.TabIndex = 12
        Me.DownloadButton.Text = "Download Selected"
        Me.DownloadButton.UseVisualStyleBackColor = False



        Me.ClientPic.Location = New System.Drawing.Point(56, 9)
        Me.ClientPic.Name = "ClientPic"
        Me.ClientPic.Size = New System.Drawing.Size(72, 67)
        Me.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClientPic.TabIndex = 10
        Me.ClientPic.TabStop = False



        Me.UserButton.BackColor = System.Drawing.Color.Black
        Me.UserButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UserButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserButton.FlatAppearance.BorderSize = 0
        Me.UserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.UserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserButton.Font = New System.Drawing.Font("Roboto Slab", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.UserButton.Image = CType(resources.GetObject("UserButton.Image"), System.Drawing.Image)
        Me.UserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserButton.Location = New System.Drawing.Point(0, 553)
        Me.UserButton.Name = "UserButton"
        Me.UserButton.Size = New System.Drawing.Size(187, 28)
        Me.UserButton.TabIndex = 13
        Me.UserButton.Text = "User Folder"
        Me.UserButton.UseVisualStyleBackColor = False



        Me.usrscreen.Location = New System.Drawing.Point(56, 123)
        Me.usrscreen.Name = "usrscreen"
        Me.usrscreen.Size = New System.Drawing.Size(33, 33)
        Me.usrscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.usrscreen.TabIndex = 14
        Me.usrscreen.TabStop = False



        Me.Cliflag.Location = New System.Drawing.Point(56, 89)
        Me.Cliflag.Name = "Cliflag"
        Me.Cliflag.Size = New System.Drawing.Size(33, 33)
        Me.Cliflag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Cliflag.TabIndex = 12
        Me.Cliflag.TabStop = False



        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto Slab", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(183, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Pictures"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False



        Me.dcimbutton.BackColor = System.Drawing.Color.Black
        Me.dcimbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dcimbutton.FlatAppearance.BorderSize = 0
        Me.dcimbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.dcimbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.dcimbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dcimbutton.Font = New System.Drawing.Font("Roboto Slab", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcimbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dcimbutton.Image = CType(resources.GetObject("dcimbutton.Image"), System.Drawing.Image)
        Me.dcimbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dcimbutton.Location = New System.Drawing.Point(103, 61)
        Me.dcimbutton.Name = "dcimbutton"
        Me.dcimbutton.Size = New System.Drawing.Size(74, 28)
        Me.dcimbutton.TabIndex = 15
        Me.dcimbutton.Text = "DCIM"
        Me.dcimbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dcimbutton.UseVisualStyleBackColor = False



        Me.sdcardbutton.BackColor = System.Drawing.Color.Black
        Me.sdcardbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sdcardbutton.FlatAppearance.BorderSize = 0
        Me.sdcardbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.sdcardbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.sdcardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sdcardbutton.Font = New System.Drawing.Font("Roboto Slab", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdcardbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.sdcardbutton.Image = CType(resources.GetObject("sdcardbutton.Image"), System.Drawing.Image)
        Me.sdcardbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sdcardbutton.Location = New System.Drawing.Point(6, 61)
        Me.sdcardbutton.Name = "sdcardbutton"
        Me.sdcardbutton.Size = New System.Drawing.Size(91, 28)
        Me.sdcardbutton.TabIndex = 14
        Me.sdcardbutton.Text = "SD CARD"
        Me.sdcardbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sdcardbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.sdcardbutton.UseVisualStyleBackColor = False



        Me.Timer1.Interval = 1000



        Me.PB.ForeColor = System.Drawing.Color.Lime
        Me.PB.Location = New System.Drawing.Point(101, 22)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(450, 24)
        Me.PB.TabIndex = 5



        Me.pathtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pathtxt.BackColor = System.Drawing.Color.White
        Me.pathtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pathtxt.Cursor = System.Windows.Forms.Cursors.No
        Me.pathtxt.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathtxt.ForeColor = System.Drawing.Color.Black
        Me.pathtxt.Location = New System.Drawing.Point(101, 22)
        Me.pathtxt.Name = "pathtxt"
        Me.pathtxt.ReadOnly = True
        Me.pathtxt.Size = New System.Drawing.Size(450, 24)
        Me.pathtxt.TabIndex = 0



        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(2, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 37)
        Me.Label2.TabIndex = 9



        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Downpic)
        Me.Panel2.Controls.Add(Me.sdcardbutton)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.cancelbtn)
        Me.Panel2.Controls.Add(Me.dcimbutton)
        Me.Panel2.Controls.Add(Me.ClearButton)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.pathtxt)
        Me.Panel2.Controls.Add(Me.PB)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(187, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(671, 97)
        Me.Panel2.TabIndex = 8



        Me.Downpic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Downpic.BackColor = System.Drawing.Color.Transparent
        Me.Downpic.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight
        Me.Downpic.BadgeText = "0"
        Me.Downpic.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Downpic.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Downpic.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Downpic.Font = New System.Drawing.Font("Roboto Slab", 8.0!)
        Me.Downpic.HoverBadgeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Downpic.HoverBadgeTextColor = System.Drawing.Color.White
        Me.Downpic.HoverBorderColor = System.Drawing.Color.Teal
        Me.Downpic.HoverColor = System.Drawing.Color.Teal
        Me.Downpic.HoverTextColor = System.Drawing.Color.White
        Me.Downpic.IsDerivedStyle = True
        Me.Downpic.Location = New System.Drawing.Point(560, 11)
        Me.Downpic.Name = "Downpic"
        Me.Downpic.NormalBadgeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Downpic.NormalBadgeTextColor = System.Drawing.Color.White
        Me.Downpic.NormalBorderColor = System.Drawing.Color.Black
        Me.Downpic.NormalColor = System.Drawing.Color.Black
        Me.Downpic.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Downpic.PressBadgeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Downpic.PressBadgeTextColor = System.Drawing.Color.White
        Me.Downpic.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Downpic.PressColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Downpic.PressTextColor = System.Drawing.Color.White
        Me.Downpic.Size = New System.Drawing.Size(108, 42)
        Me.Downpic.Style = MetroSet_UI.Enums.Style.Custom
        Me.Downpic.StyleManager = Nothing
        Me.Downpic.TabIndex = 20
        Me.Downpic.Tag = "off"
        Me.Downpic.Text = "Downloads"
        Me.Downpic.ThemeAuthor = "Narwin"
        Me.Downpic.ThemeName = "MetroLite"



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(701, 620)
        Me.Name = "FileManager"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.Text = "FileManager"
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.usrnetwork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usrbtry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usrscreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliflag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents DownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilesUpload As OpenFileDialog
    Friend WithEvents FolderDownloadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncryptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOpacity As Timer
    Friend WithEvents BoxTitle As PictureBox
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetWallpaperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaySoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ThumbsCont As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DownloadButton As Button
    Friend WithEvents RotateButton As Button
    Friend WithEvents thumb_chk As Toggle
    Friend WithEvents UserButton As Button
    Friend WithEvents sdcardbutton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dcimbutton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents FileDat As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents viwimage As ZoomPictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DGVDATA As DataGridView
    Friend WithEvents N As DataGridViewTextBoxColumn
    Friend WithEvents P As DataGridViewTextBoxColumn
    Friend WithEvents S As DataGridViewTextBoxColumn
    Friend WithEvents D As DataGridViewTextBoxColumn
    Friend WithEvents ST As DataGridViewTextBoxColumn
    Friend WithEvents PB As ProgressBar
    Public WithEvents pathtxt As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ClientPic As PictureBox
    Friend WithEvents Cliflag As PictureBox
    Friend WithEvents usrscreen As PictureBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents Usrbtry As PictureBox
    Friend WithEvents usrnetwork As PictureBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Downpic As MetroSet_UI.Controls.MetroSetBadge
    Friend WithEvents VRBAR As VScrollBar
End Class
