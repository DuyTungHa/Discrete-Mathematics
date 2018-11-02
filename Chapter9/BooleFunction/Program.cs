using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleFunction
{
    class Program
    {
        private int[,] table;
        private string[] vars;
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        private void go()
        {
            table = new int[8, 4];
            vars = new string[3] { "x", "y", "z"};
            Console.WriteLine("Enter the values of boole function with 3 variables namely x, y, z: ");
            Console.WriteLine("x y z value");
            for(int i = 0; i<8; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for(int j = 0; j<4; j++)
                {
                    table[i, j] = int.Parse(input[j]);
                }
            }
            string func = findFunctionNaive();
            Console.WriteLine("The boole function found naively is: " + func);
            printKarnaugh(func);
        }

        private string findFunctionNaive()
        {
            string result = String.Empty;
            for(int i =0; i<8; i++)
            {
                if(table[i,3] == 1)
                {
                    for(int j = 0; j<3; j++)
                    {
                        result += formVariable(vars[j], table[i, j]);
                    }
                    result += " + ";
                }
            }
            result = result.Substring(0,result.Length - 3);
            return result;
        }

        private string formVariable(string variable, int booleValue)
        {
            if (booleValue == 1)
                return variable;
            else
                return "(-" + variable + ")";
        }

        private void printKarnaugh(string func)
        {
            string[] elemFunc = func.Split(' ');
            string[] row = new string[2] { "x", "(-x)" };
            string[] column = new string[4] { "yz", "y(-z)", "(-y)(-z)", "(-y)z" };
            int[,] result = new int[2, 4];

            for(int i =0; i<2; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    if (elemFunc.ToList().Contains(row[i] + column[j]))
                        result[i, j] = 1;
                    else
                        result[i, j] = 0;
                }
            }

            Console.WriteLine("The Karnaugh map of the boole function is: ");
            Console.WriteLine("      yz      y(-z)    (-y)(-z)   (-y)z");
            for(int i = 0; i<2; i++)
            {
                if (i == 0)
                    Console.Write("  x   ");
                else
                    Console.Write("(-x)  ");
                for(int j =0; j<4; j++)
                {
                    Console.Write(result[i, j] + "         ");
                }
                Console.WriteLine();
            }
        }
    }
}
