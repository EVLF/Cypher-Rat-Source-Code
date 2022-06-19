Public Class NotifiForm
     Public ClassClient As sockets.Client
     Private Sub NotifiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         If ClassClient IsNot Nothing Then
            If ClassClient.Notifications.Count > 0 Then
                For Each s In ClassClient.Notifications
                    Try
                        If s IsNot Nothing Then
                            If s.Length > 0 Then
                                notifitext.Text += s + vbNewLine + "---------------"
                            End If
                         End If
                    Catch ex As Exception
                     End Try
                 Next
             Else
                notifitext.Text += "No Notifications ..."
            End If
        End If
        ClassClient.isnewnotifi = False
        ClassClient.Card.notpic.Image = Nothing
     End Sub
     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        notifitext.Text = ""
        ClassClient.Notifications = New String(100) {}
    End Sub
End Class