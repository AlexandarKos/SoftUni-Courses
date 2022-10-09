using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfDailyFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            int biggestOrder = queue.Max();
            Console.WriteLine(biggestOrder);

            for (int i = 0; i < orders.Length; i++)
            {
                if (queue.Count > 0)
                {
                    int orderQuantity = queue.Peek();
                    if (quantityOfDailyFood >= orderQuantity)
                    {
                        quantityOfDailyFood -= queue.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
            }
        }
    }
}
