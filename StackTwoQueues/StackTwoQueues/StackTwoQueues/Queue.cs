using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTwoQueues
{
    class Queue
    {
        public Stack StkOne { get; set; }
        public Stack StkTwo { get; set; }

        public Queue(int data)
        {
            StkOne = new Stack(data);
            StkTwo = new Stack();
        }

        public void Enqueue(int data)
        {
            StkOne.Push(data);
        }

        public Node Dequeue()
        {
            while (StkOne.Head != null)
            {
                StkTwo.Push(StkOne.Pop().Data);
            }
            Node temp = StkTwo.Pop();
            while (StkTwo.Head != null)
            {
                StkOne.Push(StkTwo.Pop().Data);
            }
            return temp;
        }
    }
}
