using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    abstract class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void View()
        {
            Node runner = Head;
            string output = "null <=<= ";
            while (runner.Next != null)
            {
                output += runner.Data + " =>=> ";
                runner = runner.Next;
            }
            output += runner.Data + " =>=> null";
            Console.WriteLine(output);
        }
    }
}

