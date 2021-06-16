using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_trein
{
    public class Carnivoor : Dier
    {
        public Carnivoor(Groottes grootte) : base(grootte)
        {
            Dieet = DieetSoorten.Carnivoor;
        }

        public override bool EetAnderen(Dier anderDier)
        {
                    if (this.EetAnder(anderDier) /*|| anderDier.EetAnderen(this)*/)
                    {
                        return true;
                    }           
 
            return false;
        }

        private bool EetAnder(Dier d)
        {
            return d.Gewicht <= this.Gewicht;
        }
    }
}
