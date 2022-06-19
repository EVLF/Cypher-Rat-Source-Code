Imports System.IO
 Public Class Ports
    Public _ports As String = Nothing
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
    Private Sub Ports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.max
         Dim filepath = Environment.CurrentDirectory.ToString & "\res\Config\Pass.inf"
        Dim list = File.ReadAllLines(filepath)
        For Each lin In list
            passtxt.Text = Codes.Decrypt(lin, sockets.Data.THEKEY)
        Next
         SpyStyle()
         For Each p In My.Settings.ports.Split(":")
             If p IsNot Nothing Then
                po.Value = CInt(p)
            End If
         Next
         po.Value = My.Settings.build_text_port
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
         b_ok.Focus()
         b_ok.Select()
     End Sub
     Private Sub b_ok_Click(sender As Object, e As EventArgs) Handles b_ok.Click
        Try
            Dim filepath = Environment.CurrentDirectory.ToString & "\res\Config\Pass.inf"
             If Not File.Exists(filepath) Then
                File.WriteAllText(filepath, Encrypt("X0X0X", sockets.Data.THEKEY))
            End If
             Dim list = File.ReadAllLines(filepath)
             If passtxt.Text = Codes.Decrypt(list.GetValue(0).ToString, sockets.Data.THEKEY) Then
             ElseIf passtxt.Text.Length > 3 Then
                MessageBox.Show("New Password Saved")
                Dim text As String = File.ReadAllText(filepath)
                text = text.Replace(list.GetValue(0).ToString, Encrypt(passtxt.Text, sockets.Data.THEKEY))
                File.WriteAllText(filepath, text)
                 Dim newme As Process = Process.Start(Application.ExecutablePath)
                CypherRat.Close()
            ElseIf passtxt.Text.Length < 4 Then
                MessageBox.Show("Password Shoud be more Than 3 chars")
                Return
            End If
         Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
         If po.Value > 0 Then
             My.Settings.build_text_port = po.Value
            My.Settings.Save()
            _ports &= po.Value
             Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
     End Sub
     Private Sub pnl1_Paint(sender As Object, e As PaintEventArgs) Handles pnl1.Paint
             End Sub
     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
 End Class