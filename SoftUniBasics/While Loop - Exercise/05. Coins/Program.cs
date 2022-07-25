using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // четене на цялата сума/ресто пари от входа
            // пресмятане колко най-малко монети може да се върне рестото
            // превръщаме цялата сума/ресто в стотинки: convertedTotalCoins = changeTotal * 100;
            // 1, 2, 5, 10, 20, 50, 1.00, 2.00
            // 

            double changeTotal = double.Parse(Console.ReadLine());

            double convertedTotalCoins = changeTotal * 100;
            
            int totalNumberChangeCoins = 0;
            while (convertedTotalCoins > 0)
            {
                if (convertedTotalCoins >= 200)
                {
                    
                    changeTotal -= 200;
                    totalNumberChangeCoins++;
                }
                else if (convertedTotalCoins >= 100)
                {

                    convertedTotalCoins -= 100;
                    totalNumberChangeCoins++;
                }
                else if (convertedTotalCoins >= 50)
                {

                    convertedTotalCoins -= 50;
                    totalNumberChangeCoins++;
                }
                else if (convertedTotalCoins >= 20)
                {

                    convertedTotalCoins -= 20;
                    totalNumberChangeCoins++;
                }
                else if (convertedTotalCoins >= 10)
                {

                    convertedTotalCoins -= 10;
                    totalNumberChangeCoins++;
                }
                else if (convertedTotalCoins >= 5)
                {

                    convertedTotalCoins -= 5;
                    totalNumberChangeCoins++;
                }
                else if (convertedTotalCoins >= 2)
                {

                    convertedTotalCoins -= 2;
                    totalNumberChangeCoins++;
                }
                else if (convertedTotalCoins >= 1)
                {
                    convertedTotalCoins -= 1;
                    totalNumberChangeCoins++;                   
                    //break;
                }
            }
            Console.WriteLine(totalNumberChangeCoins);
        }
    }
}
