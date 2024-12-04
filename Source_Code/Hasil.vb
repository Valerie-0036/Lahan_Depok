Imports System.Globalization
Imports System.Configuration
Imports System
Imports System.Data
Imports Npgsql
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Hasil
    Dim opf As New OpenFileDialog
    Dim spf As New SaveFileDialog
    Dim intBtnExpand As Integer
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub HijauSeb_Click(sender As Object, e As EventArgs) Handles HijauSeb.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Imper_Click(sender As Object, e As EventArgs) Handles Imper.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Hijau_Click(sender As Object, e As EventArgs) Handles Hijau.Click

    End Sub

    Private Sub DateInp_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim exist As Integer
        Dim kec, citra As String

        Dim hijauint, hijausebint, imperint As Integer

        kec = LandInp.SelectedItem.ToString()
        Call DoConnect()
        Dim query As String = "SELECT COUNT(*)AS Row_Count FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
        Dim commandGet As New NpgsqlCommand(query, con)
        exist = commandGet.ExecuteScalar()
        con.Close()
        If exist = 0 Then
            MsgBox("Data belum diklasifikasi! Lakukan klasifikasi data terlebih dahulu di modul Testing!", MsgBoxStyle.Information, "Hasil Klasifikasi Data")
        Else

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT img_3pre FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            citra = cmd.ExecuteScalar()
            con.Close()

            hasilPB.Image = Image.FromFile(citra)
            hasilPB.SizeMode = PictureBoxSizeMode.Zoom

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_hijau_3 FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            hijauint = Integer.Parse(cmd.ExecuteScalar())
            Hijau.Text() = hijauint.ToString("#,#")
            con.Close()

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_hijauseb_3 FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            hijausebint = Integer.Parse(cmd.ExecuteScalar())
            HijauSeb.Text() = hijausebint.ToString("#,#")
            con.Close()

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_impervious_3 FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            imperint = Integer.Parse(cmd.ExecuteScalar())
            Imper.Text() = imperint.ToString("#,#")
            con.Close()
            Dim luasall = hijauint + hijausebint + imperint
            hprs.Text() = "(" & (Math.Round(((hijauint / (luasall))) * 100, 2)).ToString() & "%" & ")"
            hsprs.Text() = "(" & (Math.Round(((hijausebint / (luasall))) * 100, 2)).ToString() & "%" & ")"
            impprs.Text() = "(" & (Math.Round(((imperint / (luasall))) * 100, 2)).ToString() & "%" & ")"
        End If
    End Sub

    Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click
        Dim exist As Integer
        Dim kec, citra As String

        kec = LandInp.SelectedItem.ToString()
        Call DoConnect()
        Dim commandGet As New NpgsqlCommand("SELECT COUNT(*)AS Row_Count FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'", con)
        exist = commandGet.ExecuteScalar()
        con.Close()

        If exist = 0 Then
            MsgBox("Data belum diklasifikasi! Lakukan klasifikasi data terlebih dahulu di modul Testing!", MsgBoxStyle.Information, "Hasil Klasifikasi Data")
        Else

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT img_3pre FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            citra = cmd.ExecuteScalar()
            con.Close()

            spf.Filter = "TIF Image|*.tif"
            spf.Title = "Save an Image File"
            spf.FilterIndex = 2
            spf.RestoreDirectory = True
            If spf.ShowDialog() = DialogResult.OK Then
                hasilPB.Image.Save(spf.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
            End If
        End If
    End Sub

    Sub DateInpCall()
        Call DoConnect()
        Dim commandGet As New NpgsqlCommand("SELECT img_date from metadata_file order by img_date", con)
        commandGet.ExecuteNonQuery()
        Dim myReader = commandGet.ExecuteReader
        Do While myReader.Read
            Dim myFormat = "yyyy-MM-dd"
            DateInp.Items.Add(Format(CDate(myReader.Item("img_date")), myFormat))
        Loop
        con.Close()
    End Sub

    Private Sub Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DateInpCall()
        LandInp.SelectedIndex = 0
        DateInp.SelectedIndex = 0
        intBtnExpand = 0
    End Sub

    Private Sub LandInp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LandInp.SelectedIndexChanged

    End Sub

    Private Sub DateInp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DateInp.SelectedIndexChanged

    End Sub

    Private Sub Expand_Click(sender As Object, e As EventArgs) Handles Expand.Click
        If (intBtnExpand = 0) Then
            GroupBox1.Size = New Size(587, 303)
            intBtnExpand = 1
            Expand.Text = "X"
        Else
            intBtnExpand = 0
            GroupBox1.Size = New Size(587, 40)
            Expand.Text = "V"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class