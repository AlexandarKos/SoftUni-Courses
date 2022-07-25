using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstCharacter = int.Parse(Console.ReadLine());
            int secondCharacter = int.Parse(Console.ReadLine());

            for (int i = firstCharacter; i <= secondCharacter; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
