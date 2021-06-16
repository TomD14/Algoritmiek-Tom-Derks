using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_trein
{
    public class Herbivoor : Dier
    {
        public Herbivoor(Groottes grootte) : base(grootte)
        {
            Dieet = DieetSoorten.Herbivoor;
        }

        public override bool EetAnderen(Dier dier)
        {
            return false;
        }
    }
}
