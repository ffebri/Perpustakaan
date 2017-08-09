Public Class FormRakdanKategori

    Private Sub BtnRak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRak.Click
        FormRak.ShowDialog()
    End Sub

    Private Sub BtnKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKategori.Click
        FormKategori.ShowDialog()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FormRakdanKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

End Class
