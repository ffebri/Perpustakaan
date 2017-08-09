Public Class FormMenuUtama

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Lbl12Jam.Text = Format(Now, "hh:mm:ss tt")
        LblTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")

    End Sub

    Private Sub BtnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuku.Click
        FormBuku.ShowDialog()
    End Sub

    Private Sub BtnRakKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRakKategori.Click
        FormRakdanKategori.ShowDialog()
    End Sub

    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        Me.CenterToScreen()
    End Sub

    Private Sub BtnPeminjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjam.Click
        FormPeminjam.ShowDialog()
    End Sub

    Private Sub BtnPeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjaman.Click
        FormProsesPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        FormCari.ShowDialog()
    End Sub

    Private Sub BtnPengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPengembalian.Click
        FormPengembalian.ShowDialog()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub
End Class
