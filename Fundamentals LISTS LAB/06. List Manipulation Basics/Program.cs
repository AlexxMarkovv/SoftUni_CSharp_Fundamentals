using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];

                if (command == "Add")
                {
                    int number = int.Parse(inputArr[1]);
                    numbersList.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(inputArr[1]);
                    numbersList.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(inputArr[1]);
                    numbersList.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputArr[1]);
                    int index = int.Parse(inputArr[2]);
                    numbersList.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(' ', numbersList));
        }
    }
}