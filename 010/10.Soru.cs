using System;

public class soru10
{
    static bool asalMi(long sayi)
    {
        if (sayi <= 1)
            return false;
        if (sayi == 2)
            return true;
        if (sayi % 2 == 0)
            return false;

        for (long i = 3; i * i <= sayi; i += 2)
        {
            if (sayi % i == 0)
                return false;
        }
        return true;
    }
    
    public static void Main(string[] args)
    {
        long toplam = 0;
        
        for (long sayi = 2; sayi < 2000000; sayi++)
        {
            if (asalMi(sayi))
                toplam += sayi;
        }

        Console.WriteLine(toplam);
    }
}
