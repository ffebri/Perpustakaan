<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPeminjaman))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnKodePeminjam = New System.Windows.Forms.Button()
        Me.BtnKodeBuku = New System.Windows.Forms.Button()
        Me.FotoPic = New System.Windows.Forms.PictureBox()
        Me.DPKembali = New System.Windows.Forms.DateTimePicker()
        Me.DPPinjam = New System.Windows.Forms.DateTimePicker()
        Me.TxtHari = New System.Windows.Forms.TextBox()
        Me.TxtTelepon = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtIdentitas = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtRak = New System.Windows.Forms.TextBox()
        Me.TxtKategori = New System.Windows.Forms.TextBox()
        Me.TxtJudulBuku = New System.Windows.Forms.TextBox()
        Me.TxtKodeBuku = New System.Windows.Forms.TextBox()
        Me.TxtNoPeminjaman = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKodePeminjam
        '
        Me.BtnKodePeminjam.Image = CType(resources.GetObject("BtnKodePeminjam.Image"), System.Drawing.Image)
        Me.BtnKodePeminjam.Location = New System.Drawing.Point(331, 43)
        Me.BtnKodePeminjam.Name = "BtnKodePeminjam"
        Me.BtnKodePeminjam.Size = New System.Drawing.Size(33, 23)
        Me.BtnKodePeminjam.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.BtnKodePeminjam, "Kode Peminjam")
        Me.BtnKodePeminjam.UseVisualStyleBackColor = True
        '
        'BtnKodeBuku
        '
        Me.BtnKodeBuku.Image = CType(resources.GetObject("BtnKodeBuku.Image"), System.Drawing.Image)
        Me.BtnKodeBuku.Location = New System.Drawing.Point(331, 213)
        Me.BtnKodeBuku.Name = "BtnKodeBuku"
        Me.BtnKodeBuku.Size = New System.Drawing.Size(33, 23)
        Me.BtnKodeBuku.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.BtnKodeBuku, "Kode Buku")
        Me.BtnKodeBuku.UseVisualStyleBackColor = True
        '
        'FotoPic
        '
        Me.FotoPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPic.Location = New System.Drawing.Point(435, 27)
        Me.FotoPic.Name = "FotoPic"
        Me.FotoPic.Size = New System.Drawing.Size(111, 133)
        Me.FotoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPic.TabIndex = 59
        Me.FotoPic.TabStop = False
        '
        'DPKembali
        '
        Me.DPKembali.CustomFormat = "dd/MM/yyyy"
        Me.DPKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPKembali.Location = New System.Drawing.Point(165, 341)
        Me.DPKembali.Name = "DPKembali"
        Me.DPKembali.Size = New System.Drawing.Size(155, 20)
        Me.DPKembali.TabIndex = 58
        '
        'DPPinjam
        '
        Me.DPPinjam.CustomFormat = "dd/MM/yyyy"
        Me.DPPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPPinjam.Location = New System.Drawing.Point(165, 315)
        Me.DPPinjam.Name = "DPPinjam"
        Me.DPPinjam.Size = New System.Drawing.Size(155, 20)
        Me.DPPinjam.TabIndex = 57
        '
        'TxtHari
        '
        Me.TxtHari.Location = New System.Drawing.Point(165, 364)
        Me.TxtHari.Name = "TxtHari"
        Me.TxtHari.Size = New System.Drawing.Size(155, 20)
        Me.TxtHari.TabIndex = 54
        '
        'TxtTelepon
        '
        Me.TxtTelepon.Location = New System.Drawing.Point(165, 188)
        Me.TxtTelepon.Name = "TxtTelepon"
        Me.TxtTelepon.Size = New System.Drawing.Size(160, 20)
        Me.TxtTelepon.TabIndex = 53
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(165, 121)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(246, 55)
        Me.TxtAlamat.TabIndex = 52
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(165, 95)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(246, 20)
        Me.TxtNama.TabIndex = 51
        '
        'TxtIdentitas
        '
        Me.TxtIdentitas.Location = New System.Drawing.Point(165, 69)
        Me.TxtIdentitas.Name = "TxtIdentitas"
        Me.TxtIdentitas.Size = New System.Drawing.Size(155, 20)
        Me.TxtIdentitas.TabIndex = 50
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKode.Location = New System.Drawing.Point(165, 45)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(155, 20)
        Me.TxtKode.TabIndex = 49
        '
        'TxtRak
        '
        Me.TxtRak.Location = New System.Drawing.Point(165, 287)
        Me.TxtRak.Name = "TxtRak"
        Me.TxtRak.Size = New System.Drawing.Size(155, 20)
        Me.TxtRak.TabIndex = 48
        '
        'TxtKategori
        '
        Me.TxtKategori.Location = New System.Drawing.Point(165, 263)
        Me.TxtKategori.Name = "TxtKategori"
        Me.TxtKategori.Size = New System.Drawing.Size(155, 20)
        Me.TxtKategori.TabIndex = 47
        '
        'TxtJudulBuku
        '
        Me.TxtJudulBuku.Location = New System.Drawing.Point(165, 237)
        Me.TxtJudulBuku.Name = "TxtJudulBuku"
        Me.TxtJudulBuku.Size = New System.Drawing.Size(246, 20)
        Me.TxtJudulBuku.TabIndex = 46
        '
        'TxtKodeBuku
        '
        Me.TxtKodeBuku.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKodeBuku.Location = New System.Drawing.Point(165, 215)
        Me.TxtKodeBuku.Name = "TxtKodeBuku"
        Me.TxtKodeBuku.Size = New System.Drawing.Size(160, 20)
        Me.TxtKodeBuku.TabIndex = 45
        '
        'TxtNoPeminjaman
        '
        Me.TxtNoPeminjaman.Location = New System.Drawing.Point(165, 12)
        Me.TxtNoPeminjaman.Name = "TxtNoPeminjaman"
        Me.TxtNoPeminjaman.ReadOnly = True
        Me.TxtNoPeminjaman.Size = New System.Drawing.Size(155, 20)
        Me.TxtNoPeminjaman.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 365)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 15)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Lama Pinjam (Hari)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 15)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Tanggal Kembali"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 15)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Tanggal Pinjam"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Telepon"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Nama Peminjam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "No. Identitas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Kode Peminjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Rak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Judul Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Kode Buku"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "No. Peminjaman"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(444, 235)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(92, 30)
        Me.BtnKeluar.TabIndex = 60
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOk.Location = New System.Drawing.Point(444, 193)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(92, 30)
        Me.BtnOk.TabIndex = 61
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'FormPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(570, 409)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.FotoPic)
        Me.Controls.Add(Me.DPKembali)
        Me.Controls.Add(Me.DPPinjam)
        Me.Controls.Add(Me.BtnKodePeminjam)
        Me.Controls.Add(Me.BtnKodeBuku)
        Me.Controls.Add(Me.TxtHari)
        Me.Controls.Add(Me.TxtTelepon)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtIdentitas)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.TxtRak)
        Me.Controls.Add(Me.TxtKategori)
        Me.Controls.Add(Me.TxtJudulBuku)
        Me.Controls.Add(Me.TxtKodeBuku)
        Me.Controls.Add(Me.TxtNoPeminjaman)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPeminjaman"
        Me.Text = "FormPeminjaman"
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FotoPic As System.Windows.Forms.PictureBox
    Friend WithEvents DPKembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents DPPinjam As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnKodePeminjam As System.Windows.Forms.Button
    Friend WithEvents BtnKodeBuku As System.Windows.Forms.Button
    Friend WithEvents TxtHari As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdentitas As System.Windows.Forms.TextBox
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents TxtRak As System.Windows.Forms.TextBox
    Friend WithEvents TxtKategori As System.Windows.Forms.TextBox
    Friend WithEvents TxtJudulBuku As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoPeminjaman As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
End Class
