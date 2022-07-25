using System;

namespace _01._Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the grade from the user
            double grade = double.Parse(Console.ReadLine());
            // print the message to the console if the grade is excellent
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
