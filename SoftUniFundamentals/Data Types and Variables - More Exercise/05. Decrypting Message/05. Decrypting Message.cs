using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string result = "";
            for (int i = 0; i < n; i++)
            {
                char currCharr = char.Parse(Console.ReadLine());
                int ascValue = (int)Convert.ToChar(currCharr);
                result += (char)(ascValue + key);                
            }
            Console.WriteLine(result);
        }
    }
}
