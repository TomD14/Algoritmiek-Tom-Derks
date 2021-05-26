using System;
using System.Collections.Generic;
using System.Text;

namespace Circus_trein
{
    public class PrintFunctie
    {
        public void PrintWagon(List<Dier> WagonDieren, int MaxGewicht, int TotaalGewicht)
        {
            Console.WriteLine("	    o			    ");
            Console.WriteLine("	    o			    ");
            Console.WriteLine("========= ooooo =========");
            foreach (Dier dier in WagonDieren)
            {
                Console.WriteLine($"==		       ==");
                Console.WriteLine($"{dier.Grootte} {dier.Dieet}");

            }
            Console.WriteLine($"({MaxGewicht - TotaalGewicht})");
            Console.WriteLine($"========= ooooo =========");
        }
    }
}
