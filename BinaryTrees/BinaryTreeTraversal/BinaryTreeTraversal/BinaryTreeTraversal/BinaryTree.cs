using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversal
{
    class BinaryTree
    {
        public Node Root;

        public BinaryTree() => Root = new Node(null);

        public void GetChild(Node Current)
        {

            if(Current != null)
            {

            Console.Write(Current.Value);
            GetChild(Current.Left);
            GetChild(Current.Right); 

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

