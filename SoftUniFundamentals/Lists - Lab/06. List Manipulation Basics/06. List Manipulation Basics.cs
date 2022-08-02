using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> list = command.Split().ToList();

                switch (list[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(list[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(list[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(list[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int ToInsert = int.Parse(list[1]);
                        int indexToInsert = int.Parse(list[2]);
                        numbers.Insert(indexToInsert, ToInsert);
                        break;
                    default:
                        Console.WriteLine("Command does not exist");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
