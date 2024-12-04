import rasterio
import numpy as np
import pandas as pd
from PIL import Image
import joblib
import math
from sklearn.discriminant_analysis import QuadraticDiscriminantAnalysis
from sklearn.preprocessing import StandardScaler
from sklearn.decomposition import PCA 
from sklearn.model_selection import train_test_split
from sklearn.metrics import classification_report, confusion_matrix
from datetime import datetime
from numpy.linalg import inv, multi_dot, det
import time
import psycopg2

#Baca data
print("======================== Klasik ========================")
print("=========================================================================================")
print("Menghubungkan dengan Database...")


con = psycopg2.connect(database="postgres", user="postgres", password="000000", host="127.0.0.1", port=5432)

cursor = con.cursor()

print("Database terhubung.")
print("\n=========================================================================================\n")
print("Membaca Data...")
cursor.execute('SELECT * FROM pelatihan')
df = []
r = []
r1 = []
r2 = []
r3 = []
dater1=[]
dater2=[]
dater3=[]
#radiometric

for row in cursor.fetchall():
    df.append(row)

for i in range (len(df)):
    print ("Membaca Data ke-" ,i+1)
    if df[i][1]=="Hijau":
        for j in range(6):
            x = rasterio.open(df[i][j+3])
            h = x.height
            w = x.width
            x.crs
            z = x.read(1).astype('float64')
            if j == 0:
                ri = z.reshape(z.size,1)
            else:
                y = z.reshape(z.size,1)
                ri = np.append(ri,y,axis=1)
        tempdate=np.full((ri.shape[0],1),(datetime.strftime(df[i][2], '%Y-%m-%d')))
        if len(r1) == 0:
            r1=ri
            dater1=tempdate
        else:
            dater1= np.append(dater1,tempdate,axis=0)
            r1 = np.append(r1,ri,axis=0)
        
    elif df[i][1]=="Hijau Sebagian":
        for j in range(6):
            x = rasterio.open(df[i][j+3])
            h = x.height
            w = x.width
            x.crs
            z = x.read(1).astype('float64')
            if j == 0:
                ri = z.reshape(z.size,1)
            else:
                y = z.reshape(z.size,1)
                ri = np.append(ri,y,axis=1)
        tempdate=np.full((ri.shape[0],1),(datetime.strftime(df[i][2], '%Y-%m-%d')))
        if len(r2)== 0:
            r2=ri
            dater2=tempdate
        else:
            dater2= np.append(dater2,tempdate,axis=0)
            r2 = np.append(r2,ri,axis=0)
    else:
        for j in range(6):
            x = rasterio.open(df[i][j+3])
            h = x.height
            w = x.width
            x.crs
            z = x.read(1).astype('float64')
            if j == 0:
                ri = z.reshape(z.size,1)
            else:
                y = z.reshape(z.size,1)
                ri = np.append(ri,y,axis=1)
        tempdate=np.full((ri.shape[0],1),(datetime.strftime(df[i][2], '%Y-%m-%d')))
        if len(r3)== 0:
            r3=ri
            dater3=tempdate
        else:
            dater3= np.append(dater3,tempdate,axis=0)
            r3 = np.append(r3,ri,axis=0)
    

o=0
for i in range(r1.shape[0]):
    if(r1[i][0]!=0.0):
        o=o+1

r1_clean = np.empty((o,6))
dater1_clean = np.empty((o,1),dtype='object')
k=0
for i in range(r1.shape[0]):
    if(r1[i][0]!=0):
        dater1_clean[k] = dater1[i]
        r1_clean[k] = r1[i]
        k=k+1
        
a = pd.DataFrame(dater1_clean)
r1_clean = np.append(r1_clean,a,axis=1)
a = ["Hijau" for i in range(r1_clean.shape[0])]
a = pd.DataFrame(a)
r1_clean = np.append(r1_clean,a,axis=1)

o=0
for i in range(r2.shape[0]):
    if(r2[i][0]!=0.0):
        o=o+1

r2_clean = np.empty((o,6))
dater2_clean = np.empty((o,1),dtype='object')
k=0
for i in range(r2.shape[0]):
    if(r2[i][0]!=0):
        dater2_clean[k] = dater2[i]
        r2_clean[k] = r2[i]
        k=k+1

