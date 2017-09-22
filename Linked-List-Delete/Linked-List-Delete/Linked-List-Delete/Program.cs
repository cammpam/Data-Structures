using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList lnklist = new LinkedList();
            Console.WriteLine();

            lnklist.AddAtLast("1");
            lnklist.AddAtLast("2");
            lnklist.AddAtLast("3");
            lnklist.AddAtLast("4");
            lnklist.AddAtLast("5");
            lnklist.PrintAllNodes();
            Console.WriteLine();
            Console.WriteLine("Please type a number to find n");
            lnklist.deleteNode(Convert.ToInt32(Console.ReadLine()));
            lnklist.PrintAllNodes();
            Console.WriteLine();
            Console.Read();

        }

    }

}
