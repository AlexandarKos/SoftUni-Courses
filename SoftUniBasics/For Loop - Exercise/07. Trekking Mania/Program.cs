using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsNum = int.Parse(Console.ReadLine());

            double musala = 0.0;
            double monblan = 0.0;
            double kilimandjaro = 0.0;
            double k2 = 0.0;
            double everest = 0.0;

            int totalClimbers = 0;

            for (int i = 0; i < groupsNum; i++)
            {
                int climbersNum = int.Parse(Console.ReadLine());
                if (climbersNum <= 5)
                {
                    musala+=climbersNum;
                }
                else if (climbersNum > 5 && climbersNum <= 12)
                {
                    monblan+=climbersNum;
                }
                else if (climbersNum > 12 && climbersNum <= 25)
                {
                    kilimandjaro += climbersNum;
                }
                else if (climbersNum > 25 && climbersNum <= 40)
                {
                    k2 += climbersNum;
                }
                else if (climbersNum > 40)
                {
                    everest += climbersNum;
                }
                totalClimbers += climbersNum;
            }

            musala = musala / totalClimbers * 100;
            monblan = monblan / totalClimbers * 100;
            kilimandjaro = kilimandjaro / totalClimbers * 100;
            k2 = k2 / totalClimbers * 100;
            everest = everest / totalClimbers * 100;
           
            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}