﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circus_trein;

namespace Circus_trein
{
    class Program
    {
        static void Main(string[] args)
        {
            Aanmaak aanmaak = new Aanmaak();

            List<Dier> dieren = aanmaak.MaakDier(20, 3);
            Trein trein = new Trein(dieren, 10);

            Console.ReadLine();
        }
    }
}
