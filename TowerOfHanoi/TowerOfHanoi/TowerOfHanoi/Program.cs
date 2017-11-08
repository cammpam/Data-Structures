using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of disks:");
            Console.WriteLine();
            int values = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"For {values} disks, make the following moves:");
            Tower(values, 1, 3);
            int moves = Convert.ToInt32(Math.Pow(2, values) - 1);
            Console.WriteLine();
            Console.WriteLine($"This took {moves} moves.");
            Console.Read();
        }

        // moves q and their values, one at a time, from one stack to another stack
        public static void Tower(int q, int StackNext, int StackPrev)
        {
            int holdingStack;

            if (q == 1)
            {
                Console.WriteLine($"{StackNext} -> {StackPrev}");
            }
            else
            {

                holdingStack = 6 - (StackNext + StackPrev);

                // Move q values to holding stack execpt largest value 
                Tower(q - 1, StackNext, holdingStack);

                // Move largest value to destination stack
                Console.WriteLine($"{StackNext} -> {StackPrev}");

                // Move disks from helpStack to destination
                Tower(q - 1, holdingStack, StackPrev);
            }
        }
    }
}
