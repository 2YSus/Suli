using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj programot amely egy általad bekért zárt intervalumban kiírja az összes hárommal osztható számot.");
            try
            {
                Console.Write("Az alsó szám: ");
                int also = int.Parse(Console.ReadLine());
                Console.Write("Az felső szám: ");
                int felso = int.Parse(Console.ReadLine());

                if (Math.Min(also, felso) == also || Math.Max(also, felso) == felso)
                {
                    for (int i = also; i <= felso; i++)
                    {
                        if (i % 3 == 0)
                        {
                            Console.Write($"{i} ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Rossz sorrendeben adta meg a számokat");
                }
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Túl nagy szám");
            }
            finally
            {
                Console.WriteLine("A program lefutott");
            }
            Console.ReadKey();
        }
    }
}
