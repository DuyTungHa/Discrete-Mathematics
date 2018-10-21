using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameTree
{
    class Program
    {
        List<Node> graph;
        List<Node> tree;
        int[,] matrix;
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        private void go()
        {
            graph = new List<Node>();
            tree = new List<Node>();

            Console.Write("Enter the list of verticals: ");
            string[] input = Console.ReadLine().Split(' ');
            matrix = new int[input.Length, input.Length];
            foreach(string e in input)
            {
                Node node = new Node();
                node.name = e;
                graph.Add(node);
            }

            Console.WriteLine("Enter the matrix of the graph: ");
            for(int i =0; i<input.Length; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for(int j =0; j<line.Length; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            Console.Write("Do you want to find a normal frame tree or a smallest frame tree?: ");
            if (Console.ReadLine() == "normal frame tree")
            {
                tree.Add(graph[0]);
                buildTree(tree[0]);
                Console.WriteLine("The frame tree is: (parent first, then children from left to right) ");
                printTree(tree[0]);
            }
            else
            {
                Console.WriteLine("The smallest frame tree with value of " + smallestFrameTree() + " is: (parent first, then children from left to right) ");
                printTree(tree[0]);
            }
        }

        private void buildTree(Node current)
        {
            for(int i = 0; i<graph.Count; i++)
            {
                if(matrix[graph.IndexOf(current),i] >0 && !tree.Contains(graph[i]))
                {
                    current.children.Add(graph[i]);
                    tree.Add(graph[i]);
                }
            }

            if (current.children.Count == 0)
                return;

            foreach(Node e in current.children)
            {
                buildTree(e);
            }
        }

        private int smallestFrameTree()
        {
            int result = 0;

            if(tree.Count == graph.Count)
            {
                return result;
            }
            else if (tree.Count == 0)
            {
                int min = int.MaxValue;
                int iMin = 0;
                int jMin = 0;

                for(int i =0; i<graph.Count; i++)
                {
                    for(int j = i; j<graph.Count; j++)
                    {
                        if(matrix[i,j] > 0 && matrix[i,j] < min)
                        {
                            min = matrix[i, j];
                            iMin = i;
                            jMin = j;
                        }
                    }
                }

                graph[iMin].children.Add(graph[jMin]);
                tree.Add(graph[iMin]);
                tree.Add(graph[jMin]);

                result += min + smallestFrameTree();
                return result;
            }
            else
            {
                int min = int.MaxValue;
                int iMin = 0;
                int jMin = 0;

                foreach(Node e in tree)
                {
                    for(int j = 0; j< graph.Count; j++)
                    {
                        if(matrix[graph.IndexOf(e),j] > 0 && matrix[graph.IndexOf(e), j] <min && !tree.Contains(graph[j]))
                        {
                            iMin = graph.IndexOf(e);
                            jMin = j;
                            min = matrix[graph.IndexOf(e), j];
                        }
                    }
                }

                graph[iMin].children.Add(graph[jMin]);
                tree.Add(graph[jMin]);

                result += min + smallestFrameTree();
                return result;
            }
        }

        private void printTree(Node current)
        {
            Console.Write(current.name + " ");
            if (current.children.Count != 0)
                foreach (Node e in current.children)
                    printTree(e);
        }
    }
}
