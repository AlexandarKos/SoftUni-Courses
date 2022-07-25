using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double changeTotal = double.Parse(Console.ReadLine());
            changeTotal *= 100;            

            int count = 0;
            while (changeTotal > 0)
            {
                if (changeTotal >= 200)
                {
                    count++;
                    changeTotal -= 200;
                    //count++;
                }
                else if (changeTotal >= 100)
                {
                    count++;
                    changeTotal -= 100;
                    //count++;
                }
                else if (changeTotal >= 50)
                {
                    count++;
                    changeTotal -= 50;
                    //count++;
                }
                else if (changeTotal >= 20)
                {
                    count++;
                    changeTotal -= 20;
                    //count++;
                }
                else if (changeTotal >= 10)
                {
                    count++;
                    changeTotal -= 10;
                    //count++;
                }
                else if (changeTotal >= 5)
                {
                    count++;
                    changeTotal -= 5;
                    //count++;
                }
                else if (changeTotal >= 2)
                {
                    count++;
                    changeTotal -= 2;
                    //count++;
                }
                else if (changeTotal >= 1)
                {
                    count++;
                    changeTotal -= 1;
                    
                    //break;
                }
                else
                {
                    changeTotal = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}