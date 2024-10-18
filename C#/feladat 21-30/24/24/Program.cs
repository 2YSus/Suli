using System;

namespace huszonnegyedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem add meg az első szög adatait!");
            Console.Write("Fok1: ");
            int fok1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("szperc1: ");
            int szperc1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("szmp1: ");
            int szmp1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kérem add meg a második szög adatait!");
            int fok2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("szperc2: ");
            int szperc2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("szmp2: ");
            int szmp2 = Convert.ToInt32(Console.ReadLine());

            int szog1 = fok1 * 3600 + szperc1 * 60 + szmp1;
            int szog2 = fok2 * 3600 + szperc2 * 60 + szmp2;
            int osszeg = szog1 + szog2;

            int ofok = osszeg / 3600;
            int Osszeg = osszeg - ofok * 3600;
            int oszperc = Osszeg / 60;
            int oszmp = Osszeg - oszperc * 60;

            Console.WriteLine("A két szög összege: {0} fok {1} szögperc {2} szögmásodőerc", ofok, oszperc, oszmp);
        }
    }
}