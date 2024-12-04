from osgeo import gdal
from sys import argv
import os
arg_data = argv[1].split(',')
inputPath = arg_data[0] #bands to be cut
shapePath = arg_data[1] #shapefiles directory
outputDir = arg_data[2] #output directory
print(argv)
print(inputPath)
print(shapePath)
print(outputDir)
# print(inputPath)
head, tail = os.path.split(shapePath)
tail  = tail[:-4]
bandList = [band for band in os.listdir(inputPath) if (band[-4:]=='.TIF' or band[-4:]=='.tif')]
print(bandList)
shp_clip = shapePath
print("Citra yang akan di transformasi: \n", bandList)
#print(shp_clip)
for band in bandList: 
    outputPath = outputDir + "\\" 
    if not os.path.exists(outputPath):
        os.makedirs(outputPath)
    options = gdal.WarpOptions(cutlineDSName=shp_clip,cropToCutline=True)
    outBand = gdal.Warp(srcDSOrSrcDSTab=os.path.join(inputPath, band),
                        destNameOrDestDS=outputPath + band[:-4]+'_crop_'+tail+band[-4:],
                        options=options)
    print(outputPath + band[:-4]+'_crop_'+tail+band[-4:])
    outBand= None
