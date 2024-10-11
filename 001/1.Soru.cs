/*Eğer $10$'un altındaki tüm doğal sayıları listelersek ve bu sayılardan
 * $3$ veya $5$'in katları olanları seçersek, bu sayılar
 * $3, 5, 6$ ve $9$ olur. Bu katların toplamı $23$'tür.
$1000$'ın altındaki tüm $3$ veya $5$ katlarının toplamını bulun.*/

int toplam = 0;
for(int i=1;i<1000;i++)
{
	if (i % 3 == 0)
		toplam += i;
	else if (i % 5 == 0)
		toplam += i;
}
Console.WriteLine(toplam);