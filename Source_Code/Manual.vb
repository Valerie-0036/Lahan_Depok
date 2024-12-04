Public Class Manual
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub PelatihanBtn_Click(sender As Object, e As EventArgs) Handles PelatihanBtn.Click
        TitleLbl.Text = "Pelatihan"
        PelatihanBtn.BackColor = Color.FloralWhite
        PengujianBtn.BackColor = Color.DarkGray
        HasilBtn.BackColor = Color.DarkGray
        KomparasiBtn.BackColor = Color.DarkGray
        PerubahanBtn.BackColor = Color.DarkGray
        CuttingBtn.BackColor = Color.DarkGray
        TextDisplay.Text = "Modul Pelatihan berfungsi sebagai tempat untuk memasukkan dan mengolah data pelatihan yang akan digunakan dalam algoritma Quadratic Discriminant Analysis (QDA). Data pelatihan yang telah melalui tiga tahap pra-pemrosesan akan digunakan untuk membangun model klasifikasi yang optimal. Input pada modul ini berupa hasil potongan lahan hijau, hijau sebagian, dan impervious dari saluran 2 hingga 7. Akan ditampilkan hasil precision, recall, dan F1-Score dari data latih serta jumlah data yang digunakan dari tiap kelas setelah dilakukan deteksi outlier.
Menambahkan Data
1.Klik tombol 'Pelatihan' untuk berpindah ke modul pelatihan.
2.Terdapat tombol ‘Blue - B2’, ‘Green – B3’, ‘Red – B4’, ‘NIR – B5’, ‘SWIR 1 – B6’, dan ‘SWIR 2 – B7’. Klik tombol band yang akan diupload.
3.Pada kolom ‘Jenis Lahan’ pilih kelas lahan dari citra latihan. Pada kolom ‘Tanggal Citra Diambil’ pilih tanggal citra tersebut diambil. 
4.Setelah itu klik tombol ‘Simpan’ agar citra tersimpan dalam database.
 
Menghapus Data
1.Pada tabel ‘Data Training’, pilih baris data yang ingin dihapus dengan mengklik kolom kosong pertama di sebelah kiri baris data yang akan dihapus.
2.Kemudian klik tombol ‘Hapus’. Akan muncul konfirmasi dan klik ‘Ok’.
 
Melatih Data
1.Bila dirasa data latih yang diupload sudah cukup, klik ‘Latih’ di pojok kanan bawah.
2.Akan muncul window terminal untuk membangun model. Tunggu sampai proses selesai.
3.Setelah selesai, akan muncul pop-up message. Klik ‘OK’.
4.Nilai Precision, Recall, F1 model yang dibangun dari tiap kelas lahan  akan tampil di tabel di kanan atas. Sedangkan akan ditampilan jumlah piksel sebelum deteksi outlier dan setelah deteksi outlier tiap kelas lahan pada tabel ‘Perbandingan Jumlah Data Setelah Deteksi Outlier’ di kanan bawah.
"
    End Sub

    Private Sub PengujianBtn_Click(sender As Object, e As EventArgs) Handles PengujianBtn.Click
        TitleLbl.Text = "Pengujian"
        PelatihanBtn.BackColor = Color.DarkGray
        PengujianBtn.BackColor = Color.FloralWhite
        HasilBtn.BackColor = Color.DarkGray
        KomparasiBtn.BackColor = Color.DarkGray
        PerubahanBtn.BackColor = Color.DarkGray
        CuttingBtn.BackColor = Color.DarkGray
        TextDisplay.Text = "Modul Pengujian, berfungsi untuk menggunakan model klasifikasi yang telah dibangun pada Modul Pelatihan. Data uji yang dimasukkan akan diklasifikasikan tiap pikselnya ke dalam salah satu kelas yang telah ditentukan sebelumnya, yaitu kelas hijau, hijau sebagian, atau impervious, berdasarkan aturan yang telah dipelajari oleh model. Input pada modul ini berupa hasil potongan kecamatan dan tanggal citra tersebut diambil.
