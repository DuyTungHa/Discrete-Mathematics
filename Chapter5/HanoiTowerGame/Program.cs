using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        private void go()
        {
            Console.Write("Enter the number of stories: ");
            int story = int.Parse(Console.ReadLine());
            Console.WriteLine("The number of steps to finish the game is: " + calculateSteps(story));
        }

        private long calculateSteps(int a)
        {
            if (a == 1)
                return 1;
            else
                return (2 * calculateSteps(a - 1) + 1);
        }
    }
}
