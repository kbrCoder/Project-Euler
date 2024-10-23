using System;

public class Soru9
{
    public static void Main(string[] args)
    {
        int a, b, c, pisagor=0;

        for(a=1;a<1000/3;a++)
        {
            for(b=a+1;b<1000/2;b++)
            {
                c=1000-a-b;
                if(a*a+b*b==c*c)
                {
                    pisagor=a*b*c;
                    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                    Console.WriteLine($"Pisagor abc = {pisagor}");
                    return;
                }
            }
        }
    }
}