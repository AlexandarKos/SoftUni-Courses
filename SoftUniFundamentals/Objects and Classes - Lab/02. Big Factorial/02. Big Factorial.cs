using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= range; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
