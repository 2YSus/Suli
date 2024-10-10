using System;

namespace otodik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a kör sugarát!");
            Console.Write("a: ");
            double r = Convert.ToInt32(Console.ReadLine());
            double K = 2 * r * Math.PI;
            double T = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("A kör kerülete: {0}", K);
            Console.WriteLine("A kör területe: {0}", T);
        }
    }
}