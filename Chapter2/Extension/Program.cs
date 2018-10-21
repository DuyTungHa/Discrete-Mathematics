using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int r;
            String result = String.Empty;


            Console.Write("Enter the number you want to expand: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the base number: ");
            b = int.Parse(Console.ReadLine());

            while (a >= b)
            {
                r = a % b;
                a = a / b;
                result = FormatResult(result, r);
            }

            //The last number in the expansion is a
            result = FormatResult(result, a); 

            Console.WriteLine("The base expansion of your number is: " + result);

            Console.ReadKey();
        }

        static String FormatResult(String result, int number)
        {
            if (number >= 10)
            {
                result = String.Format((Surplus)number + result);
            }
            else
            {
                result = String.Format(number + result);
            }

            return result;
        }
    }
}
