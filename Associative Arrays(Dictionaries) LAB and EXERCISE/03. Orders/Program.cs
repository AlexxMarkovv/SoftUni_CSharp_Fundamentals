using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{name} {price} {quantity}"

            Dictionary<string, double> productsAndPrices =
                new Dictionary<string, double>();

            Dictionary<string, int> productsAndQuantity 
                = new Dictionary<string, int>();

           string input = string.Empty;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmndArrs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string product = cmndArrs[0];
                double price = double.Parse(cmndArrs[1]);
                int quantity = int.Parse(cmndArrs[2]);

                if (!productsAndPrices.ContainsKey(product))
                {
                    productsAndPrices.Add(product, price);
                    productsAndQuantity.Add(product, quantity);
                }
                else
                {
                    if (productsAndPrices[product] != price)
                    {
                        productsAndPrices[product] = price;
                    }
                    //productsAndPrices.Remove(product);
                    //productsAndPrices.Add(product, price);
                    productsAndQuantity[product] += quantity;
                }
            }

            foreach(var item in productsAndPrices)
            {
                foreach(var item2 in productsAndQuantity)
                {
                    if (item.Key == item2.Key)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value * item2.Value:f2}");
                    }
                }
            }
        }
    }
}