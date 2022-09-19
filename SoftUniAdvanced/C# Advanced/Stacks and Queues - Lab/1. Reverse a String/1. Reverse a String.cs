using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  

            Stack<char> charStack = new Stack<char>();

            foreach (char character in input)
            {
                charStack.Push(character);
                
            }

            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
        }
    }
}
