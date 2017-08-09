Imports System.Data
Imports System.Data.OleDb
Module ModKoneksi
    Public Database As OleDbConnection
    Public Tabel As OleDbDataAdapter
    Public Data As DataSet
    Public Record, Record_Peminjaman As New BindingSource
    Public DML As New OleDbCommand
    Public Cari As OleDbDataReader

    Public Sub Koneksi()
        Try
            Database = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBPerpustakaan.accdb")
            Database.Open()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Module
