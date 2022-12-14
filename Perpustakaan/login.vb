Imports System.IO
Public Class login

    Public Shared users As users
    Public Shared perpustakaan As perpustakaan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        perpustakaan = New perpustakaan()
        users = New users
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TextBoxUname.Text
        Dim plainPassword As String = TextBoxPW.Text

        Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            users.GSusername = data_user(1)
            perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If

        'Dim Encrypted As String = Users.EncryptData(plainPassword)
        'MessageBox.Show(Encrypted)

        Dim AuthStatus As Boolean = users.CheckAuth(plainUsername, plainPassword)
        'MessageBox.Show(AuthStatus)

        If AuthStatus Then
            perpustakaan.Show()
        Else
            MessageBox.Show("Password Salah")
        End If
    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        register.Show()
    End Sub

    'Try
    'testimage.Image = System.Drawing.Bitmap.FromFile("e:\Road.jpg")
    'Catch
    'MsgBox("Please insert the flash drive in drive E!")
    'Finally
    'MsgBox("Error handler complete")
    'End Try

    'Try
    'If TestImage.Enable = False Then Exit Try
    'TestImage.Image = System.Drawing.Bitmap.FromFile("e:\road.jpg")
    'Catch
    'tries +-1
    'f Retries <= 2 Then
    'MsgBox("Please insert the flash drive in drive E!")
    'Else
    'MsgBox("File load feature disable")
    'Button1.Enabled = False
    'End If
    'End Try


    'cek teksbox kosong apa ngga
    'if NoteTextBox.text.lenght > 0 Then

End Class