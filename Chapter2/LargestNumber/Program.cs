using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestNumber = -1;
            int largestNumberFirstIndex = -1;
            int largestNumberLastIndex = -1;
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter an array of numbers below: ");
            List<String> input = new List<string>(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));

            foreach (String element in input)
            {
                numbers.Add(int.Parse(element));
            }

            for (int i = 0; i<numbers.Count;i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                    largestNumberFirstIndex = i;
                    largestNumberLastIndex = i;
                }
                else if (numbers[i] == largestNumber)
                {
                    largestNumberLastIndex = i;
                }
            }

            Console.WriteLine("The largest number is: " + largestNumber);
            Console.WriteLine("The first one is located in position: " + (largestNumberFirstIndex + 1));
            Console.WriteLine("The last one is located in position: " + (largestNumberLastIndex + 1));

            Console.ReadKey();
        }
    }
}
