using System;

namespace _02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read input for radians
            double radians = double.Parse(Console.ReadLine());
            // get the degrees 
            double degrees = radians * 180 / Math.PI;
            // print the result
            Console.WriteLine(degrees);

        }
    }
}
