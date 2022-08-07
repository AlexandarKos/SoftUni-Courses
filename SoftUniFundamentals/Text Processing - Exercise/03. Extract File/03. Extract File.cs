using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pathToFile = Console.ReadLine().Split('.');
            string[] filePath = pathToFile[0].Split('\\');
            string fileName = filePath[filePath.Length - 1];
            string extension = pathToFile[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
