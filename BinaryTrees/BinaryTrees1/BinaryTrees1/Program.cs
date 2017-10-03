using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees1
{
    class Program
    {
        static void Main(string[] args)
        {
            //New Tree is created
            Tree newTree = new Tree();

            //Starting with the root, create leaf(1) on the left
            newTree.Root.Left = new Leaf(1);

            //Starting with the root, create leaf(2) on the Right
            newTree.Root.Right = new Leaf(2);

            //Starting with Leaf(1), create leaf(3) on the left
            newTree.Root.Left.Left = new Leaf(3);

            //Starting with Leaf(1), create leaf(4) on the Right
            newTree.Root.Left.Right = new Leaf(4);

            //Starting with Leaf(2), create leaf(5) on the left
            newTree.Root.Right.Left = new Leaf(5);

            //Starting with Leaf(1), create leaf(6) on the right
            newTree.Root.Right.Right = new Leaf(6);
        }
    }
}
