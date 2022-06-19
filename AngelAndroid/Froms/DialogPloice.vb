Imports System.Windows.Forms
 Public Class DialogPloice
     Private ARTEXT As String = "انا قرأت ما موجود اعلاه , وموافق على الشروط"
    Private ENTEXT As String = "I read all text above, And Accepted All"
    Private IsArab As Boolean = False
    Private StartNow As Date
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
         If Not Acccheck.Checked Then
            If IsArab Then
                MsgBox("قم بالموافقة على الشروط اولا!")
                Return
            Else
                MsgBox("Accepte Privacy Policy First!")
                Return
             End If
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
     End Sub
     Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
     Private Sub DialogPloice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartNow = DateAndTime.Now.AddSeconds(15)
        Timer1.Start()
        Me.OK_Button.Enabled = False
        Me.Cancel_Button.Enabled = False
        Me.MainText.AppendText(My.Resources.Police)
    End Sub
     Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IsArab = True
        Me.MainText.Text = ""
        Me.MainText.AppendText(My.Resources.ARPolice)
        Me.Acccheck.Text = ARTEXT
        OK_Button.Text = "موافق"
        Cancel_Button.Text = "كلا"
    End Sub
     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IsArab = False
        Me.MainText.Text = ""
        Me.MainText.AppendText(My.Resources.Police)
        Me.Acccheck.Text = ENTEXT
        OK_Button.Text = "OK"
        Cancel_Button.Text = "Cancel"
    End Sub
     Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Me.StartNow < DateAndTime.Now) Then
            OK_Button.Enabled = True
            Cancel_Button.Enabled = True
            Me.Text = " Privacy Policy & Terms of Service"
            Timer1.Stop()
        Else
            Me.Text = " Privacy Policy & Terms of Service - " + (Me.StartNow.Second - DateAndTime.Now.Second).ToString
        End If
    End Sub
End Class
