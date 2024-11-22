using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány napnak a hőmérékleti adatát kérjem be?");
            Console.Write("Szám: ");

            int n = int.Parse(Console.ReadLine());

            int[] homerseklet = new int[n];

            int s = 0;
            for(int i = 0; i<n; i++)
            {
                Console.Write($"{i+1}. nap: ");
                homerseklet[i] = int.Parse(Console.ReadLine());
                s = s + homerseklet[i];
            }

            Console.WriteLine($"Az átlaghőmérséklet {s/n} celsius fok volt.");
            Console.ReadKey();
        }
    }
}