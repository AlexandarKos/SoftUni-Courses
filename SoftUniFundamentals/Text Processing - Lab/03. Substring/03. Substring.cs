using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            string resultString = Console.ReadLine();

            while (true)
            {
                if (resultString == resultString.Replace(substring, ""))
                {
                    break;
                }
                resultString = resultString.Replace(substring, "");
            }

            Console.WriteLine(resultString);
        }
    }
}
