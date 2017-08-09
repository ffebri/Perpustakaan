Imports System.Data
Imports System.Data.OleDb

Public Class FormKategori
    Sub Data_Record()
        Try
            Call Koneksi()
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from Table_Kategori", Database)
            Data = New DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString()
            DGVKategori.DataSource = Record
            DGVKategori.Columns(0).Width = 300
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Clear()

        BtnSimpanKategori.Enabled = True
        BtnUbahKategori.Enabled = False
        BtnHapusKategori.Enabled = False
        TxtKategori.Text = ""
        TxtKategori.Focus()
        Call Koneksi()
        Call Data_Record()

    End Sub

    Private Sub FormRakdanKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Clear()
        Me.CenterToParent()
    End Sub

    Private Sub BtnSimpanKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanKategori.Click
        If TxtKategori.Text = "" Then TxtKategori.Focus() : Exit Sub
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "insert into  Table_Kategori values('" & TxtKategori.Text & "')"
            DML.ExecuteNonQuery()
            MsgBox("Data Telah Disimpan")
            Call Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnUbahKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbahKategori.Click
        If TxtKategori.Text = "" Then TxtKategori.Focus() : Exit Sub
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "update Table_Kategori set Kategori='" & TxtKategori.Text & "' where Kategori='" & DGVKategori.SelectedCells(0).Value & "'"
            DML.ExecuteNonQuery()
            MsgBox("Data Telah Diubah")
            Call Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHapusKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusKategori.Click
        If TxtKategori.Text = "" Then TxtKategori.Focus() : Exit Sub
        Try
            Dim pesan = MsgBox("Anda Yakin Ingin Menghapus Data?", vbYesNo, "Konfirmasi")
            If pesan = vbYes Then
                Call Koneksi()
                DML.Connection = Database
                DML.CommandType = CommandType.Text
                DML.CommandText = "delete from Table_Kategori where Kategori='" & TxtKategori.Text & "'"
                DML.ExecuteNonQuery()
                MsgBox("Data Telah Dihapus")
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub FormKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub DGVKategori_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVKategori.CellContentClick
        Try
            TxtKategori.Text = DGVKategori.SelectedCells(0).Value
            BtnSimpanKategori.Enabled = False
            BtnUbahKategori.Enabled = True
            BtnHapusKategori.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

End Class