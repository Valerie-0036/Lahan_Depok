<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manual))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.PelatihanBtn = New System.Windows.Forms.Button()
        Me.PengujianBtn = New System.Windows.Forms.Button()
        Me.HasilBtn = New System.Windows.Forms.Button()
        Me.KomparasiBtn = New System.Windows.Forms.Button()
        Me.PerubahanBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.TextDisplay = New System.Windows.Forms.Label()
        Me.CuttingBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackBtn.Image = CType(resources.GetObject("BackBtn.Image"), System.Drawing.Image)
        Me.BackBtn.Location = New System.Drawing.Point(-1, -4)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(124, 83)
        Me.BackBtn.TabIndex = 33
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'PelatihanBtn
        '
        Me.PelatihanBtn.BackColor = System.Drawing.Color.FloralWhite
        Me.PelatihanBtn.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PelatihanBtn.Location = New System.Drawing.Point(70, 228)
        Me.PelatihanBtn.Name = "PelatihanBtn"
        Me.PelatihanBtn.Size = New System.Drawing.Size(299, 71)
        Me.PelatihanBtn.TabIndex = 34
        Me.PelatihanBtn.Text = "Pelatihan"
        Me.PelatihanBtn.UseVisualStyleBackColor = False
        '
        'PengujianBtn
        '
        Me.PengujianBtn.BackColor = System.Drawing.Color.DarkGray
        Me.PengujianBtn.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PengujianBtn.Location = New System.Drawing.Point(70, 346)
        Me.PengujianBtn.Name = "PengujianBtn"
        Me.PengujianBtn.Size = New System.Drawing.Size(299, 71)
        Me.PengujianBtn.TabIndex = 35
        Me.PengujianBtn.Text = "Pengujian"
        Me.PengujianBtn.UseVisualStyleBackColor = False
        '
        'HasilBtn
        '
        Me.HasilBtn.BackColor = System.Drawing.Color.DarkGray
        Me.HasilBtn.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HasilBtn.Location = New System.Drawing.Point(70, 453)
        Me.HasilBtn.Name = "HasilBtn"
        Me.HasilBtn.Size = New System.Drawing.Size(299, 71)
        Me.HasilBtn.TabIndex = 36
        Me.HasilBtn.Text = "Hasil"
        Me.HasilBtn.UseVisualStyleBackColor = False
        '
        'KomparasiBtn
        '
        Me.KomparasiBtn.BackColor = System.Drawing.Color.DarkGray
        Me.KomparasiBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KomparasiBtn.Location = New System.Drawing.Point(70, 560)
        Me.KomparasiBtn.Name = "KomparasiBtn"
        Me.KomparasiBtn.Size = New System.Drawing.Size(299, 71)
        Me.KomparasiBtn.TabIndex = 37
        Me.KomparasiBtn.Text = "Tampilan Hasil Komparasi"
        Me.KomparasiBtn.UseVisualStyleBackColor = False
        '
        'PerubahanBtn
        '
        Me.PerubahanBtn.BackColor = System.Drawing.Color.DarkGray
        Me.PerubahanBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerubahanBtn.Location = New System.Drawing.Point(70, 667)
        Me.PerubahanBtn.Name = "PerubahanBtn"
        Me.PerubahanBtn.Size = New System.Drawing.Size(299, 71)
        Me.PerubahanBtn.TabIndex = 38
        Me.PerubahanBtn.Text = "Perubahan Periodik"
        Me.PerubahanBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(60, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 70)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "User Manual"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel1.Controls.Add(Me.TitleLbl)
        Me.Panel1.Controls.Add(Me.TextDisplay)
        Me.Panel1.Location = New System.Drawing.Point(430, -13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 900)
        Me.Panel1.TabIndex = 40
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.White
        Me.TitleLbl.Location = New System.Drawing.Point(45, 33)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(199, 54)
        Me.TitleLbl.TabIndex = 41
        Me.TitleLbl.Text = "Pelatihan"
        '
        'TextDisplay
        '
        Me.TextDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDisplay.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TextDisplay.Location = New System.Drawing.Point(40, 97)
        Me.TextDisplay.Name = "TextDisplay"
        Me.TextDisplay.Size = New System.Drawing.Size(872, 745)
        Me.TextDisplay.TabIndex = 67
        Me.TextDisplay.Text = resources.GetString("TextDisplay.Text")
        '
        'CuttingBtn
        '
        Me.CuttingBtn.BackColor = System.Drawing.Color.DarkGray
        Me.CuttingBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuttingBtn.Location = New System.Drawing.Point(70, 774)
        Me.CuttingBtn.Name = "CuttingBtn"
        Me.CuttingBtn.Size = New System.Drawing.Size(299, 71)
        Me.CuttingBtn.TabIndex = 41
        Me.CuttingBtn.Text = "Pemotongan Citra"
        Me.CuttingBtn.UseVisualStyleBackColor = False
        '
        'Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1376, 863)
        Me.Controls.Add(Me.CuttingBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PerubahanBtn)
        Me.Controls.Add(Me.KomparasiBtn)
        Me.Controls.Add(Me.HasilBtn)
        Me.Controls.Add(Me.PengujianBtn)
        Me.Controls.Add(Me.PelatihanBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1398, 919)
        Me.MinimumSize = New System.Drawing.Size(1398, 919)
        Me.Name = "Manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents PelatihanBtn As Button
    Friend WithEvents PengujianBtn As Button
    Friend WithEvents HasilBtn As Button
    Friend WithEvents KomparasiBtn As Button
    Friend WithEvents PerubahanBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextDisplay As Label
    Friend WithEvents TitleLbl As Label
    Friend WithEvents CuttingBtn As Button
End Class
