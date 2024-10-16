using System;

namespace tizenhetedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az időt másodpercekben");
            Console.Write("Idő mp-ben: ");
            int ido = Convert.ToInt32(Console.ReadLine());
            int ora = ido / 3600;
            int perc = ido / 60 % 60;
            int mp = ido % 60;
            Console.WriteLine("A megadott idő átalakítva: {0}-óra {1}-perc {2}-mp", ora, perc, mp);
        }
    }
}