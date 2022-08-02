using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(a, b));
        }

        static double RaiseToPower(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
