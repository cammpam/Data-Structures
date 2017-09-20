using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {          
            string input, output = "";
            Console.WriteLine("Whats your Word? ");
            input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine("Your word Reverse: {0}", output);
            Restart();
            Console.ReadLine();

        }
        static void Restart()
        {
            Console.WriteLine("Restart Y/N");
            string input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                Main();
            }
            if (input == "N" || input == "n")
            {
                Console.WriteLine("Thank You. Come Again!");
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("Enter Y/y or N/n. Thank you.");
                    Restart();
            }


            

        }
         
    }
}
