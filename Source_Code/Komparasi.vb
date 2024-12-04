Imports Npgsql
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Komparasi
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim exist As Integer
        Dim kec, citra As String

        Dim hijauint, hijausebint, imperint As Integer
        If (LandInp.SelectedItem = "" Or DateInp.SelectedItem = "") Then
            MsgBox("Isi Kecamatan dan Tanggal!", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        End If
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

            citraPP.Image = Image.FromFile(citra)
            citraPP.SizeMode = PictureBoxSizeMode.Zoom

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_hijau_3 FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            hijauint = Integer.Parse(cmd.ExecuteScalar())
            PreHijau.Text() = hijauint.ToString("#,#")
            con.Close()

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_hijauseb_3 FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            hijausebint = Integer.Parse(cmd.ExecuteScalar())
            PreHSeb.Text() = hijausebint.ToString("#,#")
            con.Close()

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_impervious_3 FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            imperint = Integer.Parse(cmd.ExecuteScalar())
            PreImp.Text() = imperint.ToString("#,#")
            con.Close()


            'non prepreocessing'
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT img_classic FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            citra = cmd.ExecuteScalar()
            con.Close()

            citraClassic.Image = Image.FromFile(citra)
            citraClassic.SizeMode = PictureBoxSizeMode.Zoom

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_hijau_none FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            hijauint = Integer.Parse(cmd.ExecuteScalar())
            ClassicHijau.Text() = hijauint.ToString("#,#")
            con.Close()

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_hijauseb_none FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            hijausebint = Integer.Parse(cmd.ExecuteScalar())
            ClassicHSeb.Text() = hijausebint.ToString("#,#")
            con.Close()

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "SELECT l_impervious_none FROM hasil WHERE res_date='" & DateInp.SelectedItem & "' AND kecamatan='" & kec & "'"
            cmd.Connection = con
            con.Open()
            imperint = Integer.Parse(cmd.ExecuteScalar())
            ClassicImp.Text() = imperint.ToString("#,#")
            con.Close()

        End If
    End Sub

    Sub DateInpCall()
        Call DoConnect()
        Dim commandGet As New NpgsqlCommand("SELECT Distinct img_date from metadata_file order by img_date", con)
        commandGet.ExecuteNonQuery()
        Dim myReader = commandGet.ExecuteReader
        Do While myReader.Read
            Dim myFormat = "yyyy-MM-dd"
            DateInp.Items.Add(Format(CDate(myReader.Item("img_date")), myFormat))
        Loop
        con.Close()
    End Sub

    Private Sub Komparasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DateInpCall()
        ToolTip.SetToolTip(SaveBtn, "Membandingkan Citra Dengan 3 Tahap Pre-Processing dengan Klasik pada tanggal dan kecamatan yang sama.")
    End Sub

    Private Sub LandInp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LandInp.SelectedIndexChanged

    End Sub
End Class