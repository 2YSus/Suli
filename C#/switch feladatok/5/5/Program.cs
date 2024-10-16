using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Az osztályzat: ");
            int osztalyzat = int.Parse(Console.ReadLine());

            switch(osztalyzat)
            {
                case 1:
                    Console.WriteLine("A tanuló sajnos megbukott");
                    break;

                case 2:
                    Console.WriteLine("A tanuló elégséges");
                    break;

                case 3:
                    Console.WriteLine("A tanuló közepes");
                    break;

                case 4:
                    Console.WriteLine("A tanuló jó");
                    break;

                case 5:
                    Console.WriteLine("A tanuló jeles");
                    break;

                default:
                    Console.WriteLine("Nem létező osztályzatot adott meg.");
                    break;

            }
        }
    }
}
