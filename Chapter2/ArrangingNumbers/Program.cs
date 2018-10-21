using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            while (true)
            {
                try
                {
                    Console.Write("How many numbers do you want your array to have?: ");
                    int length = int.Parse(Console.ReadLine());
                    numbers = new int[length +1];

                    for (int i = 0; i<length; i++)
                    {
                        Console.Write("Enter element number " + (i + 1) + ": ");
                        numbers[i] = int.Parse(Console.ReadLine());
                    }

                    Array.Sort(numbers);

                    Console.Write("Enter a number to be arrange in the array containing ");
                    for(int i = 0; i<length; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                    Console.Write(": ");

                    numbers[length] = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Dont be that silly! Do it again!");
                }
            }

            Console.Write("New List: ");
            ArrangeNumber(numbers);

            Console.ReadKey();

        }

        static void ArrangeNumber (int[] numbers)
        {
            int x = numbers[numbers.Length - 1];
            int i = numbers.Length - 2;

            while(x< numbers[i] && i>=0)
            {
                numbers[i + 1] = numbers[i];
                numbers[i] = x;
                i--;
            }

            for (int a = 0; a < numbers.Length; a++)
            {
                Console.Write(numbers[a] + " ");
            }
        }
    }
}
