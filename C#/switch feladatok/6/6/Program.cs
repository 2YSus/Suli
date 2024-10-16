using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Az osztályzat: ");
            int osztalyzat = int.Parse(Console.ReadLine());

            switch (osztalyzat)
            {
                case 1:
                    Console.WriteLine("bukó");
                    break;

                case 2:
                    Console.WriteLine("elégséges");
                    break;

                case 3:
                    Console.WriteLine("közepes");
                    break;

                case 4:
                    Console.WriteLine("jó");
                    break;

                case 5:
                    Console.WriteLine("jeles");
                    break;

                default:
                    Console.WriteLine("Nem létező osztályzatot adott meg.");
                    break;

            }
        }
    }
}
