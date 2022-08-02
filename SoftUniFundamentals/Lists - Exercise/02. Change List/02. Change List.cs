using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Delete":
                        int matchElement = int.Parse(command[1]);
                        numbers.RemoveAll(n => n == matchElement);
                        //for (int i = 0; i < numbers.Count; i++)
                        //{
                        //    int currElement = numbers[i];
                        //    int matchElement = int.Parse(command[1]);
                        //    if (currElement == matchElement)
                        //    {
                        //        numbers.Remove(i);
                        //    }
                        //}
                        break;
                    case "Insert":
                        int elementToBeInserted = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, elementToBeInserted);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
