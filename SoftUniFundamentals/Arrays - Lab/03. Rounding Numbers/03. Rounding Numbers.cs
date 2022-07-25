using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split();
            double[] realNumbers = new double[items.Length];
            double[] roundedNumbers = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                realNumbers[i] = double.Parse(items[i]);
                roundedNumbers[i] = (int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero);
            }
            for (int j = 0; j < items.Length; j++)
            {
                Console.WriteLine($"{realNumbers[j]} => {roundedNumbers[j]}");
            }
        }
    }
}
