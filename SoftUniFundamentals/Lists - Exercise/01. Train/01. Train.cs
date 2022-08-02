using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Until you receive the "end" command, you will be receiving two types of input:
            //Add { passengers} – add a wagon to the end of the train with the given number of passengers.
            //{ passengers} – find a single wagon to fit all the incoming passengers(starting from the first wagon)
            //In the end, print the final state of the train
            int maxCapacityOfSingleWaggon = int.Parse(Console.ReadLine());

            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                List<string> command = inputCommand.Split().ToList();

                switch (command[0])
                {
                    case "Add":
                        int passengersToAdd = int.Parse(command[1]);
                        wagonsList.Add(passengersToAdd);
                        break;
                    default:
                        for (int i = 0; i < wagonsList.Count; i++)
                        {
                            int incomingPassangers = int.Parse(command[0]);
                            int availableSpace = maxCapacityOfSingleWaggon - wagonsList[i];
                            if (availableSpace >= incomingPassangers)
                            {
                                wagonsList[i] += incomingPassangers;
                                break;
                            }
                        }
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagonsList));
        }
    }
}
