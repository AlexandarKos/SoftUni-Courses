using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            double totalAmount = 0; // totalAmount to print at the end

            while (input != "NoMoreMoney")
            {
                // parse the string input to double
                double currentAmount = double.Parse(input);
                if (currentAmount < 0)
                {
                    // print invalid message and stop the program
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {currentAmount:f2}");
                totalAmount += currentAmount;
                // new input by the user
                input = Console.ReadLine();
            }
            // print the total amount
            Console.WriteLine($"Total: {totalAmount:f2}");
        }
    }
}
