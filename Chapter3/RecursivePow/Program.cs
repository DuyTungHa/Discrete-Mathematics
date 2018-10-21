using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePow
{
    class Program
    {
        int a;
        int n;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.go();
            Console.ReadKey();
        }

        private void go()
        {
            Console.Write("Enter a positive integer variable named a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a positive integer variable named n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("The result of a^2^n is: " + CalculatePow(n));
        }

        private int CalculatePow(int n)
        {
            if (n == 1)
                return a * a;
            else
                return (CalculatePow(n - 1) * CalculatePow(n - 1));
        }
    }
}
