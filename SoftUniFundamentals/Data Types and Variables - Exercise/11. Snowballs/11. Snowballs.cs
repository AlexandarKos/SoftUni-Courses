using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            BigInteger? biggestSnowballSnow = 0;
            BigInteger? biggestSnowballTime = 0;
            int biggestSnowballQuality = 0;
            BigInteger biggestSnowballValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                BigInteger currSnowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger currSnowballTime = BigInteger.Parse(Console.ReadLine());
                int currSnowballQuality = int.Parse(Console.ReadLine());

                //snowballValue by the following formula => (snowballSnow / snowballTime) ^ snowballQuality
                BigInteger snowTimeDivision = currSnowballSnow / currSnowballTime;
                BigInteger currSnowballValue = (BigInteger.Pow(snowTimeDivision, currSnowballQuality));

                if (currSnowballValue > biggestSnowballValue)
                {
                    biggestSnowballValue = currSnowballValue;
                    biggestSnowballSnow = currSnowballSnow;
                    biggestSnowballTime = currSnowballTime;
                    biggestSnowballQuality = currSnowballQuality;
                }
            }
            Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {biggestSnowballValue} ({biggestSnowballQuality})");
        }
    }
}
