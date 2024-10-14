static bool ciftMi(int sayi)
{
	return sayi % 2 == 0;
}

static void Main(string[] args)
{
	int sayi1 = 1, sayi2 = 2, toplam = 0;
	toplam += sayi2;

	do
	{
		int deger = sayi1 + sayi2;
		sayi1 = sayi2;
		sayi2 = deger;

		if (ciftMi(sayi2))
			toplam += sayi2;

	} while (sayi2 < 4000000);

	Console.WriteLine(toplam);
	Console.ReadKey();
}