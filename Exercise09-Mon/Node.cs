using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class Node
    {
        public Node Next { get; set; }
        public object Data { get; set; }
        public Node(object o)
        {
            Data = o;
            Next = null;
        }
        public override string ToString()
        {
            string output;
            output = Data.ToString();
            return output;
        }
    }
}
