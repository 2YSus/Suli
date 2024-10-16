﻿using System;

namespace tizenharmadik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy négyjegyű számot!");
            int szam = Convert.ToInt32(Console.ReadLine());

            int ezresek = szam / 1000;
            int szazasok = szam / 10 % 10;
            int tizesek = szam / 100 % 10;
            int egyesek = szam % 10;

            int forditva = egyesek * 1000 + szazasok * 100 + tizesek * 10 + ezresek;

            int osszeg = egyesek + tizesek + szazasok + ezresek;

            int legkisebb = egyesek;

            if (tizesek < szazasok && tizesek < ezresek && tizesek < egyesek)
            {
                legkisebb = tizesek;
            }
            else if (szazasok < tizesek && szazasok < ezresek && szazasok < egyesek)
            {
                legkisebb = szazasok;
            }
            else
            {
                legkisebb = ezresek;
            }

            Console.WriteLine("A megadott szám visszafele: {0}", forditva);
            Console.WriteLine("A megadott számnak számjegyeinek összege: {0}", osszeg);
            Console.WriteLine("A megadott számnak legkisebb számjegyei: {0}", legkisebb);
        }
    }
}