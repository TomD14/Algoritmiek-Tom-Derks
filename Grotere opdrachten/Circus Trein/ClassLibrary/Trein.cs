using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circus_trein;

namespace Circus_trein
{
    public class Trein
    {
        public List<Dier> Dieren { get; set; } = new List<Dier>();

        public int TotaalGewicht { get; set; }

        public List<Wagon> Wagons { get; set; } = new List<Wagon>();

        public List<Wagon> TreinT(List<Dier> dieren)
        {
            this.Dieren = dieren;
            WagonLaden();
            return (Wagons);
        }

        public void WagonLaden()
        {
            int x = 0;
            int y = 0;
            Wagons.Add(new Wagon());

            while(Dieren.Count != 0)
            {
                if (y >= Dieren.Count || Wagons[x].TotaalGewicht == Wagons[x].MaxGewicht)
                {
                    Wagons.Add(new Wagon());
                    x++;
                    y = 0;
                }

                else if (Wagons[x].DierToevoeging(Dieren[y]) == true)
                {
                    Dieren.RemoveAt(y);
                }

                else
                {
                    y++;
                }
            }
        }

        
    }
}
