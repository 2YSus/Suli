using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány elemű legyen a tömb?");
            Console.Write("Szám= ");
            int n = int.Parse(Console.ReadLine());

            int[] szamok = new int[n];
            int Patlag = 0; int DBpoz = 0;
            int Natlag = 0; int DBneg = 0;

            for(int i = 0; i<n; i++)
            {
                Console.WriteLine($"{i} elem");
                szamok[i]= int.Parse(Console.ReadLine());

                if (szamok[i]<0)
                {

                }
            }
        }
    }
}
