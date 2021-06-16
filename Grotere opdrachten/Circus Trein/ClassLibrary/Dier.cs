using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_trein
{
    public abstract class Dier
    {
        public Groottes Grootte { get; set; }
        public enum Groottes{Klein,Gemiddeld,Groot};

        public DieetSoorten Dieet { get; set; }
        public enum DieetSoorten{Carnivoor,Herbivoor};

        public int Gewicht { get; set; }

        public Dier(Groottes grootte)
        {
            this.Grootte = grootte;

            switch (Grootte)
            {
                case Groottes.Klein:
                    this.Gewicht = 1;
                    break;
                case Groottes.Gemiddeld:
                    this.Gewicht = 3;
                    break;
                case Groottes.Groot:
                    this.Gewicht = 5;
                    break;
                default:
                    break;
            }
        }

        public abstract bool EetAnderen(Dier anderDier);
    }
}
