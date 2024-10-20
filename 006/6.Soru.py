toplamUssu,usToplam=0,0
for i in range(1,101):
    toplamUssu +=i
    usToplam += i*i
toplamUssu=toplamUssu*toplamUssu
print(toplamUssu-usToplam)