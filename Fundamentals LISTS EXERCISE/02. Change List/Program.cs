using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.Remove(number);
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position, number);
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}