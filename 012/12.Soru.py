import math

def ucgen_sayi_bul(n):
    return n * (n + 1) // 2

def bolen_sayisi_hesapla(sayi):
    bolen_sayisi = 0
    karekok = int(math.sqrt(sayi))

    for i in range(1, karekok + 1):
        if sayi % i == 0:
            bolen_sayisi += 2 

    if karekok * karekok == sayi:
        bolen_sayisi -= 1

    return bolen_sayisi

def main():
    sira = 1  
    bolen_sayisi = 0  

    while bolen_sayisi <= 500:
        ucgen_sayi = ucgen_sayi_bul(sira)  
        bolen_sayisi = bolen_sayisi_hesapla(ucgen_sayi)  

        if bolen_sayisi > 500:
            print(f"500'den fazla böleni olan ilk üçgen sayı: {ucgen_sayi}")
            break

        sira += 1 

if __name__ == "__main__":
    main()
