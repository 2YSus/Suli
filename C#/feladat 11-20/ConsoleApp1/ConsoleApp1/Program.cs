using System;

namespace tinenyolcadik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg a vonat indulásának idejét óra/percben");
            Console.Write("Indulás ideje órában: ");
            int ora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indulás ideje percben: ");
            int perc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg meddig tartott az út percben");
            Console.Write("Utazási ido: ");
            int ut_ido = Convert.ToInt32(Console.ReadLine());
            int indulas = ora * 60 + perc;
            int erkezes = indulas + ut_ido;
            int erk_ora = erkezes / 60 % 24;
            int erk_perc = erkezes % 60;
            Console.WriteLine("A vonat, {0}:{1} perckor érkezett az állomásra", erk_ora, erk_perc);
        }
    }
}