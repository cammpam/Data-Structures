using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queueNow = new Queue("2");
            queueNow.Enqueue("C");
            queueNow.Enqueue("H");
            queueNow.Enqueue("A");
            queueNow.Enqueue("I");
            queueNow.Enqueue("N");
            queueNow.Enqueue("S");
            queueNow.View();
            Console.WriteLine();

            Console.WriteLine(queueNow.IsPalindrome());
            Console.WriteLine();
            Console.WriteLine();
            Queue nowQueue = new Queue("R");
            nowQueue.Enqueue("A");
            nowQueue.Enqueue("C");
            nowQueue.Enqueue("E");
            nowQueue.Enqueue("C");
            nowQueue.Enqueue("A");
            nowQueue.Enqueue("R");
            nowQueue.View();
            Console.WriteLine();
            Console.WriteLine(nowQueue.IsPalindrome());

            Console.Read();
        }
    }
}
