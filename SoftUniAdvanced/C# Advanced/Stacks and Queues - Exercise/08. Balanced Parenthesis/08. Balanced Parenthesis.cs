using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isBalanced = true;

            foreach (var character in input)
            {
                if (character == '(' || character == '{' || character == '[')
                {
                    stack.Push(character);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    char currParentheses = stack.Peek();

                    switch (currParentheses)
                    {
                        case '(':
                            if (character == ')')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                isBalanced = false;
                            }
                            break;
                        case '{':
                            if (character == '}')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                isBalanced = false;
                            }
                            break;
                        case '[':
                            if (character == ']')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                isBalanced = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }


            if (isBalanced && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
