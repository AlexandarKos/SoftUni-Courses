using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line of input, you will receive a sequence of integers, separated by a single space – the targets sequence.
            List<int> targetSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            //On the following lines, until the "End" command, you be receiving integers each on a single line – the index of the target to be shot.
            string input = Console.ReadLine();

            while (input != "End")
            {
                int indexOfTarget = int.Parse(input);

                if (indexOfTarget > targetSequence.Count - 1 || indexOfTarget < 0)
                {
                    continue;
                }

                int currTarget = targetSequence[indexOfTarget];

                if (true)
                {
                         
                }

                input = Console.ReadLine();
            }

        }
    }
}
