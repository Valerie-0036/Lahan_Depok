from PIL import Image
import rasterio
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd
from PIL import Image
import joblib
from sklearn.model_selection import train_test_split
from sklearn.metrics import classification_report, confusion_matrix
from sys import argv, path
import os
import psycopg2


#Baca data
print("============================== Perubahan Alih Fungsi Lahan ==============================")
print("=========================================================================================")
print("Menghubungkan dengan Database...")

arg_data = argv[1].split(',')
arg_data[0] = arg_data[0].replace(";", " ")

kecamatan = arg_data[0]
tgl1 = arg_data[1]
tgl2 = arg_data[2]
current_dir = arg_data[3]
# kecamatan = "Cipayung"
# tgl1 = '2014-04-22'
# tgl2 = '2024-07-22'
# current_dir = "D:\Bahan\SEM7\Code\Python"
con = psycopg2.connect(database="postgres", user="postgres", password="000000", host="127.0.0.1", port=5432)

cursor = con.cursor()

print("Database terhubung.")
print("\n=========================================================================================\n")
print("Membaca Data...")

cursor.execute("SELECT img_3pre FROM hasil WHERE kecamatan='{0}' AND res_date='{1}'".format(kecamatan,tgl1))
path1 = cursor.fetchone()[0]
cursor.execute("SELECT img_3pre FROM hasil WHERE kecamatan='{0}' AND res_date='{1}'".format(kecamatan,tgl2))
path2 = cursor.fetchone()[0]

citra1 = Image.open(path1)
citra2 = Image.open(path2)

print("Selesai membaca data.")

df = []

w, h = citra1.size

d1 = list(citra1.getdata())
d2 = list(citra2.getdata())

d1 = np.array(d1).reshape(h,w,3)
d2 = np.array(d2).reshape(h,w,3)

red = np.zeros((h,w)).astype(np.uint8)
green = np.zeros((h,w)).astype(np.uint8)
blue = np.zeros((h,w)).astype(np.uint8)

print("Membandingkan citra...")

berubah = 0
tetap = 0

hhs = 0
hi = 0
hsh = 0
hsi = 0
ih = 0
ihs = 0

hj = np.array([16, 112, 16])
hs = np.array([222, 215, 80])
im = np.array([223,  32,  32])

for i in range(h):
    for j in range(w):
        if (d1[i][j] != 0).all() and (d2[i][j] != 0).all():
            if(d1[i][j] == d2[i][j]).all():
                red[i][j] = 255
                green[i][j] = 255
                blue[i][j] = 255
                tetap = tetap + 1
            elif(np.array_equal(d1[i][j], hj) and np.array_equal(d2[i][j], hs)):
                red[i][j] = 255
                green[i][j] = 128
                blue[i][j] = 0
                berubah = berubah + 1
                hhs = hhs + 1
            elif(np.array_equal(d1[i][j], hj) and np.array_equal(d2[i][j], im)):
                red[i][j] = 143
                green[i][j] = 72
                blue[i][j] = 0
                berubah = berubah + 1
                hi = hi + 1
            elif(np.array_equal(d1[i][j], hs) and np.array_equal(d2[i][j], hj)):
                red[i][j] = 170
                green[i][j] = 230
                blue[i][j] = 30
                berubah = berubah + 1
                hsh = hsh + 1
            elif(np.array_equal(d1[i][j], hs) and np.array_equal(d2[i][j], im)):
                red[i][j] = 255
                green[i][j] = 204
                blue[i][j] = 153
                berubah = berubah + 1
                hsi = hsi + 1
            elif(np.array_equal(d1[i][j], im) and np.array_equal(d2[i][j], hj)):
                red[i][j] = 97
                green[i][j] = 117
                blue[i][j] = 70
                berubah = berubah + 1
                ih = ih + 1
            elif(np.array_equal(d1[i][j], im) and np.array_equal(d2[i][j], hs)):
                red[i][j] = 246
                green[i][j] = 255
                blue[i][j] = 138
                berubah = berubah + 1
                ihs = ihs + 1

h_hs = str(hhs * 900)
h_i = str(hi*900)
hs_h = str(hsh*900)
hs_i = str(hsi*900)
i_h = str(ih*900)
i_hs = str(ihs*900)

ttp = str(tetap*900)
brb = str(berubah*900)


hasil = np.dstack((red,green,blue))

print("Menyimpan citra hasil klasifikasi...")
citra = Image.fromarray(hasil,'RGB')
os.makedirs((current_dir+"\\Hasil Perubahan\\"+kecamatan), exist_ok=True)
path = os.path.join(current_dir,'Hasil Perubahan',kecamatan, kecamatan +'_'+tgl1 +'_'+tgl2 +'.png')
# if os.path.exists(path):
#   os.remove(path)
# else:
#   print("The file does not exist")

print(path)
citra.save(path)

cursor.execute("SELECT COUNT(*)AS Row_Count FROM perubahan_lahan WHERE kecamatan='{0}' AND (start_date='{1}' AND end_date='{2}')".format(kecamatan,tgl1,tgl2))
co = cursor.fetchone()[0]

if co == 0:
    cursor.execute("INSERT INTO perubahan_lahan(kecamatan,start_date,end_date,img_change,hij_hijseb,hij_imper,hijseb_hij,hijseb_imper,imper_hij,imper_hijseb,no_change) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')".format(kecamatan,tgl1,tgl2,path,h_hs,h_i,hs_h,hs_i,i_h,i_hs,ttp))
    con.commit()
else:
    cursor.execute("DELETE FROM perubahan_lahan WHERE kecamatan='{0}' AND(start_date='{1}' AND end_date='{2}')".format(kecamatan,tgl1,tgl2))
    cursor.execute("INSERT INTO perubahan_lahan(kecamatan,start_date,end_date,img_change,hij_hijseb,hij_imper,hijseb_hij,hijseb_imper,imper_hij,imper_hijseb,no_change) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')".format(kecamatan,tgl1,tgl2,path,h_hs,h_i,hs_h,hs_i,i_h,i_hs,ttp))
    con.commit()
print("Selesai menyimpan citra\n")
print("\n=========================================================================================\n")