Public Class FormCari

    Private Sub TxtKodeBuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKodeBuku.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from Table_Buku where Kode_Buku='" & TxtKodeBuku.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                TxtCari.Text = Cari("Rak")
            Else
                TxtKodeBuku.Text = ""
                TxtCari.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FormCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub BtnKode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKode.Click
        Dim Kode_Buku = InputBox("Masukkan kode buku yang akan dicari")
        TxtKodeBuku.Text = Kode_Buku
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnJudul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJudul.Click
        Dim Judul_Buku = InputBox("Masukkan Judul buku lengkap yang akan dicari")
        TxtJudulBuku.Text = Judul_Buku
    End Sub

    Private Sub TxtJudulBuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtJudulBuku.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from Table_Buku where Judul_Buku='" & TxtJudulBuku.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                TxtCari.Text = Cari("Rak")
            Else
                TxtJudulBuku.Text = ""
                TxtCari.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class