using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList linkedList = new MyList();
            ClubMember clubMember1 = new ClubMember(0, "Matt", "Peterson", 18);
            ClubMember clubMember2 = new ClubMember(1, "Matt", "Perry", 26);
            ClubMember clubMember3 = new ClubMember(2, "Anthony", "Peterson", 52);
            ClubMember clubMember4 = new ClubMember(3, "Carmelo", "Anthony", 30);
            linkedList.Insert(clubMember1);
            linkedList.Insert(clubMember2);
            //linkedList.Insert(clubMember3);
            linkedList.Insert(clubMember4);
            Console.WriteLine(linkedList.ToString());
            Console.ReadKey();
            linkedList.Insert(1, clubMember3);
            Console.WriteLine(linkedList.ToString());
            Console.ReadKey();
            linkedList.Delete();
            linkedList.Delete();
            linkedList.Delete();
            linkedList.Delete();
            Console.WriteLine(linkedList.ToString());
            Console.ReadKey();
        }
    }
}
