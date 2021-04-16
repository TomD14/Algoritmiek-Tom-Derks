using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindroom
{
    class Program
    {


        static void Main(string[] args)
        {
            int getalX = 999;
            int getalY = 999;
            int antwoord = 0;

            List<int> palindroom = new List<int>();

            for (int i = getalX; i >= 100; i--)
            {
                for (int j = getalY; j >= 100; j--)
                {
                    antwoord = getalX * j;

                    if (isPalindrome(antwoord.ToString()))
                    {
                        palindroom.Add(antwoord);
                    }
                }
                getalX--;
            }

            int max = palindroom[0];
            foreach (int i in palindroom)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            Console.WriteLine(max);
            Console.ReadKey();

        }

        static bool isPalindrome(string nmr)
        {
            int z = 0;
            int x = 0;
            int y = 0;

            if (nmr.Length % 2 != 0)
            {
                z = nmr.Length / 2;
                x = z;
                y = z;

                for (int i = z; y < nmr.Length - 1; i++)
                {
                    x--;
                    y++;
                    if (nmr[x] != nmr[y]) return false;
                }
            }

            else
            {
                y = nmr.Length / 2;
                x = (nmr.Length / 2) - 1;

                for (int i = y; i < nmr.Length; i++)
                {
                    if (nmr[x] != nmr[y]) return false;
                    else
                    {
                        x--;
                        y++;
                    }
                }
            }

            return true;



        }

    }
}