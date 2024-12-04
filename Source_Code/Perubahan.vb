Imports System.IO
Imports System.Reflection
Imports System.Security.Policy
Imports Npgsql

Public Class Perubahan
    Dim pyLocation, workingDir As String
    Dim intBtnExpand As Integer

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim exist1, exist2 As Integer
        Dim hij_imper, imper_hij, hs_hij, hs_imper, hij_hs, imper_hs, ttp, h1, hs1, i1 As Integer
        Dim kec, tanggal1, tanggal2, citra As String
        If (LandInp.SelectedItem = "" Or DateInpStart.SelectedItem = "" Or DateInpEnd.SelectedItem = "") Then
            MsgBox("Isi Kecamatan, Tanggal Awal, atau Tanggal Akhir!", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        End If
        tanggal1 = DateInpStart.SelectedItem

        tanggal2 = DateInpEnd.SelectedItem

        kec = LandInp.SelectedItem.ToString()


        Call DoConnect()
        Dim commandChange1 As New NpgsqlCommand("SELECT COUNT(*)AS Row_Count FROM hasil WHERE res_date='" & tanggal1 & "' AND kecamatan='" & kec & "'", con)
        exist1 = commandChange1.ExecuteScalar()

        Dim commandChange2 As New NpgsqlCommand("SELECT COUNT(*)AS Row_Count FROM hasil WHERE res_date='" & tanggal2 & "' AND kecamatan='" & kec & "'", con)
        exist2 = commandChange2.ExecuteScalar()


        If (exist1 * exist2) = 0 Then
            MsgBox("Data belum diklasifikasi! Lakukan klasifikasi data terlebih dahulu di modul Testing!", MsgBoxStyle.Information, "Hasil Klasifikasi Data")
            con.Close()
        Else

            Dim py As New Process()
            pyLocation = Home.pyLoc
            workingDir = Home.pwdLoc
            py.StartInfo.FileName = pyLocation
            py.StartInfo.WorkingDirectory = workingDir
            py.StartInfo.Arguments = ("Perubahan.py " & Chr(34) & kec & Chr(34) & "," & tanggal1 & "," & tanggal2 & "," & Chr(34) & workingDir & Chr(34))
            py.Start()
            py.WaitForExit()


            Dim commandCitra As New NpgsqlCommand("SELECT img_change FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)
            citra = commandCitra.ExecuteScalar()


            cit.Image = Image.FromFile(citra)
            cit.SizeMode = PictureBoxSizeMode.Zoom

            Dim commandCitraAwal As New NpgsqlCommand(" SELECT img_3pre FROM hasil WHERE res_date='" & tanggal1 & "' AND kecamatan='" & kec & "'", con)
            citra = commandCitraAwal.ExecuteScalar()
            citawal.Image = Image.FromFile(citra)
            citawal.SizeMode = PictureBoxSizeMode.Zoom

            Dim commandCitraAkhir As New NpgsqlCommand(" SELECT img_3pre FROM hasil WHERE res_date='" & tanggal2 & "' AND kecamatan='" & kec & "'", con)
            citra = commandCitraAkhir.ExecuteScalar()
            citakhir.Image = Image.FromFile(citra)
            citakhir.SizeMode = PictureBoxSizeMode.Zoom

            commandCitra = New NpgsqlCommand("SELECT hij_hijseb FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)
            hij_hs = Integer.Parse(commandCitra.ExecuteScalar())
            HijHijSeb.Text() = Integer.Parse(commandCitra.ExecuteScalar()).ToString("#,#")



            commandCitra = New NpgsqlCommand("SELECT hij_imper FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)
            hij_imper = Integer.Parse(commandCitra.ExecuteScalar())
            HijImp.Text() = Integer.Parse(commandCitra.ExecuteScalar()).ToString("#,#")




            commandCitra = New NpgsqlCommand("SELECT hijseb_hij FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)

            hs_hij = Integer.Parse(commandCitra.ExecuteScalar())
            HijSebHij.Text() = Integer.Parse(commandCitra.ExecuteScalar()).ToString("#,#")



            commandCitra = New NpgsqlCommand("SELECT hijseb_imper FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)

            hs_imper = Integer.Parse(commandCitra.ExecuteScalar())
            HijSebImp.Text() = Integer.Parse(commandCitra.ExecuteScalar()).ToString("#,#")




            commandCitra = New NpgsqlCommand("SELECT imper_hij FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)

            imper_hij = Integer.Parse(commandCitra.ExecuteScalar())
            ImpHij.Text() = Integer.Parse(commandCitra.ExecuteScalar()).ToString("#,#")



            commandCitra = New NpgsqlCommand("SELECT imper_hijseb FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)

            imper_hs = Integer.Parse(commandCitra.ExecuteScalar())
            ImpHijSeb.Text() = Integer.Parse(commandCitra.ExecuteScalar()).ToString("#,#")


            Hijau.Text() = (imper_hij + hs_hij).ToString("#,#")
            Impervious.Text() = (hij_imper + hs_imper).ToString("#,#")


            commandCitra = New NpgsqlCommand("SELECT no_change FROM perubahan_lahan WHERE start_date='" & tanggal1 & "' AND (kecamatan='" & kec & "' AND end_date='" & tanggal2 & "')", con)

            ttp = Integer.Parse(commandCitra.ExecuteScalar())
            Tetap.Text() = Integer.Parse(commandCitra.ExecuteScalar()).ToString("#,#")



            commandCitra = New NpgsqlCommand("SELECT l_hijau_3 FROM hasil WHERE res_date='" & tanggal1 & "' AND kecamatan='" & kec & "'", con)

            h1 = Integer.Parse(commandCitra.ExecuteScalar())



            commandCitra = New NpgsqlCommand("SELECT l_hijauseb_3 FROM hasil WHERE res_date='" & tanggal1 & "' AND kecamatan='" & kec & "'", con)

            hs1 = Integer.Parse(commandCitra.ExecuteScalar())

            commandCitra = New NpgsqlCommand("SELECT l_impervious_3 FROM hasil WHERE res_date='" & tanggal1 & "' AND kecamatan='" & kec & "'", con)

            i1 = Integer.Parse(commandCitra.ExecuteScalar())
            con.Close()
            Dim total As Integer = (ttp + hij_hs + hij_imper + hs_hij + hs_imper + imper_hij + imper_hs)
            ttpprs.Text() = "(" & (Math.Round((ttp / total) * 100, 2)).ToString() & "%" & ")"
            hhsprs.Text() = "(" & (Math.Round((hij_hs / total) * 100, 2)).ToString() & "%" & ")"
            hiprs.Text() = "(" & (Math.Round((hij_imper / total) * 100, 2)).ToString() & "%" & ")"
            hshprs.Text() = "(" & (Math.Round((hs_hij / total) * 100, 2)).ToString() & "%" & ")"
            hsiprs.Text() = "(" & (Math.Round((hs_imper / total) * 100, 2)).ToString() & "%" & ")"
            ihprs.Text() = "(" & (Math.Round((imper_hij / total) * 100, 2)).ToString() & "%" & ")"
            ihsprs.Text() = "(" & (Math.Round((imper_hs / total) * 100, 2)).ToString() & "%" & ")"
            hjprs.Text() = "(" & (Math.Round(((imper_hij + hs_hij) / total) * 100, 2)).ToString() & "%" & ")"
            impprs.Text() = "(" & (Math.Round(((hij_imper + hs_imper) / total) * 100, 2)).ToString() & "%" & ")"

        End If
    End Sub
    Sub DateInpCall()
        Call DoConnect()
        Dim commandGet As New NpgsqlCommand("SELECT Distinct img_date from metadata_file order by img_date", con)
        commandGet.ExecuteNonQuery()
        Dim myReader = commandGet.ExecuteReader
        Do While myReader.Read
            Dim myFormat = "yyyy-MM-dd"
            DateInpStart.Items.Add(Format(CDate(myReader.Item("img_date")), myFormat))
            DateInpEnd.Items.Add(Format(CDate(myReader.Item("img_date")), myFormat))
        Loop
        con.Close()
    End Sub

    Private Sub LandInp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LandInp.SelectedIndexChanged

    End Sub



    Private Sub DateStartInp_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateEndInp_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Expand_Click(sender As Object, e As EventArgs) Handles Expand.Click
        If (intBtnExpand = 0) Then
            GroupBox1.Size = New Size(625, 689)
            intBtnExpand = 1
            Expand.Text = "X"
        Else
            intBtnExpand = 0
            GroupBox1.Size = New Size(625, 60)
            Expand.Text = "V"
        End If
    End Sub

    Private Sub Tetap_Click(sender As Object, e As EventArgs) Handles Tetap.Click

    End Sub

    Private Sub ihprs_Click(sender As Object, e As EventArgs) Handles ihprs.Click

    End Sub

    Private Sub Perubahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DateInpCall()
        intBtnExpand = 0
    End Sub

End Class