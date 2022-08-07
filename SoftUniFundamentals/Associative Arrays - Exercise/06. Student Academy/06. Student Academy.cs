using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairOfRows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < pairOfRows; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades.Add(student, new List<double>());
                }
                studentsGrades[student].Add(grade);
            }

            foreach (var student in studentsGrades)
            {
                string studentName = student.Key;
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{studentName} -> {averageGrade:f2}");
                }
            }
        }
    }
}