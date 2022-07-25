using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            short sumOfDigits = 0;

            while (number != 0)
            {
                sumOfDigits += (short)(number % 10);
                number /= 10;
            }
            Console.WriteLine(sumOfDigits);

        }
    }
}
