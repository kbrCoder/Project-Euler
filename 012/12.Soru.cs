using System;

class Program
{
    static int ucgenSayiBul(int n)
    {
        return n * (n + 1) / 2;
    }
    static int bolenSayisİHesapla(int sayi)
    {
        int bolenSayisi = 0;
        int karekok = (int)Math.Sqrt(sayi);

        for(int i = 1; i <= karekok; i++)
        {
              if (sayi % i == 0)
            {
                bolenSayisi += 2; 
            }
        }

        if (karekok * karekok == sayi)
        {
            bolenSayisi--;
        }

        return bolenSayisi;

    }
     static void Main(string[] args)
    {
        int sira = 1; 
        int bolenSayisi = 0; 

        while (bolenSayisi <= 500)
        {
            int ucgenSayi = ucgenSayiBul(sira); 
            bolenSayisi = bolenSayisİHesapla(ucgenSayi);  

            if (bolenSayisi > 500)
            {
                Console.WriteLine($"500'den fazla böleni olan ilk üçgen sayı: {ucgenSayi}");
                break;
            }

            sira++; 
        }
    }
}