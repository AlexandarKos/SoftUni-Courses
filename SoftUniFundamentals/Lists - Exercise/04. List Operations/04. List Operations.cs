using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 23 29 18 43 21 20       

            //Add 5                 1 23 29 18 43 21 20 5
            //Remove 5              1 23 29 18 43 20 5
            //Shift left 3          1 23 29 18 43 20 5 => 23 29 18 43 20 5 1 =>  29 18 43 20 5 1 23 => 18 43 20 5 1 23 29
            //Shift left 1          18 43 20 5 1 23 29 => 43 20 5 1 23 29 18
            //End                   43 20 5 1 23 29 18


            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Add":
                        int numberToBeAdded = int.Parse(command[1]);
                        numbers.Add(numberToBeAdded);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);
                        int lastIndex = numbers.Count - 1;

                        if (indexToInsert > lastIndex || indexToInsert < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);
                        if (indexToRemove > numbers.Count - 1 || indexToRemove < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Shift":

                        if (command[1] == "left")
                        {
                            int shiftLeftCount = int.Parse(command[2]);
                            //1 23 29 18 43 20 5 => 23 29 18 43 20 5 1
                            for (int i = 0; i < shiftLeftCount; i++)
                            {
                                int tempElement = numbers[0];
                                numbers.Remove(tempElement);
                                numbers.Add(tempElement);
                            }

                        }
                        else
                        {
                            int shiftRightCount = int.Parse(command[2]);
                            for (int i = 0; i < shiftRightCount; i++)
                            {
                                int tempElement = numbers[numbers.Count - 1];
                                int lastElementIndex = numbers.Count - 1;
                                numbers.RemoveAt(lastElementIndex);
                                numbers.Insert(0, tempElement);
                            }
                        }
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
