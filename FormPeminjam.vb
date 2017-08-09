Imports System.Data
Imports System.Data.OleDb

Public Class FormPeminjam

    Sub Data_Record()
        Try
            'memanggil koneksi database
            Call Koneksi()
            'mengambil data dari tabel buku
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from Table_Peminjam", Database)
            'inisialisasi DataSet
            Data = New DataSet
            'memasukkan data tabel ke DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString()
            DGVPeminjam.DataSource = Record
            DGVPeminjam.Columns(3).Width = 150
            DGVPeminjam.Columns(4).Width = 250
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Clear()
        BtnSimpan.Enabled = True
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        TxtPeminjam.Text = ""
        TxtIdentitas.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtTelepon.Text = ""
        TxtPeminjam.Enabled = False
        TxtPeminjam.Focus()
        Call Kode_Peminjam()
        Call Koneksi()
        Call Data_Record()
    End Sub

    Sub Kode_Peminjam()
        Try
            Call Koneksi()
            Dim a As String = ""
            Dim b As String = ""
            DML = New OleDbCommand("select * from Table_Peminjam order by Kode_Peminjam desc", Database)
            Cari = DML.ExecuteReader
            If Cari.Read Then
                a = Mid(Cari.Item("Kode_Peminjam"), 3, 3)
                b = Val(a) + 1
                TxtPeminjam.Text = "P0" + Mid("0", 1, 2 - b.Length) & b
            Else
                TxtPeminjam.Text = "P001"
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FormPeminjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Call Clear()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "insert into Table_Peminjam (Kode_Peminjam, No_Identitas, Nama_Peminjam, Alamat, No_Telp)" & _
                "values('" & TxtPeminjam.Text & "','" & TxtIdentitas.Text & "','" & TxtNama.Text & _
                "','" & TxtAlamat.Text & "','" & TxtTelepon.Text & "')"
            DML.ExecuteNonQuery()
            MsgBox("Data Telah Disimpan")
            Call Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "update Table_Peminjam set No_Identitas='" & TxtIdentitas.Text & _
                "',Nama_Peminjam ='" & TxtNama.Text & "', Alamat='" & TxtAlamat.Text & _
                "',No_Telp='" & TxtTelepon.Text & "' where Kode_Peminjam='" & TxtPeminjam.Text & "'"
            DML.ExecuteNonQuery()
            MsgBox("Data Telah Diubah")
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
                DML.CommandText = "delete from Table_Peminjam where Kode_Peminjam='" & TxtPeminjam.Text & "'"
                DML.ExecuteNonQuery()
                MsgBox("Data Telah Dihapus")
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVPeminjam_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPeminjam.CellContentClick
        Try
            TxtPeminjam.Text = DGVPeminjam.Rows(e.RowIndex).Cells(1).Value
            TxtIdentitas.Text = DGVPeminjam.Rows(e.RowIndex).Cells(2).Value
            TxtNama.Text = DGVPeminjam.Rows(e.RowIndex).Cells(3).Value
            TxtAlamat.Text = DGVPeminjam.Rows(e.RowIndex).Cells(4).Value
            TxtTelepon.Text = DGVPeminjam.Rows(e.RowIndex).Cells(5).Value
            BtnSimpan.Enabled = False
            BtnEdit.Enabled = True
            BtnHapus.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Dim Kode_Peminjam = InputBox("Masukkan Kode Peminjam")
        Try
            Data.Tables(0).PrimaryKey = New DataColumn() {Data.Tables(0).Columns("Kode_Peminjam")}
            Dim row As DataRow
            row = Data.Tables(0).Rows.Find(Kode_Peminjam)
            TxtPeminjam.Text = row("Kode_Peminjam")
            TxtIdentitas.Text = row("No_Identitas")
            TxtNama.Text = row("Nama_Peminjam")
            TxtAlamat.Text = row("Alamat")
            TxtTelepon.Text = row("No_Telp")
        Catch ex As Exception
            MsgBox("Data Tidak Ditemukan")
        End Try
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Call Kode_Peminjam()
        TxtIdentitas.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtTelepon.Text = ""
        TxtPeminjam.Focus()
    End Sub

End Class