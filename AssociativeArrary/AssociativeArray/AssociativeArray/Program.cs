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
            {
                AssocArray newAA = new AssocArray();
                State wash = new State("WA", "Olympia");

                newAA.Add(new State("OR", "Salem"));
                newAA.Add(wash);
                newAA.Add(new State("TX", "Austin"));
                newAA.Add(new State("NY", "Albany"));
                newAA.SearchKey("TX");

                newAA.Print();

                newAA.Delete(wash);

                newAA.Print();

                Console.Read();
            }
        }

    }
}
