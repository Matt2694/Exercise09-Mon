using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class BSTNode
    {
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
        public IComparable Data { get; set; }
        public BSTNode(IComparable o)
        {
            Data = o;
        }
        public override string ToString()
        {
            string output;
            output = Data.ToString();
            return output;
        }
    }

}
