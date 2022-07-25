using System;

namespace _03._Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the number by the user
            int number = int.Parse(Console.ReadLine());
            // check if the number even and print the result            
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
