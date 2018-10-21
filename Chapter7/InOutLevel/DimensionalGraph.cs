using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutLevel
{
    class DimensionalGraph : GeneralGraph
    {
        private int[] inLevel;
        private int[] outLevel;
        private int[,] matrix;
        public DimensionalGraph(string[,] edges) : base(edges)
        {
            inLevel = new int[verticals.Count];
            outLevel = new int[verticals.Count];
            for(int i = 0; i<verticals.Count; i++)
            {
                inLevel[i] = 0;
                outLevel[i] = 0;
            }
            setUpDimensionalGraph();
            matrix = makeMatrix(verticals);
        }

        protected void setUpDimensionalGraph()
        {
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                inLevel[verticals.IndexOf(edges[i, 1])]++;
                outLevel[verticals.IndexOf(edges[i, 0])]++;
            }
        }

        public int[] GetInLevel()
        {
            return inLevel;
        }

        public int[] GetOutLevel()
        {
            return outLevel;
        }

        public int[,] makeMatrix(List<string> specifiedVerticals)
        {
            int[,] matrix = new int[specifiedVerticals.Count, specifiedVerticals.Count];
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                matrix[specifiedVerticals.IndexOf(edges[i, 0]), specifiedVerticals.IndexOf(edges[i, 1])] ++;
            }
            return matrix;
        }

        private bool checkEulerRoad()
        {
            int s;
            int d = 0;
            for(int i =0;i <verticals.Count; i++)
            {
                s = 0;
                for(int j =0; j<verticals.Count; j++)
                {
                    s += matrix[i, j];
                    s += matrix[j, i];
                }
                if (s % 2 != 0) d++;
            }
            if (d > 0)
                return false;
            return true;
        }

        public List<string> FindEulerRoad()
        {
            int x;
            int v;
            Stack<int> temp = new Stack<int>();
            List<string> dce = new List<string>();
            if (!checkEulerRoad()) return dce;
            temp.Push(0);
            while (temp.Count > 0)
            {
                x = 0;
                v = temp.Peek();
                while (x < verticals.Count && matrix[v, x] == 0)
                    x++;
                if (x == verticals.Count)
                {
                    dce.Add(verticals[v]);
                    temp.Pop();
                }
                else
                {
                    temp.Push(x);
                    matrix[v, x]--;
                }
            }
            return dce;
        }

    }
}
