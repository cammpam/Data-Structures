using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Turn A Matrix: ");
            // change the n value to change the size of the matrix
            int n = 5;
            // creates a matrix using an iterator starting at 11 of size n x n as requested
            MtxTurn rotator = new MtxTurn(n);
            Console.WriteLine();
            Console.WriteLine("ORIGINAL: ");
            rotator.Print();
            Console.WriteLine();
            Console.WriteLine("TURNED 90 DEGREES: ");
            rotator.Rotator();
            rotator.Print();

            Console.Read();
        }
    }
}
