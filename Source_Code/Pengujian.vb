Imports System.Configuration
Imports System
Imports System.Data
Imports Npgsql
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Data.SqlClient

Public Class Pengujian
    Dim opf As New OpenFileDialog
    Dim spf As New SaveFileDialog
    Dim kecamatan As String
    Dim b2 As Bitmap
    Dim b3 As Bitmap
    Dim b4 As Bitmap
    Dim b5 As Bitmap
    Dim b6 As Bitmap
    Dim b7 As Bitmap
    Dim tanggal As Date
    Dim path_b2, path_b3, path_b4, path_b5, path_b6, path_b7 As String
    Dim pyLocation, workingDir As String
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
    Private Sub B6Btn_Click(sender As Object, e As EventArgs) Handles B6Btn.Click
        opf.Title = "Pick Image for B6 Test"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b6 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b6 = opf.FileName
            band6.Image = b6
            band6.SizeMode = PictureBoxSizeMode.Zoom
            band6.ImageLocation = opf.FileName
            TabControl1.SelectedIndex = 4
        End If
    End Sub

    Private Sub B3Btn_Click(sender As Object, e As EventArgs) Handles B3Btn.Click
        opf.Title = "Pick Image for B3 Test"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b3 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b3 = opf.FileName

            band3.Image = b3
            band3.SizeMode = PictureBoxSizeMode.Zoom
            band3.ImageLocation = opf.FileName
            TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub B4Btn_Click(sender As Object, e As EventArgs) Handles B4Btn.Click
        opf.Title = "Pick Image for B4 Test"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b4 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b4 = opf.FileName
            band4.Image = b4
            band4.SizeMode = PictureBoxSizeMode.Zoom
            band4.ImageLocation = opf.FileName
            TabControl1.SelectedIndex = 2
        End If
    End Sub

    Private Sub B5Btn_Click(sender As Object, e As EventArgs) Handles B5Btn.Click
        opf.Title = "Pick Image for B5 Test"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b5 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b5 = opf.FileName
            band5.Image = b5
            band5.SizeMode = PictureBoxSizeMode.Zoom
            band5.ImageLocation = opf.FileName
            TabControl1.SelectedIndex = 3
        End If
    End Sub

    Private Sub B7Btn_Click(sender As Object, e As EventArgs) Handles B7Btn.Click
        opf.Title = "Pick Image for B7 Test"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b7 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b7 = opf.FileName
            band7.Image = b7
            band7.SizeMode = PictureBoxSizeMode.Zoom
            band7.ImageLocation = opf.FileName
            path_b7 = band7.ImageLocation
            TabControl1.SelectedIndex = 5
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Dim id As Integer
        Dim alert As DialogResult

        If DataGridView1.RowCount = 1 Then
            MsgBox("Data kosong!", MsgBoxStyle.Information, "Hapus Data")
        Else
            If DataGridView1.SelectedCells.Count < 2 Then
                MsgBox("Pilih data yang ingin dihapus!", MsgBoxStyle.Information, "Hapus Data")
            Else
                id = DataGridView1.SelectedCells(0).Value

                alert = MessageBox.Show("Yakin ingin menghapus?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If alert = DialogResult.OK Then
                    Call DoConnect()
                    Dim commandGet As New NpgsqlCommand("DELETE FROM pengujian WHERE id_test='" & id & "'", con)
                    commandGet.ExecuteNonQuery()


                    MsgBox("Data berhasil dihapus!", MsgBoxStyle.Exclamation, "Hapus Data")
                    DataGridView1.DataSource = Nothing
                    Dim adapter As New NpgsqlDataAdapter("SELECT id_test as ""id"", kecamatan as ""Kecamatan"", test_date AS ""Tanggal Citra"", b2 as ""Lokasi Citra B2"", b3 as ""Lokasi Citra B3"", b4 as ""Lokasi Citra B4"", b5 as ""Lokasi Citra B5"", b6 as ""Lokasi Citra B6"", b7 as ""Lokasi Citra B7"" FROM pengujian;", con)
                    con.Close()
                    Dim Table As New DataTable()
                    adapter.Fill(Table)
                    DataGridView1.DataSource = Table
                End If

            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Pengujian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New NpgsqlDataAdapter("SELECT id_test as ""id"", kecamatan as ""Kecamatan"", test_date AS ""Tanggal Citra"", b2 as ""Lokasi Citra B2"", b3 as ""Lokasi Citra B3"", b4 as ""Lokasi Citra B4"", b5 as ""Lokasi Citra B5"", b6 as ""Lokasi Citra B6"", b7 as ""Lokasi Citra B7"" FROM pengujian;", con)
        Dim Table As New DataTable()
        adapter.Fill(Table)
        DataGridView1.DataSource = Table

        Call DateInpCall()

    End Sub

    Private Sub TestBtn_Click(sender As Object, e As EventArgs) Handles TestBtn.Click
        Dim exist As Integer
        Dim id As Integer
        Dim kec, tgl As String
        Dim tgl1 As Date
        If DataGridView1.RowCount = 1 Then
            MsgBox("Data kosong!", MsgBoxStyle.Information, "Klasifikasi Data")
        Else
            If DataGridView1.SelectedCells.Count < 2 Then
                MsgBox("Pilih data yang ingin diklasifikasikan!", MsgBoxStyle.Information, "Klasifikasi Data")
            Else
                id = DataGridView1.SelectedCells(0).Value
                kec = DataGridView1.SelectedCells(1).Value
                tgl1 = DataGridView1.SelectedCells(2).Value

                tgl = Format(tgl1, "yyyy-MM-dd")
                Call DoConnect()
                Dim commandGet As New NpgsqlCommand("SELECT COUNT(*)AS Row_Count FROM pengujian WHERE test_date='" & tgl & "' AND kecamatan='" & kec & "'", con)
                exist = commandGet.ExecuteScalar()
                con.Close()
                Dim py As New Process()
                pyLocation = Home.pyLoc
                workingDir = Home.pwdLoc
                py.StartInfo.FileName = Home.pyLoc
                py.StartInfo.WorkingDirectory = (Home.pwdLoc)
                py.StartInfo.Arguments = ("Testing.py " & Chr(34) & kec & Chr(34) & "," & tgl & "," & Chr(34) & workingDir & Chr(34))
                py.Start()
                py.WaitForExit()

                MsgBox("Data berhasil diklasifikasi!", MsgBoxStyle.Exclamation, "Klasifikasi Data")
            End If
        End If
        Hasil.Show()
        Me.Hide()
    End Sub

    Private Sub B2Btn_Click(sender As Object, e As EventArgs) Handles B2Btn.Click
        opf.Title = "Pick Image for B2 Test"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b2 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b2 = opf.FileName
            band2.Image = b2
            band2.SizeMode = PictureBoxSizeMode.Zoom
            band2.ImageLocation = opf.FileName
            TabControl1.SelectedIndex = 0
        End If
    End Sub

    Dim Value As String
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Home.Show()
        Me.Hide()
    End Sub


    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim exist As Integer

        If path_b2 = "" Then
            MsgBox("Citra Band 2 belum diinput", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        ElseIf path_b3 = "" Then
            MsgBox("Citra Band 3 belum diinput", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        ElseIf path_b4 = "" Then
            MsgBox("Citra Band 4 belum diinput", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        ElseIf path_b5 = "" Then
            MsgBox("Citra Band 5 belum diinput", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        ElseIf path_b6 = "" Then
            MsgBox("Citra Band 6 belum diinput", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        ElseIf path_b7 = "" Then
            MsgBox("Citra Band 7 belum diinput", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        ElseIf LandInp.SelectedItem = "" Then
            MsgBox("Jenis lahan belum dipilih", MsgBoxStyle.Exclamation, "Input Data")
            Exit Sub
        End If

        Dim h2, h3, h4, h5, h6, h7 As Integer
        Dim w2, w3, w4, w5, w6, w7 As Integer

        h2 = b2.Height
        h3 = b3.Height
        h4 = b4.Height
        h5 = b5.Height
        h6 = b6.Height
        h7 = b7.Height

        w2 = b2.Width
        w3 = b3.Width
        w4 = b4.Width
        w5 = b5.Width
        w6 = b6.Width
        w7 = b7.Width

        Call DoConnect()
        If (h2 = h3) And (h2 = h4) And (h2 = h5) And (h2 = h6) And (h2 = h7) And (w2 = w3) And (w2 = w4) And (w2 = w5) And (w2 = w6) And (w2 = w7) Then
            Dim commandSelected As New NpgsqlCommand("SELECT COUNT(*)AS Row_Count FROM pengujian WHERE test_date='" & DateInp.SelectedItem & "' AND kecamatan='" & LandInp.SelectedItem.ToString() & "'", con)
            exist = commandSelected.ExecuteScalar()

            If exist = 0 Then
                commandSelected = New NpgsqlCommand("INSERT INTO pengujian (kecamatan,test_date,b2,b3,b4,b5,b6,b7)" & "VALUES('" & LandInp.SelectedItem.ToString() & "', '" & DateInp.SelectedItem & "','" & path_b2 & "','" & path_b3 & "','" & path_b4 & "','" & path_b5 & "','" & path_b6 & "','" & path_b7 & "')", con)
                commandSelected.ExecuteNonQuery()
                MsgBox("Input data sukses!", MsgBoxStyle.Information, "Input Data")
                con.Close()

            Else
                MsgBox("Data sudah ada di database", MsgBoxStyle.Information, "Input Data")
                con.Close()
                Exit Sub
            End If
        Else
            MsgBox("Ukuran citra input berbeda", MsgBoxStyle.Exclamation, "Input Data")
            con.Close()
            Exit Sub
        End If

        Dim adapter As New NpgsqlDataAdapter("SELECT id_test as ""id"", kecamatan as ""Kecamatan"", test_date AS ""Tanggal Citra"", b2 as ""Lokasi Citra B2"", b3 as ""Lokasi Citra B3"", b4 as ""Lokasi Citra B4"", b5 as ""Lokasi Citra B5"", b6 as ""Lokasi Citra B6"", b7 as ""Lokasi Citra B7"" FROM pengujian;", con)
        Dim Table As New DataTable()
        adapter.Fill(Table)
        DataGridView1.DataSource = Table

        path_b2 = ""
        path_b3 = ""
        path_b4 = ""
        path_b5 = ""
        path_b6 = ""
        path_b7 = ""
        band2.Image = Nothing
        band3.Image = Nothing
        band4.Image = Nothing
        band5.Image = Nothing
        band6.Image = Nothing
        band7.Image = Nothing
    End Sub
End Class