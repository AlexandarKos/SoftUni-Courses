﻿using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] weekDays =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(weekDays[day -1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
