using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInPrePostOrder
{
    class BinaryTree
    {
        public Node Root;

        public BinaryTree() => Root = new Node(null);

        public void InOrder(Node Current)
        {

            if (Current != null)
            {

                InOrder(Current.Left);
                Console.Write(Current.Value);
                InOrder(Current.Right);

            }
        }

    public void PostOrder(Node Current)
    {

        if (Current != null)
        {

            PostOrder(Current.Left);
            PostOrder(Current.Right);
            Console.Write(Current.Value);

        }
    }

    }



    public class Node
    {
        //Leaf Value
        public object Value;
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(object leafValue)
        {
            Value = leafValue;
            Left = null;
            Right = null;
        }
    }
}
