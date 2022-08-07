using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var regex = new Regex("(.)\\1+");

            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}
