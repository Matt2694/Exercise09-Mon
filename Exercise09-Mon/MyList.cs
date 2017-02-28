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
            Head = Head.Next;
        }
        public void Delete(int index)
        {
            if (index == 0)
            {
                Head = Head.Next;
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
            Node current = Head;
            Node previous = current;
            Node min = current;
            Node minPrevious = min;
            Node sortedListHead = null;
            Node sortedListTail = sortedListHead;
            int i = 0;
            while (i < 4)
            {
                current = Head;
                min = current;
                minPrevious = min;
                while (current != null)
                {
                    ClubMember _currentData = (ClubMember)current.Data;
                    ClubMember _minData = (ClubMember)min.Data;
                    if (_currentData.Nr < _minData.Nr)
                    {
                        min = current;
                        minPrevious = previous;
                    }
                    previous = current;
                    current = current.Next;
                }
                if (min == Head)
                {
                    Head = Head.Next;
                }
                else if (min.Next == null)
                {
                    minPrevious.Next = null;
                }
                else
                {
                    minPrevious.Next = minPrevious.Next.Next;
                }
                if (sortedListHead != null)
                {
                    sortedListTail.Next = min;
                    sortedListTail = sortedListTail.Next;
                }
                else
                {
                    sortedListHead = min;
                    sortedListTail = sortedListHead;
                }
                i++;
            }
            Head = sortedListHead;
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
