using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int currNum = int.Parse(input);
                if (isPalindrome(currNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }

        static bool isPalindrome(int number)
        {
            int reverseNumber = 0;
            int tempNumber = number;

            while (tempNumber > 0)
            {
                reverseNumber = reverseNumber * 10 + tempNumber % 10;
                tempNumber /= 10;
            }
            if (reverseNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
