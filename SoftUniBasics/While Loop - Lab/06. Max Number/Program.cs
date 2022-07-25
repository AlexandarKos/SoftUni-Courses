using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double maxNumber = int.MinValue;

            do
            {
                input = Console.ReadLine();

                bool isDouble = double.TryParse(input, out double currentNumber);
                if (isDouble && maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            while (input != "Stop");
            Console.WriteLine(maxNumber);
        }
    }
}