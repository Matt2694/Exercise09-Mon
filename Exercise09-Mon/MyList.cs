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
            Node beforeNode = (Node)Search(index - 1);
            Node afterNode = beforeNode.Next;
            newNode.Next = afterNode;
            beforeNode.Next = newNode;
        }
        public void Delete()
        {
            Node temp = Head;
            Head = Head.Next;
            temp.Next = null;
        }
        public void Delete(int index)
        {
            if (index == 0)
            {
                Node temp = Head;
                Head = Head.Next;
                temp.Next = null;
            }
            else
            {
                Node nodeToDelete = (Node)Search(index);
                Node nodeBefore = (Node)Search(index - 1);
                nodeBefore.Next = nodeToDelete.Next;
            }
        }
        public object Search(int index)
        {
            if(Head == null)
            {
                throw new Exception();
            }
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
            Node pointer = Head;
            bool swapped = false;
            do
            {
                pointer = Head;
                swapped = false;
                while (pointer.Next != null)
                {
                    ClubMember a = (ClubMember)pointer.Data;
                    ClubMember b = (ClubMember)pointer.Next.Data;
                    if (a.Nr > b.Nr)
                    {
                        Change(pointer, pointer.Next);
                        swapped = true;
                    }
                    pointer = pointer.Next;
                }
            } while (swapped == true);
        }

        private void Change(Node nodeA, Node nodeB)
        {
            object tmpData = nodeA.Data;
            nodeA.Data = nodeB.Data;
            nodeB.Data = tmpData;
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

        public bool Contains(object data)
        {
            if (Head == null)
            {
                throw new Exception();
            }
            Node point = Head;
            while (point != null)
            {
                if (point.Data.Equals(data))
                {
                    return true;
                }
                point = point.Next;
            }
            return false;
        }

        public int IndexOf(object data)
        {
            if (Head == null)
            {
                throw new Exception();
            }
            int counter = 0;
            Node point = Head;
            while (point != null)
            {
                if (point.Data.Equals(data))
                {
                    return counter;
                }
                point = point.Next;
                counter++;
            }
            throw new Exception();
        }
    }
}
