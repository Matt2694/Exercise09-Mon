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
            Node nodeToDelete = (Node)Search(index);
            Node nodeBefore = (Node)Search(index - 1);
            nodeBefore.Next = nodeToDelete.Next;
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
            return point;
        }
        public void SortNr()
        {
            Node nPoint1 = Head;
            Node nPoint2 = nPoint1.Next;
            Node nPoint3 = nPoint2.Next;
            while(nPoint3 != null)
            {
                ClubMember cPoint1 = (ClubMember)nPoint1.Data;
                ClubMember cPoint2 = (ClubMember)nPoint2.Data;
                if(cPoint1.Nr > cPoint2.Nr)
                {
                    Head = nPoint2;
                    nPoint1.Next = nPoint3;
                    nPoint2.Next = nPoint1;
                }
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
