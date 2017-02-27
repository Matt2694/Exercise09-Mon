using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class MyList
    {
        private Node Head { get; set; }
        public MyList()
        {
            Head = null;
        }
        public void Insert(object input)
        {
            Node newNode = new Node(input);
            newNode.Next = Head;
            Head = newNode;
        }
        public void Insert(int index, object input)
        {
            Node newNode = new Node(input);
            Node oldNode = (Node)Search(index);
            newNode.Next = oldNode;
            Node olderNode = (Node)Search(index - 1);
            olderNode.Next = newNode;
        }
        public void Delete()
        {
            Head = Head.Next;
        }
        public void Delete(int index)
        {

        }
        public object Search(int index)
        {
            int counter = 0;
            Node point = Head;
            while (point != null && counter < index)
            {
                point = point.Next;
                counter++;
            }
            try
            {
                return point;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        public override string ToString()
        {
            string output = "";
            Node point = Head;
            while(point != null)
            {
                output += point.ToString() + "\n";
                point = point.Next;
            }
            return output;
        }
    }
}
