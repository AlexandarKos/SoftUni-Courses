using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> queue = new Queue<int>();

            foreach (int num in input)
            {
                if (num % 2 == 0)
                {
                    queue.Enqueue(num);
                }
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
