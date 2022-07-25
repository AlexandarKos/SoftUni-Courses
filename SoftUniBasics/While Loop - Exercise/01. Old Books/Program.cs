using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int numberOfBooks = 0;
            while (currentBook != "No More Books")
            {
                if (currentBook == favouriteBook)
                {
                    Console.WriteLine($"You checked {numberOfBooks} books and found it.");
                    break;
                }
                else
                {
                    numberOfBooks++;
                    currentBook = Console.ReadLine();
                }
            }
            if (currentBook == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");
            }
        }
    }
}
