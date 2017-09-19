using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
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
    }

}
