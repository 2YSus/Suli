using System;

namespace huszonharmadik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy egész számot!");
            Console.Write("Szám: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A megadott szám páros!");
            }
            else
            {
                Console.WriteLine("A megadott szám nem páros");
            }
        }
    }
}