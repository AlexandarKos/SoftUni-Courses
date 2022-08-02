using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    break;
                case "string":
                    string first = Console.ReadLine();
                    string second = Console.ReadLine();
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "char":
                    char a = char.Parse(Console.ReadLine());
                    char b = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(a, b));
                    break;
                default:
                    break;
            } 
        }
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
        static string GetMax(string a, string b)
        {
            if (String.Compare(a, b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static char GetMax(char a, char b)
        {
            if ((int)a > (int)b )
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
