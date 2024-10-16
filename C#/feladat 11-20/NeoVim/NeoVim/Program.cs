using System;
using System.IO;

namespace NeoVim
{
    class Vimming
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Döntse el hogy mit szeretne\n\n1. Fájl létrehozása.\n2. Fájl olvasása\n3. Fájl hozzáadása\n4. Fájl törlése\n5. Fájl vagy könyvtár létezésének ellenörzése.");
            int valasztas = int.Parse(Console.ReadLine());

            switch(valasztas)
            {
                case 1:
                    FajlLetrahozas();
                    break;

                case 2:
                    FajlOlvasasa();
                    break;

                
            }
            static void FajlLetrahozas()
            {
                Console.Write("Add meg a fájl nevét (Pl.: raaaaaawr.txt)");
                string FajlNev = Console.ReadLine();
            }
            static void FajlOlvasasa()
            {
                Console.WriteLine();
            }
        }
    }
}
