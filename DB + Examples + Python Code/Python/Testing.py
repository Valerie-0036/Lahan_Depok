from PIL import Image
import rasterio
import numpy as np
import pandas as pd
from PIL import Image
import joblib
import math
import os
from numpy import loadtxt
from sklearn.model_selection import train_test_split
from sklearn.metrics import classification_report, confusion_matrix
from sklearn.discriminant_analysis import QuadraticDiscriminantAnalysis
from sklearn.preprocessing import StandardScaler
from sklearn.decomposition import PCA 
from numpy.linalg import inv, multi_dot, det
from datetime import datetime
from pathlib import Path
from sys import argv
import psycopg2
import time


#Baca data
print("======================= Klasifikasi Data dengan Quadratic Discriminant Analysis =======================")
print("=========================================================================================")
print("Menghubungkan dengan Database...")

arg_data = argv[1].split(',')
print(arg_data)
arg_data[0] = arg_data[0].replace(";", " ")
# arg_data[0] = arg_data[0].replace("'", "\"")
kecamatan = arg_data[0]
tgl = arg_data[1] 
current_dir = arg_data[2]

print(current_dir)
# kecamatan = "Limo"
# tgl = '2014-04-22'
# current_dir = "D:\Bahan\SEM7\Code\Python"

con = psycopg2.connect(database="postgres", user="postgres", password="000000", host="127.0.0.1", port=5432)

cursor = con.cursor()
cursor.execute("SELECT * FROM pengujian WHERE kecamatan='{0}' AND test_date='{1}'".format(kecamatan,tgl))

print("Database terhubung.")
print("\n=========================================================================================\n")
print("Membaca Data...")

df = []

for row in cursor.fetchall():
    df.append(row)

for j in range(6):
    x = rasterio.open(df[0][j+3])
    #print(inputPath + bandList[i])
    h = x.height
    w = x.width
    x.crs
    z = x.read(1).astype('float64')
    if j == 0:
        test_data = z.reshape(z.size,1)
    else:
        y = z.reshape(z.size,1)
        test_data = np.append(test_data,y,axis=1)

tempdate=datetime.strftime(df[0][2], '%Y-%m-%d')

#temp pls del
xEdgeCase=rasterio.open(df[0][3])
xEdgeCase=xEdgeCase.read(1).astype('float64')
xEdgeCase = np.array(xEdgeCase).reshape(x.height,x.width).astype(np.uint8)

o=[]
for i in range(test_data.shape[0]):
    if(test_data[i][0]!=0.0):
        o.append(test_data[i])
test_data=np.array(o)
print(test_data.shape)

print("Kecamatan:", kecamatan)
print("Tanggal:",tgl)
print("Ukuran Data:", test_data.shape[0],"piksel\n")

print("Memuat model...")
# classifier = joblib.load("./modelClassic.pkl") #qda sklearn

#QDA Manual
data = loadtxt('./modelClassic.txt', dtype='float')
sizeofarray = 6
mean_hij=np.empty(sizeofarray,dtype='float')
mean_hijseb=np.empty(sizeofarray,dtype='float')
mean_imp=np.empty(sizeofarray,dtype='float')
x_cov_hij=np.empty((sizeofarray,sizeofarray),dtype='float')
x_cov_hijseb=np.empty((sizeofarray,sizeofarray),dtype='float')
x_cov_imp=np.empty((sizeofarray,sizeofarray),dtype='float')
x_covinv_hij=np.empty((sizeofarray,sizeofarray),dtype='float')
x_covinv_hijseb=np.empty((sizeofarray,sizeofarray),dtype='float')
x_covinv_imp=np.empty((sizeofarray,sizeofarray),dtype='float')
line=0
for i in range(sizeofarray):
  mean_hij[i]=data[i]
line=line+sizeofarray
for i in range(sizeofarray):
  mean_hijseb[i]=data[line+i]
line=line+sizeofarray
for i in range(sizeofarray):
  mean_imp[i]=data[line+i]
