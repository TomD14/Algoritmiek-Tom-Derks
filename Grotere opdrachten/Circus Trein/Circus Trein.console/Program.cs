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

            List<Dier> dieren = aanmaak.MaakDier(20, 2);

            Trein trein = new Trein(dieren);

            foreach (Wagon wagon in trein.Wagons)
            {
                printFunctie.PrintWagon(wagon.WagonDieren, wagon.MaxGewicht, wagon.TotaalGewicht);
            }

            System.Console.ReadKey();
        }
    }
}
