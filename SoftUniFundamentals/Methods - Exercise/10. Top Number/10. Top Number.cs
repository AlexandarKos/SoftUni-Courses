using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumbers1ToN(n);
        }

        static bool HoldsOddDigit(int number)
        {
            // · Holds at least one odd digit, e.g. 232, 707, 87578
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static bool DivisibleByEight(int number)
        {
            //· Its sum of digits is divisible by 8, e.g. 8, 17, 88
            if (number % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TopNumbers1ToN(int rangeEnd)
        {
            for (int i = 1; i <= rangeEnd; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }            
        }

        static bool IsTopNumber(int number)
        {
            if (DivisibleByEight(SumOfDigits(number)) && HoldsOddDigit(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int SumOfDigits(int number)
        {
            int sumOfDigits = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                sumOfDigits += lastDigit;
                number /= 10;
            }
            return sumOfDigits;
        }
    }
}