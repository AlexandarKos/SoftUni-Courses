using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintingTriangle(int.Parse(Console.ReadLine()));
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintingTriangle(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                PrintLine(1, i);
            }
            for (int i = size - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
