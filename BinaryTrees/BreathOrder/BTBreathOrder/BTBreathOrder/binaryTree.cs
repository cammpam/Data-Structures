using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTBreathOrder
{
    class BinaryTree
    {
        public Node Root;

        // initializes tree
        public BinaryTree() => Root = null;

        public void BreadthOrder(Node Current)
        {
            Queue<Node> tree = new Queue<Node>();

            if (Current == null) { return; }

            tree.Enqueue(Current);

            while (tree.Count > 0)
            {
                Node Counter = tree.Dequeue();
                if (Counter.Left != null)
                {
                    tree.Enqueue(Counter.Left);
                }
                if (Counter.Right != null)
                {
                    tree.Enqueue(Counter.Right);
                }
                Console.Write($"{Counter.Value} ");
            }
        }

        public void PreOrder(Node Current)
        {
            if (Current != null)
            {
                Console.Write($"{Current.Value} ");
                PreOrder(Current.Left);
                PreOrder(Current.Right);
            }
        }
        public void PostOrder(Node Current)
        {
            if (Current != null)
            {
                PostOrder(Current.Left);
                PostOrder(Current.Right);
                Console.Write($"{Current.Value} ");
            }
        }
        public void InOrder(Node Current)
        {
            if (Current != null)
            {
                InOrder(Current.Left);
                Console.Write($"{Current.Value} ");
                InOrder(Current.Right);
            }
        }
    }
    public class Node
    {
        public object Value;
        public Node Left;
        public Node Right;

        public Node(object leafValue)
        {
            Value = leafValue;
            Left = null;
            Right = null;
        }
    }
}