using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Mennyi autó sebességét kérjem be?");
                Console.Write("Szám: ");
                int n = int.Parse(Console.ReadLine());
                int[] sebesseg = new int[n];

                int s = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1}. sebesség: ");
                    sebesseg[i] = int.Parse(Console.ReadLine());
                    s = s + sebesseg[i];
                }
                Console.WriteLine($"Az autók átlagsebessége {s / n} volt");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"A megadott szar {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}