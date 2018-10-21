using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsExample
{
    class Program
    {
        List<int> list1;
        List<int> list2;
        List<int> list3;
        int sameElementCount = 0;
        int sameElement12Count = 0;
        int sameElement13Count = 0;
        int sameElement23Count = 0;
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        private void go()
        {
            GetInput();
            compareList();
            Console.Write("The number of same elements in three lists is {0}\nThe number of same elements in couple 1&2, 2&3, and 1&3 are {1}, {2}, and {3} respectively\nThe number of elements in each list is {4}, {5}, and {6}\nThe number of different elements in three lists is {7}", sameElementCount,sameElement12Count,sameElement23Count,sameElement13Count,list1.Count,list2.Count,list3.Count,(list1.Count + list2.Count + list3.Count - sameElement12Count - sameElement13Count - sameElement23Count + sameElementCount));
        }

        private void GetInput()
        {
            list1 = new List<int>();
            list2 = new List<int>();
            list3 = new List<int>();
            Console.Write("Enter list1: ");
            String[] list1String = Console.ReadLine().Split(' ');
            foreach (String e in list1String)
            {
                list1.Add(int.Parse(e));
            }
            Console.Write("Enter list2: ");
            String[] list2String = Console.ReadLine().Split(' ');
            foreach (String e in list2String)
            {
                list2.Add(int.Parse(e));
            }
            Console.Write("Enter list3: ");
            String[] list3String = Console.ReadLine().Split(' ');
            foreach (String e in list3String)
            {
                list3.Add(int.Parse(e));
            }
        }

        private void compareList()
        {
            foreach(int e in list1)
            {
                if (list2.Contains(e) && list3.Contains(e))
                    sameElementCount++;
                if (list2.Contains(e))
                    sameElement12Count++;
                if (list3.Contains(e))
                    sameElement13Count++;
            }

            foreach(int e in list2)
            {
                if (list3.Contains(e))
                    sameElement23Count++;
            }
        }
    }
}
