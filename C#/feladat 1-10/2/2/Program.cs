using System;
using System.Xml.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek két egész számot");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int hanyados = a / b;
            int maradek = a % b;
            string eredmeny = String.Format("Az egész rész: {0}, a maradék: {1}", hanyados, maradek);
            Console.WriteLine(eredmeny);
        }
    }
}