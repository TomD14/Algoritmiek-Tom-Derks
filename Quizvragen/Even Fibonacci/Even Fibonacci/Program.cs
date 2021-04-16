using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
            long getalX = 2;
            long getalY = 0;
            long GetalZ = 2;
            long totaal = 0;

            while (GetalZ < 4000000)
            {
                totaal += GetalZ;

                GetalZ = 4 * getalX + getalY;
                getalY = getalX;
                getalX = GetalZ;


            }
            Console.WriteLine(totaal);
            Console.ReadKey();
        }
    }
}