Menambahkan Data
1.Klik tombol 'Pengujian' untuk berpindah ke modul pengujian.
2.Terdapat tombol 'Blue - B2', 'Green – B3', 'Red – B4', 'NIR – B5', 'SWIR 1 – B6', dan 'SWIR 2 – B7'. Klik tombol band yang akan diupload.
3.Pada kolom 'Kecamatan' pilih kelas lahan dari citra yang akan dipetakan. Pada kolom 'Tanggal Citra Diambil' pilih tanggal citra tersebut diambil. 
4.Setelah itu klik tombol 'Simpan' agar citra tersimpan dalam database.

Menghapus Data
1.Pada tabel 'Data Testing, pilih baris data yang ingin dihapus dengan mengklik kolom kosong pertama di sebelah kiri baris data yang akan dihapus. 
2.Kemudian klik tombol 'Hapus'. Akan muncul konfirmasi dan klik 'Ok'.

Menguji Data
1.Pada tabel 'Data Testing' di sisi kanan, pilih data yang ingin diuji dengan mengklik kolom kosong pertama di sebelah kiri baris data yang akan dipetakan. 
2.Kemudian klik tombol 'Hasil Uji.
3.Akan muncul window terminal. Proses klasifikasi dan pemetaan sedang berlangsung tunggu sampai selesai.
4.Akan muncul pop-up message. Klik 'OK'.
5.Data yang sudah diuji akan bisa dilihat pada modul hasil.
"

    End Sub

    Private Sub HasilBtn_Click(sender As Object, e As EventArgs) Handles HasilBtn.Click
        TitleLbl.Text = "Hasil"
        PelatihanBtn.BackColor = Color.DarkGray
        PengujianBtn.BackColor = Color.DarkGray
        HasilBtn.BackColor = Color.FloralWhite
        KomparasiBtn.BackColor = Color.DarkGray
        PerubahanBtn.BackColor = Color.DarkGray
        CuttingBtn.BackColor = Color.DarkGray

        TextDisplay.Text = "Modul Hasil menyajikan visualisasi dari hasil klasifikasi yang diperoleh setelah proses pelatihan dan pengujian model. Modul ini menampilkan citra hasil klasifikasi yang telah melalui tiga tahap pra-pemrosesan menggunakan algoritma Quadratic Discriminant Analysis. Ditampilkan juga luas lahan yang terklasifikasi menjadi kelas hijau, hijau sebagian, dan impervious. Citra hasil klasifikasi dapat diunduh ke lokasi yang dipilih.
1.Klik 'Hasil' untuk menuju ke modul hasil.
2.Pilih tanggal dan kecamatan yang ingin dilihat pada 'Kecamatan' dan 'Tanggal Citra Diambil', lalu klik 'Lihat.
3.Citra hasil klasifikasi akan muncul di sisi kiri window. Angka 0 pada kotak Luas Tiap Kelas akan berubah sesuai luas tiap tipe lahannya. Angka 2 pada kotak Luas Tiap Kelas akan berubah sesuai persentase kelas tersebut terhadap keseluruhan lahan.
4.Klik tombol 'V' pada Luas Tiap Kelas untuk melihat rincian luas lahan.
5.Citra hasil klasifikasi dapat diunduh ke folder tertentu dengan klik tombol 'Unduh'
"
    End Sub

    Private Sub KomparasiBtn_Click(sender As Object, e As EventArgs) Handles KomparasiBtn.Click
        TitleLbl.Text = "Tampilan Hasil Komparasi"
        PelatihanBtn.BackColor = Color.DarkGray
        PengujianBtn.BackColor = Color.DarkGray
        HasilBtn.BackColor = Color.DarkGray
        KomparasiBtn.BackColor = Color.FloralWhite
        PerubahanBtn.BackColor = Color.DarkGray
        CuttingBtn.BackColor = Color.DarkGray
        TextDisplay.Text = "Modul Tampilan Hasil Komparasi digunakan untuk membandingkan kinerja model klasifikasi dengan dan tanpa penerapan tiga tahap pra-pemrosesan. Modul ini menyajikan visualisasi perbandingan hasil klasifikasi masing-masing kelas. Luas lahan hijau, hijau sebagian, dan impervious metode klasik dan 3 tahap pra-pemrosesan diperlihatkan.
