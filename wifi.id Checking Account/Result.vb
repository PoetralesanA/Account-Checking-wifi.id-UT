Public Class Result
    Private Sub loadRslt() Handles MyBase.Load
        txt_uR.MaxLength = 1
        txt_Pwd.MaxLength = 1
    End Sub
    Private Sub Result_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        maiN.Show()
    End Sub
End Class