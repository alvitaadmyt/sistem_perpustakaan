<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenImageKoleksi1 = New System.Windows.Forms.OpenFileDialog()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.GroupBoxKategori = New System.Windows.Forms.GroupBox()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.RdEng = New System.Windows.Forms.RadioButton()
        Me.RdInd = New System.Windows.Forms.RadioButton()
        Me.GroupBoxBahasa = New System.Windows.Forms.GroupBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.DateTimePickerKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxRak = New System.Windows.Forms.TextBox()
        Me.TextBoxTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxJenis = New System.Windows.Forms.ComboBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnUpdateFoto = New System.Windows.Forms.Button()
        Me.OpenImageKoleksi = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxKategori.SuspendLayout()
        Me.GroupBoxBahasa.SuspendLayout()
        CType(Me.OpenImageKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenImageKoleksi1
        '
        Me.OpenImageKoleksi1.FileName = "OpenFileDialog1"
        '
        'ChkBudaya
        '
        Me.ChkBudaya.AutoSize = True
        Me.ChkBudaya.Location = New System.Drawing.Point(30, 165)
        Me.ChkBudaya.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkBudaya.Name = "ChkBudaya"
        Me.ChkBudaya.Size = New System.Drawing.Size(96, 29)
        Me.ChkBudaya.TabIndex = 3
        Me.ChkBudaya.Text = "Budaya"
        Me.ChkBudaya.UseVisualStyleBackColor = True
        '
        'ChkTeknologi
        '
        Me.ChkTeknologi.AutoSize = True
        Me.ChkTeknologi.Location = New System.Drawing.Point(30, 124)
        Me.ChkTeknologi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkTeknologi.Name = "ChkTeknologi"
        Me.ChkTeknologi.Size = New System.Drawing.Size(114, 29)
        Me.ChkTeknologi.TabIndex = 2
        Me.ChkTeknologi.Text = "Teknologi"
        Me.ChkTeknologi.UseVisualStyleBackColor = True
        '
        'ChkSosial
        '
        Me.ChkSosial.AutoSize = True
        Me.ChkSosial.Location = New System.Drawing.Point(30, 82)
        Me.ChkSosial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkSosial.Name = "ChkSosial"
        Me.ChkSosial.Size = New System.Drawing.Size(84, 29)
        Me.ChkSosial.TabIndex = 1
        Me.ChkSosial.Text = "Sosial"
        Me.ChkSosial.UseVisualStyleBackColor = True
        '
        'GroupBoxKategori
        '
        Me.GroupBoxKategori.Controls.Add(Me.ChkBudaya)
        Me.GroupBoxKategori.Controls.Add(Me.ChkTeknologi)
        Me.GroupBoxKategori.Controls.Add(Me.ChkSosial)
        Me.GroupBoxKategori.Controls.Add(Me.ChkSains)
        Me.GroupBoxKategori.Location = New System.Drawing.Point(589, 732)
        Me.GroupBoxKategori.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxKategori.Name = "GroupBoxKategori"
        Me.GroupBoxKategori.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxKategori.Size = New System.Drawing.Size(256, 215)
        Me.GroupBoxKategori.TabIndex = 47
        Me.GroupBoxKategori.TabStop = False
        Me.GroupBoxKategori.Text = "Kategori"
        '
        'ChkSains
        '
        Me.ChkSains.AutoSize = True
        Me.ChkSains.Location = New System.Drawing.Point(30, 40)
        Me.ChkSains.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkSains.Name = "ChkSains"
        Me.ChkSains.Size = New System.Drawing.Size(79, 29)
        Me.ChkSains.TabIndex = 0
        Me.ChkSains.Text = "Sains"
        Me.ChkSains.UseVisualStyleBackColor = True
        '
        'RdEng
        '
        Me.RdEng.AutoSize = True
        Me.RdEng.Location = New System.Drawing.Point(17, 89)
        Me.RdEng.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdEng.Name = "RdEng"
        Me.RdEng.Size = New System.Drawing.Size(152, 29)
        Me.RdEng.TabIndex = 1
        Me.RdEng.TabStop = True
        Me.RdEng.Text = "Bahasa Inggris"
        Me.RdEng.UseVisualStyleBackColor = True
        '
        'RdInd
        '
        Me.RdInd.AutoSize = True
        Me.RdInd.Location = New System.Drawing.Point(17, 47)
        Me.RdInd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdInd.Name = "RdInd"
        Me.RdInd.Size = New System.Drawing.Size(174, 29)
        Me.RdInd.TabIndex = 0
        Me.RdInd.TabStop = True
        Me.RdInd.Text = "Bahasa Indonesia"
        Me.RdInd.UseVisualStyleBackColor = True
        '
        'GroupBoxBahasa
        '
        Me.GroupBoxBahasa.Controls.Add(Me.RdEng)
        Me.GroupBoxBahasa.Controls.Add(Me.RdInd)
        Me.GroupBoxBahasa.Location = New System.Drawing.Point(589, 577)
        Me.GroupBoxBahasa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxBahasa.Name = "GroupBoxBahasa"
        Me.GroupBoxBahasa.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxBahasa.Size = New System.Drawing.Size(256, 143)
        Me.GroupBoxBahasa.TabIndex = 46
        Me.GroupBoxBahasa.TabStop = False
        Me.GroupBoxBahasa.Text = "Bahasa"
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(589, 519)
        Me.TextBoxStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(254, 31)
        Me.TextBoxStock.TabIndex = 45
        '
        'DateTimePickerKoleksi
        '
        Me.DateTimePickerKoleksi.Location = New System.Drawing.Point(589, 465)
        Me.DateTimePickerKoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerKoleksi.Name = "DateTimePickerKoleksi"
        Me.DateTimePickerKoleksi.Size = New System.Drawing.Size(254, 31)
        Me.DateTimePickerKoleksi.TabIndex = 44
        '
        'TextBoxRak
        '
        Me.TextBoxRak.Location = New System.Drawing.Point(589, 410)
        Me.TextBoxRak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxRak.Name = "TextBoxRak"
        Me.TextBoxRak.Size = New System.Drawing.Size(254, 31)
        Me.TextBoxRak.TabIndex = 43
        '
        'TextBoxTahunTerbit
        '
        Me.TextBoxTahunTerbit.Location = New System.Drawing.Point(589, 359)
        Me.TextBoxTahunTerbit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxTahunTerbit.Name = "TextBoxTahunTerbit"
        Me.TextBoxTahunTerbit.Size = New System.Drawing.Size(254, 31)
        Me.TextBoxTahunTerbit.TabIndex = 42
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(589, 309)
        Me.TextBoxPenerbit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(254, 31)
        Me.TextBoxPenerbit.TabIndex = 41
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(589, 162)
        Me.RichTextBoxDeskripsi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(254, 131)
        Me.RichTextBoxDeskripsi.TabIndex = 40
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'ComboBoxJenis
        '
        Me.ComboBoxJenis.FormattingEnabled = True
        Me.ComboBoxJenis.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.ComboBoxJenis.Location = New System.Drawing.Point(589, 104)
        Me.ComboBoxJenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxJenis.Name = "ComboBoxJenis"
        Me.ComboBoxJenis.Size = New System.Drawing.Size(254, 33)
        Me.ComboBoxJenis.TabIndex = 39
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(589, 52)
        Me.TextBoxNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(254, 31)
        Me.TextBoxNama.TabIndex = 38
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(446, 1009)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(141, 38)
        Me.BtnUpdate.TabIndex = 37
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(363, 732)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 25)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Kategori"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(363, 577)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Bahasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 524)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 25)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(363, 475)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 415)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 364)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 314)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 25)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Koleksi"
        '
        'BtnUpdateFoto
        '
        Me.BtnUpdateFoto.Location = New System.Drawing.Point(159, 257)
        Me.BtnUpdateFoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUpdateFoto.Name = "BtnUpdateFoto"
        Me.BtnUpdateFoto.Size = New System.Drawing.Size(107, 38)
        Me.BtnUpdateFoto.TabIndex = 26
        Me.BtnUpdateFoto.Text = "Update"
        Me.BtnUpdateFoto.UseVisualStyleBackColor = True
        '
        'OpenImageKoleksi
        '
        Me.OpenImageKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OpenImageKoleksi.Location = New System.Drawing.Point(143, 57)
        Me.OpenImageKoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpenImageKoleksi.Name = "OpenImageKoleksi"
        Me.OpenImageKoleksi.Size = New System.Drawing.Size(143, 190)
        Me.OpenImageKoleksi.TabIndex = 25
        Me.OpenImageKoleksi.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(140, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tambah Koleksi"
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 1050)
        Me.Controls.Add(Me.GroupBoxKategori)
        Me.Controls.Add(Me.GroupBoxBahasa)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.DateTimePickerKoleksi)
        Me.Controls.Add(Me.TextBoxRak)
        Me.Controls.Add(Me.TextBoxTahunTerbit)
        Me.Controls.Add(Me.TextBoxPenerbit)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenis)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnUpdateFoto)
        Me.Controls.Add(Me.OpenImageKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "update"
        Me.Text = "update"
        Me.GroupBoxKategori.ResumeLayout(False)
        Me.GroupBoxKategori.PerformLayout()
        Me.GroupBoxBahasa.ResumeLayout(False)
        Me.GroupBoxBahasa.PerformLayout()
        CType(Me.OpenImageKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenImageKoleksi1 As OpenFileDialog
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTeknologi As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents GroupBoxKategori As GroupBox
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents RdEng As RadioButton
    Friend WithEvents RdInd As RadioButton
    Friend WithEvents GroupBoxBahasa As GroupBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents DateTimePickerKoleksi As DateTimePicker
    Friend WithEvents TextBoxRak As TextBox
    Friend WithEvents TextBoxTahunTerbit As TextBox
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents ComboBoxJenis As ComboBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUpdateFoto As Button
    Friend WithEvents OpenImageKoleksi As PictureBox
    Friend WithEvents Label1 As Label
End Class
