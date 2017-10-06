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

            Console.WriteLine();
            Console.WriteLine();

            BinaryTree inOrderTree = new BinaryTree();

            Console.WriteLine("In-Order");

            inOrderTree.Root.Left = new Node(1);

            inOrderTree.Root.Right = new Node(2);

            inOrderTree.Root.Left.Left = new Node(3);

            inOrderTree.Root.Left.Right = new Node(4);

            inOrderTree.Root.Right.Left = new Node(5);

            inOrderTree.Root.Right.Right = new Node(6);

            inOrderTree.InOrder(traverseTree.Root);

            Console.WriteLine();
            Console.WriteLine();

            BinaryTree postOrderTree = new BinaryTree();

            Console.WriteLine("Post-Order");

            postOrderTree.Root.Left = new Node(1);

            postOrderTree.Root.Right = new Node(2);

            postOrderTree.Root.Left.Left = new Node(3);

            postOrderTree.Root.Left.Right = new Node(4);

            postOrderTree.Root.Right.Left = new Node(5);

            postOrderTree.Root.Right.Right = new Node(6);

            postOrderTree.InOrder(traverseTree.Root);




            Console.Read();
        }
    }
}

