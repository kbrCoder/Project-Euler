def palindromMu(sayi):
    stringsayi = str(sayi)
    ters = stringsayi[::-1]
    return stringsayi == ters


max = 0

for i in range(100,1000):
    for j in range(100,1000):
        if palindromMu(i*j)==True:
            if max<(i*j):
                max=i*j

print(max)
