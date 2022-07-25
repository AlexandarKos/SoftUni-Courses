using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int validCombinationsCount = 0;
            for (int i = 0; i <=n; i++)
            {
                for (int y = 0; y <= n; y++)
                {
                    for (int z = 0; z <= n; z++)
                    {
                        if (i+y+z == n )
                        {
                            validCombinationsCount++;
                        }
                    }
                }
            }
            Console.WriteLine(validCombinationsCount);
        }
    }
}
