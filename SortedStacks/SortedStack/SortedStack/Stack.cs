using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedStack
{
    class Stack
    {
        public Node head;
        public Node tail;
        public int length;

        public object Push(object data)
        {
            Node Add = new Node
            {
                Data = data
            };

            if (head == null)
            {
                head = Add;
                tail = head;
                Console.WriteLine($"Head: {head.Data}  Tail: {tail.Data}");
            }
            else
            {
                tail.Next = Add;
                Add.Prev = tail;
                tail = Add;
                Console.WriteLine($"Pushed Nodes: {tail.Data}");
            }
            length++;
            return Add.Data;

        }

        public object Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Stack.");
                return null;
            }

            Node delete = tail;

            if (tail.Prev == null)
            {
                head = null;
                return delete.Data;
            }

            tail = delete.Prev;
            tail.Next = null;

            Console.WriteLine($"Popped Nodes: {delete.Data}");
            length--;
            return delete.Data;
        }

        public bool NotEmpty()
        {
            if (head != null)
            {
                return true;
            }
            return false;
        }

        public object SortPush(object data)
        {
            if (!NotEmpty())
            {
                Push(data);
            }
            else
            {
                List<object> Sorter = new List<object>();
                Sorter.Add(data);
                while (NotEmpty())
                {
                    Sorter.Add(Pop());
                }
                Sorter.Sort();

                foreach (var o in Sorter)
                {
                    Push(o);

                }
            }
            length++;
            Console.WriteLine(length);
            return data;
        }

    }
}
