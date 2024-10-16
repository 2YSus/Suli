using System;

namespace tizenötödik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy háromjeyű számot!");
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int egyesek = szam % 10;
            int tizesek = szam / 10 % 10;
            int szazasok = szam / 100;
            int legnagyobb = egyesek;
            if (tizesek > egyesek && tizesek > szazasok)
            {
                legnagyobb = tizesek;
            }
            else if (szazasok > egyesek && szazasok > tizesek)
            {
                legnagyobb = szazasok;
            }
            int legkisebb = egyesek;
            if (tizesek < egyesek && tizesek < szazasok)
            {
                legkisebb = tizesek;
            }
            else if (szazasok < egyesek && szazasok < tizesek)
            {
                legkisebb = szazasok;
            }
            int kozepso = egyesek + tizesek + szazasok - legkisebb - legnagyobb;

            int ujSzam = legnagyobb * 100 + kozepso * 10 + legkisebb;

            Console.WriteLine("Az adott számjegyekbő a legnagyobb képezhető szám: {0}", ujSzam);
        }
    }
}