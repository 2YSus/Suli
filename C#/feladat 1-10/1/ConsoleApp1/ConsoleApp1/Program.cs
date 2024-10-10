using System;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az első számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int osszeg = a + b;
            int kulonbseg = a - b;
            int szorzat = a * b;
            int hanyados = a / b;
            Console.WriteLine("A két szám összege: " + osszeg);
            Console.WriteLine("A két szám különbsége" + kulonbseg);
            Console.WriteLine("A két szám szorzata: " + szorzat);
            Console.WriteLine("A két szám hányadosa: " + hanyados);
        }
    }
}