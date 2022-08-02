using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds a place for the tourist on a lift.
            //On the first line, you will receive how many people are waiting to get on the lift.
            //On the second line, you will receive the current state of the lift separated by a single space ' '.
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Every wagon should have a maximum of 4 people on it.
            int maxSpace = 4;

            //If a wagon is full, you should direct the people to the next one with space available.
            //When there is no more available space left on the lift, or there are no more people in the queue, you should print on the console the final state of the lift's wagons separated by ' ' and one of the following messages:
            //If there are no more people and the lift has empty spots, you should print:
            //"The lift has empty spots!
            //{ wagons separated by ' '}
            //            "

            bool emptySlots = false;
            int maxCapacity = lift.Count * maxSpace;

            for (int i = 0; i < lift.Count; i++)
            {
                // get available space in wagon
                int availableSpaceCurrWagon = maxSpace - lift[i];
                // 
                // int addedPeople = 
                if (availableSpaceCurrWagon > peopleWaiting)
                {
                    lift[i] += peopleWaiting;
                    peopleWaiting = 0;
                }
                else
                {
                    peopleWaiting -= availableSpaceCurrWagon;
                    lift[i] += availableSpaceCurrWagon;
                }

                if (peopleWaiting == 0)
                {
                    emptySlots = true;
                    break;
                }

                if (maxCapacity == lift.Sum() && peopleWaiting > 0)
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                    Console.WriteLine(String.Join(" ", lift));
                    break;
                }
            }

            if (emptySlots && maxCapacity == lift.Sum())
            {
                Console.WriteLine(String.Join(" ", lift));
            }
            else if (emptySlots)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lift));
            }         
        }
    }
}
