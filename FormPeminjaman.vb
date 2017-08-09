Imports System.Data
Imports System.Data.OleDb

Public Class FormPeminjaman

    Sub No_Peminjaman()
        Tabel = New Data.OleDb.OleDbDataAdapter("select * from Table_Peminjaman", Database)
        Data = New DataSet
        Tabel.Fill(Data)
        Record.DataSource = Data
        Record.DataMember = Data.Tables(0).ToString()
        Try
            Dim A As String = ""
            Dim B As String = ""
            DML = New OleDbCommand("select * from Table_Peminjaman order by No_Peminjaman desc", Database)
            Cari = DML.ExecuteReader
            If Cari.Read Then
                A = Mid(Cari.Item("No_Peminjaman"), 4, 4)
                B = Val(A) + 1
                TxtNoPeminjaman.Text = "PM0" + Mid("0", 1, 2 - B.Length) & B
            Else
                TxtNoPeminjaman.Text = "PM001"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Clear()
        Call Koneksi()
        If BtnOk.Text = "Ok" Then
            TxtKodeBuku.Text = ""
            TxtKode.Text = ""
            TxtHari.Text = ""
            DPPinjam.Value = Format(Now, "dd/MM/yyyy")
            DPKembali.Value = Format(Now, "dd/MM/yyyy")

            Call No_Peminjaman()
        End If
    End Sub

    Sub Lama_Pinjam()
        Dim SelisihHari As Long
        SelisihHari = DateDiff(DateInterval.Day, DPPinjam.Value, DPKembali.Value)
        TxtHari.Text = "" & SelisihHari & " Hari"
    End Sub

    Private Sub FormPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Clear()
        Me.CenterToParent()
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text

            Select Case BtnOk.Text
                Case "Ok"
                    DML.CommandText = "insert into Table_Peminjaman (No_Peminjaman, Kode_Buku, Kode_Peminjam, Tgl_Pinjam, Tgl_Kembali, Lama_Pinjam, Status) values('" & TxtNoPeminjaman.Text & _
                        "','" & TxtKodeBuku.Text & "','" & TxtKode.Text & "','" & DPPinjam.Value & _
                        "','" & DPKembali.Value & "','" & TxtHari.Text & "','Pinjam')"
                Case "Ubah"
                    DML.CommandText = "update Table_Peminjaman set Kode_Buku='" & TxtKode.Text & _
                        "', Kode_Peminjam='" & TxtKode.Text & "', Tgl_Pinjam='" & DPPinjam.Value & _
                        "', Tgl_Kembali='" & DPKembali.Value & "', Lama_Pinjam='" & TxtHari.Text & _
                        "' where No_Peminjaman='" & TxtNoPeminjaman.Text & "'"
                Case "Hapus"
                    DML.CommandText = "delete from Table_Peminjaman where No_Peminjaman='" & TxtNoPeminjaman.Text & "'"
            End Select
            DML.ExecuteNonQuery()
            MsgBox("Data Telah Diproses")
            Call FormProsesPeminjaman.Data_Record()
            TxtKodeBuku.Text = ""
            TxtKode.Text = ""
            TxtHari.Text = ""
            FotoPic.Image = Nothing
            DPPinjam.Value = Format(Now, "dd/MM/yyyy")
            DPKembali.Value = Format(Now, "dd/MM/yyyy")
            Call No_Peminjaman()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnKodeBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKodeBuku.Click
        Dim Kode_Buku = InputBox("Masukkan kode buku (Kode Buku yang akan dipinjam)")
        TxtKodeBuku.Text = Kode_Buku
    End Sub

    Private Sub TxtKodeBuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKodeBuku.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from Table_Buku where Kode_Buku='" & TxtKodeBuku.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                TxtJudulBuku.Text = Cari("Judul_Buku")
                TxtKategori.Text = Cari("Kategori")
                TxtRak.Text = Cari("Rak")
                FotoPic.ImageLocation = Cari("Foto")
            Else
                TxtKodeBuku.Text = ""
                TxtJudulBuku.Text = ""
                TxtKategori.Text = ""
                TxtRak.Text = ""
                FotoPic.Image = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnKodePeminjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKodePeminjam.Click
        Dim Kode = InputBox("Masukkan Kode Peminjam (Kode Peminjam yang akan meminjam Buku)")
        TxtKode.Text = Kode
    End Sub

    Private Sub DPPinjam_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPPinjam.ValueChanged
        Call Lama_Pinjam()
    End Sub

    Private Sub DPKembali_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPKembali.ValueChanged
        Call Lama_Pinjam()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub TxtKode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKode.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from Table_Peminjam where Kode_Peminjam='" & TxtKode.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                TxtIdentitas.Text = Cari("No_Identitas")
                TxtNama.Text = Cari("Nama_Peminjam")
                TxtAlamat.Text = Cari("Alamat")
                TxtTelepon.Text = Cari("No_Telp")
            Else
                TxtIdentitas.Text = ""
                TxtNama.Text = ""
                TxtAlamat.Text = ""
                TxtTelepon.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

End Class