using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubArrays
{
    class Program
    {
        List<int> inputArray = new List<int>();
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        void go()
        {
            getInput();
            Console.WriteLine("The longest incrementing sub array is: " + getResult(findIncrementingSubArray()));
            Console.WriteLine("The longest decrementing sub array is: " + getResult(findDecrementingSubArray()));

        }

        void getInput()
        {
            Console.Write("Enter an array: ");
            List<string> inputStringArray = Console.ReadLine().Split(' ').ToList();
            foreach(string variable in inputStringArray)
            {
                inputArray.Add(int.Parse(variable));
            }
        }

        List<int> findIncrementingSubArray()
        {
            List<int> compareList = new List<int>();
            List<int> resultList = new List<int>();

            for (int a = 0;a<=inputArray.Count -2;a++)
            {
                for (int b = a+ 1;b<=inputArray.Count -1;b++)
                {
                    compareList = new List<int>();
                    int compareNum = inputArray[a];
                    compareList.Add(inputArray[a]);
                    for (int c = b; c<= inputArray.Count -1; c++)
                    {
                        if (inputArray[c] > compareNum)
                        {
                            compareNum = inputArray[c];
                            compareList.Add(inputArray[c]);
                        }
                    }
                    if (compareList.Count > resultList.Count)
                        resultList = compareList;
                }
            }

            return resultList;
        }

        List<int> findDecrementingSubArray()
        {
            List<int> compareList = new List<int>();
            List<int> resultList = new List<int>();

            for (int a = 0; a <= inputArray.Count - 2; a++)
            {
                for (int b = a + 1; b <= inputArray.Count - 1; b++)
                {
                    compareList = new List<int>();
                    int compareNum = inputArray[a];
                    compareList.Add(inputArray[a]);
                    for (int c = b; c <= inputArray.Count - 1; c++)
                    {
                        if (inputArray[c] < compareNum)
                        {
                            compareNum = inputArray[c];
                            compareList.Add(inputArray[c]);
                        }
                    }
                    if (compareList.Count > resultList.Count)
                        resultList = compareList;
                }
            }

            return resultList;
        }

        string getResult(List<int> numberList)
        {
            string result = String.Empty;
            foreach(int num in numberList)
            {
                result += num + " ";
            }
            return result;
        }
    }
}
