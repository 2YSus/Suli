using System;
using System.IO;
using System.Collections.Generic;

namespace titanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileNev = @"Z:\Suli\C#\Adrian\titanic.txt";
            List<AdatSzerkezet> beolvasottAdatok = new List<AdatSzerkezet>();

            using (StreamReader olvaso = File.OpenText(fileNev))
            {
                string sor;
                while ((sor = olvaso.ReadLine()) != null)
                {
                    var elemek = sor.Split(";");
                    string kategoria = elemek[0].Trim();
                    if (elemek.Length == 3)
                    {

                        if (int.TryParse(elemek[1].Trim(), out int szam1) && int.TryParse(elemek[2].Trim(), out int szam2))
                        {
                            beolvasottAdatok.Add(new AdatSzerkezet
                            {
                                Kategoria = kategoria,
                                Szam1 = szam1,
                                Szam2 = szam2
                            });
                        }
                        else
                        {
                            Console.WriteLine($"Hiba a sorban: {sor}. Ellenőrizd hibákért.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Hiba a sor formátumában: {sor}");
                    }
                }
            }

            Console.WriteLine("A beolvasott adatok:");
            foreach (var adat in beolvasottAdatok)
            {
                Console.WriteLine($"Kategória: {adat.Kategoria}, Szám1: {adat.Szam1}, Szám2: {adat.Szam2}");
            }

            Console.ReadKey();
        }
    }

    public class AdatSzerkezet
    {
        public string Kategoria { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
    }
}