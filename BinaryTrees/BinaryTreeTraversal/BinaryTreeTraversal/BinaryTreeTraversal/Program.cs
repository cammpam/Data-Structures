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
            BinaryTree newTree = new BinaryTree();

            //Starting with the root, create leaf(1) on the left
            newTree.Root.Left = new Node(1);

            //Starting with the root, create leaf(2) on the Right
            newTree.Root.Right = new Node(2);

            //Starting with Leaf(1), create leaf(3) on the left
            newTree.Root.Left.Left = new Node(3);

            //Starting with Leaf(1), create leaf(4) on the Right
            newTree.Root.Left.Right = new Node(4);

            //Starting with Leaf(2), create leaf(5) on the left
            newTree.Root.Right.Left = new Node(5);

            //Starting with Leaf(1), create leaf(6) on the right
            newTree.Root.Right.Right = new Node(6);

            newTree.GetChild(newTree.Root);
            Console.Read();
        }
    }
}

