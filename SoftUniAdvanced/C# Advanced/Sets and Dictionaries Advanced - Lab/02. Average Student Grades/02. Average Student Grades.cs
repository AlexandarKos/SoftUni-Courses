using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> keyValuePairs = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                List<decimal> values = new List<decimal>();

                if (!keyValuePairs.ContainsKey(name))
                {
                    values.Add(grade);
                    keyValuePairs.Add(name, values);
                }
                else
                {
                    keyValuePairs[name].Add(grade);
                }
            }

            foreach (var student in keyValuePairs)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var item in student.Value)
                {
                    Console.Write($"{item:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}