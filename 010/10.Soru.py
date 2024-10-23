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

toplam = 0
for i in range(2,2000000):
    if asalMi(i):
        toplam += i
print(toplam)
