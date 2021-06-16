using Circus_trein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Aanmaak aanmaak = new Aanmaak();
            PrintFunctie printFunctie = new PrintFunctie();
            Trein trein = new Trein();

            List<Dier> dieren = aanmaak.MaakDier(20, 7);
            List<Wagon> Wagons = trein.TreinCreatie(dieren);

            foreach (Wagon wagon in Wagons)
            {
                printFunctie.PrintWagon(wagon.WagonDieren, wagon.MaxGewicht, wagon.TotaalGewicht);
            }

            System.Console.ReadKey();
        }
    }
}
