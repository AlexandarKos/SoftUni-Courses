using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "{първи множител} * {втори множител} = {резултат}"

            for (int i = 1; i <= 10; i++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{i} * {y} = {i*y}");
                }
            }
        }
    }
}
