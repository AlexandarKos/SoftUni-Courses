using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input number of pages in the book
            int numPages = int.Parse(Console.ReadLine());
            // input number of pages read in one hour
            int pagesPerHour = int.Parse(Console.ReadLine());
            // input number of days to read
            int days = int.Parse(Console.ReadLine());

            // logical solution for number of hours per day needed to read the book

            int totalTimeToRead = numPages / pagesPerHour;
            int neededHoursPerDay = totalTimeToRead / days;

            // Print the result

            Console.WriteLine(neededHoursPerDay);
        }
    }
}
