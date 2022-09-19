using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01___First_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The possible commands are:
            //"Complete"
            //"Make Upper {index}"
            //"Make Lower {index}"
            //"Insert {index} {char}"
            //"Replace {char} {value}"
            //"Validation"

            string password = Console.ReadLine();
            StringBuilder sb = new StringBuilder(password);
                
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "Complete")
            {
                switch (input[0])
                {
                    case "Make":
                        if (input[1] == "Upper")
                        {
                            int indexToUper = int.Parse(input[2]);
                            char charToUpper = sb[indexToUper];

                            sb[indexToUper] = char.ToUpper(charToUpper);
                            Console.WriteLine(sb);
                        }
                        else
                        {
                            int indexToLower = int.Parse(input[2]);
                            char charToLower = sb[indexToLower];

                            sb[indexToLower] = char.ToLower(charToLower);
                            Console.WriteLine(sb);
                        }
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(input[1]);
                        char charToInsert = char.Parse(input[2]);

                        if (indexToInsert > sb.Length)
                        {
                            break;
                        }
                        else
                        {
                            sb.Insert(indexToInsert, charToInsert);
                            Console.WriteLine(sb);
                        }
                        break;
                    case "Replace":
                        char charToGetValue = char.Parse(input[1]);
                        int asciiValue = (int)charToGetValue;
                        int value = int.Parse(input[2]);
                        int sumOfCharAndValue = asciiValue + value;
                        char replaceThisChar = (char)sumOfCharAndValue;

                        if (!sb.ToString().Contains(charToGetValue))
                        {
                            break;
                        }
                        else
                        {
                            sb.Replace(charToGetValue, replaceThisChar);
                            Console.WriteLine(sb);
                        }
                        break;
                    case "Validation":
                        //"Password must be at least 8 characters long!"
                        if (sb.Length < 8)
                        {
                            Console.WriteLine("Password must be at least 8 characters long!");
                        }

                        //"Password must consist only of letters, digits and _!"
                        if (!Regex.IsMatch(sb.ToString(), @"^[a-zA-Z0-9_]+$"))
                        {
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                        }

                        //"Password must consist at least one uppercase letter!"
                        if (!Regex.IsMatch(sb.ToString(), @"^(.*[A-Z].*)+$"))
                        {
                            Console.WriteLine("Password must consist at least one uppercase letter!");
                        }
                        //"Password must consist at least one lowercase letter!"
                        if (!Regex.IsMatch(sb.ToString(), @"^(.*[a-z].*)+$"))
                        {
                            Console.WriteLine("Password must consist at least one lowercase letter!");
                        }
                        //"Password must consist at least one digit!"
                        if (!Regex.IsMatch(sb.ToString(), @"^(.*\d.*)+$"))
                        {
                            Console.WriteLine("Password must consist at least one digit!");
                        }

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }

            //Console.WriteLine(sb);

            //The possible outputs are:
            //"Password must be at least 8 characters long!"
            //"Password must consist only of letters, digits and _!"
            //"Password must consist at least one uppercase letter!"
            //"Password must consist at least one lowercase letter!"
            //"Password must consist at least one digit!"

        }
    }
}
