using System;

namespace tizenegyedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy kétjegyű számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            int egyesek = szam % 10;
            int tizesek = szam / 10;
            int forditva = egyesek * 10 + tizesek;
            int osszeg = egyesek + tizesek;
            int nagyobb = Math.Max(tizesek, egyesek);
            Console.WriteLine("A megadott szám visszafelé: {0}", forditva);
            Console.WriteLine("A két számjegy összege: {0}", osszeg);
            Console.WriteLine("A két számjegy közül a nagyobbik: {0}", nagyobb);
        }
    }
}