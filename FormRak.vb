Imports System.Data
Imports System.Data.OleDb

Public Class FormRak

    Sub Data_Record()
        Try
            Call Koneksi()
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from Table_Rak", Database)
            Data = New DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString()
            DGVRak.DataSource = Record
            DGVRak.Columns(0).Width = 300
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Clear()
        BtnSimpanRak.Enabled = True
        BtnUbahRak.Enabled = False
        BtnHapusRak.Enabled = False
        TxtRak.Text = ""
        TxtRak.Focus()
        Call Koneksi()
        Call Data_Record()

    End Sub

    Private Sub FormRak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Clear()
        Me.CenterToParent()
    End Sub

    Private Sub BtnSimpanRak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanRak.Click
        If TxtRak.Text = "" Then TxtRak.Focus() : Exit Sub
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "insert into Table_Rak values('" & TxtRak.Text & "')"
            DML.ExecuteNonQuery()
            MsgBox("Data Telah Disimpan")
            Call Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnUbahRak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbahRak.Click
        If TxtRak.Text = "" Then TxtRak.Focus() : Exit Sub
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "update Table_Rak set Rak='" & TxtRak.Text & "' where Kategori='" & DGVRak.SelectedCells(0).Value & "'"
            DML.ExecuteNonQuery()
            MsgBox("Data Telah Diubah")
            Call Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHapusRak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusRak.Click
        If TxtRak.Text = "" Then TxtRak.Focus() : Exit Sub
        Try
            Dim pesan = MsgBox("Anda Yakin Ingin Menghapus Data?", vbYesNo, "Konfirmasi")
            If pesan = vbYes Then
                Call Koneksi()
                DML.Connection = Database
                DML.CommandType = CommandType.Text
                DML.CommandText = "delete from Table_Rak where Rak='" & TxtRak.Text & "'"
                DML.ExecuteNonQuery()
                MsgBox("Data Telah Dihapus")
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVRak_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVRak.CellContentClick
        Try
            TxtRak.Text = DGVRak.SelectedCells(0).Value
            BtnSimpanRak.Enabled = False
            BtnUbahRak.Enabled = True
            BtnHapusRak.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

End Class