using System;

namespace _01._USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the USD
            double usd = double.Parse(Console.ReadLine());
            // add fixed currency convertion rate
            double convertionRate = 1.79549;
            // convert the USD to BGN
            double bgn = usd * convertionRate;
            // print the result in the console
            Console.WriteLine(bgn);
        }
    }
}
