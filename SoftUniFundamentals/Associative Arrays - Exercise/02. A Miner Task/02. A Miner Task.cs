using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceCount = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resourceCount.ContainsKey(resource))
                {
                    resourceCount[resource] += quantity;
                }
                else
                {
                    resourceCount.Add(resource, quantity);
                }

                resource = Console.ReadLine();
            }

            foreach (var material in resourceCount)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");

            }
        }
    }
}
