using System;

namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the number and print invalid if the number is outside the [100...200] or is 0
            int number = int.Parse(Console.ReadLine());
            if (number >= 100 && number <=200 || number == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
