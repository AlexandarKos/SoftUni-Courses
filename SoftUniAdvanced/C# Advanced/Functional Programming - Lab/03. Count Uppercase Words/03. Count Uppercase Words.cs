using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static Func<string, bool> isUppercase = x
        => x[0] == x.ToUpper()[0];
        static void Main(string[] args)
        {
            Console.WriteLine(
                String.Join("\n",
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(isUppercase)
                ));
        }
    }
}
