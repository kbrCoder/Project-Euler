using System;

public class HelloWorld
{
    static bool asalMi(long sayi)
    {
        long sayac = 0;
        if(sayi==1)
            return false;
        else if(sayi==2)
            return true;
        for(long i=1;i<sayi;i++)
        {
            if(sayi % i == 0)
                sayac++;
        }
        if(sayac == 0)
            return true;
        else
            return false;
    }
    
    public static void Main(string[] args)
    {
        long sayac = 0,sayi=1;
        do{
            if(asalMi(sayi)==true)
                sayac++;
        }while(sayac==10001);

        Console.WriteLine(sayac+". asal sayı = "+sayi);
    }
}
