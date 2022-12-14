Public Class register
    Private Sub butreg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        If TxtBoxUname.Text.Length > 0 And TxtBoxPW.Text.Length > 0 Then

            'Login.Users.AddDataUsers(TxtUserName.Text, TxtPassword.Text)
            login.users.AddUserDatabase(TxtBoxUname.Text, TxtBoxPW.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
        login.users.setUserPassKoleksi(TxtBoxUname.Text, TxtBoxPW.Text)
        TxtBoxUname.Select()
        TxtBoxUname.Text = ""
        TxtBoxPW.Text = ""
        Me.Close()

    End Sub

    Private Sub BtnLogReg_Click(sender As Object, e As EventArgs) Handles BtnLogReg.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub register_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtBoxUname.Select()
        TxtBoxUname.Text = ""
        TxtBoxPW.Text = ""

    End Sub

    Private Sub tbpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxPW.KeyPress
        TxtBoxPW.PasswordChar = "*"c

    End Sub
End Class