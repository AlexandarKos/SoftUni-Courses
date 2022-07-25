using System;

namespace _02._Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the two numbers by the user
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            // print the bigger number of the two
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
