using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot amelyiknek az osztóit szeretnéd tudni");
            Console.Write("Szám: ");

            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A {szam} osztói: ");

            for(int i = 1; i<=szam; i++)
            {
                if (szam%i==0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.ReadKey();
        }
    }
}

