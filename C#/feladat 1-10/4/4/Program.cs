using System;

namespace Negyedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a négyzet oldalát!");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int K = 4 * a;
            double T = Math.Pow(a, 2);
            double d = a * Math.Sqrt(2);
            Console.WriteLine("A négyzet kerülete: {0}", K);
            Console.WriteLine("A négyzet területe: {0}", T);
            Console.WriteLine("A négyzet átlója: {0}", Math.Round(d, 2));
        }
    }
}