using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfAllStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfAllStudents; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();
                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderByDescending(g => g.Grade).ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }            
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
    }
}
