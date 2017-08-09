<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCari))
        Me.TxtKodeBuku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnKode = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnJudul = New System.Windows.Forms.Button()
        Me.TxtJudulBuku = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtKodeBuku
        '
        Me.TxtKodeBuku.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKodeBuku.Location = New System.Drawing.Point(120, 24)
        Me.TxtKodeBuku.Name = "TxtKodeBuku"
        Me.TxtKodeBuku.Size = New System.Drawing.Size(151, 20)
        Me.TxtKodeBuku.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Kode Buku"
        '
        'BtnKode
        '
        Me.BtnKode.Image = CType(resources.GetObject("BtnKode.Image"), System.Drawing.Image)
        Me.BtnKode.Location = New System.Drawing.Point(299, 16)
        Me.BtnKode.Name = "BtnKode"
        Me.BtnKode.Size = New System.Drawing.Size(33, 33)
        Me.BtnKode.TabIndex = 57
        Me.BtnKode.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeluar.Location = New System.Drawing.Point(254, 147)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(92, 30)
        Me.BtnKeluar.TabIndex = 62
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnJudul
        '
        Me.BtnJudul.Image = CType(resources.GetObject("BtnJudul.Image"), System.Drawing.Image)
        Me.BtnJudul.Location = New System.Drawing.Point(299, 54)
        Me.BtnJudul.Name = "BtnJudul"
        Me.BtnJudul.Size = New System.Drawing.Size(33, 33)
        Me.BtnJudul.TabIndex = 65
        Me.BtnJudul.UseVisualStyleBackColor = True
        '
        'TxtJudulBuku
        '
        Me.TxtJudulBuku.BackColor = System.Drawing.SystemColors.Info
        Me.TxtJudulBuku.Location = New System.Drawing.Point(120, 62)
        Me.TxtJudulBuku.Name = "TxtJudulBuku"
        Me.TxtJudulBuku.Size = New System.Drawing.Size(151, 20)
        Me.TxtJudulBuku.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Judul Buku"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(120, 147)
        Me.TxtCari.Multiline = True
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(110, 30)
        Me.TxtCari.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Rak"
        '
        'FormCari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(369, 210)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnJudul)
        Me.Controls.Add(Me.TxtJudulBuku)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnKode)
        Me.Controls.Add(Me.TxtKodeBuku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCari)
        Me.Name = "FormCari"
        Me.Text = "FormCari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnKode As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnJudul As System.Windows.Forms.Button
    Friend WithEvents TxtJudulBuku As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
