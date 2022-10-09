using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbersTimes = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (!numbersTimes.ContainsKey(currNum))
                {
                    numbersTimes.Add(currNum, 0);
                }

                numbersTimes[currNum]++;
            }

            foreach (var item in numbersTimes)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
