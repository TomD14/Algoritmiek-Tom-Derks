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

            List<Dier> dieren = aanmaak.MaakDier(20, 3);
            Trein trein = new Trein(dieren, 10);
            System.Console.ReadKey();
        }
    }
}
