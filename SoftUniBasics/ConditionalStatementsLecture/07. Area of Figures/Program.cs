using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the type of the figure
            string figure = Console.ReadLine();

            // input the dimensions according to the figure type
            if (figure == "square")
            {
                // input the square length
                double squareLength = double.Parse(Console.ReadLine());

                // print the square area => a*a (round up to 3 digits)
                double squareArea = squareLength * squareLength;               
                Console.WriteLine("{0:F3}", squareArea);
            }
            else if (figure == "rectangle")
            {
                // input the two rectangle sides needed to calculate its area
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                // calculate and print the rectangle area (round up to 3 digits)
                double rectangleArea = sideB * sideA;
                Console.WriteLine("{0:F3}", rectangleArea);
            }
            else if (figure== "circle")
            {
                // input the circle radius
                double radius = double.Parse(Console.ReadLine());

                // calcualte the circle area, round it to 3 digits and print 
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine("{0:F3}", circleArea);
            }
            else
            {
                // input the triangle side and height
                double triangleSide = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                // calculate the triangle area and print it with rounding
                double triangleArea = (triangleSide * height) / 2;
                Console.WriteLine("{0:F3}", triangleArea);
            }
        }
    }
}
