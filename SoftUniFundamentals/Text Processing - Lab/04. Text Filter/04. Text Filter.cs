using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                int count = word.Length;
                char ch = '*';
                text = text.Replace(word, new string(ch, count));
            }

            Console.WriteLine(text);
        }
    }
}