using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            List<string> data = Console.ReadLine().Split().ToList();

            List<Box> boxes = new List<Box>();

            while (data[0] != "end")
            {
                string serialNumber = data[0];
                string name = data[1];
                int quantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                decimal priceBox = GetPriceBox(quantity, itemPrice);

                Item item = new Item();
                item.Name = name;
                item.Price = itemPrice;

                Box box = new Box { SerialNumber = serialNumber, Item = item, Quantity = quantity, PriceBox = priceBox };

                boxes.Add(box);

                data = Console.ReadLine().Split().ToList();
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(b => b.PriceBox).ToList();

            foreach (var box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }

        static decimal GetPriceBox(int quantity, decimal itemPrice)
        {
            return quantity * itemPrice;
        }
    }
    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceBox { get; set; }

    }

    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
