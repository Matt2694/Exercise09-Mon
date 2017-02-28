using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class Program
    {
        private static MyList linkedList = new MyList();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            switch (GetInput())
            {
                case 1: Exercise1(); break;
                case 2: Exercise2(); break;
                case 3: Exercise3(); break;
            }
        }

        private int GetInput()
        {
            int result;
            Console.Write("Enter exercise number: ");
            string input = Console.ReadLine();
            result = Int32.Parse(input);
            return result;
        }

        private static void Exercise1()
        {
            Console.WriteLine("Exercise 1");
            ClubMember clubMember1 = new ClubMember(0, "Matt", "Peterson", 18);
            ClubMember clubMember2 = new ClubMember(1, "Matt", "Perry", 26);
            ClubMember clubMember3 = new ClubMember(2, "Anthony", "Peterson", 52);
            ClubMember clubMember4 = new ClubMember(3, "Carmelo", "Anthony", 30);
            linkedList.Insert(clubMember1);
            linkedList.Insert(clubMember2);
            linkedList.Insert(clubMember3);
            linkedList.Insert(clubMember4);
            PrintList();
            linkedList.Delete();
            linkedList.Delete();
            linkedList.Delete();
            linkedList.Delete();
            PrintList();
        }

        private static void Exercise2()
        {
            Console.WriteLine("Exercise 2");
            ClubMember clubMember1 = new ClubMember(0, "Matt", "Peterson", 18);
            ClubMember clubMember2 = new ClubMember(1, "Matt", "Perry", 26);
            ClubMember clubMember3 = new ClubMember(2, "Anthony", "Peterson", 52);
            ClubMember clubMember4 = new ClubMember(3, "Carmelo", "Anthony", 30);
            linkedList.Insert(clubMember1);
            linkedList.Insert(clubMember2);
            linkedList.Insert(clubMember4);
            PrintList();
            linkedList.Insert(1, clubMember3);
            PrintList();
            linkedList.Delete(2);
            PrintList();
        }

        private void Exercise3()
        {
            Console.WriteLine("Exercise 3");
            ClubMember clubMember1 = new ClubMember(0, "Matt", "Peterson", 18);
            ClubMember clubMember2 = new ClubMember(1, "Matt", "Perry", 26);
            ClubMember clubMember3 = new ClubMember(2, "Anthony", "Peterson", 52);
            ClubMember clubMember4 = new ClubMember(3, "Carmelo", "Anthony", 30);
            linkedList.Insert(clubMember2);
            linkedList.Insert(clubMember1);
            linkedList.Insert(clubMember4);
            linkedList.Insert(clubMember3);
            PrintList();
            linkedList.SortNr();
            PrintList();
        }

        public static void PrintList()
        {
            Console.WriteLine("List: \n" + linkedList.ToString());
            Console.ReadKey();
        }
    }
}
