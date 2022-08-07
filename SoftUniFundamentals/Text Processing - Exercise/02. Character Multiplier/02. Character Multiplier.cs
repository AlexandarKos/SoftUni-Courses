using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];
            Console.WriteLine(CharMultiplier(firstString, secondString));
        }

        public static int CharMultiplier(string str1, string str2)
        {
            int sum = 0;

            string shorterString = string.Empty;
            string longerString = string.Empty;

            if (str1.Length <= str2.Length)
            {
                shorterString = str1;
                longerString = str2;
            }
            else
            {
                shorterString = str2;
                longerString = str1;
            }
            //int shorterString = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += str1[i] * str2[i];
            }

            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }

            return sum;
        } 
    }
}
