using System;

namespace tizenhatodik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy legalább háromjegyű számot!");
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int utolso_3jegy = szam % 1000;
            int egyesek = utolso_3jegy % 10;
            int tizesek = (utolso_3jegy / 10) % 10;
            int szazasok = utolso_3jegy / 100;
            int csere = egyesek * 100 + tizesek * 10 + szazasok;
            int ujSzam = (szam / 1000) * 1000 + csere;
            Console.WriteLine("Az egyesek és százasok megcserélve: {0}", ujSzam);
        }
    }
}