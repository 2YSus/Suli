using System;
using System.Runtime.InteropServices;

namespace huszonhetedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adj meg két számot");
            Console.Write("Első szám: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A nagyobb szám: {0}", a);
            }
            else
            {
                Console.WriteLine("A nagyobb szám: {0}", b);
            }
        }
    }
}