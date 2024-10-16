using System;

namespace tizennegyedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            int egyesek = szam % 10;
            int szazasok = szam / 100 * 10;
            int ujSzam = szazasok + egyesek;

            Console.WriteLine("A tizeseket kihagyva {0} számot kapjuk", ujSzam);
        }
    }
}