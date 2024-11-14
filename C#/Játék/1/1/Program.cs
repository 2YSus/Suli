using System;

namespace Randomszam_kitalalasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia! Kitalálom hogy milyen számra gondoltál.");
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            Console.WriteLine($"A szám amire gondoltál.... a {szam}?");
            Console.Write("Kitaláltam?(igen/nem): ");
            string valasz = Console.ReadLine();
            string kicsinites = valasz.ToLower();

            if (kicsinites == "igen")
            {
                Console.WriteLine("Beszoptad");
            }
            else
            {
                Console.WriteLine("Hazudsz");
            }

        }
    }
}