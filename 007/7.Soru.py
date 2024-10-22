import math

def asalMi(sayi):
    if sayi == 1:
        return False
    if sayi == 2:
        return True
    for i in range(2, int(math.sqrt(sayi)) + 1):
        if sayi % i == 0:
            return False
    return True

sayac, sayi = 0, 1
while sayac < 10001:
    sayi += 1
    if asalMi(sayi):
        sayac += 1

print(str(sayac) + ". asal sayı = " + str(sayi))
