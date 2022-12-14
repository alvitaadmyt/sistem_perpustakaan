Public Class perpustakaan

    'variabel global koleksibuku
    Public Shared KoleksiBuku As KoleksiBuku
    Public Shared selectedTableKoleksi
    Dim selectedTableKoleksiNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'manggil class koleksibuku
        KoleksiBuku = New KoleksiBuku()

        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim tambah_koleksi = New tambah_koleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If (ListBoxKoleksi.SelectedIndex = -1) Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        Else
            Dim hapus_koleksi = New hapus_koleksi()
            hapus_koleksi.Show()
        End If
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambah_koleksi = New tambah_koleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'ListBoxKoleksi.Items.Clear()

        'For Each koll In KoleksiBuku.getKoleksiItem
        'ListBoxKoleksi.Items.Add(koll)
        'Next


        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridView1.Rows.Clear()
        For Each rowKoleksi In KoleksiBuku.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(4),
                                         rowKoleksi(3),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10)}
            DataGridView1.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim dataselected = KoleksiBuku.getKoleksiDataTable.Item(selectedTableKoleksi)

        KoleksiBuku.GSFoto = dataselected(0)

        KoleksiBuku.GSNama = dataselected(1)
        KoleksiBuku.GSJenis = dataselected(2)
        KoleksiBuku.GSDeskripsi = dataselected(3)
        KoleksiBuku.GSPenerbit = dataselected(4)
        KoleksiBuku.GSTahunTerbit = dataselected(5)
        KoleksiBuku.GSLokasiRak = dataselected(6)
        KoleksiBuku.GSTanggal = dataselected(7)
        KoleksiBuku.GSStock = dataselected(8)
        KoleksiBuku.GSBahasa = dataselected(9)

        'MessageBox.Show(dataselected(10).ToString)
        Dim data_koleksi As List(Of String) = KoleksiBuku.ConvertStringToKoleksi(dataselected(10))

        For Each info_tambah In data_koleksi
            KoleksiBuku.AddKategori(info_tambah)
        Next

        Dim infoTambah = New info_tambah_koleksi()
        infoTambah.Show()
    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = KoleksiBuku.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'selectedTableKoleksi = DataGridView1.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = KoleksiBuku.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        KoleksiBuku.GSFoto = selectedKoleksi(2)

        KoleksiBuku.GSNama = selectedKoleksi(1)
        KoleksiBuku.GSJenis = selectedKoleksi(5)
        KoleksiBuku.GSDeskripsi = selectedKoleksi(3)
        KoleksiBuku.GSPenerbit = selectedKoleksi(4)
        KoleksiBuku.GSTahunTerbit = selectedKoleksi(6)
        KoleksiBuku.GSLokasiRak = selectedKoleksi(7)
        KoleksiBuku.GSTanggal = selectedKoleksi(8)
        KoleksiBuku.GSStock = selectedKoleksi(9)
        KoleksiBuku.GSBahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = KoleksiBuku.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            KoleksiBuku.AddKategori(info_kategori)
        Next

        Dim formUpdate = New info_tambah_koleksi()
        formUpdate.show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formHapus = New hapus_koleksi()
        formHapus.Show()
    End Sub
End Class