line=line+sizeofarray
prior_hij=data[line]
prior_hijseb=data[line+1]
prior_imp=data[line+2]
line+=3
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_cov_hij[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_cov_hijseb[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_cov_imp[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_covinv_hij[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_covinv_hijseb[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_covinv_imp[i][j] = data[line+temp]
    temp+=1


thresholdarr=np.zeros((test_data.shape[0],3))
for i in range (test_data.shape[0]):
  x_of_data=test_data[i,:sizeofarray]
  bayes_probhij =  (-.5 * multi_dot([(x_of_data-mean_hij),(x_covinv_hij),(x_of_data-mean_hij).T])) - (.5 * np.log(det(x_cov_hij))) + np.log(prior_hij)
  bayes_probhijseb =  (-.5 * multi_dot([(x_of_data-mean_hijseb),(x_covinv_hijseb),(x_of_data-mean_hijseb).T])) - (.5 * np.log(det(x_cov_hijseb))) + np.log(prior_hijseb)
  bayes_probimp =  (-.5 * multi_dot([(x_of_data-mean_imp),(x_covinv_imp),(x_of_data-mean_imp).T])) - (.5 * np.log(det(x_cov_imp))) + np.log(prior_imp)
  thresholdarr[i,0]=bayes_probhij
  thresholdarr[i,1]=bayes_probhijseb
  thresholdarr[i,2]=bayes_probimp
indices_of_highest_prob = np.argmax(thresholdarr,axis=1)
new_indices = []
for i in range(indices_of_highest_prob.shape[0]):
  indice = indices_of_highest_prob[i]
  if(indice==0):new_indices=np.append(new_indices,"Hijau")
  elif(indice==1):new_indices=np.append(new_indices,"HijauSebagian")
  else:new_indices=np.append(new_indices,"Impervious")

pred = new_indices
print(len(pred))
print("Melakukan klasifikasi...")
# pred = classifier.predict(test_data) #qda sklearn
h=0 
hs=0
im = 0
# for i in range(len(pred)):
#   if pred[i] == "Hijau":
#       h +=1
#   if pred[i] == "HijauSebagian":
#       hs +=1
#   if pred[i] == "Impervious":
#       im +=1
# print("Hijau:",h,"piksel")
# print("HijauSebagian:",hs,"piksel")
# print("Impervious:",im,"piksel")
print("Membuat citra hasil klasifikasi...")
red = np.array(z).reshape(x.height,x.width).astype(np.uint8)
green = np.array(z).reshape(x.height,x.width).astype(np.uint8)
blue = np.array(z).reshape(x.height,x.width).astype(np.uint8)

k=0
for i in range(x.height):
  for j in range(x.width):
    if (red[i][j] != 0.0 and green[i][j] != 0.0 and blue[i][j] != 0.0):
      if(xEdgeCase[i][j]==0):
        k-=1
        # print(i,j)
        # print(red[i][j])
        # print(green[i][j])
        # print(blue[i][j])
      if pred[k] == "Hijau":
        h +=1
      elif pred[k] == "HijauSebagian":
        hs +=1
      elif pred[k] == "Impervious":
        im +=1

      k=k+1
# print("how much is k:",k)
print("Hijau:",h,"piksel")
print("HijauSebagian:",hs,"piksel")
print("Impervious:",im,"piksel")
hijauClassic = str(h * 900)
hjsClassic = str(hs * 900)
imperClassic = str(im * 900)
k =0
# print("Total classified: ", pred.size())
for i in range(x.height):
  for j in range(x.width):
    if (red[i][j] != 0 and green[i][j] != 0 and blue[i][j] != 0):
      if(xEdgeCase[i][j]==0):
        k-=1
      if pred[k] == "Hijau":
        red[i][j] = 16
        green[i][j] = 112
        blue[i][j] = 16
      elif pred[k] == "HijauSebagian":
        red[i][j] = 222
        green[i][j] = 215
        blue[i][j] = 80
      elif pred[k] == "Impervious":
        red[i][j] = 223
        green[i][j] = 32
        blue[i][j] = 32
      k +=1

hasil = np.dstack((red,green,blue))

print("Menyimpan citra hasil klasifikasi...")
citraClassic = Image.fromarray(hasil,'RGB')
os.makedirs(current_dir+"\\Hasil Testing\\"+kecamatan, exist_ok=True)

pathClassic = os.path.join(current_dir,"Hasil Testing",kecamatan+"\\"+ kecamatan+'_'+tgl+'_Classic.png')
print(pathClassic)
citraClassic.save(pathClassic)

start = time.time()

def radiometric(X_input):
  x_temp=np.array(X_input)
  datelist=tempdate
  query="SELECT m2,m3,m4,m5,m6,m7,a2,a3,a4,a5,a6,a7,sun_elevation FROM metadata_file WHERE img_date='{0}'".format(datelist)
  cursor.execute(query)
  temp=cursor.fetchall()
  reflect_mult_band=temp[0][:6]
  reflect_add_band=temp[0][6:12]
  sun_elev=temp[0][12]

  sun_elevation=math.radians(sun_elev) #radian
  x_temp=x_temp*reflect_mult_band+reflect_add_band
  x_temp=x_temp/math.sin(sun_elevation)
  return x_temp
X_test=radiometric(test_data)
sc = StandardScaler()
X_test = sc.fit_transform(X_test)

pca = PCA(n_components  = 2, random_state=0)
test_data = pca.fit_transform(X_test)
print("Selesai membaca data.")
print("Kecamatan:", kecamatan)
print("Tanggal:",tgl)
print("Ukuran Data:", test_data.shape[0],"piksel\n")

print("Memuat model...")
# classifier = joblib.load("./modelPreprocessing.pkl") #qda manual


#QDA Manual
data = loadtxt('./modelPreprocessing.txt', dtype='float')
sizeofarray = 2
mean_hij=np.empty(sizeofarray,dtype='float')
mean_hijseb=np.empty(sizeofarray,dtype='float')
mean_imp=np.empty(sizeofarray,dtype='float')
x_cov_hij=np.empty((sizeofarray,sizeofarray),dtype='float')
x_cov_hijseb=np.empty((sizeofarray,sizeofarray),dtype='float')
x_cov_imp=np.empty((sizeofarray,sizeofarray),dtype='float')
x_covinv_hij=np.empty((sizeofarray,sizeofarray),dtype='float')
x_covinv_hijseb=np.empty((sizeofarray,sizeofarray),dtype='float')
x_covinv_imp=np.empty((sizeofarray,sizeofarray),dtype='float')
line=0
for i in range(sizeofarray):
  mean_hij[i]=data[i]
line=line+sizeofarray
for i in range(sizeofarray):
  mean_hijseb[i]=data[line+i]
line=line+sizeofarray
for i in range(sizeofarray):
  mean_imp[i]=data[line+i]
line=line+sizeofarray
prior_hij=data[line]
prior_hijseb=data[line+1]
prior_imp=data[line+2]
line+=3
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_cov_hij[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_cov_hijseb[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_cov_imp[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_covinv_hij[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_covinv_hijseb[i][j] = data[line+temp]
    temp+=1
line+=temp
temp=0
for i in range(sizeofarray):
  for j in range(sizeofarray):
    x_covinv_imp[i][j] = data[line+temp]
    temp+=1


thresholdarr=np.zeros((test_data.shape[0],3))
for i in range (test_data.shape[0]):
  x_of_data=test_data[i,:sizeofarray]
  bayes_probhij =  (-.5 * multi_dot([(x_of_data-mean_hij),(x_covinv_hij),(x_of_data-mean_hij).T])) - (.5 * np.log(det(x_cov_hij))) + np.log(prior_hij)
  bayes_probhijseb =  (-.5 * multi_dot([(x_of_data-mean_hijseb),(x_covinv_hijseb),(x_of_data-mean_hijseb).T])) - (.5 * np.log(det(x_cov_hijseb))) + np.log(prior_hijseb)
  bayes_probimp =  (-.5 * multi_dot([(x_of_data-mean_imp),(x_covinv_imp),(x_of_data-mean_imp).T])) - (.5 * np.log(det(x_cov_imp))) + np.log(prior_imp)
  thresholdarr[i,0]=bayes_probhij
  thresholdarr[i,1]=bayes_probhijseb
  thresholdarr[i,2]=bayes_probimp
indices_of_highest_prob = np.argmax(thresholdarr,axis=1)
new_indices = []
for i in range(indices_of_highest_prob.shape[0]):
  indice = indices_of_highest_prob[i]
  if(indice==0):new_indices=np.append(new_indices,"Hijau")
  elif(indice==1):new_indices=np.append(new_indices,"HijauSebagian")
  else:new_indices=np.append(new_indices,"Impervious")

pred = new_indices

print("Melakukan klasifikasi...")
# pred = classifier.predict(test_data) #qda manual
h=0 
hs=0
im = 0
# for i in range(len(pred)):
#   if pred[i] == "Hijau":
#       h +=1
#   if pred[i] == "HijauSebagian":
#       hs +=1
#   if pred[i] == "Impervious":
#       im +=1

print("Membuat citra hasil klasifikasi...")
red = np.array(z).reshape(x.height,x.width).astype(np.uint8)
green = np.array(z).reshape(x.height,x.width).astype(np.uint8)
blue = np.array(z).reshape(x.height,x.width).astype(np.uint8)

k=0
for i in range(x.height):
  for j in range(x.width):
    if (red[i][j] != 0 and green[i][j] != 0 and blue[i][j] != 0):
      if(xEdgeCase[i][j]==0):
        k-=1
      if pred[k] == "Hijau":
        h +=1
      elif pred[k] == "HijauSebagian":
        hs +=1
      elif pred[k] == "Impervious":
        im +=1
      k=k+1
print("Hijau:",h,"piksel")
print("HijauSebagian:",hs,"piksel")
print("Impervious:",im,"piksel")
hijau = str(h * 900)
hjs = str(hs * 900)
imper = str(im * 900)
k =0
for i in range(x.height):
  for j in range(x.width):
    if (red[i][j] != 0 and green[i][j] != 0 and blue[i][j] != 0):
      if(xEdgeCase[i][j]==0):
        k-=1
      if pred[k] == "Hijau":
        red[i][j] = 16
        green[i][j] = 112
        blue[i][j] = 16
      elif pred[k] == "HijauSebagian":
        red[i][j] = 222
        green[i][j] = 215
        blue[i][j] = 80
      elif pred[k] == "Impervious":
        red[i][j] = 223
        green[i][j] = 32
        blue[i][j] = 32
      k +=1

hasil = np.dstack((red,green,blue))
print("Menyimpan citra hasil klasifikasi...")
citra = Image.fromarray(hasil,'RGB')
pathPreprocess = os.path.join(current_dir,"Hasil Testing",kecamatan, kecamatan+'_'+tgl+'_PreProcessed.png')
print(pathPreprocess)
citra.save(pathPreprocess)

cursor.execute("SELECT COUNT(*)AS Row_Count FROM hasil WHERE kecamatan='{0}' AND res_date='{1}'".format(kecamatan,tgl))
co = cursor.fetchone()[0]

if co == 0:
    cursor.execute("INSERT INTO hasil(kecamatan,res_date,img_3pre,l_hijau_3,l_hijauseb_3,l_impervious_3,img_classic,l_hijau_none,l_hijauseb_none,l_impervious_none) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')".format(kecamatan,tgl,pathPreprocess,hijau,hjs,imper,pathClassic,hijauClassic,hjsClassic,imperClassic))
    con.commit()
else:
    cursor.execute("DELETE FROM hasil WHERE kecamatan='{0}' AND res_date='{1}'".format(kecamatan,tgl))
    cursor.execute("INSERT INTO hasil(kecamatan,res_date,img_3pre,l_hijau_3,l_hijauseb_3,l_impervious_3,img_classic,l_hijau_none,l_hijauseb_none,l_impervious_none) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')".format(kecamatan,tgl,pathPreprocess,hijau,hjs,imper,pathClassic,hijauClassic,hjsClassic,imperClassic))
    con.commit()
print("Selesai menyimpan citra\n")
print("\n=========================================================================================\n")
print("============================== Proses Klasifikasi Selesai ===============================\n")
end = time.time()
print("Waktu pemetaan model",end - start)