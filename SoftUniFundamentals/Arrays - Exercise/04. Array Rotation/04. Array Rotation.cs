using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input                 Output
            //51 47 32 61 21    =>  32 61 21 51 47
            //2

            //2 4 15 31         =>  4 15 31 2
            //5 

            int[] startingArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationsNumber = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotationsNumber; rotation++)
            {
                int currElement = startingArray[0];
                for (int i = 0; i < startingArray.Length -1; i++)
                {
                    startingArray[i] = startingArray[i + 1];
                }
                startingArray[startingArray.Length - 1] = currElement;
            }
            Console.WriteLine(String.Join(' ', startingArray));
        }
    }
}
