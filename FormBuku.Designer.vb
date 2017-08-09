<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuku
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuku))
        Me.DGVBuku = New System.Windows.Forms.DataGridView()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.CBKategori = New System.Windows.Forms.ComboBox()
        Me.LblRak = New System.Windows.Forms.Label()
        Me.CBRak = New System.Windows.Forms.ComboBox()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.FotoPic = New System.Windows.Forms.PictureBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.BtnHapusFoto = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.OFDFoto = New System.Windows.Forms.OpenFileDialog()
        Me.FotoTxt = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtJudul = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVBuku
        '
        Me.DGVBuku.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBuku.Location = New System.Drawing.Point(15, 140)
        Me.DGVBuku.Name = "DGVBuku"
        Me.DGVBuku.ReadOnly = True
        Me.DGVBuku.Size = New System.Drawing.Size(749, 294)
        Me.DGVBuku.TabIndex = 0
        '
        'LblKode
        '
        Me.LblKode.AutoSize = True
        Me.LblKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblKode.Location = New System.Drawing.Point(12, 11)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(67, 15)
        Me.LblKode.TabIndex = 1
        Me.LblKode.Text = "Kode Buku"
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJudul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblJudul.Location = New System.Drawing.Point(12, 36)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(68, 15)
        Me.LblJudul.TabIndex = 3
        Me.LblJudul.Text = "Judul Buku"
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblKategori.Location = New System.Drawing.Point(12, 64)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(84, 15)
        Me.LblKategori.TabIndex = 5
        Me.LblKategori.Text = "Kategori Buku"
        '
        'CBKategori
        '
        Me.CBKategori.FormattingEnabled = True
        Me.CBKategori.Location = New System.Drawing.Point(137, 63)
        Me.CBKategori.Name = "CBKategori"
        Me.CBKategori.Size = New System.Drawing.Size(402, 21)
        Me.CBKategori.TabIndex = 6
        '
        'LblRak
        '
        Me.LblRak.AutoSize = True
        Me.LblRak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRak.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblRak.Location = New System.Drawing.Point(12, 94)
        Me.LblRak.Name = "LblRak"
        Me.LblRak.Size = New System.Drawing.Size(29, 15)
        Me.LblRak.TabIndex = 7
        Me.LblRak.Text = "Rak"
        '
        'CBRak
        '
        Me.CBRak.FormattingEnabled = True
        Me.CBRak.Location = New System.Drawing.Point(137, 93)
        Me.CBRak.Name = "CBRak"
        Me.CBRak.Size = New System.Drawing.Size(195, 21)
        Me.CBRak.TabIndex = 8
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStok.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblStok.Location = New System.Drawing.Point(12, 119)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(31, 15)
        Me.LblStok.TabIndex = 9
        Me.LblStok.Text = "Stok"
        '
        'FotoPic
        '
        Me.FotoPic.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FotoPic.Location = New System.Drawing.Point(621, 10)
        Me.FotoPic.Name = "FotoPic"
        Me.FotoPic.Size = New System.Drawing.Size(107, 124)
        Me.FotoPic.TabIndex = 11
        Me.FotoPic.TabStop = False
        '
        'BtnFoto
        '
        Me.BtnFoto.Image = CType(resources.GetObject("BtnFoto.Image"), System.Drawing.Image)
        Me.BtnFoto.Location = New System.Drawing.Point(734, 41)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(41, 29)
        Me.BtnFoto.TabIndex = 12
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'BtnHapusFoto
        '
        Me.BtnHapusFoto.Image = CType(resources.GetObject("BtnHapusFoto.Image"), System.Drawing.Image)
        Me.BtnHapusFoto.Location = New System.Drawing.Point(734, 76)
        Me.BtnHapusFoto.Name = "BtnHapusFoto"
        Me.BtnHapusFoto.Size = New System.Drawing.Size(41, 29)
        Me.BtnHapusFoto.TabIndex = 13
        Me.BtnHapusFoto.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(15, 440)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(92, 30)
        Me.BtnSimpan.TabIndex = 14
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(211, 440)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(92, 30)
        Me.BtnHapus.TabIndex = 15
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(113, 440)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(92, 30)
        Me.BtnEdit.TabIndex = 16
        Me.BtnEdit.Text = "Ubah"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(683, 440)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(92, 30)
        Me.BtnKeluar.TabIndex = 17
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'FotoTxt
        '
        Me.FotoTxt.Location = New System.Drawing.Point(642, 32)
        Me.FotoTxt.Name = "FotoTxt"
        Me.FotoTxt.Size = New System.Drawing.Size(69, 20)
        Me.FotoTxt.TabIndex = 18
        Me.FotoTxt.Visible = False
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(137, 11)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(195, 20)
        Me.TxtKode.TabIndex = 19
        '
        'TxtJudul
        '
        Me.TxtJudul.Location = New System.Drawing.Point(137, 35)
        Me.TxtJudul.Name = "TxtJudul"
        Me.TxtJudul.Size = New System.Drawing.Size(402, 20)
        Me.TxtJudul.TabIndex = 20
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(137, 118)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(195, 20)
        Me.TxtStok.TabIndex = 21
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(309, 440)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(92, 30)
        Me.BtnCari.TabIndex = 22
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(624, 440)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(53, 30)
        Me.BtnRefresh.TabIndex = 37
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'FormBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(794, 482)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.TxtJudul)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.FotoTxt)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnHapusFoto)
        Me.Controls.Add(Me.BtnFoto)
        Me.Controls.Add(Me.FotoPic)
        Me.Controls.Add(Me.LblStok)
        Me.Controls.Add(Me.CBRak)
        Me.Controls.Add(Me.LblRak)
        Me.Controls.Add(Me.CBKategori)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.LblJudul)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.DGVBuku)
        Me.Name = "FormBuku"
        Me.Text = "FormBuku"
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVBuku As System.Windows.Forms.DataGridView
    Friend WithEvents LblKode As System.Windows.Forms.Label
    Friend WithEvents LblJudul As System.Windows.Forms.Label
    Friend WithEvents LblKategori As System.Windows.Forms.Label
    Friend WithEvents CBKategori As System.Windows.Forms.ComboBox
    Friend WithEvents LblRak As System.Windows.Forms.Label
    Friend WithEvents CBRak As System.Windows.Forms.ComboBox
    Friend WithEvents LblStok As System.Windows.Forms.Label
    Friend WithEvents FotoPic As System.Windows.Forms.PictureBox
    Friend WithEvents BtnFoto As System.Windows.Forms.Button
    Friend WithEvents BtnHapusFoto As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents OFDFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FotoTxt As System.Windows.Forms.TextBox
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents TxtJudul As System.Windows.Forms.TextBox
    Friend WithEvents TxtStok As System.Windows.Forms.TextBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
End Class
