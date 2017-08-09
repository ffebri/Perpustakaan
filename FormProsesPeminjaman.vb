Imports System.Data
Imports System.Data.OleDb

Public Class FormProsesPeminjaman

    Sub Data_Record()
        Try
            Call Koneksi()
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from Query1 where Status='Pinjam'", Database)
            Data = New DataSet
            Tabel.Fill(Data)
            Record_Peminjaman.DataSource = Data
            Record_Peminjaman.DataMember = Data.Tables(0).ToString
            DGVPeminjaman.DataSource = Record
            DGPeminjaman.DataSource = Record_Peminjaman

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Clear()
        BtnTransaksi.Enabled = True
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        Call Koneksi()
        Call Data_Record()
    End Sub

    Private Sub FrmDataPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Clear()
    End Sub

    Private Sub BtnTransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransaksi.Click
        FormPeminjaman.Text = "Ok"
        FormPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        FormPeminjaman.BtnOk.Text = "Ubah"
        FormPeminjaman.TxtNoPeminjaman.Text = DGVPeminjaman.SelectedCells(1).Value
        FormPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        FormPeminjaman.BtnOk.Text = "Hapus"
        FormPeminjaman.TxtNoPeminjaman.Text = DGVPeminjaman.SelectedCells(1).Value
        FormPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub DGVPeminjaman_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPeminjaman.CellContentClick
        Try
            FormPeminjaman.TxtNoPeminjaman.Text = DGVPeminjaman.Rows(e.RowIndex).Cells(0).Value
            FormPeminjaman.TxtKodeBuku.Text = DGVPeminjaman.Rows(e.RowIndex).Cells(1).Value
            FormPeminjaman.TxtKode.Text = DGVPeminjaman.Rows(e.RowIndex).Cells(5).Value
            FormPeminjaman.DPPinjam.Value = DGVPeminjaman.Rows(e.RowIndex).Cells(10).Value
            FormPeminjaman.DPKembali.Value = DGVPeminjaman.Rows(e.RowIndex).Cells(11).Value
            FormPeminjaman.TxtHari.Text = DGVPeminjaman.Rows(e.RowIndex).Cells(12).Value
            BtnEdit.Enabled = True
            BtnHapus.Enabled = True
            BtnTransaksi.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FormProsesPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
   
End Class