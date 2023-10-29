using System;
using System.Linq;
using System.Collections.Generic;
using static _06._Store_Boxes.Program;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmndArrs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string serialNum = cmndArrs[0];
                string itemName = cmndArrs[1];
                int quantity = int.Parse(cmndArrs[2]);
                decimal price = decimal.Parse(cmndArrs[3]);

                Item item = new (itemName, price);
                Box box = new (serialNum, item, quantity);
                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PriceBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }

        public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Box
        {
            public Box(string serialNum, Item item, int quantity)
            {
                SerialNumber = serialNum;
                Item = item;
                Quantity = quantity;
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public decimal PriceBox
            {
                get
                {
                    return Quantity * Item.Price;
                }
            }
        }
    }
}