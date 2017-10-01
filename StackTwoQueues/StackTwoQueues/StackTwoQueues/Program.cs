using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTwoQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queueTest = new Queue(1);
            queueTest.Enqueue(2);
            queueTest.Enqueue(3);
            queueTest.StkOne.View();
            Console.WriteLine("Add More\n");
            queueTest.Enqueue(4);
            queueTest.Enqueue(5);
            queueTest.StkOne.View();

            Console.WriteLine();

            Console.WriteLine($"{ queueTest.Dequeue().Data} was removed!");
            queueTest.StkOne.View();
            Console.Read();
        }
    }
}
