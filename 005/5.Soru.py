def OBEB(a,b):
    while b != 0:
        temp = b
        b = a % b
        a = temp
    return a

def EOK(a,b):
    return (a*b)//OBEB(a,b)

sonuc = 1
for i in range(1,21):
    sonuc = EOK(sonuc,i)
print(sonuc)
