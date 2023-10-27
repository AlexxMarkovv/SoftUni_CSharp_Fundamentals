using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listWithWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    int newWagon = int.Parse(command[1]);
                    listWithWagons.Add(newWagon);
                }
                else if (command[0] != null)
                {
                    int passangers = int.Parse(command[0]);

                    for (int i = 0; i < listWithWagons.Count; i++)
                    {
                        if (wagonCapacity - listWithWagons[i] >= passangers)
                        {
                            listWithWagons[i] = passangers + listWithWagons[i];
                            break;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(' ', listWithWagons));
        }
    }
}