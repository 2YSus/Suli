namespace harmadik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a téglalap oldalait!");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int K = 2 * (a + b);
            int T = a * b;
            double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("A téglalap kerülete: {0}", K);
            Console.WriteLine("A téglalap területe: {0}", T);
            Console.WriteLine("A téglalap átmérője: {0}", d);
        }
    }
}