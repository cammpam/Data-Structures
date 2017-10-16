using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTBreathOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //root node
            BinaryTree newTree = new BinaryTree();

            // collects nodes 
            newTree.Root = new Node(4);
            newTree.Root.Left = new Node(2);
            newTree.Root.Right = new Node(6);
            newTree.Root.Left.Left = new Node(1);
            newTree.Root.Left.Right = new Node(3);
            newTree.Root.Right.Left = new Node(5);
            newTree.Root.Right.Right = new Node(7);

            // BreathOrder
            Console.Write("Breadth Order: ");
            newTree.BreadthOrder(newTree.Root);
            Console.Read();
        }
    }
}
