using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutLevel
{
    class SingleGraph : GeneralGraph
    {
        private List<string> group1;
        private List<string> group2;
        private List<int> length;
        private int[] level;
        public List<int> Length { set => length = value; }
        public SingleGraph(string[,] edges) : base(edges)
        {
            group1 = new List<string>();
            group2 = new List<string>();
            level = new int[verticals.Count];
            for(int i = 0; i<edges.GetLength(0); i++)
            {
                level[verticals.IndexOf(edges[i, 0])]++;
                level[verticals.IndexOf(edges[i, 1])]++;
            }
        }
        
        public bool Devidable()
        {
            bool result = true;
            group1.Add(verticals[0]);
            verticals.RemoveAt(0);

            while (verticals.Count > 0)
            {
                if (!result) break;
                foreach(string e in group1)
                {
                    if (!result) break;
                    for(int i = 0; i<edges.GetLength(0); i++)
                    {
                        if(e == edges[i,0] || e == edges[i, 1])
                        {
                            string verticalAdd = e == edges[i, 0] ? edges[i, 1] : edges[i, 0];
                            if (group1.Contains(verticalAdd))
                            {
                                result = false;
                                break;
                            }
                            if (!group2.Contains(verticalAdd))
                            {
                                group2.Add(verticalAdd);
                                verticals.Remove(verticalAdd);
                            }
                        }
                    }
                }

                foreach(string e in group2)
                {
                    if (!result) break;
                    for (int i = 0; i < edges.GetLength(0); i++)
                    {
                        if (e == edges[i, 0] || e == edges[i, 1])
                        {
                            string verticalAdd = e == edges[i, 0] ? edges[i, 1] : edges[i, 0];
                            if (group2.Contains(verticalAdd))
                            {
                                result = false;
                                break;
                            }
                            if (!group1.Contains(verticalAdd))
                            {
                                group1.Add(verticalAdd);
                                verticals.Remove(verticalAdd);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public int[,] makeMatrix(List<string> specifiedVerticals)
        {
            int[,] matrix = new int[specifiedVerticals.Count, specifiedVerticals.Count];
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                matrix[specifiedVerticals.IndexOf(edges[i, 0]), specifiedVerticals.IndexOf(edges[i, 1])] = 1;
                matrix[specifiedVerticals.IndexOf(edges[i, 1]), specifiedVerticals.IndexOf(edges[i, 0])] = 1;
            }
            return matrix;
        }

        public void shortestRoad(string start, string end)
        {
            List<long> verticalLength = new List<long>();
            List<string> road = new List<string>();
            List<string> S = new List<string>();
            int[,] w = new int[verticals.Count, verticals.Count];

            for(int i =0; i<w.GetLength(0); i++)
            {
                for(int j =0; j<w.GetLength(0); j++)
                {
                    w[i, j] = int.MaxValue;
                }
            }
            for(int i = 0; i<edges.GetLength(0); i++)
            {
                w[verticals.IndexOf(edges[i, 0]), verticals.IndexOf(edges[i, 1])] = length[i];
                w[verticals.IndexOf(edges[i, 1]), verticals.IndexOf(edges[i, 0])] = length[i];
            }
            for(int i = 0; i< verticals.Count; i++)
            {
                if (i == verticals.IndexOf(start))
                {
                    verticalLength.Add(0);
                    road.Add("a");
                }
                else
                {
                    road.Add(String.Empty);
                    verticalLength.Add(int.MaxValue);
                }
            }



            while (!S.Contains(end))
            {
                long minLength = int.MaxValue;
                foreach(string u in verticals)
                {
                    if(!S.Contains(u))
                        minLength = Math.Min(minLength, verticalLength[verticals.IndexOf(u)]);
                }
                S.Add(verticals[verticalLength.IndexOf(minLength)]);

                foreach(string v in verticals)
                {
                    if(!S.Contains(v))
                    {
                        if (minLength + w[verticalLength.IndexOf(minLength), verticals.IndexOf(v)] < verticalLength[verticals.IndexOf(v)])
                        {
                            verticalLength[verticals.IndexOf(v)] = minLength + w[verticalLength.IndexOf(minLength), verticals.IndexOf(v)];
                            road[verticals.IndexOf(v)] = road[verticalLength.IndexOf(minLength)] + v;
                        }
                    }
                } 
            }

            Console.WriteLine("The road is " + road[verticals.IndexOf(end)] + " and the length is " + verticalLength[verticals.IndexOf(end)]);
        }

        public int[] colorGraph()
        {
            int[] colors = new int[verticals.Count];
            int maxLevelIndex = 0;
            int color = 0;
            while (true)
            {
                for (int i = 0; i < level.Length; i++)
                {
                    if (level[i] > level[maxLevelIndex])
                        maxLevelIndex = i;
                }
                if (level[maxLevelIndex] == int.MinValue)
                    break;
                level[maxLevelIndex] = int.MinValue;
                colors[maxLevelIndex] = ++color;
                
                foreach(string e in verticals)
                {
                    bool found = true;
                    for(int j = 0; j<colors.Length; j++)
                    {
                        if (colors[j] == color)
                        {
                            for (int i = 0; i < edges.GetLength(0); i++)
                            {
                                if ((verticals[j] == edges[i, 0] && e == edges[i, 1]) || (verticals[j] == edges[i, 1] && e == edges[i, 0]))
                                {
                                    found = false;
                                    break;
                                }
                            }
                        }
                        if (!found)
                            break;

                    }   
                    if(found && colors[verticals.IndexOf(e)] ==0)
                        {
                        colors[verticals.IndexOf(e)] = color;
                        level[verticals.IndexOf(e)] = int.MinValue;
                    }
                }
            }
            return colors;
        }
    }
}
