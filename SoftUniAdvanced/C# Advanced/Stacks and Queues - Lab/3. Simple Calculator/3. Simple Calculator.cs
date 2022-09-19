using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> expressionInput = Console.ReadLine().Split().ToList();

            Stack<string> stack = new Stack<string>();

            //o Input expression: 2 + 5 + 10 - 2 - 1
            //o Stack: 1 - 2 - 10 + 5 + 2

            for (int i = 0; i < expressionInput.Count; i++)
            {
                stack.Push(expressionInput[i]);

                if (stack.Count == 3)
                {
                    int firstNum = int.Parse(stack.Pop());
                    string operation = stack.Pop();
                    int secondNum = int.Parse(stack.Pop());
                    int result = 0;

                    if (operation == "+")
                    {
                        result = firstNum + secondNum;

                    }
                    else if (operation == "-")
                    {
                        result = secondNum - firstNum;
                    }
                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}