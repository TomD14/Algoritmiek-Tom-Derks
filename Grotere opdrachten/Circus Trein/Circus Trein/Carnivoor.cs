using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circus_Trein;

namespace Circus_Trein
{
    public class Carnivoor : Dier
    {
        public Carnivoor(Groottes grootte) : base(grootte)
        {
            Dieet = DieetSoorten.Carnivoor;
        }
    }
}
