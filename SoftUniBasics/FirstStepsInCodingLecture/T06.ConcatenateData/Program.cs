using System;

namespace T06.ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input first name by user
            string firstName = Console.ReadLine();
            // input last name by user
            string lastName = Console.ReadLine();
            // input age by user type int
            int age = int.Parse(Console.ReadLine());
            // input town by user
            string town = Console.ReadLine();

            // Print the concatenated Data

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
