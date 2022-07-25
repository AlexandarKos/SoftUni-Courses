using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            int totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                totalSum += (int)currChar;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
