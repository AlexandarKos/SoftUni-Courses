using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            char[] words = Console.ReadLine().ToCharArray();

            foreach (var letter in words)
            {
                if (letter != ' ')
                {
                    if (lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter]++;
                    }
                    else
                    {
                        lettersCount.Add(letter, 1);
                    }
                }
            }

            foreach (var letter in lettersCount)
            {
                //"{char} -> {occurrences}"
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}