using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class ClubMember : IComparable
    {
        public int Nr { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public ClubMember(int n, string f, string l, int a)
        {
            Nr = n;
            Fname = f;
            Lname = l;
            Age = a;
        }
        public override string ToString()
        {
            string output;
            output = Nr + " " + Fname + " " + Lname + " " + Age;
            return output;
        }

        public int CompareTo(object obj)
        {
            ClubMember cM = (ClubMember)obj;
            if(this.Nr > cM.Nr)
            {
                return 1;
            }
            else if(this.Nr < cM.Nr)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override bool Equals(object obj)
        {
            ClubMember cM = (ClubMember)obj;
            if(this.Nr == cM.Nr && this.Fname.Equals(cM.Fname) && this.Lname.Equals(cM.Lname) && this.Age == cM.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Nr.GetHashCode() + Fname.GetHashCode() + Lname.GetHashCode() + Age.GetHashCode();
        }
    }
}
