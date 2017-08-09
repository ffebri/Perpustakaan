<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl12Jam = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBuku = New System.Windows.Forms.Button()
        Me.BtnPeminjam = New System.Windows.Forms.Button()
        Me.BtnRakKategori = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnPeminjaman = New System.Windows.Forms.Button()
        Me.BtnPengembalian = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Lbl12Jam
        '
        Me.Lbl12Jam.AutoSize = True
        Me.Lbl12Jam.Location = New System.Drawing.Point(191, 208)
        Me.Lbl12Jam.Name = "Lbl12Jam"
        Me.Lbl12Jam.Size = New System.Drawing.Size(26, 13)
        Me.Lbl12Jam.TabIndex = 2
        Me.Lbl12Jam.Text = "Jam"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Location = New System.Drawing.Point(264, 208)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(46, 13)
        Me.LblTanggal.TabIndex = 4
        Me.LblTanggal.Text = "Tanggal"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(156, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(291, 266)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, -30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(539, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnBuku
        '
        Me.BtnBuku.Image = CType(resources.GetObject("BtnBuku.Image"), System.Drawing.Image)
        Me.BtnBuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuku.Location = New System.Drawing.Point(12, 229)
        Me.BtnBuku.Name = "BtnBuku"
        Me.BtnBuku.Size = New System.Drawing.Size(124, 37)
        Me.BtnBuku.TabIndex = 7
        Me.BtnBuku.Text = "Buku"
        Me.BtnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuku.UseVisualStyleBackColor = True
        '
        'BtnPeminjam
        '
        Me.BtnPeminjam.Image = CType(resources.GetObject("BtnPeminjam.Image"), System.Drawing.Image)
        Me.BtnPeminjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeminjam.Location = New System.Drawing.Point(464, 229)
        Me.BtnPeminjam.Name = "BtnPeminjam"
        Me.BtnPeminjam.Size = New System.Drawing.Size(123, 37)
        Me.BtnPeminjam.TabIndex = 9
        Me.BtnPeminjam.Text = "Peminjam"
        Me.BtnPeminjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPeminjam.UseVisualStyleBackColor = True
        '
        'BtnRakKategori
        '
        Me.BtnRakKategori.Image = CType(resources.GetObject("BtnRakKategori.Image"), System.Drawing.Image)
        Me.BtnRakKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRakKategori.Location = New System.Drawing.Point(12, 315)
        Me.BtnRakKategori.Name = "BtnRakKategori"
        Me.BtnRakKategori.Size = New System.Drawing.Size(124, 37)
        Me.BtnRakKategori.TabIndex = 10
        Me.BtnRakKategori.Text = "Rak dan Kategori"
        Me.BtnRakKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRakKategori.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(12, 272)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(124, 37)
        Me.BtnCari.TabIndex = 11
        Me.BtnCari.Text = "Cari Buku"
        Me.BtnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(12, 358)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(124, 37)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "Keluar"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnPeminjaman
        '
        Me.BtnPeminjaman.Image = CType(resources.GetObject("BtnPeminjaman.Image"), System.Drawing.Image)
        Me.BtnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeminjaman.Location = New System.Drawing.Point(464, 272)
        Me.BtnPeminjaman.Name = "BtnPeminjaman"
        Me.BtnPeminjaman.Size = New System.Drawing.Size(123, 37)
        Me.BtnPeminjaman.TabIndex = 13
        Me.BtnPeminjaman.Text = "Peminjaman"
        Me.BtnPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPeminjaman.UseVisualStyleBackColor = True
        '
        'BtnPengembalian
        '
        Me.BtnPengembalian.Image = CType(resources.GetObject("BtnPengembalian.Image"), System.Drawing.Image)
        Me.BtnPengembalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPengembalian.Location = New System.Drawing.Point(464, 315)
        Me.BtnPengembalian.Name = "BtnPengembalian"
        Me.BtnPengembalian.Size = New System.Drawing.Size(123, 37)
        Me.BtnPengembalian.TabIndex = 14
        Me.BtnPengembalian.Text = "Pengembalian"
        Me.BtnPengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPengembalian.UseVisualStyleBackColor = True
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(599, 407)
        Me.Controls.Add(Me.BtnPengembalian)
        Me.Controls.Add(Me.BtnPeminjaman)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.BtnRakKategori)
        Me.Controls.Add(Me.BtnPeminjam)
        Me.Controls.Add(Me.BtnBuku)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.Lbl12Jam)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FormMenuUtama"
        Me.Text = "FormHome"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbl12Jam As System.Windows.Forms.Label
    Friend WithEvents LblTanggal As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBuku As System.Windows.Forms.Button
    Friend WithEvents BtnPeminjam As System.Windows.Forms.Button
    Friend WithEvents BtnRakKategori As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnPeminjaman As System.Windows.Forms.Button
    Friend WithEvents BtnPengembalian As System.Windows.Forms.Button

End Class
