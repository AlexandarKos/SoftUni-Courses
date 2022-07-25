using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            //int number = 0;
            bool isSpecialNum = false;

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                while (number > 0)
                {

                    sum += number % 10;

                    number = number / 10;

                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
                sum = 0;
                //i = number;
            }
        }
    }
}
