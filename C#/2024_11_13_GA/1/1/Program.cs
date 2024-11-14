using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("olvass be egy számot döntsd el hogy a szám pozitív negatív vagy nulla");
                Console.Write("A szám: ");
                int szam = int.Parse(Console.ReadLine());


                if(szam < 0)
                {
                    Console.WriteLine("A szám negatív");
                }
                else if (szam > 1)
                {
                    Console.WriteLine("A szám pozitív");
                }
                else
                {
                    Console.WriteLine("A szám nulla");
                }
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }
            catch(OverflowException)
            {
                Console.WriteLine("A szám túl nagy");
            }
            finally
            {
                Console.WriteLine("------------\nProgram lefutott");
            }
            Console.ReadKey();
        }
    }
}
