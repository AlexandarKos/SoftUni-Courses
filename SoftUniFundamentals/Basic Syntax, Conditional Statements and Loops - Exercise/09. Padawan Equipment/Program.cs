using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //You will be given the amount of money John has, the
            //number of students and the prices of each item.            
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            //John should buy 10 % more sabers (taken from the students' count), rounded up to the next integer.
            //Every sixth belt is free.
            //double totalMoney = 0.0;
            int freeBelts = studentsCount / 6;

            saberPrice = saberPrice * (studentsCount + Math.Ceiling(studentsCount * 0.10));
            robePrice *= studentsCount;            
            beltsPrice *= studentsCount - freeBelts;

            double totalMoney = saberPrice + robePrice + beltsPrice;



            //If price is less or equal to the budget
            // => "The money is enough - it would cost {the cost of the equipment}lv."

            //If the price is more than the budget:
            //=>"John will need {neededMoney}lv more."
            if (totalMoney <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalMoney - budget):f2}lv more.");
            }

            //All prices rounded to two digits after the decimal point

        }
    }
}
