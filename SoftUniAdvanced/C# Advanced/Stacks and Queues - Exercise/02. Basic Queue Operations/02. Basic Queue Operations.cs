using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int eleToEnqueue = input[0];
            int eleToDequeue = input[1];
            int eleToPeek = input[2];

            int[] intArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(eleToEnqueue);

            foreach (int num in intArr)
            {
                queue.Enqueue(num);
            }

            for (int i = 0; i < eleToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(eleToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestEle = queue.Min();
                Console.WriteLine(smallestEle);
            }
        }
    }
}
