using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {
        int n;
        List<int> inputList = new List<int>();
        Random random = new Random();
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        private void go()
        {
            getInput();
            Console.Write("The random array created from the original one is: " );
            foreach (int element in createRandomArray())
            {
                Console.Write(element + " ");
            }
        }

        private void getInput()
        {
            Console.Write("Enter the last number of the array: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1;i<=n;i++)
            {
                inputList.Add(i);
            }
        }

        private List<int> createRandomArray()
        {
            List<int> output = new List<int>();

            for (int i =1;i<=n;i++)
            {
                int specifiedIndex = random.Next(0, inputList.Count - 1);
                output.Add(inputList[ specifiedIndex]);
                inputList.RemoveAt(specifiedIndex);
            }
            return output;
        }
    }
}
