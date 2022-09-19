using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComands; i++)
            {
                string inputMessage = Console.ReadLine();

                if (!Regex.IsMatch(inputMessage, @"^![A-Z][a-z]{2,}!:\[[A-Za-z]{8,}\]$"))
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                string[] matchedMessage = inputMessage.Split(":");

                string commandInput = matchedMessage[0];
                string messageInput = matchedMessage[1];
                string wordPatternCommand = @"[A-Z][a-z\s]*";
                string wordPatternMessage = @"[A-Z][A-Za-z\s]*";

                Match commandMatch = Regex.Match(commandInput, wordPatternCommand);
                Match messageMatch = Regex.Match(messageInput, wordPatternMessage);
                
                if (!commandMatch.Success || !messageMatch.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                string command = commandMatch.Value;
                string message = messageMatch.Value;

                List<int> convertedMessage = new List<int>();

                foreach (char ch in message)
                {
                    int charToInt = (int)ch;
                    convertedMessage.Add(charToInt);
                }

                string resultMessage = string.Join(" ", convertedMessage);
                Console.Write($"{command}: {resultMessage}");
                Console.WriteLine();
            }
        }
    }
}
