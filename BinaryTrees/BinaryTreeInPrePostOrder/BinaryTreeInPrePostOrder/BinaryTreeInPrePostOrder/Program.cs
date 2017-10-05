using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInPrePostOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree inOrder = new BinaryTree();
            BinaryTree postOrder = new BinaryTree();

            Console.WriteLine("InOrder");

            inOrder.Root.Left = new Node(1);

            inOrder.Root.Right = new Node(2);

            inOrder.Root.Left.Left = new Node(3);

            inOrder.Root.Left.Right = new Node(4);

            inOrder.Root.Right.Left = new Node(5);

            inOrder.Root.Right.Right = new Node(6);

            inOrder.InOrder(inOrder.Root);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("PostOrder");

            postOrder.Root.Left = new Node(1);

            postOrder.Root.Right = new Node(2);

            postOrder.Root.Left.Left = new Node(3);

            postOrder.Root.Left.Right = new Node(4);

            postOrder.Root.Right.Left = new Node(5);

            postOrder.Root.Right.Right = new Node(6);

            postOrder.PostOrder(postOrder.Root);


            Console.Read();

        }
    }
}
