<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRak))
        Me.BtnUbahRak = New System.Windows.Forms.Button()
        Me.BtnHapusRak = New System.Windows.Forms.Button()
        Me.BtnSimpanRak = New System.Windows.Forms.Button()
        Me.DGVRak = New System.Windows.Forms.DataGridView()
        Me.LblRak = New System.Windows.Forms.Label()
        Me.TxtRak = New System.Windows.Forms.TextBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        CType(Me.DGVRak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUbahRak
        '
        Me.BtnUbahRak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahRak.Image = CType(resources.GetObject("BtnUbahRak.Image"), System.Drawing.Image)
        Me.BtnUbahRak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbahRak.Location = New System.Drawing.Point(347, 93)
        Me.BtnUbahRak.Name = "BtnUbahRak"
        Me.BtnUbahRak.Size = New System.Drawing.Size(71, 30)
        Me.BtnUbahRak.TabIndex = 25
        Me.BtnUbahRak.Text = "Ubah"
        Me.BtnUbahRak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbahRak.UseVisualStyleBackColor = True
        '
        'BtnHapusRak
        '
        Me.BtnHapusRak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusRak.Image = CType(resources.GetObject("BtnHapusRak.Image"), System.Drawing.Image)
        Me.BtnHapusRak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapusRak.Location = New System.Drawing.Point(347, 129)
        Me.BtnHapusRak.Name = "BtnHapusRak"
        Me.BtnHapusRak.Size = New System.Drawing.Size(71, 30)
        Me.BtnHapusRak.TabIndex = 24
        Me.BtnHapusRak.Text = "Hapus"
        Me.BtnHapusRak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapusRak.UseVisualStyleBackColor = True
        '
        'BtnSimpanRak
        '
        Me.BtnSimpanRak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanRak.Image = CType(resources.GetObject("BtnSimpanRak.Image"), System.Drawing.Image)
        Me.BtnSimpanRak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpanRak.Location = New System.Drawing.Point(347, 57)
        Me.BtnSimpanRak.Name = "BtnSimpanRak"
        Me.BtnSimpanRak.Size = New System.Drawing.Size(71, 30)
        Me.BtnSimpanRak.TabIndex = 23
        Me.BtnSimpanRak.Text = "Simpan"
        Me.BtnSimpanRak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpanRak.UseVisualStyleBackColor = True
        '
        'DGVRak
        '
        Me.DGVRak.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVRak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRak.Location = New System.Drawing.Point(12, 57)
        Me.DGVRak.Name = "DGVRak"
        Me.DGVRak.Size = New System.Drawing.Size(317, 331)
        Me.DGVRak.TabIndex = 22
        '
        'LblRak
        '
        Me.LblRak.AutoSize = True
        Me.LblRak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRak.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblRak.Location = New System.Drawing.Point(12, 23)
        Me.LblRak.Name = "LblRak"
        Me.LblRak.Size = New System.Drawing.Size(29, 15)
        Me.LblRak.TabIndex = 21
        Me.LblRak.Text = "Rak"
        '
        'TxtRak
        '
        Me.TxtRak.Location = New System.Drawing.Point(85, 20)
        Me.TxtRak.Name = "TxtRak"
        Me.TxtRak.Size = New System.Drawing.Size(244, 20)
        Me.TxtRak.TabIndex = 20
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(347, 358)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(71, 30)
        Me.BtnKeluar.TabIndex = 28
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'FormRak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(430, 413)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnUbahRak)
        Me.Controls.Add(Me.BtnHapusRak)
        Me.Controls.Add(Me.BtnSimpanRak)
        Me.Controls.Add(Me.DGVRak)
        Me.Controls.Add(Me.LblRak)
        Me.Controls.Add(Me.TxtRak)
        Me.Name = "FormRak"
        Me.Text = "FormRak"
        CType(Me.DGVRak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUbahRak As System.Windows.Forms.Button
    Friend WithEvents BtnHapusRak As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanRak As System.Windows.Forms.Button
    Friend WithEvents DGVRak As System.Windows.Forms.DataGridView
    Friend WithEvents LblRak As System.Windows.Forms.Label
    Friend WithEvents TxtRak As System.Windows.Forms.TextBox
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
