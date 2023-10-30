using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string resourceType;
            while ((resourceType = Console.ReadLine()) != "stop") 
            {
                int resourceQuantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, resourceQuantity);
                }
                else
                {
                    resources[resourceType] += resourceQuantity;
                }
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}