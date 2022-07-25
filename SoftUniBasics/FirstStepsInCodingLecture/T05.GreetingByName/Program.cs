using System;

namespace T05.GreetingByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input name by user
            string name = Console.ReadLine();

            // print greeting with the input name

            Console.WriteLine($"Hello, {name}!");

        }
    }
}
