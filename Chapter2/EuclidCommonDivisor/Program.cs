using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int r;

            Console.Write("Enter the larger number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the smaller number: ");
            b = int.Parse(Console.ReadLine());

            while(! (a%b == 0))

            {
                r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine("The smallest common divisor of a and b is: " + b);

            Console.ReadKey();
        }
    }
}
