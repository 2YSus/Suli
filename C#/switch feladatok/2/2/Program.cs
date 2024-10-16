using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a kívánt hónap sorszámát.");
            Console.WriteLine("A hónapp sorszáma: ");
            int szam = int.Parse(Console.ReadLine());

            switch (szam)
            {
                case 1:
                    Console.WriteLine("Január, Tél");
                    break;

                case 2:
                    Console.WriteLine("Február, Tél");
                    break;

                case 3:
                    Console.WriteLine("Március, Tavasz");
                    break;

                case 4:
                    Console.WriteLine("Április, Tavasz");
                    break;

                case 5:
                    Console.WriteLine("Május, Tavasz");
                    break;

                case 6:
                    Console.WriteLine("Június, Nyár");
                    break;

                case 7:
                    Console.WriteLine("Július, Nyár");
                    break;

                case 8:
                    Console.WriteLine("Augusztus, Nyár");
                    break;

                case 9:
                    Console.WriteLine("Szeptember, Ősz");
                    break;

                case 10:
                    Console.WriteLine("Október, Ősz");
                    break;

                case 11:
                    Console.WriteLine("November, Ősz");
                    break;

                case 12:
                    Console.WriteLine("December, Tél");
                    break;

                default:
                    Console.WriteLine("Ilyen sorszámú hónap nem létezik.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
