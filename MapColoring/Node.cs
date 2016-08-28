using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapColoring
{
    public class Node
    {
        public string name;
        public List<Node> neighbor = new List<Node>();
        public string color = "null";
        public int noOfConflicts = 0;
        public List<string> domain = new List<string>();

        public Node()
        {

        }
        public Node(String name)
        {
            this.name = name;
        }
    }
}