a = pd.DataFrame(dater2_clean)
r2_clean = np.append(r2_clean,a,axis=1)
a = ["HijauSebagian" for i in range(r2_clean.shape[0])]
a = pd.DataFrame(a)
r2_clean = np.append(r2_clean,a,axis=1)

o=0
for i in range(r3.shape[0]):
    if(r3[i][0]!=0.0):
        o=o+1

r3_clean = np.empty((o,6))
dater3_clean = np.empty((o,1),dtype='object')
k=0
for i in range(r3.shape[0]):
    if(r3[i][0]!=0):
        dater3_clean[k] = dater3[i]
        r3_clean[k] = r3[i]
        k=k+1
a = pd.DataFrame(dater3_clean)
r3_clean = np.append(r3_clean,a,axis=1)
a = ["Impervious" for i in range(r3_clean.shape[0])]
a = pd.DataFrame(a)
r3_clean = np.append(r3_clean,a,axis=1)
print("Hijau Penuh:",r1_clean.shape[0]," piksel")
print("Hijau Sebagian Penuh:",r2_clean.shape[0]," piksel")
print("Impervious Penuh:",r3_clean.shape[0]," piksel")
r = np.append(r1_clean, (np.append(r2_clean,r3_clean,axis=0)),axis=0)
print("\nJumlah piksel data latih:", r.shape[0], "piksel")
print("Selesai Membaca Data.")
print("\n=========================================================================================\n")
print("========================= Proses Data dengan  3 Tahap Pre-Processing ==========================\n")
print("Membagi data latih dan data validasi...")

y_train = r[:,7]
train = r[:, :7]

def radiometric(X_input):
  inputarr=[]
  x_temp=np.array(X_input[0,:6])
  datelist=X_input[0,6]
  for i in range(1,X_input.shape[0]):
      if(i==X_input.shape[0]-1 or X_input[i,6]!=datelist):
          datelist=X_input[i,6]
          query="SELECT m2,m3,m4,m5,m6,m7,a2,a3,a4,a5,a6,a7,sun_elevation FROM metadata_file WHERE img_date='{0}'".format(datelist)
          cursor.execute(query)
          temp=cursor.fetchall()
          reflect_mult_band=temp[0][:6]
          reflect_add_band=temp[0][6:12]
          sun_elev=temp[0][12]

          sun_elevation=math.radians(sun_elev) #radian
          if(i==X_input.shape[0]-1): 
            x_temp=np.vstack([x_temp,X_input[i,:6]])
          # print(i,X_input.shape[0]-1)
          # print(x_temp.shape)
          x_temp=x_temp*reflect_mult_band+reflect_add_band
          x_temp=x_temp/math.sin(sun_elevation)
          if not inputarr:
            inputarr=np.array(x_temp)
          else: 
            inputarr=np.vstack([inputarr,x_temp])
          x_temp=X_input[i,:6]
          datelist=X_input[i,6]
      else:
          # print(x_temp)
          x_temp=np.vstack([x_temp,X_input[i,:6]])

  return inputarr

state = 12  
test_size = 0.35  
  
X_train, X_val, y_train, y_val = train_test_split(train, y_train,  
    test_size=test_size, random_state=state)
X_train_og=X_train
y_train_og=y_train
X_val_og=X_val
indexHijauTrain = np.where(y_train == "Hijau")
indexHijauSebagianTrain = np.where(y_train == "HijauSebagian")
indexImperviousTrain = np.where(y_train == "Impervious")
for i in X_train[indexHijauTrain,:6]: X_hij=i
for i in X_train[indexHijauSebagianTrain,:6]: X_hijseb=i
for i in X_train[indexImperviousTrain,:6]: X_imp=i
print("Hijau Latih:",X_hij.shape[0]," piksel")
print("Hijau Sebagian Latih:",X_hijseb.shape[0]," piksel")
print("Impervious Latih:",X_imp.shape[0]," piksel")
X_train=np.concatenate((X_hij,X_hijseb),axis=0)
X_train=np.concatenate((X_train,X_imp),axis=0)
y_hij=np.full(X_hij.shape[0],'Hijau')
y_hijseb=np.full(X_hijseb.shape[0],'HijauSebagian')
y_imp=np.full(X_imp.shape[0],'Impervious')
y_train=np.concatenate((y_hij,y_hijseb),axis=0)
y_train=np.concatenate((y_train,y_imp),axis=0)

