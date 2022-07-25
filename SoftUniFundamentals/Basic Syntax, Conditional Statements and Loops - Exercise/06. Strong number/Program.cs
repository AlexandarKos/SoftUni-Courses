using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalNum = int.Parse(Console.ReadLine());

            int lastDigit = 0;
            int factSum = 1;
            int num = originalNum;
            bool isStrong = false;
            int totalFact = 0;
            while (num != 0)
            {
                lastDigit = num % 10;
                //if (lastDigit == 0)
                //{
                //    factSum++;
                //}
                for (int i = 1; i <= lastDigit; i++)
                {
                    factSum *= i; 
                }
                num /= 10;
                totalFact += factSum;
                factSum = 1;
            }
            if (totalFact == originalNum)
            {
                isStrong = true;
                
            }

            if (isStrong)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
