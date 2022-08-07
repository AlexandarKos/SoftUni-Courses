using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesInforation = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" : ").ToArray();

            while (input[0] != "end")
            {
                string course = input[0];
                string studentName = input[1];

                if (!coursesInforation.ContainsKey(course))
                {
                    coursesInforation.Add(course, new List<string>());
                }
                coursesInforation[course].Add(studentName);

                input = Console.ReadLine().Split(" : ").ToArray();
            }

            foreach (var course in coursesInforation)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}