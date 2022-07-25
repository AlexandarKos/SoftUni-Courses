using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //isSpecial => when its sum of digits is 5, 7 or 11.
            //Read an integer n and for all numbers in the range 1…n -> print the number and if it is special or not (True / False).

            int n = int.Parse(Console.ReadLine());
            //bool isSpecial = false;

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                while (number != 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");

                }
                sum = 0;
            }
        }
    }
}
