Imports System.Data
Imports System.Data.OleDb

Public Class FormBuku
    Sub Data_Record()
        Try
            'memanggil koneksi database
            Call Koneksi()
            'mengambil data dari tabel buku
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from Table_Buku", Database)
            'inisialisasi DataSet
            Data = New DataSet
            'memasukkan data tabel ke DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString()
            DGVBuku.DataSource = Record
            DGVBuku.Columns(1).Width = 300
            DGVBuku.Columns(2).Width = 150
            DGVBuku.Columns(5).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Clear()
        
        BtnSimpan.Enabled = True
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        TxtKode.Text = ""
        TxtJudul.Text = ""
        CBKategori.Text = ""
        CBRak.Text = ""
        TxtStok.Text = ""
        TxtKode.Enabled = True
        TxtKode.Focus()
        Call Koneksi()
        Call Data_Record()

    End Sub

    Sub Data_Kategori()
        Call Koneksi()

        Tabel = New Data.OleDb.OleDbDataAdapter("select * from Table_Kategori", Database)
        Data = New DataSet
        Tabel.Fill(Data)
        Record.DataSource = Data
        Record.DataMember = Data.Tables(0).ToString()

        Try
            Dim a As DataRow
            CBKategori.Items.Clear()
            For Each a In Data.Tables(0).Rows
                CBKategori.Items.Add(a.Item(0))
            Next a
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Data_Rak()
        Tabel = New Data.OleDb.OleDbDataAdapter("select * from Table_Rak", Database)
        Data = New DataSet
        Tabel.Fill(Data)
        Record.DataSource = Data
        Record.DataMember = Data.Tables(0).ToString()

        Try
            Dim a As DataRow
            CBRak.Items.Clear()
            For Each a In Data.Tables(0).Rows
                CBRak.Items.Add(a.Item(0))
            Next a
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Function Validasi()
        If TxtKode.Text = "" Or TxtJudul.Text = "" Or CBKategori.Text = "" Or CBRak.Text = "" Or TxtStok.Text = "" Then
            Validasi = "Tidak Valid"
        Else
            Validasi = "Valid"
        End If
    End Function

    Private Sub FormBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Kategori()
        Call Data_Rak()
        Call Clear()
        Me.CenterToParent()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            Call Koneksi()
            Dim Cek = Validasi()
            If Cek = "Valid" Then
                DML.Connection = Database
                DML.CommandType = CommandType.Text
                DML.CommandText = "Insert into Table_Buku values('" & TxtKode.Text & "','" & TxtJudul.Text & "','" & CBKategori.Text & "','" & CBRak.Text & "','" & TxtStok.Text & "', '" & FotoTxt.Text & "')"
                DML.ExecuteNonQuery()
                MsgBox("Data Telah Disimpan")
                Call Clear()
            Else
                MsgBox("Data Gagal Disimpan", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "Update Table_Buku set Judul_Buku='" & TxtJudul.Text & _
                    "', Kategori='" & CBKategori.Text & "', Rak='" & CBRak.Text & _
                    "', Stok='" & TxtStok.Text & "', Foto= '" & FotoTxt.Text & _
                    "' where Kode_Buku='" & TxtKode.Text & "'"
            DML.ExecuteNonQuery()
            MsgBox("Data telah diubah")
            Call Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Try
            Dim pesan = MsgBox("Anda Yakin Ingin Menghapus Data?", vbYesNo, "Konfirmasi")
            If pesan = vbYes Then
                Call Koneksi()
                DML.Connection = Database
                DML.CommandType = CommandType.Text
                DML.CommandText = "Delete from Table_Buku where Kode_Buku='" & TxtKode.Text & "'"
                DML.ExecuteNonQuery()
                MsgBox("data telah dihapus")
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVBuku_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVBuku.CellContentClick
        Try
            TxtKode.Text = DGVBuku.Rows(e.RowIndex).Cells(0).Value
            TxtJudul.Text = DGVBuku.Rows(e.RowIndex).Cells(1).Value
            CBKategori.Text = DGVBuku.Rows(e.RowIndex).Cells(2).Value
            CBRak.Text = DGVBuku.Rows(e.RowIndex).Cells(3).Value
            TxtStok.Text = DGVBuku.Rows(e.RowIndex).Cells(4).Value
            FotoTxt.Text = DGVBuku.Rows(e.RowIndex).Cells(5).Value
            BtnSimpan.Enabled = False
            BtnEdit.Enabled = True
            BtnKeluar.Enabled = True
            BtnHapus.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFoto.Click
        OFDFoto.Filter = "JPG|*.jpg|Bitmap|*.bmp"
        OFDFoto.RestoreDirectory = True
        OFDFoto.ShowDialog()
        If OFDFoto.FileName = "" Then
            Exit Sub
        Else
            'belum ada proses upload file gambar ke folder tertentu
            FotoTxt.Text = OFDFoto.FileName
            On Error Resume Next
            FotoPic.ImageLocation = FotoTxt.Text
        End If
    End Sub

    Private Sub BtnHapusFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusFoto.Click
        FotoPic.Image = Nothing
        FotoTxt.Text = ""
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Dim Kode_Buku = InputBox("Masukkan Kode Buku")
        Try
            Data.Tables(0).PrimaryKey = New DataColumn() {Data.Tables(0).Columns("Kode_Buku")}
            Dim row As DataRow
            row = Data.Tables(0).Rows.Find(Kode_Buku)
            TxtKode.Text = row("Kode_Buku")
            TxtJudul.Text = row("Judul_Buku")
            CBKategori.Text = row("Kategori")
            CBRak.Text = row("Rak")
            TxtStok.Text = row("Stok")
        Catch ex As Exception
            MsgBox("Data Tidak Ditemukan")
        End Try
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        TxtKode.Text = ""
        TxtJudul.Text = ""
        CBKategori.Text = ""
        CBRak.Text = ""
        TxtStok.Text = ""
        TxtKode.Enabled = True
        TxtKode.Focus()
    End Sub
End Class