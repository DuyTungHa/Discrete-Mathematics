using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutLevel
{
    class Permutation
    {
        private int n;
        private int r;
        private List<int> permutationList = new List<int>();
        public List<List<int>> Result { get; } = new List<List<int>>();

        public Permutation(int n, int r)
        {
            this.n = n;
            this.r = r;
            getPermutation();
        }

        private void getPermutation()
        {
            for (int i = 1; i <= r; i++)
            {
                permutationList.Add(i);
            }

            //For only one selection
            if (r == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            //Formultiple selections
            else
            {
                //Arrange the first array
                arrangeNumber();

                //Find other arrays
                while (true)
                {
                    int i = r;
                    while (permutationList[i - 1] == (n + i - r))
                    {
                        i--;
                        if (i == 0)
                            return;
                    }



                    permutationList[i - 1]++;

                    for (int a = i - 1; a <= r - 1; a++)
                    {
                        permutationList[a] = permutationList[i - 1] + a - (i - 1);
                    }

                    arrangeNumber();
                }
            }
        }

        private void arrangeNumber()
        {
            List<int> copyList = new List<int>(permutationList);
            //Print the first array list
            printResult(copyList);

            //Find the other arrangements
            while (true)
            {
                int i = r;
                while (copyList[i - 2] > copyList[i - 1])
                {
                    i--;
                    if (i == 1)
                        return;
                }
                i = i - 2;

                for (int a = r - 1; a > i; a--)
                {
                    if (copyList[a] > copyList[i])
                    {
                        int z = copyList[a];
                        copyList[a] = copyList[i];
                        copyList[i] = z;
                        break;
                    }
                }

                int s = i + 1;
                int t = r - 1;
                while (t > s)
                {
                    int z = copyList[s];
                    copyList[s] = copyList[t];
                    copyList[t] = z;

                    s++;
                    t--;
                }

                printResult(copyList);
            }

        }

        private void printResult(List<int> list)
        {
            List<int> temp = new List<int>(list);
            Result.Add(temp);
        }

        
    }
}
