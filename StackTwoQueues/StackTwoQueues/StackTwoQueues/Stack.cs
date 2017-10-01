using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTwoQueues
{
    class Stack : LinkedList
    {
        public Stack(int data)
        {
            Head = new Node(data);
            Tail = Head;
        }

        public Stack()
        {
            Head = null;
            Tail = null;
        }

        public void Push(int data)
        {
            Node temporary = Head;
            Head = new Node(data) { Next = temporary };
        }

        public Node Pop()
        {
            if (Head == Tail) { Tail = null; }
            Node temporary = Head.Next;
            Head.Next = null;
            Node value = Head;
            Head = temporary;
            return value;
        }
    }
}
