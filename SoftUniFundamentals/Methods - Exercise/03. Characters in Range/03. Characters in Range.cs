using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Console.WriteLine(PrintCharactersBetween(first, second));            
        }

        static string PrintCharactersBetween(char first, char second)
        {
            string result = string.Empty;
            if (second < first)
            {
                for (int i = (int)second + 1; i < (int)first; i++)
                {
                    result += $"{(char)i} ";
                }
            }
            else
            {
                for (int i = (int)first + 1; i < (int)second; i++)
                {
                    result += $"{(char)i} ";
                }
            }
            return result;
        }
    }
}
