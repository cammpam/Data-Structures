using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class LinkList
    {       
            public Node head = new Node(null);

            public Node tailSearch()
            {
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                return current;
            }

            public void PrintList()
            {
                if (head == null)
                {
                    Console.WriteLine("This is empty!");
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                        Console.Write($"{current.Data} =>=> ");
                    }
                }
            }     
    }
}
