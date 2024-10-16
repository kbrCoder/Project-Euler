long sayi = 600851475143;
long maxAsal = 1;
while(sayi%2==0)
{
	maxAsal = 2;
	sayi /= 2;
}

for(long i=3;i*i<=sayi; i+=2)
{
	while(sayi%i==0)
	{
		maxAsal = i;
		sayi /= i;
	}
}

if(sayi >2)
{
	 maxAsal = sayi;
}
Console.WriteLine(maxAsal);
Console.ReadKey();