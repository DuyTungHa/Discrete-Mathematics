using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquivalenceMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length n of relation matrix nxn: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Enter the matrix of a relation:");
            for (int i = 0; i < n; i++)
            {
                String[] a = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(a[j]);
                }
            }

            matrix = makeEquivalence(matrix, n);

            Console.WriteLine("The smallest equivalence relation matrix is:");
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        static int[,] makeEquivalence(int[,] matrix, int n)
        {
            for (int i = 0; i< n; i++)
            {
                matrix[i, i] = 1;
            }

            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    if (i != j && matrix[i, j] == 1)
                        matrix[j, i] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (matrix[i, j] == 1 && matrix[j, k] == 1)
                            matrix[i, k] = 1;
                    }
                }
            }

            return matrix;
        }
    }
}
