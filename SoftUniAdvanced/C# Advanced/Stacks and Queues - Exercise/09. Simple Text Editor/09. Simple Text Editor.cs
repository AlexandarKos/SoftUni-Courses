using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder textBuilder = new StringBuilder();

            Stack<string> memory = new Stack<string>();

            memory.Push(string.Empty);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int operation = int.Parse(input[0]);

                switch (operation)
                {
                    case 1:
                        string appendThisText = input[1];
                        textBuilder.Append(appendThisText);
                        memory.Push(textBuilder.ToString());
                        break;

                    case 2:
                        int eraseLastNumberOfElements = int.Parse(input[1]);
                        textBuilder = textBuilder.Remove(textBuilder.Length - eraseLastNumberOfElements, eraseLastNumberOfElements);
                        memory.Push(textBuilder.ToString());

                        break;
                    case 3:
                        int indexOfElement = int.Parse(input[1]);
                        char printThisElement = textBuilder[indexOfElement - 1];
                        Console.WriteLine(printThisElement);

                        break;
                    case 4:
                        memory.Pop();
                        string previosVersion = memory.Peek();
                        textBuilder = new StringBuilder(previosVersion); 
                        break;

                    default:
                        break;
                }

            }

        }
    }
}
