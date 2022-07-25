using System;

namespace T07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the name of the architect
            string nameOfArchitect = Console.ReadLine();
            // input the number of projects the architect must do
            int numberOfProjects = int.Parse(Console.ReadLine());
            // input single project time in type int
            int singleProjectTime = 3;
            // logical solution for total hours needed for all projects
            int totalProjectTime = numberOfProjects * singleProjectTime;
            // print the result

            Console.WriteLine($"The architect {nameOfArchitect} will need {totalProjectTime} hours to complete {numberOfProjects} project/s.");
        }
    }
}
