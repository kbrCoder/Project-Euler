static bool palindromMu(long sayi)
{
	string stringsayi = Convert.ToString(sayi);
	string ters = new string(stringsayi.Reverse().ToArray());
	return stringsayi == ters;
}

static void Main(string[] args)
{
	long max = 0;
	for(long i = 100;i<=999;i++)
	{
		for(long j = 100;j<=999;j++)
		{
			if(palindromMu(i * j)==true)
				if(max < i * j)
					max= i * j;
		}
	}
    Console.WriteLine(max);
	Console.ReadKey();
}