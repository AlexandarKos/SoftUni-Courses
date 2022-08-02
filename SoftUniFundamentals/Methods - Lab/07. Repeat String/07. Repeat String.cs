using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string output = RepeatString(input, n);
            Console.WriteLine(output);
        }

        static string RepeatString(string input, int n)
        {
            string repeatedString = String.Empty;
            for (int i = 0; i < n; i++)
            {
                repeatedString += input;
                //Console.Write(input);
            }
            return repeatedString;
        }
    }
}
