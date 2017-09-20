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
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            Console.WriteLine(slow.Value);
        }

    }
}
