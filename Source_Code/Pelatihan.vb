Imports System.Configuration
Imports System
Imports System.Data
Imports Npgsql
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Windows.Forms.AxHost

Public Class Pelatihan
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

    Dim Value As String


    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub B2Btn_Click(sender As Object, e As EventArgs) Handles B2Btn.Click
        opf.Title = "Pick Image for B2 Train"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b2 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b2 = opf.FileName
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
                    Dim commandGet As New NpgsqlCommand("DELETE FROM pelatihan WHERE id_train='" & id & "'", con)
                    commandGet.ExecuteNonQuery()

                    MsgBox("Data berhasil dihapus!", MsgBoxStyle.Exclamation, "Hapus Data")
                    DataGridView1.DataSource = Nothing
                    Dim adapter As New NpgsqlDataAdapter("SELECT id_train as ""id"", jenis as ""Kelas Lahan"", img_date as ""Tanggal Citra"", b2 as ""Lokasi Citra B2"", b3 as ""Lokasi Citra B3"", b4 as ""Lokasi Citra B4"", b5 as ""Lokasi Citra B5"", b6 as ""Lokasi Citra B6"", b7 as ""Lokasi Citra B7"" FROM pelatihan;", con)
                    con.Close()
                    Dim Table As New DataTable()
                    adapter.Fill(Table)
                    DataGridView1.DataSource = Table
                End If

            End If
        End If

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
        ElseIf DateInp.SelectedItem = "" Then
            MsgBox("Tanggal Citra belum dipilih", MsgBoxStyle.Exclamation, "Input Data")
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

            Dim commandSelected As New NpgsqlCommand("SELECT COUNT(*)AS Row_Count FROM pelatihan WHERE jenis='" & LandInp.SelectedItem.ToString() & "' AND (b2='" & path_b2 & "' OR b3='" & path_b3 & "' OR b4='" & path_b4 & "' OR b5='" & path_b5 & "' OR b6='" & path_b6 & "' OR b7='" & path_b7 & "')", con)
            exist = commandSelected.ExecuteScalar()

            If exist = 0 Then
                Dim commandInsert As New NpgsqlCommand("INSERT INTO pelatihan (jenis,img_date,b2,b3,b4,b5,b6,b7) VALUES('" & LandInp.SelectedItem.ToString() & "','" & DateInp.SelectedItem & "','" & path_b2 & "','" & path_b3 & "','" & path_b4 & "','" & path_b5 & "','" & path_b6 & "','" & path_b7 & "')", con)
                commandInsert.ExecuteNonQuery()
                MsgBox("Input data sukses!", MsgBoxStyle.Information, "Input Data Testing")
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

        Dim adapter As New NpgsqlDataAdapter("SELECT id_train as ""id"", jenis as ""Kelas Lahan"", img_date as ""Tanggal Citra"", b2 as ""Lokasi Citra B2"", b3 as ""Lokasi Citra B3"", b4 as ""Lokasi Citra B4"", b5 as ""Lokasi Citra B5"", b6 as ""Lokasi Citra B6"", b7 as ""Lokasi Citra B7"" FROM pelatihan;", con)
        Dim Table As New DataTable()
        adapter.Fill(Table)
        DataGridView1.DataSource = Table

        path_b2 = ""
        path_b3 = ""
        path_b4 = ""
        path_b5 = ""
        path_b6 = ""
        path_b7 = ""
    End Sub

    Private Sub B4Btn_Click(sender As Object, e As EventArgs) Handles B4Btn.Click
        opf.Title = "Pick Image for B4 Train"
        opf.RestoreDirectory = True

        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b4 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b4 = opf.FileName
        End If
    End Sub

    Private Sub B5Btn_Click(sender As Object, e As EventArgs) Handles B5Btn.Click
        opf.Title = "Pick Image for B5 Train"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b5 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b5 = opf.FileName
        End If
    End Sub

    Private Sub B6Btn_Click(sender As Object, e As EventArgs) Handles B6Btn.Click
        opf.Title = "Pick Image for B6 Train"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b6 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b6 = opf.FileName
        End If
    End Sub

    Private Sub B7Btn_Click(sender As Object, e As EventArgs) Handles B7Btn.Click
        opf.Title = "Pick Image for B7 Train"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b7 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b7 = opf.FileName
        End If
    End Sub

    Private Sub TrainBtn_Click(sender As Object, e As EventArgs) Handles TrainBtn.Click
        Dim exist As Integer
        Call DoConnect()
        Dim commandGet As New NpgsqlCommand("SELECT COUNT(*)AS Row_Count FROM pelatihan", con)
        exist = commandGet.ExecuteScalar()
        con.Close()



        If exist = 0 Then
            MsgBox("Belum ada data!", MsgBoxStyle.Exclamation, "Training")
        Else
            Dim py As New Process()
            pyLocation = Home.pyLoc
            workingDir = Home.pwdLoc
            py.StartInfo.FileName = pyLocation
            py.StartInfo.WorkingDirectory = workingDir
            py.StartInfo.Arguments = ("Training.py")
            py.Start()
            py.WaitForExit()
            Dim pathf1 As String = workingDir & "\train_nilaipreprocess.txt"
            Dim f1_p() As String = System.IO.File.ReadAllLines(pathf1)
            PreHij.Text() = f1_p(0)
            RecHij.Text() = f1_p(1)
            F1Hij.Text() = f1_p(2) & "%"
            AwHij.Text() = f1_p(9)
            AkHij.Text() = f1_p(12)

            PreHSeb.Text() = f1_p(3)
            RecHseb.Text() = f1_p(4)
            F1Hseb.Text() = f1_p(5) & "%"
            AwHSeb.Text() = f1_p(10)
            AkHSeb.Text() = f1_p(13)

            PreImp.Text() = f1_p(6)
            RecImp.Text() = f1_p(7)
            F1Imp.Text() = f1_p(8) & "%"
            AwImp.Text() = f1_p(11)
            AkImp.Text() = f1_p(14)

            MsgBox("Proses pelatihan telah selesai!", MsgBoxStyle.Information, "Training")


        End If
    End Sub

    Private Sub LandInp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LandInp.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateInp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DateInp.SelectedIndexChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DateInp_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub B3Btn_Click(sender As Object, e As EventArgs) Handles B3Btn.Click
        opf.Title = "Pick Image for B3 Train"
        opf.RestoreDirectory = True
        opf.Filter = "Choose Image(*.tif;)|*.tif;"
        If opf.ShowDialog = DialogResult.OK Then
            b3 = CType(Image.FromFile(opf.FileName), Bitmap)
            path_b3 = opf.FileName
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
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New NpgsqlDataAdapter("SELECT id_train as ""id"", jenis as ""Kelas Lahan"", img_date as ""Tanggal Citra"", b2 as ""Lokasi Citra B2"", b3 as ""Lokasi Citra B3"", b4 as ""Lokasi Citra B4"", b5 as ""Lokasi Citra B5"", b6 as ""Lokasi Citra B6"", b7 as ""Lokasi Citra B7"" FROM pelatihan;", con)
        Dim Table As New DataTable()
        adapter.Fill(Table)
        DataGridView1.DataSource = Table

        Call DateInpCall()

    End Sub
End Class