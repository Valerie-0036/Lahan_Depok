Imports System.IO

Public Class Home
    Dim opf As New OpenFileDialog
    Dim fbd As New FolderBrowserDialog
    Public pyLoc, pwdLoc As String
    Dim file As System.IO.StreamWriter
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PelatihanPgBtn.Click
        If String.IsNullOrEmpty(pyLoc) Or String.IsNullOrEmpty(pwdLoc) Then
            PelatihanPgBtn.Enabled = False
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        Else
            Pelatihan.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PengujianPgBtn_Click(sender As Object, e As EventArgs) Handles PengujianPgBtn.Click
        If String.IsNullOrEmpty(pyLoc) Or String.IsNullOrEmpty(pwdLoc) Then
            PengujianPgBtn.Enabled = False
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        Else
            Pengujian.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub HasilPgBtn_Click(sender As Object, e As EventArgs) Handles HasilPgBtn.Click
        If String.IsNullOrEmpty(pyLoc) Or String.IsNullOrEmpty(pwdLoc) Then
            HasilPgBtn.Enabled = False
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        Else
            Hasil.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub KomparasiPgBtn_Click(sender As Object, e As EventArgs) Handles KomparasiPgBtn.Click
        If String.IsNullOrEmpty(pyLoc) Or String.IsNullOrEmpty(pwdLoc) Then
            KomparasiPgBtn.Enabled = False
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        Else
            Komparasi.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub PeriodikPgBtn_Click(sender As Object, e As EventArgs) Handles PeriodikPgBtn.Click
        If String.IsNullOrEmpty(pyLoc) Or String.IsNullOrEmpty(pwdLoc) Then
            PeriodikPgBtn.Enabled = False
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        Else
            Perubahan.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub ManualHPgBtn_Click(sender As Object, e As EventArgs) Handles ManualHPgBtn.Click
        Manual.Show()
        Me.Hide()
    End Sub

    Private Sub TentangPgBtn_Click(sender As Object, e As EventArgs) Handles TentangPgBtn.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub PyBtn_Click(sender As Object, e As EventArgs) Handles PyBtn.Click
        'Dim parentPath As String = IO.Path.GetDirectoryName(My.Computer.FileSystem.CurrentDirectory)
        'Dim newPath As String = Directory.GetParent(parentPath).FullName
        'If My.Computer.FileSystem.ReadAllText(newPath).Length = 0 Then
        'MsgBox("File is empty, creating master account")
        'Else
        'MsgBox("Creating normal account")
        'End If
        opf.Title = "Pick File for Python .EXE"
        opf.RestoreDirectory = True
        opf.Filter = "Choose File(*.exe;)|*.exe;"
        If opf.ShowDialog = DialogResult.OK Then
            pyLoc = opf.FileName
        End If
        fbd.Description = "Pick Working Directory"
        If fbd.ShowDialog = DialogResult.OK Then
            pwdLoc = fbd.SelectedPath
        End If

        If (String.IsNullOrEmpty(pwdLoc) Or String.IsNullOrEmpty(pyLoc)) Then
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        Else
            If System.IO.File.Exists(pwdLoc & "\Training.py") And System.IO.File.Exists(pwdLoc & "\Testing.py") And System.IO.File.Exists(pwdLoc & "\Perubahan.py") And System.IO.File.Exists(pwdLoc & "\Cutting.py") Then
                PelatihanPgBtn.Enabled = True
                PengujianPgBtn.Enabled = True
                PeriodikPgBtn.Enabled = True
                HasilPgBtn.Enabled = True
                KomparasiPgBtn.Enabled = True
                CutPgBtn.Enabled = True
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\pyDir.txt", pyLoc, False)
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\pwdDir.txt", pwdLoc, False)
            Else
                MsgBox("Pastikan folder terdapat 4 file Python!", MsgBoxStyle.Exclamation, "Input Data")
                PelatihanPgBtn.Enabled = False
                PengujianPgBtn.Enabled = False
                PeriodikPgBtn.Enabled = False
                HasilPgBtn.Enabled = False
                KomparasiPgBtn.Enabled = False
                CutPgBtn.Enabled = False
            End If
        End If
        'file = My.Computer.FileSystem.OpenTextFileWriter(My.Computer.FileSystem.CurrentDirectory & "\locationSettings.txt", True)
        'file.WriteLine(pyLoc)
        'file.WriteLine(pwdLoc)
        'file.Close()
    End Sub

    Private Sub WDBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Application.StartupPath & "\pyDir.txt") And System.IO.File.Exists(Application.StartupPath & "\pwdDir.txt") Then
            Dim linePy As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\pyDir.txt")
            Dim lineDir As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\pwdDir.txt")
            pyLoc = linePy
            pwdLoc = lineDir
        Else
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        End If


    End Sub

    Private Sub CutPgBtn_Click(sender As Object, e As EventArgs) Handles CutPgBtn.Click
        If String.IsNullOrEmpty(pyLoc) Or String.IsNullOrEmpty(pwdLoc) Then
            CutPgBtn.Enabled = False
            MsgBox("Isi lokasi Python dan Working Directory pada settings!", MsgBoxStyle.Exclamation, "Input Data")
        Else
            Cut.Show()
            Me.Hide()
        End If

    End Sub
End Class
