using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public class Dier : IEdible
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

        public override string ToString()
        {
            return $"Animal values = (Size: {Grootte}, Diet: {Dieet})";
        }

        public bool EetAnderen(IEnumerable<Dier> andereDieren)
        {
            if (andereDieren == null || this.Dieet == DieetSoorten.Herbivoor)
            {
                return false;
            }

            foreach (Dier anderDier in andereDieren)
            {
                if (anderDier != this)
                {
                    if (anderDier.Dieet == DieetSoorten.Herbivoor && anderDier.Gewicht <= this.Gewicht ||
                        anderDier.Dieet == DieetSoorten.Carnivoor && anderDier.Gewicht <= this.Gewicht)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool WordGegeten(IEnumerable<Dier> andereDieren)
        {
            if (andereDieren == null)
            {
                return false;
            }

            foreach (Dier anderDier in andereDieren)
            {
                if (anderDier != this)
                {
                    if (anderDier.Dieet == DieetSoorten.Herbivoor && this.Dieet == DieetSoorten.Carnivoor ||
                        anderDier.Dieet == DieetSoorten.Herbivoor && this.Dieet == DieetSoorten.Herbivoor)
                    {
                        return false;
                    }
                    else if (anderDier.Dieet == DieetSoorten.Carnivoor && this.Dieet == DieetSoorten.Herbivoor && anderDier.Gewicht >= this.Gewicht ||
                        anderDier.Dieet == DieetSoorten.Carnivoor && anderDier.Gewicht >= this.Gewicht && this.Dieet == DieetSoorten.Carnivoor ||
                        anderDier.Dieet == DieetSoorten.Carnivoor && anderDier.Gewicht == this.Gewicht)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
