using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charsArray = input.ToCharArray();
            Array.Reverse(charsArray);
            string reverseInput = new string(charsArray);
            Console.WriteLine(reverseInput);
        }
    }
}
