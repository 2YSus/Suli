using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsiusből Klevinbe vagy Kelvinből Celsiusba szeretnél váltani (1 vagy 2). ");
            int valasz = int.Parse(Console.ReadLine());
            Console.Write("Hőmérséklet: ");
            int homerseklet = int.Parse(Console.ReadLine());
            switch (valasz)
            {
                case 1:
                    Console.WriteLine($"{homerseklet} C= {homerseklet + 273} K.");
                    break;

                case 2:
                    Console.WriteLine($"{homerseklet} K= {homerseklet - 273} C.");
                    break;
            }
        }
    }
}
