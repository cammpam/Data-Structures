using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class Queues : LinkList
    {
        public void Enqueue(object data)
        {
            tailSearch().Next = new Node(data);
        }

        
        public void Dequeue()
        {
            if (head.Next == null)
            {
                Console.WriteLine("Sorry the Queue is empty!");
            }
            else
            {
                head.Next = head.Next.Next;
            }
        }
    }
}
