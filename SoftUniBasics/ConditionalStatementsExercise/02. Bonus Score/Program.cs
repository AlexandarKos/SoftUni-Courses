using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the initial points by the user
            int number = int.Parse(Console.ReadLine());

            // create a variable for the bonus points
            double bonus = 0.0;

            // add bonus points to the number according to the range

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            else
            {
                bonus = number * 0.2;
            }

            if (number % 2 == 0)
            {
                bonus++;
            }
            else if (number % 5 == 0)
            {
                bonus += 2;
            }

            // Print the bonus and the total number

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
