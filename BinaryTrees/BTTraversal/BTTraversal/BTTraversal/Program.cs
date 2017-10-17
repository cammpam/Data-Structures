using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree newTree = new BinaryTree(12);


            newTree.Add(newTree.Root, 1);
            newTree.Add(newTree.Root, 13);
            newTree.Add(newTree.Root, 11);
            newTree.Add(newTree.Root, 7);
            newTree.Add(newTree.Root, 3);
            newTree.Add(newTree.Root, 17);
            newTree.Add(newTree.Root, 15);

            Console.Read();


        }
    }
}
