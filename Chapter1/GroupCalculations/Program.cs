using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            MakeArrays(a,b);
            And(a, b);
            Or(a, b);
            AMinusB(a, b);
            Xor(a, b);
            Console.ReadKey();
        }

        private static void MakeArrays(List<int> a, List<int> b)
        {

            int numOfElementA;
            int numOfElementB;

            Console.Write("How many elements do you want your array A to have? ");
            numOfElementA = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many elements do you want your array B to have? ");
            numOfElementB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter those elements for array A");
            for (int i = 1; i <= numOfElementA; i++)
            {
                Console.Write("Element number " + i +": ");
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Now enter those elements for array B");
            for (int i = 1; i <= numOfElementB; i++)
            {
                Console.Write("Element number " + i + ": ");
                b.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        private static void And(List<int> a, List<int> b)
        {
            Console.Write("And Calculation: ");
            foreach(int element in a)
            {
                if (b.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine("");
        }

        private static void Or(List<int> a, List<int> b)
        {
            Console.Write("Or Calculation: ");
            foreach (int element in b)
            {
                Console.Write(element + " ");
            }
            foreach (int element in a)
            {
                if (!b.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine("");
        }

        private static void AMinusB(List<int> a, List<int> b)
        {
            Console.Write("A Minus B: ");
            foreach (int element in a)
            {
                if (!b.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine("");
        }

        private static void Xor(List<int> a, List<int> b)
        {
            Console.Write("Xor Calculation: ");
            foreach (int element in a)
            {
                if (!b.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
            foreach (int element in b)
            {
                if (!a.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}
