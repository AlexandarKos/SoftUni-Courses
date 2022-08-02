using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];

                if (target == bombNumber)
                {
                    int start = Math.Max(0, i - power);
                    int end = Math.Min(numbers.Count - 1, i + power);
                    for (int j = start; j <= end; j++)
                    {
                        numbers[j] = 0;
                    }                    
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}