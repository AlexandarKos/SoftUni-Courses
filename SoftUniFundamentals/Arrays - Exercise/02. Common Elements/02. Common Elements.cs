using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            foreach (string element in firstArray)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (element == secondArray[i])
                    {
                        Console.Write($"{secondArray[i]} ");
                        break;
                    }
                }
            }
        }
    }
}