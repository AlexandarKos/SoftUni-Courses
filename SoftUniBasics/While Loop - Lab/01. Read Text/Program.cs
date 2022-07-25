using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "Stop")
            {
                Console.WriteLine(word);
                word = Console.ReadLine();
            }
            //string word = string.Empty;
            //while (word != "Stop")
            //{
            //    word = Console.ReadLine();
            //    if (word != "Stop")
            //    {
            //        Console.WriteLine(word);
            //    }                
            //}


        }
    }
}
