using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            int totalSteps = 0;
            while (totalSteps <= 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    totalSteps += int.Parse(input);
                }                                
            }
            
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
