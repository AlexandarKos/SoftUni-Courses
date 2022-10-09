using System;
using System.Collections.Generic;
using System.Drawing;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                // INPUT:
                //"{color} -> {item1},{item2},{item3}…"
                //Blue -> dress,jeans,hat

                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int c = 0; c < clothes.Length; c++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[c]))
                    {
                        wardrobe[color].Add(clothes[c], 0);
                    }
                    wardrobe[color][clothes[c]]++;
                }
            }

            // SEARCH PATTERN:
            //"{color} {clothing}"
            string[] searchQuery = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = searchQuery[0];
            string searchedGarment = searchQuery[1];

            foreach (var color in wardrobe)
            {
                // PRINT:
                //"{color} clothes:            
                //* {item1} - {count}
                //* {item2} - {count}
                //* {itemN} - {count}"

                //"* {itemN} - {count} (found!)"

                Console.WriteLine($"{color.Key} clothes:");

                foreach (var garment in color.Value)
                {
                    string currGarmentName = garment.Key;
                    string currGarmentColor = color.Key;
                    if (currGarmentColor == searchedColor && currGarmentName == searchedGarment)
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value}");
                    }
                }
            }
        }
    }
}