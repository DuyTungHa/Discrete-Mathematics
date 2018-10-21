using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgingRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length n of relation matrix nxn: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Enter the matrix of a relation:");
            for (int i =0;i<n; i++)
            {
                String[] a = Console.ReadLine().Split(' ');
                for(int j = 0;j<n;j++)
                {
                    matrix[i, j] = int.Parse( a[j]);
                }
            }

            if (hasBridgingRelation(matrix, n))
                Console.WriteLine("That relation is of bridging relation");
            else
                Console.WriteLine("That relation is not of bridging relation");
            
            Console.ReadKey();
        }

        static bool hasBridgingRelation(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k =0; k<n; k++)
                    {
                        if (matrix[i, j] == 1 && matrix[j, k] == 1 && matrix[i, k] != 1)
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
