using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Middle_LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node current;

        // Keeps track of # of nodes
        public int Count;
         
        // This is a constructor
        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        public void PrintAllNodes()
        {
            Console.Write("HEAD =>>");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" =>> ");
            }
            Console.Write("TAIL NULL");
        }

        public void NthFromEnd(int n)
        {
            Node second = head;
            Node current = head;

            for (int i = 0; i < n - 1; i++)
            {
                if (current != null)
                {
                    current = current.Next;
                }
                else
                {
                    Console.WriteLine("null");   //if n is bigger than list length
                }
            }
            while (current.Next != null)
            {
                current = current.Next;
                second = second.Next;
            }
            Console.WriteLine(second.Value);
        }

        public void deleteNode(int position)
        {
            if (head == null)
            {
                return;
            }

            Node temp = head;

            if (position == 0)
            {
                head = temp.Next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null || temp.Next == null)
            {
                return;
            }

            Node next = temp.Next.Next;
              `   
            temp.Next = next;
        }

    }

}

