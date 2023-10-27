using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string guestName = input[0];

                if (input.Length == 3)
                {
                    if (guestList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                        continue;
                    }
                    guestList.Add(guestName);
                }
                else if (input.Length == 4)
                {
                    if (!guestList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                        continue;
                    }
                    guestList.Remove(guestName);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}