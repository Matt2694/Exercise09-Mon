using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class ClubMember
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
    }
}
