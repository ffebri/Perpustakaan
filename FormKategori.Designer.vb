<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKategori))
        Me.BtnUbahKategori = New System.Windows.Forms.Button()
        Me.BtnHapusKategori = New System.Windows.Forms.Button()
        Me.BtnSimpanKategori = New System.Windows.Forms.Button()
        Me.DGVKategori = New System.Windows.Forms.DataGridView()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.TxtKategori = New System.Windows.Forms.TextBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        CType(Me.DGVKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUbahKategori
        '
        Me.BtnUbahKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahKategori.Image = CType(resources.GetObject("BtnUbahKategori.Image"), System.Drawing.Image)
        Me.BtnUbahKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbahKategori.Location = New System.Drawing.Point(347, 93)
        Me.BtnUbahKategori.Name = "BtnUbahKategori"
        Me.BtnUbahKategori.Size = New System.Drawing.Size(71, 30)
        Me.BtnUbahKategori.TabIndex = 33
        Me.BtnUbahKategori.Text = "Ubah"
        Me.BtnUbahKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbahKategori.UseVisualStyleBackColor = True
        '
        'BtnHapusKategori
        '
        Me.BtnHapusKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusKategori.Image = CType(resources.GetObject("BtnHapusKategori.Image"), System.Drawing.Image)
        Me.BtnHapusKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapusKategori.Location = New System.Drawing.Point(347, 129)
        Me.BtnHapusKategori.Name = "BtnHapusKategori"
        Me.BtnHapusKategori.Size = New System.Drawing.Size(71, 30)
        Me.BtnHapusKategori.TabIndex = 32
        Me.BtnHapusKategori.Text = "Hapus"
        Me.BtnHapusKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapusKategori.UseVisualStyleBackColor = True
        '
        'BtnSimpanKategori
        '
        Me.BtnSimpanKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanKategori.Image = CType(resources.GetObject("BtnSimpanKategori.Image"), System.Drawing.Image)
        Me.BtnSimpanKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpanKategori.Location = New System.Drawing.Point(347, 57)
        Me.BtnSimpanKategori.Name = "BtnSimpanKategori"
        Me.BtnSimpanKategori.Size = New System.Drawing.Size(71, 30)
        Me.BtnSimpanKategori.TabIndex = 31
        Me.BtnSimpanKategori.Text = "Simpan"
        Me.BtnSimpanKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpanKategori.UseVisualStyleBackColor = True
        '
        'DGVKategori
        '
        Me.DGVKategori.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKategori.Location = New System.Drawing.Point(12, 57)
        Me.DGVKategori.Name = "DGVKategori"
        Me.DGVKategori.Size = New System.Drawing.Size(317, 331)
        Me.DGVKategori.TabIndex = 30
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblKategori.Location = New System.Drawing.Point(12, 23)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblKategori.Size = New System.Drawing.Size(53, 15)
        Me.LblKategori.TabIndex = 29
        Me.LblKategori.Text = "Kategori"
        '
        'TxtKategori
        '
        Me.TxtKategori.Location = New System.Drawing.Point(85, 20)
        Me.TxtKategori.Name = "TxtKategori"
        Me.TxtKategori.Size = New System.Drawing.Size(244, 20)
        Me.TxtKategori.TabIndex = 28
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(347, 358)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 30)
        Me.BtnKeluar.TabIndex = 27
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(430, 413)
        Me.Controls.Add(Me.BtnUbahKategori)
        Me.Controls.Add(Me.BtnHapusKategori)
        Me.Controls.Add(Me.BtnSimpanKategori)
        Me.Controls.Add(Me.DGVKategori)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.TxtKategori)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Name = "FormKategori"
        Me.Text = "FormKategori"
        CType(Me.DGVKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUbahKategori As System.Windows.Forms.Button
    Friend WithEvents BtnHapusKategori As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanKategori As System.Windows.Forms.Button
    Friend WithEvents DGVKategori As System.Windows.Forms.DataGridView
    Friend WithEvents LblKategori As System.Windows.Forms.Label
    Friend WithEvents TxtKategori As System.Windows.Forms.TextBox
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
