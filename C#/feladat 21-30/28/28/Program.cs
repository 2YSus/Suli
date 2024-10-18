using System;

namespace huszonnyolcadik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adj meg két számot!");
            Console.Write("Első szám: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A {0} nagyobb, szám mint {1}", a, b);
            }
            if (a < b)
            {
                Console.WriteLine("A {0} nagyobb, szám mint {1}", b, a);
            }
            else
            {
                Console.WriteLine("Egyenlők");
            }
        }
    }
}