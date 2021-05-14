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
    }
}
