using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preim_Getallen
{
    class Program
    {
        static void Main(string[] args)
        {
            const long hoofdgetal = 600851475143;
            long getalX = hoofdgetal;
            long Factor = 0;

            int i = 2;
            while (i * i <= getalX)
            {
                if (getalX % i == 0)
                {
                    getalX = getalX / i;
                    Factor = i;
                }
                else
                {
                    i++;
                }
            }
            if (getalX > Factor)
            {
                Factor = getalX;
            }
            Console.WriteLine(Factor);
            Console.ReadKey();
        }
    }
}
