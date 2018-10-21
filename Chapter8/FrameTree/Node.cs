using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTree
{
    class Node
    {
        public string name;
        public List<Node> children;

        public Node()
        {
            children = new List<Node>();
        }
    }
}
