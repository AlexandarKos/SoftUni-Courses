using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ctor
            // prop
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];
                int randomIndex = random.Next(words.Length);
                words[i] = words[randomIndex];
                words[randomIndex] = currWord;
            }
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
