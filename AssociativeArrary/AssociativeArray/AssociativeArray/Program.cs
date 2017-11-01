using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociativeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            AssocArray newAA = new AssocArray();
            newAA.Add("Monkey");
            newAA.Add("Rabbit");
            Console.WriteLine($"{newAA.Search("Monkey")}");
            Console.WriteLine($"{newAA.Delete("Rabbit")}");
            Console.Read();
        }
    }
}
