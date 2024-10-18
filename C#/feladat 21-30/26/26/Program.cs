using System;

namespace huszonhatodik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek két egész számot!");
            Console.Write("Első szám: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("A két szám egyenlő");
            }
            else
            {
                Console.WriteLine("A két szám nem egyenlő!");
            }
        }
    }
}