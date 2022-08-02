using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On first line, you will receive the sequence of targets – integer values[1…10000].


            List<int> targetsList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            //On the following lines, until the "End" command, you will be receiving the commands described above – strings.
            while (input != "End")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Shoot":
                        int indexToShoot = int.Parse(command[1]);
                        int power = int.Parse(command[2]);
                        if (indexToShoot >= targetsList.Count || indexToShoot < 0)
                        {
                            break;
                        }
                        else
                        {
                            if (power >= targetsList[indexToShoot])
                            {
                                targetsList.RemoveAt(indexToShoot);
                            }
                            else
                            {
                                targetsList[indexToShoot] -= power;
                            }
                        }
                        break;
                    case "Add":
                        int indexToAdd = int.Parse(command[1]);
                        int element = int.Parse(command[2]);
                        if (indexToAdd >= targetsList.Count || indexToAdd < 0)
                        {
                            Console.WriteLine("Invalid placement!");
                            break;
                        }
                        else
                        {
                            targetsList.Insert(indexToAdd, element);
                        }
                        break;
                    case "Strike":
                        int strikeAtIndex = int.Parse(command[1]);
                        int radius = int.Parse(command[2]);
                        if (strikeAtIndex - radius < 0 || strikeAtIndex + radius >= targetsList.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            break;
                        }

                        int start = strikeAtIndex - radius;
                        int end = strikeAtIndex + radius;
                        for (int i = start; i <= end; i++)
                        {
                            targetsList[i] = 0;
                        }
                        targetsList.RemoveAll(x => x == 0);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join("|", targetsList));
        }
    }
}
