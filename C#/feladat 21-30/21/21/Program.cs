using System;

namespace huszonegyedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy egész számot");
            Console.Write("Szám: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double ker_szam = Math.Floor(Math.Pow(Math.Floor(Math.Sqrt(N - 1)), 2));
            Console.WriteLine("A legközelebb eső {0}-nél kisebb szám, amely négyzetszám: {1}", N, ker_szam);
        }
    }
}