print("=================== Matrix Classic Correlation =============================")
dfClassic = pd.DataFrame(X_train)
dfClassic = dfClassic.astype('float')
print(dfClassic.corr())

vifs = pd.Series(np.linalg.inv(dfClassic.corr().to_numpy()).diagonal(), 
                 index=dfClassic.columns, 
                 name='VIF')

print(vifs)

mean_hij=np.mean(X_hij,axis=0)
mean_hijseb=np.mean(X_hijseb,axis=0)
mean_imp=np.mean(X_imp,axis=0)
prior_hij=X_hij.shape[0]/X_train.shape[0]
prior_hijseb=X_hijseb.shape[0]/X_train.shape[0]
prior_imp=X_imp.shape[0]/X_train.shape[0]
x_cov_hij=np.cov(X_hij.astype(float).T)
x_cov_hijseb=np.cov(X_hijseb.astype(float).T)
x_cov_imp=np.cov(X_imp.astype(float).T)
x_covinv_hij=inv(x_cov_hij)
x_covinv_hijseb=inv(x_cov_hijseb)
x_covinv_imp=inv(x_cov_imp)

thresholdarr=np.zeros((X_val.shape[0],3))
for i in range (X_val.shape[0]):
  x=X_val[i,:6]
  bayes_probhij =  (-.5 * multi_dot([(x-mean_hij),(x_covinv_hij),(x-mean_hij).T])) - (.5 * np.log(det(x_cov_hij))) + np.log(prior_hij)
  bayes_probhijseb =  (-.5 * multi_dot([(x-mean_hijseb),(x_covinv_hijseb),(x-mean_hijseb).T])) - (.5 * np.log(det(x_cov_hijseb))) + np.log(prior_hijseb)
  bayes_probimp =  (-.5 * multi_dot([(x-mean_imp),(x_covinv_imp),(x-mean_imp).T])) - (.5 * np.log(det(x_cov_imp))) + np.log(prior_imp)
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

# print(classification_report(y_val, new_indices))
sizeofarray = 6
f1 = open(r"./modelClassic.txt","w+")
for i in range(sizeofarray):
  f1.write("%s\n" % (str("%.4f" % (mean_hij[i]))))
for i in range(sizeofarray):
  f1.write("%s\n" % (str("%.4f" % (mean_hijseb[i]))))
for i in range(sizeofarray):
  f1.write("%s\n" % (str("%.4f" % (mean_imp[i]))))
