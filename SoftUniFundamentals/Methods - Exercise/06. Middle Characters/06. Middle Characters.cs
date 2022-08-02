using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(PrintMiddleCharacters(input));
        }

        static string PrintMiddleCharacters(string input)
        {
            string result = string.Empty;

            if (input.Length % 2 == 0)
            {
                result += input[input.Length / 2 - 1];
                result += input[input.Length / 2];
            }
            else
            {
                result += input[input.Length / 2];
            }
            return result;
        }
    }
}
