<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Komparasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Komparasi))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.citraPP = New System.Windows.Forms.PictureBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LandInp = New System.Windows.Forms.ComboBox()
        Me.citraClassic = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PreImp = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PreHSeb = New System.Windows.Forms.Label()
        Me.PreHijau = New System.Windows.Forms.Label()
        Me.ClassicHijau = New System.Windows.Forms.Label()
        Me.ClassicHSeb = New System.Windows.Forms.Label()
        Me.ClassicImp = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateInp = New System.Windows.Forms.ComboBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.citraPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.citraClassic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackBtn.Image = CType(resources.GetObject("BackBtn.Image"), System.Drawing.Image)
        Me.BackBtn.Location = New System.Drawing.Point(-4, -1)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(124, 83)
        Me.BackBtn.TabIndex = 33
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'citraPP
        '
        Me.citraPP.Location = New System.Drawing.Point(13, 152)
        Me.citraPP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.citraPP.Name = "citraPP"
        Me.citraPP.Size = New System.Drawing.Size(672, 578)
        Me.citraPP.TabIndex = 62
        Me.citraPP.TabStop = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.LawnGreen
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Location = New System.Drawing.Point(1104, 24)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(231, 71)
        Me.SaveBtn.TabIndex = 61
        Me.SaveBtn.Text = "Bandingkan"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 41)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Kecamatan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(627, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 41)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Tanggal Citra Diambil:"
        '
        'LandInp
        '
        Me.LandInp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LandInp.DisplayMember = "Kecamatan"
        Me.LandInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LandInp.FormattingEnabled = True
        Me.LandInp.Items.AddRange(New Object() {"Beji", "Bojongsari", "Cilodong", "Cimanggis", "Cinere", "Cipayung", "Limo", "Pancoran Mas", "Sawangan", "Sukmajaya", "Tapos"})
        Me.LandInp.Location = New System.Drawing.Point(198, 51)
        Me.LandInp.MaximumSize = New System.Drawing.Size(297, 0)
        Me.LandInp.Name = "LandInp"
        Me.LandInp.Size = New System.Drawing.Size(297, 44)
        Me.LandInp.TabIndex = 58
        '
        'citraClassic
        '
        Me.citraClassic.Location = New System.Drawing.Point(693, 152)
        Me.citraClassic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.citraClassic.Name = "citraClassic"
        Me.citraClassic.Size = New System.Drawing.Size(672, 578)
        Me.citraClassic.TabIndex = 63
        Me.citraClassic.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1030, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 41)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "QDA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(639, 41)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Koreksi Radiometrik, Deteksi Outlier, PCA, QDA"
        '
        'PreImp
        '
        Me.PreImp.AutoSize = True
        Me.PreImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreImp.Location = New System.Drawing.Point(532, 782)
        Me.PreImp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PreImp.Name = "PreImp"
        Me.PreImp.Size = New System.Drawing.Size(20, 22)
        Me.PreImp.TabIndex = 74
        Me.PreImp.Text = "0"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Location = New System.Drawing.Point(243, 761)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox3.TabIndex = 68
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Location = New System.Drawing.Point(464, 761)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(22, 761)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox4.TabIndex = 66
        Me.PictureBox4.TabStop = False
        '
        'PreHSeb
        '
        Me.PreHSeb.AutoSize = True
        Me.PreHSeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreHSeb.Location = New System.Drawing.Point(311, 782)
        Me.PreHSeb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PreHSeb.Name = "PreHSeb"
        Me.PreHSeb.Size = New System.Drawing.Size(20, 22)
        Me.PreHSeb.TabIndex = 75
        Me.PreHSeb.Text = "0"
        '
        'PreHijau
        '
        Me.PreHijau.AutoSize = True
        Me.PreHijau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreHijau.Location = New System.Drawing.Point(90, 782)
        Me.PreHijau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PreHijau.Name = "PreHijau"
        Me.PreHijau.Size = New System.Drawing.Size(20, 22)
        Me.PreHijau.TabIndex = 76
        Me.PreHijau.Text = "0"
        '
        'ClassicHijau
        '
        Me.ClassicHijau.AutoSize = True
        Me.ClassicHijau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicHijau.Location = New System.Drawing.Point(775, 782)
        Me.ClassicHijau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ClassicHijau.Name = "ClassicHijau"
        Me.ClassicHijau.Size = New System.Drawing.Size(20, 22)
        Me.ClassicHijau.TabIndex = 82
        Me.ClassicHijau.Text = "0"
        '
        'ClassicHSeb
        '
        Me.ClassicHSeb.AutoSize = True
        Me.ClassicHSeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicHSeb.Location = New System.Drawing.Point(996, 782)
        Me.ClassicHSeb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ClassicHSeb.Name = "ClassicHSeb"
        Me.ClassicHSeb.Size = New System.Drawing.Size(20, 22)
        Me.ClassicHSeb.TabIndex = 81
        Me.ClassicHSeb.Text = "0"
        '
        'ClassicImp
        '
        Me.ClassicImp.AutoSize = True
        Me.ClassicImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicImp.Location = New System.Drawing.Point(1217, 782)
        Me.ClassicImp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ClassicImp.Name = "ClassicImp"
        Me.ClassicImp.Size = New System.Drawing.Size(20, 22)
        Me.ClassicImp.TabIndex = 80
        Me.ClassicImp.Text = "0"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox5.Location = New System.Drawing.Point(928, 761)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox5.TabIndex = 79
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Red
        Me.PictureBox6.Location = New System.Drawing.Point(1149, 761)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox6.TabIndex = 78
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(707, 761)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox7.TabIndex = 77
        Me.PictureBox7.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(907, 764)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(20, 22)
        Me.Label26.TabIndex = 87
        Me.Label26.Text = "2"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(874, 780)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(24, 22)
        Me.Label27.TabIndex = 86
        Me.Label27.Text = "m"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1122, 764)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 22)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1095, 780)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 22)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "m"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1344, 764)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 22)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1320, 780)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 22)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "m"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(680, 764)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 22)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(652, 785)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 22)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "m"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(421, 782)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 22)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "m"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(443, 764)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 22)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(219, 764)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 22)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(198, 785)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 22)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "m"
        '
        'DateInp
        '
        Me.DateInp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DateInp.DropDownHeight = 250
        Me.DateInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInp.FormattingEnabled = True
        Me.DateInp.IntegralHeight = False
        Me.DateInp.Location = New System.Drawing.Point(626, 51)
        Me.DateInp.MaximumSize = New System.Drawing.Size(350, 0)
        Me.DateInp.Name = "DateInp"
        Me.DateInp.Size = New System.Drawing.Size(300, 44)
        Me.DateInp.TabIndex = 98
        '
        'Komparasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1376, 863)
        Me.Controls.Add(Me.DateInp)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.ClassicHijau)
        Me.Controls.Add(Me.ClassicHSeb)
        Me.Controls.Add(Me.ClassicImp)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PreHijau)
        Me.Controls.Add(Me.PreHSeb)
        Me.Controls.Add(Me.PreImp)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.citraClassic)
        Me.Controls.Add(Me.citraPP)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LandInp)
        Me.Controls.Add(Me.BackBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1398, 919)
        Me.MinimumSize = New System.Drawing.Size(1398, 919)
        Me.Name = "Komparasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Komparasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.citraPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.citraClassic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents citraPP As PictureBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LandInp As ComboBox
    Friend WithEvents citraClassic As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PreImp As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PreHSeb As Label
    Friend WithEvents PreHijau As Label
    Friend WithEvents ClassicHijau As Label
    Friend WithEvents ClassicHSeb As Label
    Friend WithEvents ClassicImp As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DateInp As ComboBox
    Friend WithEvents ToolTip As ToolTip
End Class
