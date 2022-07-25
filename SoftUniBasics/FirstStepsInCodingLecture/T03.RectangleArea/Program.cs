using System;

namespace T03.RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input for side A of rectangle
            int sideA = int.Parse(Console.ReadLine());
            // Input for side B of rectangle
            int sideB = int.Parse(Console.ReadLine());

            // Logical solution of the problem

            int rectangleArea = sideA * sideB;

            // Printing the result

            Console.WriteLine(rectangleArea);

        }
    }
}
