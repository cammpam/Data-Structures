using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTwoQueues
{
    abstract class LinkedList
    {
        public Node Tail { get; set; }
        public Node Head { get; set; }

        public void View()
        {
            Node pointer = Head;
            string output = "Head => ";
            while (pointer.Next != null)
            {
                output += pointer.Data + " - ";
                pointer = pointer.Next;
            }
            output += pointer.Data + " => null";
            Console.WriteLine(output);
        }
    }
}
