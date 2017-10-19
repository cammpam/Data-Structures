using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTraversal
{
    class Program
    {
        static void Main()
        {
            BinaryTree newTree = new BinaryTree(20);


            newTree.Add(newTree.Root, 1);
            newTree.Add(newTree.Root, 15);
            newTree.Add(newTree.Root, 3);
            newTree.Add(newTree.Root, 5);
            newTree.Add(newTree.Root, 11);
            newTree.Add(newTree.Root, 17);
            newTree.Add(newTree.Root, 83);

            
            
            Console.WriteLine();
            Console.Read();


        }
    }
}
