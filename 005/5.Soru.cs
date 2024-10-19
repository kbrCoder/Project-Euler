static long OBEB(long a, long b)
{
	while (b != 0)
	{
		long temp = b;
		b = a % b;
		a = temp;
	}
	return a;
}

static long EOK(long a, long b)
{
	return (a * b) / OBEB(a, b);
}

static void Main(string[] args)
{
	long sonuc = 1;
	for (long i = 1; i <= 20; i++)
	{
		sonuc = EOK(sonuc, i);
	}
	Console.WriteLine(sonuc); 
	Console.ReadLine();
}