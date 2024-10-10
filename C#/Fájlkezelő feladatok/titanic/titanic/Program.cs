using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "titanic.txt";

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Add meg a(z) {i}. diák nevét: ");
                string nev = Console.ReadLine();

                Console.Write($"Add meg a(z) {i}. diák jegyét: ");
                int jegy;
                while (!int.TryParse(Console.ReadLine(), out jegy) || jegy < 1 || jegy > 5)
                {
                    Console.WriteLine("Hibás bemenet! A jegy 1 és 5 közötti szám legyen.");
                    Console.Write("Add meg újra a jegyet: ");
                }

                // Írás a fájlba
                writer.WriteLine($"Diák neve: {nev}, Jegye: {jegy}");
            }
        }

        Console.WriteLine("\nA fájl tartalma:");
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}