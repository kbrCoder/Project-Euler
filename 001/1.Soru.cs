int toplam = 0;
for(int i=1;i<1000;i++)
{
	if (i % 3 == 0)
		toplam += i;
	else if (i % 5 == 0)
		toplam += i;
}
Console.WriteLine(toplam);
