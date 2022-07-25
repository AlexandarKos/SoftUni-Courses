using System;

namespace _06._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the number by the user
            double number = double.Parse(Console.ReadLine());

            // print the output if it's in the interval of -100, 100 and not 0.
            if (number != 0 && number >= -100 && number <= 100 )
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