1.Klik 'Tampilan Hasil Komparasi' untuk menuju ke modul perbandingan hasil.
2.Pilih tanggal dan kecamatan yang ingin dilihat pada 'Kecamatan' dan 'Tanggal Citra Diambil', lalu klik 'Bandingkan'.
3.Kedua citra hasil klasifikasi akan muncul.. Angka 0 pada kotak akan berubah sesuai luas tiap tipe lahannya
"
    End Sub

    Private Sub PerubahanBtn_Click(sender As Object, e As EventArgs) Handles PerubahanBtn.Click
        TitleLbl.Text = "Perubahan Periodik"
        PelatihanBtn.BackColor = Color.DarkGray
        PengujianBtn.BackColor = Color.DarkGray
        HasilBtn.BackColor = Color.DarkGray
        KomparasiBtn.BackColor = Color.DarkGray
        PerubahanBtn.BackColor = Color.FloralWhite
        CuttingBtn.BackColor = Color.DarkGray
        TextDisplay.Text = "Modul Perubahan Periodik digunakan untuk menganalisis perubahan tutupan lahan dalam rentang waktu tertentu. Modul ini memperlihatkan luas lahan yang tidak berubah, luas lahan hijau ke hijau sebagian, luas lahan hijau ke impervious, luas lahan hijau sebagian ke hijau, luas lahan hijau sebagian ke impervious, luas lahan impervious ke hijau, dan luas lahan impervious ke hijau sebagian.
1.Klik 'Perubahan Periodik' untuk menuju ke modul perubahan periodik.
2.Pilih tanggal awal, akhir, dan kecamatan yang ingin dilihat pada 'Tanggal Citra Awal', 'Tanggal Citra Akhir', dan 'Kecamatan'. Lalu klik 'Lihat'.
3.Akan muncul window terminal untuk menghitung perubahan luas tiap tipe lahan. Tunggu sampai selesai..
4.Klik Tab 'Tanggal Awal' untuk melihat hasil citra tanggal awal, 'Tanggal Akhir' untuk melihat hasil citra tanggal akhir, dan Tab 'Hasil Perubahan' untuk melihat citra hasil perubahan lahan.
5.Klik tombol 'V' pada Hasil Perubahan untuk melihat rincian perubahan luas lahan. Angka 0 pada kotak Hasil Perubahan akan berubah sesuai luas perubahan tiap tipe lahannya. Angka 2 pada kotak Hasil Perubahan akan berubah sesuai persentase perubahan lahan tersebut terhadap keseluruhan lahan.
"
    End Sub

    Private Sub CuttingBtn_Click(sender As Object, e As EventArgs) Handles CuttingBtn.Click
        TitleLbl.Text = "Pemotongan Citra"
        PelatihanBtn.BackColor = Color.DarkGray
        PengujianBtn.BackColor = Color.DarkGray
        HasilBtn.BackColor = Color.DarkGray
        KomparasiBtn.BackColor = Color.DarkGray
        PerubahanBtn.BackColor = Color.DarkGray
        TextDisplay.Text = "Proses pelatihan membutuhkan shapefile untuk memotong citra Landsat. Berikut langkah memotong citra Landsat berdasarkan shapefile:
1.Klik tombol 'Pemotongan Citra' untuk berpindah ke modul pemotongan citra.
2.Klik Tombol 'Folder Input'. Pilih folder yang berisi citra Landsat 8 yang sudah ditransformasi. Akan ditampilkan folder terpilih.
3.Klik Tombol 'File Shapefile'. Pilih shapefile yang akan digunakan untuk memotong citra. Akan ditampilkan file terpilih.
4.Klik Tombol 'Folder Output'. Pilih folder tujuan untuk meletakkan hasil pemotongan citra. Akan ditampilkan folder terpilih.
5.Klik Tombol 'Potong'. Tunggu hingga proses pemotongan selesai. Klik 'Ok'
"
        CuttingBtn.BackColor = Color.FloralWhite
    End Sub

    Private Sub TextDisplay_Click(sender As Object, e As EventArgs) Handles TextDisplay.Click

    End Sub
End Class