using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Second_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Valid Message:
            //"!Send!:[IvanisHere]"
            //58 :
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<int> convertedMessage = new List<int>();


            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                if (!Regex.IsMatch(input, @"^(.*[:].*)+$"))
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                string[] inputString = input.Split(":").ToArray();

                StringBuilder command = new StringBuilder(inputString[0]);
                StringBuilder message = new StringBuilder(inputString[1]);

                bool consecutiveLowers = true;
                for (int j = 2; j < command.Length - 1; j++)
                {
                    if (!Char.IsLower(command[j]))
                    {
                        consecutiveLowers = false;
                    }
                }
                StringBuilder newString = new StringBuilder(inputString[1]);                

                for (int f = 1; f < message.Length - 1; f++)
                {
                    //
                    newString.Append(message[f]);
                }

                if (!command.ToString().StartsWith('!')
                    || !command.ToString().EndsWith('!')
                    || command.Length < 5
                    || !Regex.IsMatch(command[1].ToString(), @"^(.*[A-Z].*)+$")
                    || !consecutiveLowers
                    || message.Length < 10
                    || !message.ToString().StartsWith('[')
                    || !message.ToString().EndsWith(']')
                    || !Regex.IsMatch(newString.ToString(), @"^(.*[a-zA-Z].*)+$"))
                {
                    Console.Write("The message is invalid");
                }
                else
                {
                    
                    StringBuilder outputCommand = new StringBuilder();

                    for (int b = 1; b < command.Length - 1; b++)
                    {
                        //
                        outputCommand.Append(command[b]);
                    }

                    Console.Write($"{outputCommand}: ");

                    for (int k = 1; k < message.Length - 1; k++)
                    {
                        int currLetterToAscii = (int)message[k];
                        convertedMessage.Add(currLetterToAscii);
                    }

                    foreach (var num in convertedMessage)
                    {
                        Console.Write($"{num} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
