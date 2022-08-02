using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grades(double.Parse(Console.ReadLine()));
        }

        static void Grades(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
