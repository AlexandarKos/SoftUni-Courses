using System;

namespace T04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input for inches by user
            double inchesInput = double.Parse(Console.ReadLine());
            // convert to centimeters logic
            double resultInCentimeters = inchesInput * 2.54;
            // Printing the result to console
            Console.WriteLine(resultInCentimeters);

        }
    }
}
