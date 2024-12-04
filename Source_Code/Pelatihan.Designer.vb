<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pelatihan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pelatihan))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.LandInp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.B2Btn = New System.Windows.Forms.Button()
        Me.B5Btn = New System.Windows.Forms.Button()
        Me.B3Btn = New System.Windows.Forms.Button()
        Me.B6Btn = New System.Windows.Forms.Button()
        Me.B4Btn = New System.Windows.Forms.Button()
        Me.B7Btn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.TrainBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.F1Imp = New System.Windows.Forms.Label()
        Me.RecImp = New System.Windows.Forms.Label()
        Me.PreImp = New System.Windows.Forms.Label()
        Me.F1Hseb = New System.Windows.Forms.Label()
        Me.RecHseb = New System.Windows.Forms.Label()
        Me.PreHSeb = New System.Windows.Forms.Label()
        Me.F1Hij = New System.Windows.Forms.Label()
        Me.RecHij = New System.Windows.Forms.Label()
        Me.PreHij = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AkImp = New System.Windows.Forms.Label()
        Me.AwImp = New System.Windows.Forms.Label()
        Me.AkHSeb = New System.Windows.Forms.Label()
        Me.AwHSeb = New System.Windows.Forms.Label()
        Me.AkHij = New System.Windows.Forms.Label()
        Me.AwHij = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Akhir = New System.Windows.Forms.Label()
        Me.Awal = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateInp = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackBtn.Image = CType(resources.GetObject("BackBtn.Image"), System.Drawing.Image)
        Me.BackBtn.Location = New System.Drawing.Point(-1, 0)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(124, 83)
        Me.BackBtn.TabIndex = 1
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'LandInp
        '
        Me.LandInp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LandInp.DisplayMember = "Tipe Lahan"
        Me.LandInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LandInp.FormattingEnabled = True
        Me.LandInp.Items.AddRange(New Object() {"Hijau", "Hijau Sebagian", "Impervious"})
        Me.LandInp.Location = New System.Drawing.Point(129, 73)
        Me.LandInp.MaximumSize = New System.Drawing.Size(297, 0)
        Me.LandInp.Name = "LandInp"
        Me.LandInp.Size = New System.Drawing.Size(288, 44)
        Me.LandInp.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tanggal Citra Diambil:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 41)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jenis Lahan:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 308)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(827, 407)
        Me.DataGridView1.TabIndex = 6
        '
        'B2Btn
        '
        Me.B2Btn.BackColor = System.Drawing.Color.Blue
        Me.B2Btn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B2Btn.Location = New System.Drawing.Point(44, 126)
        Me.B2Btn.Name = "B2Btn"
        Me.B2Btn.Size = New System.Drawing.Size(231, 71)
        Me.B2Btn.TabIndex = 8
        Me.B2Btn.Text = "Blue - B2"
        Me.B2Btn.UseVisualStyleBackColor = False
        '
        'B5Btn
        '
        Me.B5Btn.BackColor = System.Drawing.Color.LightCoral
        Me.B5Btn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B5Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B5Btn.Location = New System.Drawing.Point(44, 216)
        Me.B5Btn.Name = "B5Btn"
        Me.B5Btn.Size = New System.Drawing.Size(231, 71)
        Me.B5Btn.TabIndex = 10
        Me.B5Btn.Text = "NIR - B5"
        Me.B5Btn.UseVisualStyleBackColor = False
        '
        'B3Btn
        '
        Me.B3Btn.BackColor = System.Drawing.Color.LimeGreen
        Me.B3Btn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B3Btn.Location = New System.Drawing.Point(306, 126)
        Me.B3Btn.Name = "B3Btn"
        Me.B3Btn.Size = New System.Drawing.Size(231, 71)
        Me.B3Btn.TabIndex = 11
        Me.B3Btn.Text = "Green - B3"
        Me.B3Btn.UseVisualStyleBackColor = False
        '
        'B6Btn
        '
        Me.B6Btn.BackColor = System.Drawing.Color.DarkOrange
        Me.B6Btn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B6Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B6Btn.Location = New System.Drawing.Point(306, 216)
        Me.B6Btn.Name = "B6Btn"
        Me.B6Btn.Size = New System.Drawing.Size(231, 71)
        Me.B6Btn.TabIndex = 12
        Me.B6Btn.Text = "SWIR 1 - B6"
        Me.B6Btn.UseVisualStyleBackColor = False
        '
        'B4Btn
        '
        Me.B4Btn.BackColor = System.Drawing.Color.Crimson
        Me.B4Btn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B4Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B4Btn.Location = New System.Drawing.Point(567, 126)
        Me.B4Btn.Name = "B4Btn"
        Me.B4Btn.Size = New System.Drawing.Size(231, 71)
        Me.B4Btn.TabIndex = 13
        Me.B4Btn.Text = "Red - B4"
        Me.B4Btn.UseVisualStyleBackColor = False
        '
        'B7Btn
        '
        Me.B7Btn.BackColor = System.Drawing.Color.Olive
        Me.B7Btn.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B7Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B7Btn.Location = New System.Drawing.Point(567, 216)
        Me.B7Btn.Name = "B7Btn"
        Me.B7Btn.Size = New System.Drawing.Size(231, 71)
        Me.B7Btn.TabIndex = 14
        Me.B7Btn.Text = "SWIR 2 - B7"
        Me.B7Btn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.LawnGreen
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Location = New System.Drawing.Point(44, 759)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(231, 71)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Simpan"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'DelBtn
        '
        Me.DelBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DelBtn.Location = New System.Drawing.Point(306, 759)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(231, 71)
        Me.DelBtn.TabIndex = 16
        Me.DelBtn.Text = "Hapus"
        Me.DelBtn.UseVisualStyleBackColor = False
        '
        'TrainBtn
        '
        Me.TrainBtn.BackColor = System.Drawing.Color.Green
        Me.TrainBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TrainBtn.Location = New System.Drawing.Point(1020, 742)
        Me.TrainBtn.Name = "TrainBtn"
        Me.TrainBtn.Size = New System.Drawing.Size(231, 71)
        Me.TrainBtn.TabIndex = 17
        Me.TrainBtn.Text = "Latih"
        Me.TrainBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.F1Imp)
        Me.Panel1.Controls.Add(Me.RecImp)
        Me.Panel1.Controls.Add(Me.PreImp)
        Me.Panel1.Controls.Add(Me.F1Hseb)
        Me.Panel1.Controls.Add(Me.RecHseb)
        Me.Panel1.Controls.Add(Me.PreHSeb)
        Me.Panel1.Controls.Add(Me.F1Hij)
        Me.Panel1.Controls.Add(Me.RecHij)
        Me.Panel1.Controls.Add(Me.PreHij)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(909, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 275)
        Me.Panel1.TabIndex = 18
        '
        'F1Imp
        '
        Me.F1Imp.AutoSize = True
        Me.F1Imp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1Imp.Location = New System.Drawing.Point(346, 228)
        Me.F1Imp.Name = "F1Imp"
        Me.F1Imp.Size = New System.Drawing.Size(67, 25)
        Me.F1Imp.TabIndex = 36
        Me.F1Imp.Text = "F1Imp"
        '
        'RecImp
        '
        Me.RecImp.AutoSize = True
        Me.RecImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecImp.Location = New System.Drawing.Point(246, 228)
        Me.RecImp.Name = "RecImp"
        Me.RecImp.Size = New System.Drawing.Size(78, 25)
        Me.RecImp.TabIndex = 35
        Me.RecImp.Text = "RecImp"
        '
        'PreImp
        '
        Me.PreImp.AutoSize = True
        Me.PreImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreImp.Location = New System.Drawing.Point(150, 228)
        Me.PreImp.Name = "PreImp"
        Me.PreImp.Size = New System.Drawing.Size(74, 25)
        Me.PreImp.TabIndex = 34
        Me.PreImp.Text = "PreImp"
        '
        'F1Hseb
        '
        Me.F1Hseb.AutoSize = True
        Me.F1Hseb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1Hseb.Location = New System.Drawing.Point(346, 165)
        Me.F1Hseb.Name = "F1Hseb"
        Me.F1Hseb.Size = New System.Drawing.Size(85, 25)
        Me.F1Hseb.TabIndex = 33
        Me.F1Hseb.Text = "F1HSeb"
        '
        'RecHseb
        '
        Me.RecHseb.AutoSize = True
        Me.RecHseb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecHseb.Location = New System.Drawing.Point(246, 165)
        Me.RecHseb.Name = "RecHseb"
        Me.RecHseb.Size = New System.Drawing.Size(96, 25)
        Me.RecHseb.TabIndex = 32
        Me.RecHseb.Text = "RecHSeb"
        '
        'PreHSeb
        '
        Me.PreHSeb.AutoSize = True
        Me.PreHSeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreHSeb.Location = New System.Drawing.Point(150, 165)
        Me.PreHSeb.Name = "PreHSeb"
        Me.PreHSeb.Size = New System.Drawing.Size(92, 25)
        Me.PreHSeb.TabIndex = 31
        Me.PreHSeb.Text = "PreHSeb"
        '
        'F1Hij
        '
        Me.F1Hij.AutoSize = True
        Me.F1Hij.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1Hij.Location = New System.Drawing.Point(351, 92)
        Me.F1Hij.Name = "F1Hij"
        Me.F1Hij.Size = New System.Drawing.Size(57, 25)
        Me.F1Hij.TabIndex = 30
        Me.F1Hij.Text = "F1Hij"
        '
        'RecHij
        '
        Me.RecHij.AutoSize = True
        Me.RecHij.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecHij.Location = New System.Drawing.Point(251, 92)
        Me.RecHij.Name = "RecHij"
        Me.RecHij.Size = New System.Drawing.Size(68, 25)
        Me.RecHij.TabIndex = 29
        Me.RecHij.Text = "RecHij"
        '
        'PreHij
        '
        Me.PreHij.AutoSize = True
        Me.PreHij.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreHij.Location = New System.Drawing.Point(155, 92)
        Me.PreHij.Name = "PreHij"
        Me.PreHij.Size = New System.Drawing.Size(64, 25)
        Me.PreHij.TabIndex = 28
        Me.PreHij.Text = "PreHij"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 67)
        Me.Panel2.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(332, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 28)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "F1-Score"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 28)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Recall"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 28)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Precision"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 28)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Tipe Lahan"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(909, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 208)
        Me.Panel3.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 28)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Hijau"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 28)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Impervious"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 28)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Sebagian"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 28)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Hijau"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(909, 480)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(125, 208)
        Me.Panel4.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 28)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Hijau"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 28)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Impervious"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 28)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Sebagian"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(33, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 28)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Hijau"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel5.Controls.Add(Me.AkImp)
        Me.Panel5.Controls.Add(Me.AwImp)
        Me.Panel5.Controls.Add(Me.AkHSeb)
        Me.Panel5.Controls.Add(Me.AwHSeb)
        Me.Panel5.Controls.Add(Me.AkHij)
        Me.Panel5.Controls.Add(Me.AwHij)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(909, 413)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(438, 275)
        Me.Panel5.TabIndex = 28
        '
        'AkImp
        '
        Me.AkImp.AutoSize = True
        Me.AkImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AkImp.Location = New System.Drawing.Point(294, 228)
        Me.AkImp.Name = "AkImp"
        Me.AkImp.Size = New System.Drawing.Size(68, 25)
        Me.AkImp.TabIndex = 35
        Me.AkImp.Text = "AkImp"
        '
        'AwImp
        '
        Me.AwImp.AutoSize = True
        Me.AwImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwImp.Location = New System.Drawing.Point(160, 228)
        Me.AwImp.Name = "AwImp"
        Me.AwImp.Size = New System.Drawing.Size(72, 25)
        Me.AwImp.TabIndex = 34
        Me.AwImp.Text = "AwImp"
        '
        'AkHSeb
        '
        Me.AkHSeb.AutoSize = True
        Me.AkHSeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AkHSeb.Location = New System.Drawing.Point(294, 165)
        Me.AkHSeb.Name = "AkHSeb"
        Me.AkHSeb.Size = New System.Drawing.Size(86, 25)
        Me.AkHSeb.TabIndex = 32
        Me.AkHSeb.Text = "AkHSeb"
        '
        'AwHSeb
        '
        Me.AwHSeb.AutoSize = True
        Me.AwHSeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwHSeb.Location = New System.Drawing.Point(160, 165)
        Me.AwHSeb.Name = "AwHSeb"
        Me.AwHSeb.Size = New System.Drawing.Size(90, 25)
        Me.AwHSeb.TabIndex = 31
        Me.AwHSeb.Text = "AwHSeb"
        '
        'AkHij
        '
        Me.AkHij.AutoSize = True
        Me.AkHij.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AkHij.Location = New System.Drawing.Point(299, 92)
        Me.AkHij.Name = "AkHij"
        Me.AkHij.Size = New System.Drawing.Size(58, 25)
        Me.AkHij.TabIndex = 29
        Me.AkHij.Text = "AkHij"
        '
        'AwHij
        '
        Me.AwHij.AutoSize = True
        Me.AwHij.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AwHij.Location = New System.Drawing.Point(165, 92)
        Me.AwHij.Name = "AwHij"
        Me.AwHij.Size = New System.Drawing.Size(62, 25)
        Me.AwHij.TabIndex = 28
        Me.AwHij.Text = "AwHij"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel6.Controls.Add(Me.Akhir)
        Me.Panel6.Controls.Add(Me.Awal)
        Me.Panel6.Controls.Add(Me.Label27)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(438, 67)
        Me.Panel6.TabIndex = 19
        '
        'Akhir
        '
        Me.Akhir.AutoSize = True
        Me.Akhir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Akhir.Location = New System.Drawing.Point(310, 24)
        Me.Akhir.Name = "Akhir"
        Me.Akhir.Size = New System.Drawing.Size(63, 28)
        Me.Akhir.TabIndex = 23
        Me.Akhir.Text = "Akhir"
        '
        'Awal
        '
        Me.Awal.AutoSize = True
        Me.Awal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Awal.Location = New System.Drawing.Point(169, 24)
        Me.Awal.Name = "Awal"
        Me.Awal.Size = New System.Drawing.Size(59, 28)
        Me.Awal.TabIndex = 22
        Me.Awal.Text = "Awal"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(115, 28)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Tipe Lahan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(905, 359)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(319, 41)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Setelah Deteksi Outlier"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(904, 323)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(372, 41)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Perbandingan Jumlah Data"
        '
        'DateInp
        '
        Me.DateInp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DateInp.DropDownHeight = 250
        Me.DateInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInp.FormattingEnabled = True
        Me.DateInp.IntegralHeight = False
        Me.DateInp.Location = New System.Drawing.Point(429, 73)
        Me.DateInp.MaximumSize = New System.Drawing.Size(350, 0)
        Me.DateInp.Name = "DateInp"
        Me.DateInp.Size = New System.Drawing.Size(300, 44)
        Me.DateInp.TabIndex = 32
        '
        'Pelatihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1376, 863)
        Me.Controls.Add(Me.DateInp)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TrainBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.B7Btn)
        Me.Controls.Add(Me.B4Btn)
        Me.Controls.Add(Me.B6Btn)
        Me.Controls.Add(Me.B3Btn)
        Me.Controls.Add(Me.B5Btn)
        Me.Controls.Add(Me.B2Btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LandInp)
        Me.Controls.Add(Me.BackBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1398, 919)
        Me.MinimumSize = New System.Drawing.Size(1398, 919)
        Me.Name = "Pelatihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pelatihan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents LandInp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents B2Btn As Button
    Friend WithEvents B5Btn As Button
    Friend WithEvents B3Btn As Button
    Friend WithEvents B6Btn As Button
    Friend WithEvents B4Btn As Button
    Friend WithEvents B7Btn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents TrainBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents F1Imp As Label
    Friend WithEvents RecImp As Label
    Friend WithEvents PreImp As Label
    Friend WithEvents F1Hseb As Label
    Friend WithEvents RecHseb As Label
    Friend WithEvents PreHSeb As Label
    Friend WithEvents F1Hij As Label
    Friend WithEvents RecHij As Label
    Friend WithEvents PreHij As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents AkImp As Label
    Friend WithEvents AwImp As Label
    Friend WithEvents AkHSeb As Label
    Friend WithEvents AwHSeb As Label
    Friend WithEvents AkHij As Label
    Friend WithEvents AwHij As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Akhir As Label
    Friend WithEvents Awal As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DateInp As ComboBox
End Class
