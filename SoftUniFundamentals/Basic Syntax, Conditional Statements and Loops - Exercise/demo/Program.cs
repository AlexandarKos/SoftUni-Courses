using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 40;
            int lastDigit = num % 10;
            Console.WriteLine(lastDigit);
            num /= 10;
            Console.WriteLine(num);
            //if (num % 10 == 0)
            //{

            //}
        }
    }
}
