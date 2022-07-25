using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double birthdayMoney = 0.0;
            double sum = 0.0;
            for (int i = 1; i <= lilyAge; i++)
            {

                if (i % 2 == 0)
                {
                    birthdayMoney += 10;
                    sum += birthdayMoney;
                    sum--;
                }
                else
                {
                    sum += toyPrice;
                }

            }
            if (sum >= laundryPrice)
            {
                Console.WriteLine($"Yes! {(sum - laundryPrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {laundryPrice - sum:f2}");
            }
        }
    }
}