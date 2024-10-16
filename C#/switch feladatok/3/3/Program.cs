using System;

namespace rawr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg Kétmilliárdig egy számot.");
            Console.Write("Szám:");

            int szam = int.Parse(Console.ReadLine());
            int szamhossz = szam.ToString().Length;

            switch(szam)
            {
                case 1:
                    Console.WriteLine("A megadott szám egy számjegyből áll");
                    break;

                case 2:
                    Console.WriteLine("A megadott szám kettő számjegyből áll.");
                    break;

                case 3:
                    Console.WriteLine("A megadott szám három számjegyből áll");
                    break;

                case 4:
                    Console.WriteLine("A megadott szám négy számjegyből áll");
                    break;

                case 5:
                    Console.WriteLine("A megadott szám öt számjegyből áll");
                    break;

                case 6:
                    Console.WriteLine("A megadott szám hat számjegyből áll");
                    break;

                case 7:
                    Console.WriteLine("A megadott szám 6 vagy több számjegyből áll");
                    break;

                default:
                    Console.WriteLine("Nem adott meg számot");
                    break;
            }
        }
    }
}
