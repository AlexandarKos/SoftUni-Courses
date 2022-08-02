using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            bool isChanged = false;

            while (command != "end")
            {
                List<string> list = command.Split().ToList();

                switch (list[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(list[1]);
                        numbers.Add(numberToAdd);
                        isChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(list[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(list[1]);
                        numbers.RemoveAt(indexToRemove);
                        isChanged = true;
                        break;
                    case "Insert":
                        int ToInsert = int.Parse(list[1]);
                        int indexToInsert = int.Parse(list[2]);
                        numbers.Insert(indexToInsert, ToInsert);
                        isChanged = true;
                        break;
                    case "Contains":
                        int searchedNumber = int.Parse(list[1]);
                        if (numbers.Contains(searchedNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNumbers = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                oddNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        int sumOfAllNumbers = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sumOfAllNumbers += numbers[i];
                        }
                        Console.WriteLine(sumOfAllNumbers);
                        break;
                    case "Filter":
                        string condition = list[1];
                        int requestedNumber = int.Parse(list[2]);
                        List<int> filteredList = new List<int>();
                        switch (condition)
                        {
                            case "<":
                                filteredList = numbers.FindAll(n => n < requestedNumber);
                                break;
                            case ">":
                                filteredList = numbers.FindAll(n => n > requestedNumber);
                                break;
                            case ">=":
                                filteredList = numbers.FindAll(n => n >= requestedNumber);
                                break;
                            case "<=":
                                filteredList = numbers.FindAll(n => n <= requestedNumber);
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine(String.Join(" ", filteredList));
                        break;
                    default:
                        Console.WriteLine("Command does not exist");
                        break;
                }

                command = Console.ReadLine();
            }
            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
