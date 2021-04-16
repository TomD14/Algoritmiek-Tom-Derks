using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    class Trein
    {
        public List<Dier> Dieren { get; set; } = new List<Dier>();

        public int Totaalgewicht { get; set; }

        public List<Wagon> Wagons { get; set; } = new List<Wagon>();

        public Trein(List<Dier> dieren, int totaalgewicht)
        {
            this.Totaalgewicht = totaalgewicht;
            this.Dieren = dieren;
            WagonLaden();
        }

        public void WagonLaden()
        {
            int i = 0;

            while(Dieren.Count != 0)
            {
                Wagons.Add(new Wagon(Totaalgewicht));
                Dieren = Wagons[i].DierToevoegen(Dieren);
                i++;
            }
        }
    }
}
