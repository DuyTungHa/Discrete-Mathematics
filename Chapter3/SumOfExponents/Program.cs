using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfExponents
{
    class Program
    {
        private int a;
        private int r;
        private int n;
        private int sum;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Go();
            Console.ReadKey();
        }

        private void Go()
        {
            // input
            Console.Write("Enter a positive integer variable named a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a positive integer variable named r: ");
            r = int.Parse(Console.ReadLine());
            Console.Write("Enter a positive integer variable named n: ");
            n = int.Parse(Console.ReadLine());

            sum = CalculateSum(a, r, n);
            Console.WriteLine("The result of the sum calculation is: " + sum);
        }

        private int CalculateSum(int A, int R, int N)
        {
            if (N == 0)
                return A;
            else
                return (A * (int) Math.Pow(R, N) + CalculateSum(A,R,N-1) );
        }
    }
}
