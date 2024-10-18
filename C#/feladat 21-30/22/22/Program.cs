using System;

namespace huszonkettedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy egész számot!");
            Console.Write("Szám: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double ker_szam = Math.Round(Math.Pow(Math.Round(Math.Sqrt(N)), 2));
            Console.WriteLine("A(z) {0}-hez legközelebb eső négyzetszám: {1}", N, ker_szam);
        }
    }
}