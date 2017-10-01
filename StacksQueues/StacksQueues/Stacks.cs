using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class Stacks : LinkList
    {
        public void Push(object thisData)
        {
            Node toPush = new Node(thisData);

            FindTail().Next = toPush;
        }
      
        public void Pop()
        {
            Node current = head;

            if (current.Next == null)
            {
                Console.WriteLine("No Queue");
            }
            else if (current.Next.Next == null)
            {
                current.Next = null;
            }
            else
            {
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }
    }
}
