using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the deposit 
            double deposit = double.Parse(Console.ReadLine());
            // input deposit timeframe/term in months
            int lengthInMonths = int.Parse(Console.ReadLine());
            // input yearly interest rate in type double
            double yearlyInterestRate = double.Parse(Console.ReadLine());

            // calculate the sum at the end of the term/timeframe
            double endTermSum = deposit + lengthInMonths * ((deposit * (yearlyInterestRate/100)) / 12);
            // print the result sum
            Console.WriteLine(endTermSum);
        }
    }
}
