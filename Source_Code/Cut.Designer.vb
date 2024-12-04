<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cut))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.B2Btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.ShapefileLabel = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackBtn.Image = CType(resources.GetObject("BackBtn.Image"), System.Drawing.Image)
        Me.BackBtn.Location = New System.Drawing.Point(-3, -3)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(124, 83)
        Me.BackBtn.TabIndex = 34
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'B2Btn
        '
        Me.B2Btn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.B2Btn.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.B2Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B2Btn.Location = New System.Drawing.Point(58, 89)
        Me.B2Btn.Name = "B2Btn"
        Me.B2Btn.Size = New System.Drawing.Size(231, 51)
        Me.B2Btn.TabIndex = 40
        Me.B2Btn.Text = "Pilih Folder"
        Me.B2Btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(51, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 54)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Folder Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 54)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "File Shapefile"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(60, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 53)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Pilih File"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(60, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 53)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Pilih Folder"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LimeGreen
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(58, 504)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 71)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Potong"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 54)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Folder Output"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(309, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 41)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Folder Terpilih:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(309, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 41)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Folder Terpilih:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(318, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 41)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "File Terpilih:"
        '
        'InputLabel
        '
        Me.InputLabel.AutoEllipsis = True
        Me.InputLabel.BackColor = System.Drawing.Color.Transparent
        Me.InputLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel.ForeColor = System.Drawing.Color.White
        Me.InputLabel.Location = New System.Drawing.Point(530, 99)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(674, 36)
        Me.InputLabel.TabIndex = 50
        Me.InputLabel.Text = "-"
        '
        'ShapefileLabel
        '
        Me.ShapefileLabel.AutoEllipsis = True
        Me.ShapefileLabel.BackColor = System.Drawing.Color.Transparent
        Me.ShapefileLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShapefileLabel.ForeColor = System.Drawing.Color.White
        Me.ShapefileLabel.Location = New System.Drawing.Point(530, 257)
        Me.ShapefileLabel.Name = "ShapefileLabel"
        Me.ShapefileLabel.Size = New System.Drawing.Size(674, 36)
        Me.ShapefileLabel.TabIndex = 51
        Me.ShapefileLabel.Text = "-"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoEllipsis = True
        Me.OutputLabel.BackColor = System.Drawing.Color.Transparent
        Me.OutputLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLabel.ForeColor = System.Drawing.Color.White
        Me.OutputLabel.Location = New System.Drawing.Point(546, 416)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(639, 36)
        Me.OutputLabel.TabIndex = 52
        Me.OutputLabel.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.OutputLabel)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.B2Btn)
        Me.Panel2.Controls.Add(Me.ShapefileLabel)
        Me.Panel2.Controls.Add(Me.InputLabel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(121, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1217, 716)
        Me.Panel2.TabIndex = 66
        '
        'Cut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1376, 863)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BackBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1398, 919)
        Me.MinimumSize = New System.Drawing.Size(1398, 919)
        Me.Name = "Cut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cut"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents B2Btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents InputLabel As Label
    Friend WithEvents ShapefileLabel As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents Panel2 As Panel
End Class
