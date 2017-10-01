using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack:");
            Stack testS = new Stack();
            testS.Push("1");
            testS.Push("2");
            testS.Push("3");
            testS.Push("4");
            testS.Push("5");
            testS.Push("6");
            testS.Push("7");
            testS.Push("8");
            testS.Push("9");
   

            testS.SortPush("");

            Console.Read();
        }
    }
}
