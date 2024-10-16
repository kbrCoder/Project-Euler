sayi,maxAsal=600851475143,1
while sayi % 2 == 0:
    maxAsal = 2
    sayi //=2
for i in range(3,int(sayi**0.5)+1,2):   
    while sayi % i == 0:
        maxAsal = i
        sayi //= i

if sayi > 2:
    maxAsal = sayi

print(maxAsal)