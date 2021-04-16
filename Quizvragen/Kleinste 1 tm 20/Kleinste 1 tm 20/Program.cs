using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kleinste_1_tm_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int getalX = 1;
            int getalY = 20;

            while (getalY > 1)
            {
                if (getalX % getalY != 0)
                {
                    getalX++;
                    getalY = 20;
                }
                else
                {
                    getalY--;
                }
            }
            Console.WriteLine(getalX);
            Console.ReadKey();
        }
    }
}
