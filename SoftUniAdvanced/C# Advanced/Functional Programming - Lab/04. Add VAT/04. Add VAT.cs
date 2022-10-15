using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static Func<string, string> addVat = x
        => $"{double.Parse(x) * 1.2:f2}";
        static void Main(string[] args)
        {
            Console.WriteLine(
            string.Join("\n",
            Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(addVat)
            ));
        }
    }
}
