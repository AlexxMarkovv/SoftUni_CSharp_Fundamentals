using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool toPrintNumberList = false;

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];

                if (command == "Add")
                {
                    int number = int.Parse(inputArr[1]);
                    numbersList.Add(number);
                    toPrintNumberList = true;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(inputArr[1]);
                    numbersList.Remove(number);
                    toPrintNumberList = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(inputArr[1]);
                    numbersList.RemoveAt(index);
                    toPrintNumberList = true;
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputArr[1]);
                    int index = int.Parse(inputArr[2]);
                    numbersList.Insert(index, number);
                    toPrintNumberList = true;
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(inputArr[1]);
                    if (numbersList.Contains(number) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    PrintEven(numbersList);
                }
                else if (command == "PrintOdd")
                {
                    PrintOdd(numbersList);
                }
                else if (command == "GetSum")
                {
                    GetSum(numbersList);
                }
                else if (command == "Filter")
                {
                    string condition = inputArr[1];
                    int number = int.Parse(inputArr[2]);
                    Filter(numbersList, condition, number);
                }
            }
            
            if (toPrintNumberList == true)
            {
                Console.WriteLine(string.Join(' ', numbersList));
            }
        }

        static void PrintEven(List<int>numbersList)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] % 2 == 0)
                {
                    evenNumbers.Add(numbersList[i]);
                }
            }
            Console.WriteLine(string.Join(' ', evenNumbers));
        }

        static void PrintOdd(List<int> numbersList)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] % 2 != 0)
                {
                    oddNumbers.Add(numbersList[i]);
                }
            }
            Console.WriteLine(string.Join(' ', oddNumbers));
        }

        static void GetSum(List<int> numbersList)
        {
            int sum = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                sum += numbersList[i];
            }
            Console.WriteLine(sum);
        }

        static void Filter(List<int> numbersList, string condition, int number)
        {
            List<int> filter = new List<int>();
            if (condition == "<")
            {
                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (numbersList[i] < number)
                    {
                        filter.Add(numbersList[i]);
                    }
                }
                Console.WriteLine(string.Join(' ', filter));
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (numbersList[i] > number)
                    {
                        filter.Add(numbersList[i]);
                    }
                }
                Console.WriteLine(string.Join(' ', filter));
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (numbersList[i] <= number)
                    {
                        filter.Add(numbersList[i]);
                    }
                }
                Console.WriteLine(string.Join(' ', filter));
            }
            else if (condition == ">=")
            {

                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (numbersList[i] >= number)
                    {
                        filter.Add(numbersList[i]);
                    }
                }
                Console.WriteLine(string.Join(' ', filter));
            }
        }
    }
}