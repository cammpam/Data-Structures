using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList lnklist = new LinkedList();
            Console.WriteLine();

            lnklist.AddAtLast("Cam");
            lnklist.AddAtLast("Keeps");
            lnklist.AddAtLast("It");
            lnklist.AddAtLast("Over");
            lnklist.AddAtLast(100);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.Read();

        }

    }
}
