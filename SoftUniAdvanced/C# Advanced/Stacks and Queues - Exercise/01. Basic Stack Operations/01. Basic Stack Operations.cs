using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int elementsToRemove = input[1];
            int elementToPeek = input[2];

            Stack<int> stack = new Stack<int>(n);

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(elementToPeek))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(elementToPeek))
            {
                int minElement = stack.Min();
                Console.WriteLine(minElement);
            }
        }
    }
}
