using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public class Herbivoor : Dier
    {
        public Herbivoor(Groottes grootte) : base(grootte)
        {
            Dieet = DieetSoorten.Herbivoor;
        }
    }
}
