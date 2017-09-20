using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josies_Cat_Garden
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("Catnip ");
                    }

                    else
                    {
                        Console.Write("Mint ");
                    }
                }
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
