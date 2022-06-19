Imports System.Windows.Forms
 Public Class Dialog1
     Public Title As String
    Public TheText As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.TheText = Me.TheText
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
     Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
     Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mytitle.Text = Title
     End Sub
End Class
