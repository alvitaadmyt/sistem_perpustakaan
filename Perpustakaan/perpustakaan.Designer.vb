<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perpustakaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perpustakaan))
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.namaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasiRak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggalTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bahasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 25
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(290, 128)
        Me.ListBoxKoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(543, 254)
        Me.ListBoxKoleksi.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 35)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1143, 33)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton1.Text = "ToolStripBtnTambahKoleksi"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton2.Text = "ToolStripBtnHapusKoleksi"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1143, 35)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namaKoleksi, Me.jenisKoleksi, Me.penerbit, Me.deskripsi, Me.tahunTerbit, Me.lokasiRak, Me.tanggalTerbit, Me.stock, Me.bahasa, Me.kategori})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 442)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1143, 250)
        Me.DataGridView1.TabIndex = 3
        '
        'namaKoleksi
        '
        Me.namaKoleksi.HeaderText = "Nama Koleksi"
        Me.namaKoleksi.MinimumWidth = 8
        Me.namaKoleksi.Name = "namaKoleksi"
        Me.namaKoleksi.Width = 150
        '
        'jenisKoleksi
        '
        Me.jenisKoleksi.HeaderText = "Jenis Koleksi"
        Me.jenisKoleksi.MinimumWidth = 8
        Me.jenisKoleksi.Name = "jenisKoleksi"
        Me.jenisKoleksi.Width = 150
        '
        'penerbit
        '
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.MinimumWidth = 8
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Width = 150
        '
        'deskripsi
        '
        Me.deskripsi.HeaderText = "Deskripsi"
        Me.deskripsi.MinimumWidth = 8
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Width = 150
        '
        'tahunTerbit
        '
        Me.tahunTerbit.HeaderText = "Tahun Terbit"
        Me.tahunTerbit.MinimumWidth = 8
        Me.tahunTerbit.Name = "tahunTerbit"
        Me.tahunTerbit.Width = 150
        '
        'lokasiRak
        '
        Me.lokasiRak.HeaderText = "Lokasi Rak"
        Me.lokasiRak.MinimumWidth = 8
        Me.lokasiRak.Name = "lokasiRak"
        Me.lokasiRak.Width = 150
        '
        'tanggalTerbit
        '
        Me.tanggalTerbit.HeaderText = "Tanggal Masuk"
        Me.tanggalTerbit.MinimumWidth = 8
        Me.tanggalTerbit.Name = "tanggalTerbit"
        Me.tanggalTerbit.Width = 150
        '
        'stock
        '
        Me.stock.HeaderText = "Stok"
        Me.stock.MinimumWidth = 8
        Me.stock.Name = "stock"
        Me.stock.Width = 150
        '
        'bahasa
        '
        Me.bahasa.HeaderText = "Bahasa"
        Me.bahasa.MinimumWidth = 8
        Me.bahasa.Name = "bahasa"
        Me.bahasa.Width = 150
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.MinimumWidth = 8
        Me.kategori.Name = "kategori"
        Me.kategori.Width = 150
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(928, 706)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(85, 34)
        Me.BtnSelect.TabIndex = 4
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(813, 706)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(97, 34)
        Me.BtnUpdate.TabIndex = 5
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(1034, 703)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(85, 37)
        Me.BtnRemove.TabIndex = 6
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 750)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "perpustakaan"
        Me.Text = "perpustakaan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents namaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents jenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents deskripsi As DataGridViewTextBoxColumn
    Friend WithEvents tahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents lokasiRak As DataGridViewTextBoxColumn
    Friend WithEvents tanggalTerbit As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents bahasa As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
End Class
