using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array of numbers to sort: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            for(int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            for(int i =0; i<numbers.Length-1; i++)
            {
                for(int j =0; j< numbers.Length-i-1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.Write("The sorted array is: ");
            foreach(int e in numbers)
            {
                Console.Write(e + " ");
            }

            Console.ReadKey();
        }
    }
}
