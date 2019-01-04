Public Class maiN

    Private Sub LoadApp() Handles MyBase.Load
        btN_R.Cursor = Cursors.Hand


        ' Watermark

        wtm(txt_nimMhs, "Example : Nim.. (number only)")
        wtm(txt_tAhun, "Example : 2017 Registrasi genap ditulis 20172")
        wtm(TxT_tGL, "Example : 1 Februari 1991 ditulis menjadi 01021991")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/l92.168.l.l")
    End Sub

    Private Sub btN_R_Click() Handles btN_R.Click
        If txt_nimMhs.Text = "" Or
             txt_tAhun.Text = "" Or
             TxT_tGL.Text = "" Then
            MsgBox("Data Yang Anda Masukan Harus Lengkap!!", MsgBoxStyle.Critical, "")
            Else
            If Not IsNumeric(txt_nimMhs.Text) Or
                Not IsNumeric(txt_tAhun.Text) Or
                Not IsNumeric(TxT_tGL.Text) Then
                MsgBox("Numberic only!!", MsgBoxStyle.Critical, "")
            Else
                btN_R.Enabled = False
                btN_R.Cursor = Cursors.Default

                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            btN_R.Enabled = True
            btN_R.Cursor = Cursors.Hand

            MsgBox("Username=" & txt_nimMhs.Text &
                             "@ut.ac.id" & vbNewLine &
                             "password=" & txt_tAhun.Text +
                              TxT_tGL.Text, MsgBoxStyle.Information, "")
            '-----------------------------------------------------------------'
            btN_R.Enabled = False

            Result.txt_uR.Text = txt_nimMhs.Text +
                                 "@ut.ac.id" ' hasil nim = user


            Result.txt_Pwd.Text = txt_tAhun.Text +
                                  TxT_tGL.Text
            Result.Show()
            Me.Close()
        End If
    End Sub
End Class