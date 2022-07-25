using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the aquarium dimentions in centimeters and the percentage occupied
            double lengthCentimeters = double.Parse(Console.ReadLine());
            double widthCentimeters = double.Parse(Console.ReadLine());
            double heightCentimeters = double.Parse(Console.ReadLine());
            double percentageOccupied = double.Parse(Console.ReadLine()) / 100;

            // get the total aquarium volume in cubic meters => length * width * height
            double totalCubicVolume = lengthCentimeters * widthCentimeters * heightCentimeters;

            // get the volume in liters => "volume in cubic meters / 1000"
            double totalLiterVolume = totalCubicVolume / 1000;

            // get occupied liters
            double occupiedLiters = totalLiterVolume * percentageOccupied;

            // get the final needed liters to fill the aquarium
            double finalLitersNeeded = totalLiterVolume - occupiedLiters;

            // print the final liters as result
            Console.WriteLine(finalLitersNeeded);
        }
    }
}
