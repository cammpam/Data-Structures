using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class Program
    {
            static void Main(string[] args)
            {
                Stacks stackNew = new Stacks();

                Console.Write("STACK : ");
                stackNew.Push("Uno");
                stackNew.PrintList();

                Console.Write("\nSTACK/PUSH : ");
                stackNew.Push("Dos");
                stackNew.PrintList();

                Console.Write("\nSTACK/PUSH : ");
                stackNew.Push("tres");
                stackNew.PrintList();

                Console.Write("\nSTACK/POP  : ");
                stackNew.Pop();
                stackNew.PrintList();

                Console.Write("\nSTACK/POP  : ");
                stackNew.Pop();
                stackNew.PrintList();

                Console.Write("\nSTACK/POP  : ");
                stackNew.Pop();
                stackNew.PrintList();

                Console.Write("\nSTACK/POP  : ");
                stackNew.Pop();
                stackNew.PrintList();

                Queues queueNew = new Queues();

                Console.Write("\n\n QUEUE  : ");
                queueNew.Enqueue("Uno");
                queueNew.PrintList();

                Console.Write("\nQUEUE/ENQUEUE : ");
                queueNew.Enqueue("Dos");
                queueNew.PrintList();

                Console.Write("\nQUEUE/ENQUEUE : ");
                queueNew.Enqueue("Tres");
                queueNew.PrintList();

                Console.Write("\nQUEUE/DEQUEUE : ");
                queueNew.Dequeue();
                queueNew.PrintList();

                Console.Write("\nQUEUE/DEQUEUE : ");
                queueNew.Dequeue();
                queueNew.PrintList();

                Console.Write("\nQUEUE/DEQUEUE : ");
                queueNew.Dequeue();
                queueNew.PrintList();

                Console.Read();
            }
    }
}
