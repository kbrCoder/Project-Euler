def ciftMi(sayi):
    return sayi % 2 == 0

sayi1 = 1
sayi2 = 2
toplam = 0
toplam += sayi2 

while sayi2 < 4000000:
    deger = sayi1 + sayi2
    sayi1 = sayi2
    sayi2 = deger
    if ciftMi(sayi2):
        toplam += sayi2

print(toplam)
