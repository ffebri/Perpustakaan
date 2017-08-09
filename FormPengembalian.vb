Imports System.Data
Imports System.Data.OleDb

Public Class FormPengembalian

    Sub Hitung_Telat()
        Dim TelatHari As Long
        Dim Denda As Integer
        TelatHari = DateDiff(DateInterval.Day, DPKembali.Value, DPPengembalian.Value)
        TxtTelat.Text = "" & TelatHari & ""
        If TelatHari > 0 Then
            Denda = TelatHari * 1000
            TxtDenda.Text = "" & Denda & ""
        Else
            TxtDenda.Text = ""
        End If
    End Sub

    Private Sub FormPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DPPengembalian.Value = Format(Now, "dd/MM/yyyy")
        Me.CenterToParent()
    End Sub

    Private Sub BtnPeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjaman.Click
        Dim No_Peminjaman = InputBox("Masukkan nomor pada saat transaksi peminjaman")
        TxtNoPeminjaman.Text = No_Peminjaman
    End Sub

    Private Sub TxtNoPeminjaman_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNoPeminjaman.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from Query1 where No_Peminjaman='" & TxtNoPeminjaman.Text & "' and Status='Pinjam'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                TxtKodeBuku.Text = Cari("Kode_Buku")
                TxtJudulBuku.Text = Cari("Judul_Buku")
                TxtIdentitas.Text = Cari("No_Identitas")
                TxtKode.Text = Cari("Kode_Peminjam")
                TxtNama.Text = Cari("Nama_Peminjam")
                TxtAlamat.Text = Cari("Alamat")
                TxtTelepon.Text = Cari("No_Telp")
                DPPinjam.Value = Cari("Tgl_Pinjam")
                DPKembali.Value = Cari("Tgl_Kembali")
                Call Hitung_Telat()

            Else
                TxtKodeBuku.Text = ""
                TxtJudulBuku.Text = ""
                TxtIdentitas.Text = ""
                TxtKode.Text = ""
                TxtNama.Text = ""
                TxtAlamat.Text = ""
                TxtTelepon.Text = ""
                DPPengembalian.Value = Format(Now, "dd/MM/yyyy")
                TxtTelat.Text = ""
                TxtDenda.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "update Query1 set Status='Kembali' where No_Peminjaman='" & TxtNoPeminjaman.Text & "'"
            DML.ExecuteNonQuery()
            FormProsesPeminjaman.DGVPeminjaman.SelectedCells(7).Value = "Kembali"
            MsgBox("Data Telah Diproses")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DPPengembalian_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DPPengembalian.ValueChanged
        Call Hitung_Telat()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

End Class