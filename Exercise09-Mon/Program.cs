using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09_Mon
{
    class Program
    {
        private static MyList linkedList = new MyList();
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            int smallSize = 1000;
            int largeSize = smallSize * 10;

            ClubMember[] smallLinear = new ClubMember[smallSize];
            ClubMember[] largeLinear = new ClubMember[largeSize];

            ClubMember[] smallBinary = new ClubMember[smallSize];
            ClubMember[] largeBinary = new ClubMember[largeSize];

            FillArrays(ref smallLinear);
            FillArrays(ref largeLinear);
            FillArrays(ref smallBinary);
            FillArrays(ref largeBinary);

            switch (GetInput())
            {
                case 1: Exercise1(); break;
                case 2: Exercise2(); break;
                case 3: Exercise3(); break;
                case 4: Exercise4(smallLinear, largeLinear); break;
                case 5: Exercise5(smallBinary, largeBinary); break;
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
            for(int i = 0; i < 10; i++)
            {
                linkedList.Insert(CMFactory.GetClubMember());
            }
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
            for (int i = 0; i < 10; i++)
            {
                linkedList.Insert(CMFactory.GetClubMember());
            }
            PrintList();
            linkedList.SortNr();
            PrintList();
        }

        private void Exercise4(ClubMember[] smallLinear, ClubMember[] largeLinear)
        {
            Console.WriteLine("Exercise 4");
            SearchLinear(smallLinear);
            Console.ReadKey();
            SearchLinear(largeLinear);
            Console.ReadKey();
        }

        private void Exercise5(ClubMember[] smallBinary, ClubMember[] largeBinary)
        {
            Console.WriteLine("Exercise 5");
            InsertionSort(ref smallBinary);
            InsertionSort(ref largeBinary);
            Console.ReadKey();
            SearchBinary(smallBinary);
            Console.ReadKey();
            SearchBinary(largeBinary);
            Console.ReadKey();
        }

        public static void PrintList()
        {
            Console.WriteLine("List: \n" + linkedList.ToString());
            Console.ReadKey();
        }

        public void FillArrays(ref ClubMember[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = CMFactory.GetClubMember();
            }
        }

        public void SearchLinear(IComparable[] arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            bool check;
            ClubMember clubMember1 = (ClubMember)arr[rnd.Next(0, arr.Length - 1)];
            ClubMember clubMember2 = (ClubMember)arr[rnd.Next(0, arr.Length - 1)];
            ClubMember clubMember3 = (ClubMember)arr[rnd.Next(0, arr.Length - 1)];
            ClubMember found1 = null;
            ClubMember found2 = null;
            ClubMember found3 = null;
            Console.WriteLine(clubMember1.ToString());
            Console.WriteLine(clubMember2.ToString());
            Console.WriteLine(clubMember3.ToString());
            for (int i = 0; i < 1000; i++)
            {
                check = true;
                int j = 0;
                while (check && j < arr.Length)
                {
                    if (clubMember1.Equals(arr[j]))
                    {
                        check = false;
                        found1 = (ClubMember)arr[j];
                    }
                    j++;
                }
                check = true;
                j = 0;
                while (check && j < arr.Length)
                {
                    if (clubMember2.Equals(arr[j]))
                    {
                        check = false;
                        found2 = (ClubMember)arr[j];
                    }
                    j++;
                }
                check = true;
                j = 0;
                while (check && j < arr.Length)
                {
                    if (clubMember3.Equals(arr[j]))
                    {
                        check = false;
                        found3 = (ClubMember)arr[j];
                    }
                    j++;
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + "ms");
            Console.WriteLine(found1.ToString());
            Console.WriteLine(found2.ToString());
            Console.WriteLine(found3.ToString() + "\n");
        }

        public void SearchBinary(IComparable[] arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int middle;
            int min;
            int max;
            ClubMember clubMember1 = (ClubMember)arr[rnd.Next(0, arr.Length - 1)];
            ClubMember clubMember2 = (ClubMember)arr[rnd.Next(0, arr.Length - 1)];
            ClubMember clubMember3 = (ClubMember)arr[rnd.Next(0, arr.Length - 1)];
            ClubMember found1 = null;
            ClubMember found2 = null;
            ClubMember found3 = null;
            Console.WriteLine(clubMember1.ToString());
            Console.WriteLine(clubMember2.ToString());
            Console.WriteLine(clubMember3.ToString());
            for (int i = 0; i < 1000; i++)
            {
                middle = arr.Length / 2;
                min = 0;
                max = arr.Length;
                while (found1 == null)
                {
                    if (clubMember1.CompareTo(arr[middle]) == 1)
                    {
                        min = middle;
                        middle = middle + ((max - middle) / 2);
                    }
                    else if(clubMember1.CompareTo(arr[middle]) == -1)
                    {
                        max = middle;
                        middle = min + ((middle - min) / 2);
                    }
                    else
                    {
                        found1 = (ClubMember)arr[middle];
                    }
                }
                middle = arr.Length / 2;
                min = 0;
                max = arr.Length;
                while (found2 == null)
                {
                    if (clubMember2.CompareTo(arr[middle]) == 1)
                    {
                        min = middle;
                        middle = middle + ((max - middle) / 2);
                    }
                    else if (clubMember2.CompareTo(arr[middle]) == -1)
                    {
                        max = middle;
                        middle = min + ((middle - min) / 2);
                    }
                    else
                    {
                        found2 = (ClubMember)arr[middle];
                    }
                }
                middle = arr.Length / 2;
                min = 0;
                max = arr.Length;
                while (found3 == null)
                {
                    if (clubMember3.CompareTo(arr[middle]) == 1)
                    {
                        min = middle;
                        middle = middle + ((max - middle) / 2);
                    }
                    else if (clubMember3.CompareTo(arr[middle]) == -1)
                    {
                        max = middle;
                        middle = min + ((middle - min) / 2);
                    }
                    else
                    {
                        found3 = (ClubMember)arr[middle];
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + "ms");
            Console.WriteLine(found1.ToString());
            Console.WriteLine(found2.ToString());
            Console.WriteLine(found3.ToString() + "\n");
        }

        public void InsertionSort(ref ClubMember[] arr)
        {
            int holePosition;
            ClubMember valueToInsert;
            for(int i = 1; i < arr.Length; i++)
            {
                valueToInsert = arr[i];
                holePosition = i;
                while(holePosition > 0 && arr[holePosition - 1].Nr > valueToInsert.Nr)
                {
                    arr[holePosition] = arr[holePosition - 1];
                    holePosition--;
                }
                arr[holePosition] = valueToInsert;
            }
        }
    }
}
