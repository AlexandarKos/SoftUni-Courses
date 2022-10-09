using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothesInBox);

            int racksCount = 1;
            int currClothes = 0;
            int currRackCapacity = rackCapacity;

            while (stack.Count > 0)
            {
                int currGarment = stack.Peek();
                if (currRackCapacity < currGarment)
                {
                    currRackCapacity = rackCapacity;
                    currRackCapacity -= stack.Pop();
                    racksCount++;
                }
                else if (currRackCapacity >= currGarment)
                {
                    currRackCapacity -= stack.Pop();
                }
                //else if (currRackCapacity == currGarment)
                //{

                //}

            }

            Console.WriteLine(racksCount);

        }
    }
}
