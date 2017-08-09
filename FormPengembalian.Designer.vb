<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengembalian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengembalian))
        Me.BtnPeminjaman = New System.Windows.Forms.Button()
        Me.DPPengembalian = New System.Windows.Forms.DateTimePicker()
        Me.DPKembali = New System.Windows.Forms.DateTimePicker()
        Me.DPPinjam = New System.Windows.Forms.DateTimePicker()
        Me.TxtTelat = New System.Windows.Forms.TextBox()
        Me.TxtJudulBuku = New System.Windows.Forms.TextBox()
        Me.TxtKodeBuku = New System.Windows.Forms.TextBox()
        Me.TxtTelepon = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtIdentitas = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtNoPeminjaman = New System.Windows.Forms.TextBox()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.TxtDenda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnPeminjaman
        '
        Me.BtnPeminjaman.Image = CType(resources.GetObject("BtnPeminjaman.Image"), System.Drawing.Image)
        Me.BtnPeminjaman.Location = New System.Drawing.Point(290, 17)
        Me.BtnPeminjaman.Name = "BtnPeminjaman"
        Me.BtnPeminjaman.Size = New System.Drawing.Size(36, 23)
        Me.BtnPeminjaman.TabIndex = 52
        Me.BtnPeminjaman.UseVisualStyleBackColor = True
        '
        'DPPengembalian
        '
        Me.DPPengembalian.CustomFormat = "dd/MM/yyyy"
        Me.DPPengembalian.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPPengembalian.Location = New System.Drawing.Point(155, 358)
        Me.DPPengembalian.Name = "DPPengembalian"
        Me.DPPengembalian.Size = New System.Drawing.Size(129, 20)
        Me.DPPengembalian.TabIndex = 51
        '
        'DPKembali
        '
        Me.DPKembali.CustomFormat = "dd/MM/yyyy"
        Me.DPKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPKembali.Location = New System.Drawing.Point(155, 315)
        Me.DPKembali.Name = "DPKembali"
        Me.DPKembali.Size = New System.Drawing.Size(129, 20)
        Me.DPKembali.TabIndex = 50
        '
        'DPPinjam
        '
        Me.DPPinjam.CustomFormat = "dd/MM/yyyy"
        Me.DPPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPPinjam.Location = New System.Drawing.Point(155, 289)
        Me.DPPinjam.Name = "DPPinjam"
        Me.DPPinjam.Size = New System.Drawing.Size(129, 20)
        Me.DPPinjam.TabIndex = 49
        '
        'TxtTelat
        '
        Me.TxtTelat.Location = New System.Drawing.Point(155, 384)
        Me.TxtTelat.Name = "TxtTelat"
        Me.TxtTelat.Size = New System.Drawing.Size(129, 20)
        Me.TxtTelat.TabIndex = 48
        '
        'TxtJudulBuku
        '
        Me.TxtJudulBuku.Location = New System.Drawing.Point(155, 260)
        Me.TxtJudulBuku.Name = "TxtJudulBuku"
        Me.TxtJudulBuku.Size = New System.Drawing.Size(214, 20)
        Me.TxtJudulBuku.TabIndex = 47
        '
        'TxtKodeBuku
        '
        Me.TxtKodeBuku.Location = New System.Drawing.Point(155, 234)
        Me.TxtKodeBuku.Name = "TxtKodeBuku"
        Me.TxtKodeBuku.Size = New System.Drawing.Size(129, 20)
        Me.TxtKodeBuku.TabIndex = 46
        '
        'TxtTelepon
        '
        Me.TxtTelepon.Location = New System.Drawing.Point(155, 192)
        Me.TxtTelepon.Name = "TxtTelepon"
        Me.TxtTelepon.Size = New System.Drawing.Size(129, 20)
        Me.TxtTelepon.TabIndex = 45
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(155, 136)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(239, 50)
        Me.TxtAlamat.TabIndex = 44
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(155, 110)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(239, 20)
        Me.TxtNama.TabIndex = 43
        '
        'TxtIdentitas
        '
        Me.TxtIdentitas.Location = New System.Drawing.Point(155, 84)
        Me.TxtIdentitas.Name = "TxtIdentitas"
        Me.TxtIdentitas.Size = New System.Drawing.Size(129, 20)
        Me.TxtIdentitas.TabIndex = 42
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(155, 58)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(129, 20)
        Me.TxtKode.TabIndex = 41
        '
        'TxtNoPeminjaman
        '
        Me.TxtNoPeminjaman.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNoPeminjaman.Location = New System.Drawing.Point(155, 20)
        Me.TxtNoPeminjaman.Name = "TxtNoPeminjaman"
        Me.TxtNoPeminjaman.Size = New System.Drawing.Size(129, 20)
        Me.TxtNoPeminjaman.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 385)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Terlambat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 15)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Tgl Pengembalian"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Tgl Harus Kembali"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Tgl Peminjaman"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Judul Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Kode Buku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nama Peminjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "No. Identitas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Kode Peminjam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "No. Peminjaman"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(287, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 15)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Hari"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOk.Location = New System.Drawing.Point(441, 20)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(92, 30)
        Me.BtnOk.TabIndex = 63
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(441, 56)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(92, 30)
        Me.BtnKeluar.TabIndex = 62
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'TxtDenda
        '
        Me.TxtDenda.Location = New System.Drawing.Point(155, 415)
        Me.TxtDenda.Name = "TxtDenda"
        Me.TxtDenda.Size = New System.Drawing.Size(129, 20)
        Me.TxtDenda.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 416)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Denda"
        '
        'FormPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(563, 447)
        Me.Controls.Add(Me.TxtDenda)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnPeminjaman)
        Me.Controls.Add(Me.DPPengembalian)
        Me.Controls.Add(Me.DPKembali)
        Me.Controls.Add(Me.DPPinjam)
        Me.Controls.Add(Me.TxtTelat)
        Me.Controls.Add(Me.TxtJudulBuku)
        Me.Controls.Add(Me.TxtKodeBuku)
        Me.Controls.Add(Me.TxtTelepon)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtIdentitas)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.TxtNoPeminjaman)
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
        Me.Name = "FormPengembalian"
        Me.Text = "FormPengembalian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPeminjaman As System.Windows.Forms.Button
    Friend WithEvents DPPengembalian As System.Windows.Forms.DateTimePicker
    Friend WithEvents DPKembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents DPPinjam As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtTelat As System.Windows.Forms.TextBox
    Friend WithEvents TxtJudulBuku As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdentitas As System.Windows.Forms.TextBox
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoPeminjaman As System.Windows.Forms.TextBox
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents TxtDenda As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
