using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class Node
    {
            public Node Next;
            public Object Data;

            public Node(Object data)
            {
                Data = data;
                Next = null;
            }
    }
}
