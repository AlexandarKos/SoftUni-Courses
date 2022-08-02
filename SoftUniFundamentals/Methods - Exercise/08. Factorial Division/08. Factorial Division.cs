using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result = DivideFactorialOfNumbers(num1, num2);
            Console.WriteLine($"{result:f2}");
        }

        static double GetFactorialOfInt(int num)
        {
            double  factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static double DivideFactorialOfNumbers(int num1, int num2)
        {
            double result = GetFactorialOfInt(num1) / GetFactorialOfInt(num2);
            return result;
        }
    }
}
