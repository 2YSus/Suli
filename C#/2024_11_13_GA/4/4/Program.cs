using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj egy programot amely egy általad bekért zárt intervalumban kiírja az összes hárommal osztható számot");

            try
            {
                Console.Write("A szám: ");
                int szam = int.Parse(Console.ReadLine());

                switch(szam)
                {
                    case 1:
                        Console.WriteLine("A tanuló megbukott");
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
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }
            catch(OverflowException)
            {
                Console.WriteLine("A megadottszám túl nagy");
            }
            finally
            {
                    Console.WriteLine("A program lefutott");
            }
            Console.ReadKey();
        }
    }
}
