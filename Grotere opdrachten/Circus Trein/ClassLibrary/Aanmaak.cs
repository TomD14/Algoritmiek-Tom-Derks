using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Circus_trein
{
    public class Aanmaak
    {

        public List<Dier> MaakDier(int Aantal, int CarnivoorKans)
        {
            List<Dier> dieren = new List<Dier>();
            Random rand = new Random();
            Aantal += -1;

            var maximumGrootte = Enum.GetValues(typeof(Dier.Groottes));

            for (int i = 0; i <= Aantal; i++)
            {
                int randWaarde = rand.Next(1, 10);

                if(randWaarde <= CarnivoorKans)
                {
                    dieren.Add(new Carnivoor((Dier.Groottes)rand.Next(0, maximumGrootte.Length)));
                }
                else
                {
                    dieren.Add(new Herbivoor((Dier.Groottes)rand.Next(0, maximumGrootte.Length)));
                }
            }

            return dieren;
        }

    }
}
