<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProsesPeminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProsesPeminjaman))
        Me.DGVPeminjaman = New System.Windows.Forms.DataGridView()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnTransaksi = New System.Windows.Forms.Button()
        Me.DGPeminjaman = New System.Windows.Forms.DataGridView()
        CType(Me.DGVPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPeminjaman
        '
        Me.DGVPeminjaman.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPeminjaman.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVPeminjaman.Location = New System.Drawing.Point(12, 48)
        Me.DGVPeminjaman.Name = "DGVPeminjaman"
        Me.DGVPeminjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPeminjaman.Size = New System.Drawing.Size(847, 397)
        Me.DGVPeminjaman.TabIndex = 6
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(767, 12)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(92, 30)
        Me.BtnKeluar.TabIndex = 34
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(166, 12)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(92, 30)
        Me.BtnEdit.TabIndex = 33
        Me.BtnEdit.Text = "Ubah"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(264, 12)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(92, 30)
        Me.BtnHapus.TabIndex = 32
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnTransaksi
        '
        Me.BtnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransaksi.Image = CType(resources.GetObject("BtnTransaksi.Image"), System.Drawing.Image)
        Me.BtnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTransaksi.Location = New System.Drawing.Point(12, 12)
        Me.BtnTransaksi.Name = "BtnTransaksi"
        Me.BtnTransaksi.Size = New System.Drawing.Size(148, 30)
        Me.BtnTransaksi.TabIndex = 35
        Me.BtnTransaksi.Text = "Transaksi Peminjaman"
        Me.BtnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTransaksi.UseVisualStyleBackColor = True
        '
        'DGPeminjaman
        '
        Me.DGPeminjaman.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPeminjaman.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGPeminjaman.Location = New System.Drawing.Point(12, 67)
        Me.DGPeminjaman.Name = "DGPeminjaman"
        Me.DGPeminjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPeminjaman.Size = New System.Drawing.Size(860, 350)
        Me.DGPeminjaman.TabIndex = 6
        '
        'FormProsesPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(871, 451)
        Me.Controls.Add(Me.BtnTransaksi)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.DGVPeminjaman)
        Me.Name = "FormProsesPeminjaman"
        Me.Text = "FormProsesPeminjaman"
        CType(Me.DGVPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVPeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnTransaksi As System.Windows.Forms.Button
    Friend WithEvents DGPeminjaman As System.Windows.Forms.DataGridView
End Class
