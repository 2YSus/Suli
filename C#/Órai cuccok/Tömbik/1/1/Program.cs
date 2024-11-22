using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mennyi véletlenszám legyen?");
            int n = int.Parse(Console.ReadLine());

            int[] szamok = new int[n];

            int s = 0;
            Random random = new Random();
            for(int i = 0; i<n; i++)
            {
                szamok[i] = random.Next(50, 81);
                Console.Write($"{szamok[i]}, ");
                s = s + szamok[i];
            }

            Console.WriteLine($"\nA generált véletlenszámok összege: {s}");
            Console.ReadKey();
        }
    }
}
