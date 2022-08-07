using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrStrings = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            foreach (var word in arrStrings)
            {
                int currWordLength = word.Length;

                for (int i = 0; i < currWordLength; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}