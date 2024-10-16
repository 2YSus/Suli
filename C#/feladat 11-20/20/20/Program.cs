using System;
using System.Runtime.ConstrainedExecution;

namespace huszadikfeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy egész számot");
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int hettel_oszthato = szam / 7 * 7;
            Console.WriteLine("A legközelebb eső, szám ami osztható 7-tel: {0}", hettel_oszthato);
        }
    }
}