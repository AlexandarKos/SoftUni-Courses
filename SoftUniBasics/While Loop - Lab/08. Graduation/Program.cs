using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // input student name 
            string studentName = Console.ReadLine();

            // create average grade variable number of grade/class counter variable
            double averageGrade = 0.0;
            int grade = 1;
            int retake = 0;
            while (grade < 13 )
            {
                // logical solution to the problem 
                double currentYearGrade = double.Parse(Console.ReadLine());

                if (currentYearGrade < 4.00)
                {
                    retake++;
                    if (retake > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        break;
                    }
                }
                else if (currentYearGrade >= 4.00)
                {
                    averageGrade += currentYearGrade;
                    grade++;
                }                                             
            }

            if (grade >= 12)
            {
                averageGrade /= 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
