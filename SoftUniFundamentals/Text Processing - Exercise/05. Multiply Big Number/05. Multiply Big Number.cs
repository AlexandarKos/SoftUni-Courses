using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1
            // 123
            //   5
            //   5

            string bigNumber = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            StringBuilder resultString = new StringBuilder();

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {               
                char lastNum = (char)bigNumber[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int resultNum = lastNumAsDigit * num + remainder;
                

                resultString.Append(resultNum % 10);
                remainder = resultNum / 10;
            }

            if (remainder != 0)
            {
                resultString.Append(remainder);
            }

            StringBuilder reversedString = new StringBuilder();

            for (int i = resultString.Length - 1; i >= 0; i--)
            {
                reversedString.Append(resultString[i]);
            }

            Console.WriteLine(reversedString);
        }
    }
}
