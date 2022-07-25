using System;

namespace _05._Number_100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the number by the user
            int number = int.Parse(Console.ReadLine());
            // check the number and print accordingly
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >=100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
