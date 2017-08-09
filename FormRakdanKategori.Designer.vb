<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRakdanKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRakdanKategori))
        Me.LblPilih = New System.Windows.Forms.Label()
        Me.BtnRak = New System.Windows.Forms.Button()
        Me.BtnKategori = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.PicBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPilih
        '
        Me.LblPilih.AutoSize = True
        Me.LblPilih.Font = New System.Drawing.Font("MS Outlook", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPilih.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPilih.Location = New System.Drawing.Point(32, 19)
        Me.LblPilih.Name = "LblPilih"
        Me.LblPilih.Size = New System.Drawing.Size(317, 21)
        Me.LblPilih.TabIndex = 0
        Me.LblPilih.Text = "Menambah Daftar Rak dan Kategori"
        '
        'BtnRak
        '
        Me.BtnRak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRak.Location = New System.Drawing.Point(119, 61)
        Me.BtnRak.Name = "BtnRak"
        Me.BtnRak.Size = New System.Drawing.Size(65, 33)
        Me.BtnRak.TabIndex = 2
        Me.BtnRak.Text = "Rak"
        Me.BtnRak.UseVisualStyleBackColor = True
        '
        'BtnKategori
        '
        Me.BtnKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKategori.Location = New System.Drawing.Point(190, 61)
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.Size = New System.Drawing.Size(63, 33)
        Me.BtnKategori.TabIndex = 3
        Me.BtnKategori.Text = "Kategori"
        Me.BtnKategori.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(151, 116)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 30)
        Me.BtnKeluar.TabIndex = 27
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'PicBox1
        '
        Me.PicBox1.Image = CType(resources.GetObject("PicBox1.Image"), System.Drawing.Image)
        Me.PicBox1.Location = New System.Drawing.Point(119, -48)
        Me.PicBox1.Name = "PicBox1"
        Me.PicBox1.Size = New System.Drawing.Size(388, 257)
        Me.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicBox1.TabIndex = 28
        Me.PicBox1.TabStop = False
        '
        'FormRakdanKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(379, 160)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnKategori)
        Me.Controls.Add(Me.BtnRak)
        Me.Controls.Add(Me.LblPilih)
        Me.Controls.Add(Me.PicBox1)
        Me.Name = "FormRakdanKategori"
        Me.Text = "RakdanKategori"
        CType(Me.PicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPilih As System.Windows.Forms.Label
    Friend WithEvents BtnRak As System.Windows.Forms.Button
    Friend WithEvents BtnKategori As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents PicBox1 As System.Windows.Forms.PictureBox
End Class
