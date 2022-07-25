using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine()); // const target num
            int currentInput; // input from the user
            int sum = 0;

            while (targetNumber > sum)
            {
                currentInput = int.Parse(Console.ReadLine());
                sum += currentInput;
                //Console.WriteLine($"New sum is: {sum}");
            }
            Console.WriteLine(sum);
        }
    }
}
