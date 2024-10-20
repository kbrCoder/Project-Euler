long toplamUssu = 0, usToplam = 0;
for(long i =1;i<=100;i++)
{
	toplamUssu += i;
	usToplam += i*i;
}
toplamUssu=toplamUssu*toplamUssu;

Console.WriteLine(toplamUssu - usToplam);
Console.ReadKey();