﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees1
{
    class Node
    {
        //Leaf Value
        public int Value;
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int leafvalue)
        {
            Value = leafvalue;
            Left = null;
            Right = null;
        }
    }
}
