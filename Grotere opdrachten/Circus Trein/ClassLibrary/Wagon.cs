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
            else if (WagonDieren.Count == 0 && toevoegDier != null)
            {
                WagonDieren.Add(toevoegDier);
                TotaalGewicht += toevoegDier.Gewicht;
                return true;
            }
            return true;

        }
    }
}

    

