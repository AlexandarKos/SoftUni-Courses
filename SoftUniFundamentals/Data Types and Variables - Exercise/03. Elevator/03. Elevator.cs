using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            short capacityPerCourse = short.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacityPerCourse);

            Console.WriteLine(courses);
        }
    }
}
