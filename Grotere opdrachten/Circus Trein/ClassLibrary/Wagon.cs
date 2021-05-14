using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_trein
{
    public class Wagon
    {
        public List<Dier> WagonDieren { get; set; } = new List<Dier>();

        public int TotaalGewicht { get; set; }

        public int MaxGewicht { get; set; }

        private bool Vol;


        public Wagon(int maxGewicht = 10)
        {
            this.MaxGewicht = maxGewicht;
        }

        public List<Dier> DierToevoegen(List<Dier> dieren)
        {
            Random rand = new Random();
            int i = 0;
            Vol = false;

            while (!Vol)
            {
                if (i >= dieren.Count)
                {
                    Vol = true;
                    break;
                }

                Dier dier = dieren[i];

                if (!dier.WordGegeten(WagonDieren) && !dier.EetAnderen(WagonDieren) && TotaalGewicht + dier.Gewicht <= MaxGewicht)
                {
                    WagonDieren.Add(dier);
                    TotaalGewicht += dier.Gewicht;
                    dieren.Remove(dier);
                    i = 0;
                }
                else if(TotaalGewicht + dier.Gewicht > MaxGewicht && i >= dieren.Count)
                {
                    Vol = true;
                }
                else
                {
                    i++;
                }
            }

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
            return dieren;
        }

    }
}
