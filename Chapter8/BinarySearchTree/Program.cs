using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        List<int> numbers;
        Node root;
        static void Main(string[] args)
        {
            new Program().go();
            Console.ReadKey();
        }

        private void go()
        {
            Console.Write("Enter an array of different numbers: ");
            string[] input = Console.ReadLine().Split(' ');
            numbers = new List<int>();
            foreach (string e in input)
            {
                numbers.Add(int.Parse(e));
            }

            root = new Node();
            root.index = 0;

            setUpTree();

            AddNumber();
        }

        private void AddNumber()
        {
            Console.Write("Add a number to the existing tree: ");
            int number = int.Parse(Console.ReadLine());

            if (numbers.Contains(number))
                Console.WriteLine("The element is already in the tree");
            else
            {
                numbers.Add(number);
                addElementToTree(number);
                printResult();
            }
        }

        private void setUpTree()
        {
            foreach(int number in numbers)
            {
                if(number != numbers[0])
                {
                    addElementToTree(number);
                }
            }
            printResult();
        }

        private void addElementToTree(int number)
        {
            Node current = new Node();
            current.index = numbers.IndexOf(number);
            Node compareNode = root;

            while (true)
            {
                if (number < numbers[compareNode.index])
                {
                    if (compareNode.leftChild != null)
                        compareNode = compareNode.leftChild;
                    else
                    {
                        compareNode.leftChild = current;
                        break;
                    }
                }
                else
                {
                    if (compareNode.rightChild != null)
                        compareNode = compareNode.rightChild;
                    else
                    {
                        compareNode.rightChild = current;
                        break;
                    }
                }
            }
            
        }

        private void printResult()
        {
            Console.WriteLine("The tree is: (parent first, then left, and then right child) ");
            printResult(root, numbers);
            Console.WriteLine();
        }

        private void printResult(Node node, List<int> numbers)
        {
            if (node == null)
                return;
            else
            {
                Console.Write(numbers[node.index] + " ");
                printResult(node.leftChild, numbers);
                printResult(node.rightChild, numbers);
            }
        }
    }
}
