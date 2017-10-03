using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees1
{
    class Leaf
    {
        //Leaf Value
        public int Value;
        public Leaf Left { get; set; }
        public Leaf Right { get; set; }

        public Leaf(int leafvalue)
        {
            Value = leafvalue;
            Left = null;
            Right = null;
        }
    }
}
