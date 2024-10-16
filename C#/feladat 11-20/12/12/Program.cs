using System;

namespace tizenkettedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy háromjegyű számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            int szazasok = szam / 100;
            int tizesek = szam / 10 % 10;
            int egyesek = szam % 10;

            int forditva = egyesek * 100 + tizesek * 10 + szazasok;

            int osszeg = egyesek + tizesek + szazasok;

            int legnagyob = egyesek;

            if (egyesek > tizesek && egyesek > szazasok)
            {
                legnagyob = egyesek;
            }
            else if (tizesek > egyesek && tizesek > szazasok)
            {
                legnagyob = tizesek;
            }
            else
            {
                legnagyob = szazasok;
            }

            Console.WriteLine("A megadott szám visszafelé: {0}", forditva);
            Console.WriteLine("A három számjegy összege: {0}", osszeg);
            Console.WriteLine("A három számjegy közül a legnagyobb: {0}", legnagyob);
        }
    }
}