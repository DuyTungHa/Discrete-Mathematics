using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquivalenceRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of element of a group: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The number of possible equivalence relations in that group is: " + calculateEquivalence(n));
            Console.ReadKey();
        }

        static long calculateEquivalence(int n)
        {
            if (n == 0)
                return 1;
            long result = 0;
            for (int j = 0; j < n; j++)
            {
                result += (calculateFactorial(n - 1) * calculateEquivalence(n - j - 1)) / (calculateFactorial(j) * calculateFactorial(n - 1 - j));
            }
            return result;
        }

        static long calculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            long result = 1;
            for ( int i = 1; i<=n;i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
