using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());           

            List<string> guestList = new List<string>();

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                List<string> command = input.Split().ToList();

                if (command.Count < 4)
                {
                    //"{name} is going!"
                    //· You have to add the person, if they are not on the guestlist already.
                    //· If the person is on the list print the following to the console: "{name} is already in the list!"
                    if (!guestList.Contains(command[0]))
                    {
                        guestList.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                }
                else
                {
                    //"{name} is not going!"
                    //· You have to remove the person, if they are on the list.
                    //· If not, print out: "{name} is not in the list!"

                    if (guestList.Contains(command[0]))
                    {
                        guestList.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
                //input = Console.ReadLine();
            }

            //Finally, print all of the guests, each on a new line.

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        } 
    }
}
