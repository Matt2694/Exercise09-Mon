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
            int Result = 0;
            ClubMember Other = (ClubMember)obj;

            Result = Nr.CompareTo(Other.Nr);

            if (Result == 0)
            {
                Result = Fname.CompareTo(Other.Fname);
            }

            if (Result == 0)
            {
                Result = Lname.CompareTo(Other.Lname);
            }

            if (Result == 0)
            {
                Result = Age.CompareTo(Other.Age);
            }

            return Result;
        }

        public override bool Equals(object obj)
        {
            ClubMember cM = (ClubMember)obj;
            if(Nr == cM.Nr && Fname.Equals(cM.Fname) && Lname.Equals(cM.Lname) && Age == cM.Age)
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
