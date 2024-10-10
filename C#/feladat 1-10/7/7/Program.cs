using System;

namespace hatodik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a háromszög oldalainak méretét!");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                int K = a + b + c;
                int s = K / 2;
                double T = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("A háromszög kerülete: {0} cm", K);
                Console.WriteLine("A háromszög területe: {0} cm", T);
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető háromszög a megadott adatokból");
            }
        }
    }
}