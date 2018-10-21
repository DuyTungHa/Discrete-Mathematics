using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutLevel
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
            Console.Write("How many edges does your graph have? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your edges below: ");
            string[,] edges = new string[n, 2];
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                string[] edge = Console.ReadLine().Split(" ".ToCharArray());
                edges[i, 0] = edge[0];
                edges[i, 1] = edge[1];
            }

            findEulerPath(edges);

        }

        private void findEulerPath(string[,] edges)
        {
            DimensionalGraph dimensionalGraph = new DimensionalGraph(edges);
            List<string> result = dimensionalGraph.FindEulerRoad();
            if (result.Count == 0)
                Console.WriteLine("There is no Euler road in this graph");
            else
            {
                Console.Write("The Euler Road in this graph is: ");
                for(int i = result.Count -1; i>=0; i--)
                {
                    Console.Write(result[i] + " ");
                }
                Console.WriteLine("");
            }
        }

        private void colorGraph(string[,] edges)
        {
            SingleGraph singleGraph = new SingleGraph(edges);
            int[] colors = singleGraph.colorGraph();
            Console.Write("The color of verticals " + produceVerticalString(singleGraph) + "respectively are: ");
            foreach(int e in colors)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine("");
        }

        private void theShortestRoad (string[,] edges)
        {
            SingleGraph singleGraph = new SingleGraph(edges);
            Console.WriteLine("Enter the length of the edges below:");
            List<int> length = new List<int>();
            for(int i = 0; i<edges.GetLength(0); i++)
            {
                length.Add(int.Parse(Console.ReadLine()));
            }
            singleGraph.Length = length;
            Console.Write("Where do you want to start: ");
            string start = Console.ReadLine();
            Console.Write("Where do you want to stop: ");
            string end = Console.ReadLine();
            singleGraph.shortestRoad(start, end);
        }

        private void sameStructure(string[,] edges)
        {
            SingleGraph singleGraph = new SingleGraph(edges);

            Console.Write("How many edges does your second graph have? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your edges below: ");
            string[,] secondEdges = new string[n, 2];
            for (int i = 0; i < secondEdges.GetLength(0); i++)
            {
                string[] edge = Console.ReadLine().Split(" ".ToCharArray());
                secondEdges[i, 0] = edge[0];
                secondEdges[i, 1] = edge[1];
            }

            SingleGraph secondGraph = new SingleGraph(secondEdges);
            if(singleGraph.GetVerticals().Count != secondGraph.GetVerticals().Count)
            {
                Console.WriteLine("They are not the same");
                return;
            }
            Permutation permutation = new Permutation(singleGraph.GetVerticals().Count, singleGraph.GetVerticals().Count);
            bool found = true;
            foreach(List<int> e in permutation.Result)
            {
                found = true;
                List<string> specifiedVerticals = new List<string>();
                foreach(int e1 in e)
                {
                    specifiedVerticals.Add(singleGraph.GetVerticals()[e1 - 1]);
                }
                int[,] firstMatrix = singleGraph.makeMatrix(specifiedVerticals);
                int[,] secondMatrix = secondGraph.makeMatrix(secondGraph.GetVerticals());

                for(int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    for(int j =0; j< firstMatrix.GetLength(1); j++)
                    {
                        if (firstMatrix[i,j] != secondMatrix[i,j])
                        {
                            found = false;
                            break;
                        }
                    }
                }

                if (found)
                {
                    Console.WriteLine("They are the same");
                    return;
                }     
            }
            if(!found)
                Console.WriteLine("They are not the same");
        }

        private void SingleDividableResult(string[,] edges)
        {
            SingleGraph graph = new SingleGraph(edges);
            Console.WriteLine("The given single graph is devisable? " + graph.Devidable());
        }

        private void DimensionalResult(string[,] edges)
        {
            DimensionalGraph graph = new DimensionalGraph(edges);
            Console.WriteLine("The in and out level for verticals: " + produceVerticalString(graph) + "respectively are: ");
            Console.Write("In level: ");
            foreach (int e in graph.GetInLevel())
            {
                Console.Write(e + " ");
            }
            Console.WriteLine("");
            Console.Write("Out level: ");
            foreach (int e in graph.GetOutLevel())
            {
                Console.Write(e + " ");
            }
        }

        private string produceVerticalString(GeneralGraph graph)
        {
            string result = String.Empty;
            foreach(string e in graph.GetVerticals())
            {
                result += (e + " ");
            }
            return result;
        }
    }
}
