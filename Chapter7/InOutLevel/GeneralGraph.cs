using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutLevel
{
    class GeneralGraph
    {
        protected List<string> verticals;
        protected string[,] edges;

        public GeneralGraph(string[,] edges)
        {
            this.edges = edges;
            verticals = new List<string>();
            setUpGraph();
        }

        private void setUpGraph()
        {
            for(int i =0; i< edges.GetLength(0); i++)
            {
                for(int j = 0; j<2; j++)
                {
                    if (!verticals.Contains(edges[i, j]))
                        verticals.Add(edges[i, j]);
                }
            }
        }

        public List<string> GetVerticals()
        {
            return verticals;
        }
    }
}
