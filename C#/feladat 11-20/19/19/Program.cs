using System;

namespace tizenkilenc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy egész számot!");
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int hanyszor = szam / 7;
            int hettel_oszthato = (hanyszor + 1) * 7;
            Console.WriteLine("Az első legnagyobb szám, amely osztható 7-tel: {0}", hettel_oszthato);
        }
    }
}