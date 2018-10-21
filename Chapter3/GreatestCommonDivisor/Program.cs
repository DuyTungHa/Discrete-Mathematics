using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        int a;
        int b;
        int result;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.go();
            Console.ReadKey();
        }

        private void go()
        {
            Console.Write("Enter the first variable: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second variable: ");
            b = int.Parse(Console.ReadLine());

            if (a >= b)
                result = FindGreatestCommonDivisor(a, b);
            else
                result = FindGreatestCommonDivisor(b, a);

            Console.WriteLine("The Greatest Common Divisor of the two number is: " + result);
        }

        private int FindGreatestCommonDivisor(int largerNum, int smallerNum)
        {
            if (smallerNum == 0)
                return largerNum;
            else
                return FindGreatestCommonDivisor(smallerNum, largerNum % smallerNum);
        }
    }
}
