using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int query = input[0];

                switch (query)
                {
                    case 1:
                        int numberToPush = input[1];
                        stack.Push(numberToPush);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            int maxNumber = stack.Max();
                            Console.WriteLine(maxNumber);
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            int minNumber = stack.Min();
                            Console.WriteLine(minNumber);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
