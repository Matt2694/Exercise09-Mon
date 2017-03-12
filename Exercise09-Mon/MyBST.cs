using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    public class MyBST
    {
        private BSTNode Root = null;

        public void Insert(IComparable Data)
        {
            BSTNode CurNode = Root;
            BSTNode LastNode;
            BSTNode NewNode = new BSTNode(Data);

            if (this.Root == null)
            {
                this.Root = NewNode;
            }
            else
            {
                LastNode = this.Root;
                while (CurNode != null)
                {
                    int Compared = Data.CompareTo(CurNode.Data);

                    LastNode = CurNode;
                    if (Compared <= 0)
                    {
                        CurNode = CurNode.Left;
                    }
                    else if (Compared > 0)
                    {
                        CurNode = CurNode.Right;
                    }
                }

                int CompareLast = Data.CompareTo(LastNode.Data);
                if (CompareLast <= 0)
                {
                    LastNode.Left = NewNode;
                }
                else if (CompareLast > 0)
                {
                    LastNode.Right = NewNode;
                }
            }
        }

        public IComparable Search(IComparable Data)
        {
            BSTNode CurNode = Root;
            IComparable Result = null;
            while (CurNode != null && Result == null)
            {
                int Compared = Data.CompareTo(CurNode.Data);
                if (Compared < 0)
                {
                    CurNode = CurNode.Left;
                }
                else if (Compared > 0)
                {
                    CurNode = CurNode.Right;
                }
                else if (Compared == 0)
                {
                    Result = CurNode.Data;
                }
            }

            return Result;
        }
    }
}
