using System;

namespace huszonkilencedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek adj meg 4 számot");
            Console.Write("Első szám: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harmadik szám: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Negyedik szám: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int legnagyobb = a;
            if (legnagyobb < b)
            {
                legnagyobb = b;
            }
            if (legnagyobb < c)
            {
                legnagyobb = c;
            }
            if (legnagyobb < d)
            {
                legnagyobb = d;
            }
            Console.WriteLine("A négy szám közül a(z) {0} a legnagyobb", legnagyobb);
        }
    }
}