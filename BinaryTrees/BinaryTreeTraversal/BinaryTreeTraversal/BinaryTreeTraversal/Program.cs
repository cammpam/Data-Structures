using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree traverseTree = new BinaryTree();

            Console.WriteLine("This is a Traversal");

            traverseTree.Root.Left = new Node(1);

            traverseTree.Root.Right = new Node(2);

            traverseTree.Root.Left.Left = new Node(3);

            traverseTree.Root.Left.Right = new Node(4);

            traverseTree.Root.Right.Left = new Node(5);

            traverseTree.Root.Right.Right = new Node(6);

            traverseTree.Traverse(traverseTree.Root);

            Console.Read();
        }
    }
}

