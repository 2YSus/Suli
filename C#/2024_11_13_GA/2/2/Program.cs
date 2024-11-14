using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj egy programot amely meghatározza a kocka felszinét és térfogatát 6a négyzet a a köbön");
            try
            {
                Console.Write("A négyzet oldala: ");
                int oldal = int.Parse(Console.ReadLine());

                int felszin = 6*(oldal * oldal);
                double terfogat = Math.Pow(oldal*oldal, 3);

                Console.WriteLine($"A kocka felszíne: {felszin}");
                Console.WriteLine($"A kocka térfogata: {terfogat}");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Hiba: ex.Message");
            }
            catch(OverflowException)
            {
                Console.WriteLine("A szám túl nagy");
            }
            finally
            {
                Console.WriteLine("----------------\nA program lefutott");
            }
            Console.ReadKey();
        }
    }
}
