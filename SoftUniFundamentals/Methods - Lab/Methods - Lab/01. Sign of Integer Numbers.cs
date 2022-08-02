using System;

namespace Methods___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SignOfInteger(int.Parse(Console.ReadLine()));
        }

        static void SignOfInteger(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }

        }
    }
}
