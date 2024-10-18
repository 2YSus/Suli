using System;
using System.Runtime.ConstrainedExecution;

namespace huszonotodik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek adj meg egy számot!");
            Console.Write("Első szám: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Az összehasonlítás eredménye: Az első szám a nagyobb");
            }
            else if (b > a)
            {
                Console.WriteLine("Az összehasonlítás eredménye: A második szám a nagyobb");
            }
            else
            {
                Console.WriteLine("Az összehasonlítás eredménye: A Két szám egyenéő");
            }
        }
    }
}