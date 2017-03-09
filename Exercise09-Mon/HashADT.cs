using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class HashADT : IComparable
    {
        private IComparable[] clubMemberArray;

        public HashADT(int s)
        {

            clubMemberArray = new IComparable[s];
        }

        public void Insert(IComparable data)
        {
            int hashCode = data.GetHashCode();
            int index = hashCode % clubMemberArray.Length;
            clubMemberArray[index] = data;
        }

        public int Search(IComparable data)
        {
            foreach (IComparable element in clubMemberArray)
            {
                if (element.Equals(data))
                {
                    int index = element.GetHashCode() % clubMemberArray.Length;
                    return index;
                }
            }
            return -1;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
