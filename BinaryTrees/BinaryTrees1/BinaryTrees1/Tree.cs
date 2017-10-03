using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees1
{
    class Tree
    {
        
        public Leaf Root;

        public Tree()
        {
            //Leaf Root represent Leaf(0) the base or root of the tree
            Leaf Root;
            Root = new Leaf(0);
        }
    }
}
