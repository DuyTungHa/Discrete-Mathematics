using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecusiveSearchBinary
{
    class Program
    {
        private int x;
        private List<int> numbers;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.go();
            Console.ReadKey();
        }

        private void go()
        {
            numbers = new List<int>();
            Console.Write("Enter an array of positive integers in incrementing order: ");
            string[] numbersInString = Console.ReadLine().Split(new char[] { char.Parse(" ") });
            foreach(string numberInString in numbersInString)
            {
                numbers.Add(int.Parse(numberInString));
            }

            Console.Write("Enter a number in the list you want to find: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("The number you want to find is located in index: " + FindX(0, numbers.Count - 1));
        }

        private int FindX(int i, int n)
        {
            if (i == n)
                return i;
            else
            {
                int l = (i + n) / 2;
                if (numbers[l] >= x)
                    return FindX(i, l);
                else
                    return FindX(l + 1, n);
            }

        }
    }
}
