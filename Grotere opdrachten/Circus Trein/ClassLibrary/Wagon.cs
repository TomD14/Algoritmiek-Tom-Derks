using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circus_trein;

namespace Circus_trein
{
    public class Wagon
    {
        public List<Dier> WagonDieren { get; set; } = new List<Dier>();

        public int TotaalGewicht { get; set; }

        public readonly int MaxGewicht = 10;

        public bool DierToevoeging(Dier toevoegDier)
        {
            if (WagonDieren.Count >= 1)
            {

                foreach (Dier dieren in WagonDieren)
                {
                    if (dieren.EetAnderen(toevoegDier) != true && toevoegDier.EetAnderen(dieren) != true && toevoegDier.Gewicht + TotaalGewicht <= MaxGewicht)
                    {
                        WagonDieren.Add(toevoegDier);
                        TotaalGewicht += toevoegDier.Gewicht;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            else if(WagonDieren.Count == 0)
            {
                WagonDieren.Add(toevoegDier);
                TotaalGewicht += toevoegDier.Gewicht;
                return true;
            }
            return false;

        }
    }
}

        //public List<Dier> DierToevoegen(List<Dier> dieren)
        //{
        //    int i = 0;
        //    Vol = false;

        //    while (!Vol)
        //    {
        //        if (i >= dieren.Count)
        //        {
        //            Vol = true;
        //            break;
        //        }

        //        Dier dier = dieren[i];

        //        if (!dier.WordGegeten(WagonDieren) && !dier.EetAnderen(WagonDieren) && TotaalGewicht + dier.Gewicht <= MaxGewicht)
        //        {
        //            WagonDieren.Add(dier);
        //            TotaalGewicht += dier.Gewicht;
        //            dieren.Remove(dier);
        //            i = 0;
        //        }
        //        else if(TotaalGewicht + dier.Gewicht > MaxGewicht && i >= dieren.Count)
        //        {
        //            Vol = true;
        //        }
        //        else
        //        {
        //            i++;
        //        }
        //    }
            //Console.WriteLine("	    o			    ");
            //Console.WriteLine("	    o			    ");
            //Console.WriteLine("========= ooooo =========");
            //foreach (Dier dier in WagonDieren)
            //{
            //    Console.WriteLine($"==		       ==");
            //    Console.WriteLine($"{dier.Grootte} {dier.Dieet}");

            //}
            //Console.WriteLine($"({MaxGewicht - TotaalGewicht})");
            //Console.WriteLine($"========= ooooo =========");
            //return dieren;
        

    