f1.write("%s\n" % (str("%.4f" % (prior_hij))))
f1.write("%s\n" % (str("%.4f" % (prior_hijseb))))
f1.write("%s\n" % (str("%.4f" % (prior_imp))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_cov_hij[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_cov_hijseb[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_cov_imp[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_covinv_hij[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_covinv_hijseb[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_covinv_imp[i][j]))))
f1.close()
predictions = new_indices
print("Pembagian selesai...")
print("\nMembangun model classic...")
#classic
# classifier = QuadraticDiscriminantAnalysis()
# classifier.fit(X_train[:,:6], y_train)
# predictions = classifier.predict(X_val[:,:6])
print("\n=========================================================================================\n")
print("==================================== Menyimpan Model ====================================\n")
# joblib.dump(classifier, "./modelClassic.pkl")
print("Selesai menyimpan model\n")
print("\n=========================================================================================\n")
print("=============================== Proses Pelatihan Classic Selesai ================================\n")
print("Model selesai dibangun.")
print("Proses validasi dengan f1 score...")
print("Classification Report")
score = classification_report(y_val, predictions, output_dict=True)
print(classification_report(y_val, predictions,digits=4))
print(confusion_matrix(y_val,predictions))
f1 = open(r"./train_nilaiclassic.txt","w+")
f1.write("%s\n%s\n%s\n" % (str("%.4f" % (score['Hijau']['precision'])), str("%.4f" % (score['Hijau']['recall'])), str("%.2f" % (score['Hijau']['f1-score']*100))))
f1.close()

f1 = open(r"./train_nilaiclassic.txt","a")
f1.write("%s\n%s\n%s\n" % (str("%.4f" % (score['HijauSebagian']['precision'])), str("%.4f" % (score['HijauSebagian']['recall'])), str("%.2f" % (score['HijauSebagian']['f1-score']*100))))
f1.write("%s\n%s\n%s\n" % (str("%.4f" % (score['Impervious']['precision'])), str("%.4f" % (score['Impervious']['recall'])), str("%.2f" % (score['Impervious']['f1-score']*100))))
f1.write("%s\n%s\n%s\n" % (str("%.4f" % (score['macro avg']['precision'])), str("%.4f" % (score['macro avg']['recall'])), str("%.2f" % (score['macro avg']['f1-score']*100))))
f1.write("%s\n" % str("%.2f" % (score['accuracy']*100)))
f1.close()
start = time.time()

X_train=radiometric(X_train_og)
X_test=radiometric(X_val)

sc = StandardScaler()
X_train = sc.fit_transform(X_train)
X_test = sc.transform(X_test)
obscenevariable = 2
pca = PCA(n_components  = obscenevariable, random_state=0)
X_train = pca.fit_transform(X_train)
X_test = pca.transform(X_test)
print("Proses membutuhkan waktu. Mohon tunggu sebentar...")

def mcd(X_input):
  epsilon=0.00001
  delta=0.0001
  n,p=X_input.shape 
  x=np.transpose(X_input)
  h=math.ceil((n+p+1)/2)      
  rep=500
  DetSC2=np.zeros((rep,1))
  SC2=np.zeros((rep*p,p))
  TC2=np.zeros((rep*p,1))
  for k in range(rep):
    To=np.zeros((p,1))
    rn=np.random.permutation(n)
    DetSo=0
    Iadd=1
    while DetSo<delta: #pre c steps
      h1=p+Iadd
      for i in range(h1):
        To = ((1 / h1) * x[:, rn[i]]).reshape(p,1) + To
      So=np.zeros((p,p))
      for i in range(h1):
        res=np.array(x[:,rn[i]]).reshape(p,1) - To
        So1=(1/h1)* res @ res.T
        So=So1 + So
      DetSo=np.linalg.det(So)
      Iadd=Iadd+1
    d=np.zeros((n, 1))
    for m in range(3): #c steps 6x
      for i in range(n):
        res=np.array(x[:,i]).reshape(p,1) - To
        d[i]=np.sqrt(res.T @ inv(So) @ res)
      pi = np.argsort(d,axis=0) 
      ds=np.sort(d,axis=0)
      T1=np.zeros((p,1))
      for i in range(h):
        res=np.array(x[:, pi[i]]).reshape(p,1)
        T1 += (1 / h) * res
      S1=np.zeros((p,p))
      for i in range(h):
        res=np.array(x[:,pi[i]]).reshape(p,1)-T1
        S1+=((1/h)* res) @ res.T
        # print(x[:,pi[i]])
      To=T1
      So=S1
    DetSC2[k]=np.linalg.det(S1)
    # print((k)*p,(k+1)*p)
    SC2[(k)*p:(k+1)*p,:]=S1
    TC2[(k)*p:(k+1)*p,:]=T1
  pi500 = np.argsort(DetSC2,axis=0)
  DetSC2Sort=np.sort(DetSC2,axis=0)
  SCon=np.zeros((10*p,p))
  TCon=np.zeros((10*p,1))
  DetSCon=np.zeros((10,1))
  piCon=np.zeros((n,10))
  for m in range(10):
    STx=int((pi500[m]-1)*p)
    STy=int((pi500[m])*p)
    So=SC2[STx:STy,:]
    To=TC2[STx:STy,:]
    # print(To.shape)
    stop=0
    while stop==0: #csteps 
      d=np.zeros((n,1))
      for i in range(n):
        temp=np.array(x[:,i]).reshape(p,1)-To
        d[i]=np.sqrt(temp.T @ inv(So) @ temp)
      pi = np.argsort(d,axis=0)
      ds=np.sort(d,axis=0)
      T1=np.zeros((p,1))
      for i in range(h):
        temp=np.array(x[:,pi[i]]).reshape(p,1)
        T1+=(1/h)*temp
      S1=np.zeros((p,p))
      for i in range(h):
        temp=np.array(x[:,pi[i]]).reshape(p,1)-T1
        S1+=(1/h)*temp@temp.T
      DetSo=np.linalg.det(So)
      DetS1=np.linalg.det(S1)
      if (abs(DetSo-DetS1) < epsilon or DetS1==0):
        stop=1
        if DetS1==0:
          S1=So
          T1=To
      else:
        To=T1
        So=S1
    SCon[m*p:(m+1)*p,:]=S1
    TCon[m*p:(m+1)*p,:]=T1
    DetSCon[m]=DetS1
    piCon[:,m]=np.array(pi).reshape(n)
    DetSConSort=np.sort(DetSCon,axis=0) #possibility to be deleted
  pi10=np.argsort(DetSCon,axis=0)
  S=np.zeros((p,p))
  T=np.zeros((p,1))
  S=SCon[(pi10[0,0])*p:(pi10[0,0]+1)*p,:]
  T=TCon[(pi10[0,0])*p:(pi10[0,0]+1)*p,:]
  
  # S=np.array([0.07367835,-0.05940496,-0.05940496,0.83406541]).reshape(2,2)
  # T=np.array([-2.97043768,-0.1020403]).reshape(2,1)
  INVS = np.linalg.inv(S)
  d = np.zeros((n))
  newX=np.array(X_input.T).reshape((p,n))
  newY=newX-T
  for i in range(n):
    y = newY[:, i]
    d[i] = y.T @ INVS @ y
  h=math.ceil((n+p+1)/2)
  # X_temp = X_input[:h,:] # this gives 100%
  p_new=np.argsort(d)
  d_sort=np.sort(d)
  # plt.plot(d_sort, '.', markersize=14)
  # plt.show() 
  X_temp=np.zeros((h,p))
  for i in range (h):
    X_temp[i,:]=X_input[p_new[i],:]
  return X_temp

indexHijauTrain = np.where(y_train_og == "Hijau")
indexHijauSebagianTrain = np.where(y_train_og == "HijauSebagian")
indexImperviousTrain = np.where(y_train_og == "Impervious")
X_hij=mcd(X_train[indexHijauTrain])
X_hijseb=mcd(X_train[indexHijauSebagianTrain])
X_imp=mcd(X_train[indexImperviousTrain])
X_train=np.concatenate((X_hij,X_hijseb),axis=0)
X_train=np.concatenate((X_train,X_imp),axis=0)
y_hij=np.full(X_hij.shape[0],'Hijau')
y_hijseb=np.full(X_hijseb.shape[0],'HijauSebagian')
y_imp=np.full(X_imp.shape[0],'Impervious')
y_train=np.concatenate((y_hij,y_hijseb),axis=0)
y_train=np.concatenate((y_train,y_imp),axis=0)

print("=================== Matrix 3 Pre-Processing Correlation =============================")
dfClassic = pd.DataFrame(X_train)
dfClassic = dfClassic.astype('float')
print(dfClassic.corr())

vifs = pd.Series(np.linalg.inv(dfClassic.corr().to_numpy()).diagonal(), 
                 index=dfClassic.columns, 
                 name='VIF')
print(vifs)

mean_hij=np.mean(X_hij,axis=0)
mean_hijseb=np.mean(X_hijseb,axis=0)
mean_imp=np.mean(X_imp,axis=0)
prior_hij=X_hij.shape[0]/X_train.shape[0]
prior_hijseb=X_hijseb.shape[0]/X_train.shape[0]
prior_imp=X_imp.shape[0]/X_train.shape[0]
x_cov_hij=np.cov(X_hij.astype(float).T)
x_cov_hijseb=np.cov(X_hijseb.astype(float).T)
x_cov_imp=np.cov(X_imp.astype(float).T)
x_covinv_hij=inv(x_cov_hij)
x_covinv_hijseb=inv(x_cov_hijseb)
x_covinv_imp=inv(x_cov_imp)

thresholdarr=np.zeros((X_test.shape[0],3))
for i in range (X_test.shape[0]):
  x=X_test[i,:obscenevariable]
  bayes_probhij =  (-.5 * multi_dot([(x-mean_hij),(x_covinv_hij),(x-mean_hij).T])) - (.5 * np.log(det(x_cov_hij))) + np.log(prior_hij)
  bayes_probhijseb =  (-.5 * multi_dot([(x-mean_hijseb),(x_covinv_hijseb),(x-mean_hijseb).T])) - (.5 * np.log(det(x_cov_hijseb))) + np.log(prior_hijseb)
  bayes_probimp =  (-.5 * multi_dot([(x-mean_imp),(x_covinv_imp),(x-mean_imp).T])) - (.5 * np.log(det(x_cov_imp))) + np.log(prior_imp)
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

# print(classification_report(y_val, new_indices))
sizeofarray = obscenevariable
f1 = open(r"./modelPreprocessing.txt","w+")
for i in range(sizeofarray):
  f1.write("%s\n" % (str("%.4f" % (mean_hij[i]))))
for i in range(sizeofarray):
  f1.write("%s\n" % (str("%.4f" % (mean_hijseb[i]))))
for i in range(sizeofarray):
  f1.write("%s\n" % (str("%.4f" % (mean_imp[i]))))
f1.write("%s\n" % (str("%.4f" % (prior_hij))))
f1.write("%s\n" % (str("%.4f" % (prior_hijseb))))
f1.write("%s\n" % (str("%.4f" % (prior_imp))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_cov_hij[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_cov_hijseb[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_cov_imp[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_covinv_hij[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_covinv_hijseb[i][j]))))
for i in range(sizeofarray):
  for j in range(sizeofarray):
    f1.write("%s\n" % (str("%.4f" % (x_covinv_imp[i][j]))))
f1.close()
predictions = new_indices

# classifier = QuadraticDiscriminantAnalysis() #qda manual
# classifier.fit(X_train, y_train)
# predictions = classifier.predict(X_test)
print("\n=========================================================================================\n")
print("========================== Performa Model 3 Tahap Pre-Processing ==========================\n")
print("Model selesai dibangun.")
print("Proses validasi dengan f1 score...")
print("Classification Report")
score = classification_report(y_val, predictions, output_dict=True)
print(classification_report(y_val, predictions,digits=4))
print(confusion_matrix(y_val,predictions))
f1 = open(r"./train_nilaipreprocess.txt","w+")
f1.write("%s\n%s\n%s\n" % (str("%.4f" % (score['Hijau']['precision'])), str("%.4f" % (score['Hijau']['recall'])), str("%.2f" % (score['Hijau']['f1-score']*100))))
f1.close()

f1 = open(r"./train_nilaipreprocess.txt","a")
f1.write("%s\n%s\n%s\n" % (str("%.4f" % (score['HijauSebagian']['precision'])), str("%.4f" % (score['HijauSebagian']['recall'])), str("%.2f" % (score['HijauSebagian']['f1-score']*100))))
f1.write("%s\n%s\n%s\n" % (str("%.4f" % (score['Impervious']['precision'])), str("%.4f" % (score['Impervious']['recall'])), str("%.2f" % (score['Impervious']['f1-score']*100))))
f1.write("%s\n%s\n%s\n%s\n%s\n%s\n" % (str(r1_clean.shape[0]), str(r2_clean.shape[0]), str(r3_clean.shape[0]), str(X_hij.shape[0]), str(X_hijseb.shape[0]), str(X_imp.shape[0])))
f1.write("%s\n" % str("%.2f" % (score['accuracy']*100)))
f1.close()


print("\n=========================================================================================\n")
print("==================================== Menyimpan Model ====================================\n")
# joblib.dump(classifier, "./modelPreprocessing.pkl")
print("Selesai menyimpan model\n")
print("\n=========================================================================================\n")
print("=============================== Proses Pelatihan Preprocessing Selesai ================================\n")
end = time.time()
print("Waktu build model",end - start)