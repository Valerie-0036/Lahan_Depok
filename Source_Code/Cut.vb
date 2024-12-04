Public Class Cut
    Dim opf As New OpenFileDialog
    Dim fbd As New FolderBrowserDialog
    Dim inputPath, shapefilePath, outputPath As String
    Dim pyLocation, workingDir As String
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub B2Btn_Click(sender As Object, e As EventArgs) Handles B2Btn.Click
        If fbd.ShowDialog = DialogResult.OK Then
            InputLabel.Text = fbd.SelectedPath
            inputPath = fbd.SelectedPath
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opf.Title = "Pick File for Shapefile"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Shapefile(*.shp;)|*.shp;"
        If opf.ShowDialog = DialogResult.OK Then
            ShapefileLabel.Text = opf.FileName
            shapefilePath = opf.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If fbd.ShowDialog = DialogResult.OK Then
            OutputLabel.Text = fbd.SelectedPath
            outputPath = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (inputPath = "" Or shapefilePath = "" Or outputPath = "") Then
            MsgBox("File atau Folder Belum Dipilih!", MsgBoxStyle.Exclamation, "Pemotongan Citra")
        Else
            Dim py As New Process()
            pyLocation = Home.pyLoc
            workingDir = Home.pwdLoc
            py.StartInfo.FileName = pyLocation
            py.StartInfo.WorkingDirectory = workingDir
            Dim argumentPy As String = Chr(34) & inputPath & "," & shapefilePath & "," & outputPath & Chr(34)
            py.StartInfo.Arguments = ("Cutting.py " & argumentPy)
            py.Start()
            py.WaitForExit()
            MsgBox("Citra berhasil dipotong!", MsgBoxStyle.Information, "Pemotongan Citra")

        End If


    End Sub
End Class