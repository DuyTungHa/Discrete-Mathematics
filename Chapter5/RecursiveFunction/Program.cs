using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    class Program
    {
        int c1;
        int c2;
        List<int> a;
        int result;
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        private void go()
        {
            getInput();
            Console.WriteLine("The value of Ak is: " + result);
            
        }

        private void getInput()
        {
            a = new List<int>();
            Console.WriteLine("There is a recursive function: \nAn = C1*An-1 + C2*An-2");
            Console.Write("Enter A0: ");
            a.Add( int.Parse(Console.ReadLine()));
            Console.Write("Enter A1: ");
            a.Add( int.Parse(Console.ReadLine()));
            Console.Write("Enter C1: ");
            c1 = int.Parse(Console.ReadLine());
            Console.Write("Enter C2: ");
            c2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the k for Ak: ");
            result = recursiveFunction(int.Parse(Console.ReadLine()));
        }

        private int recursiveFunction(int k)
        {
            if (k == 0)
                return a[0];
            else if (k == 1)
                return a[1];
            else
                return (c1 * recursiveFunction(k - 1) + c2 * recursiveFunction(k - 2));
        }
    }
}
