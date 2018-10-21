using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int firstElementIndex;
            int lastElementIndex;
            int middleElementIndex;
            int comparisons = 0;
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter an array of numbers in ascending order below: ");
            List<String> input = new List<string>(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            Console.Write("Write the number need to be found: ");
            x = int.Parse(Console.ReadLine());

            foreach (String element in input)
            {
                numbers.Add(int.Parse(element));
            }

            firstElementIndex = 0;
            lastElementIndex = numbers.Count - 1;

            while (firstElementIndex < lastElementIndex)
            {
                middleElementIndex = (firstElementIndex + lastElementIndex) / 2;

                if (numbers[middleElementIndex] < x)
                {
                    firstElementIndex = middleElementIndex + 1;
                }
                else
                {
                    lastElementIndex = middleElementIndex;
                }

                comparisons += 2;
            }

            //For the last comparison to quit the loop
            comparisons++;

            Console.WriteLine("The position of x is {0} and the total comparisons to find x is {1}",(firstElementIndex +1), comparisons);

            Console.ReadKey();
        }
    }
}
