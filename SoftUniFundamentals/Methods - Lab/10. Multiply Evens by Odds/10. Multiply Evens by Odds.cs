using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(input), GetSumOfOddDigits(input)));
        }

        static int GetSumOfOddDigits(int input)
        {
            int lastNum = input;
            int result = 0;
            while (input > 0)
            {
                lastNum = input % 10;
                if (lastNum % 2 != 0)
                {
                    result += lastNum;
                }
                input /= 10;
            }
            return result;
        }

        static int GetSumOfEvenDigits(int input)
        {
            int lastNum = input;
            int result = 0;
            while (input > 0)
            {
                lastNum = input % 10;
                if (lastNum % 2 == 0)
                {
                    result += lastNum;                    
                }
                input /= 10;
            }
            return result;
        }

        static int GetMultipleOfEvenAndOdds(int a, int b)
        {
            return a * b;
        }
    }
}
