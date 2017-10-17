using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTraversal
{
    class BinaryTree
    {
        //Create Root Node
        public Node Root;

        //Initializes new binary tree with Root Node
        public BinaryTree(int newNode) => Root = new Node(newNode);

        public void Add(Node current, int value)
        {
            //if value is less then current node value, move to next if statment
            if (value < current.Value)
            {
                //if the left current node is null create new node with the compared value
                if (current.Left == null)
                {
                    current.Left = new Node(value);
                    return;
                }
                else
                {
                    //Repeat Add() from current.Left
                    Add(current.Left, value);
                    return;
                }
            }
            //Add() if value is GREATER then current
            if (value > current.Value)
            {
                if (current.Right == null)
                {
                    current.Right = new Node(value);
                    return;
                }
                else
                {
                    Add(current.Right, value);
                    return;
                }
            }
        }




    }
}
