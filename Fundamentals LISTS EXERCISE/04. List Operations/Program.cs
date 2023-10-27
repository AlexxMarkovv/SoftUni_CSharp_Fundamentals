using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmndArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = cmndArgs[0];

                if (cmndArgs.Length == 2)
                {
                    if (command == "Add")
                    {
                        int number = int.Parse(cmndArgs[1]);
                        numbers.Add(number);
                    }
                    else if (command == "Remove")
                    {
                        int index = int.Parse(cmndArgs[1]);
                        if (index >= numbers.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(index);
                    }
                }
                else if (cmndArgs.Length == 3)
                {
                    if (command == "Insert")
                    {
                        int number = int.Parse(cmndArgs[1]);
                        int index = int.Parse(cmndArgs[2]);

                        if (index >= numbers.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(index, number);
                    }
                    else if (command == "Shift")
                    {
                        string command2 = cmndArgs[1];
                        int count = int.Parse(cmndArgs[2]);

                        if (command2 == "left")
                        {
                            ShiftLeftNumbers(numbers, count);
                        }
                        else
                        {
                            ShiftRightNumbers(numbers, count);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }


        static void ShiftLeftNumbers(List<int> numbersA, int countA)
        {
            for (int i = 0; i < countA; i++)
            {
                int firstNum = numbersA[0];
                numbersA.RemoveAt(0);
                numbersA.Add(firstNum);
            }
        }

        static void ShiftRightNumbers(List<int> numbersA, int countA)
        {
            for (int i = 0; i < countA; i++)
            {
                int lastNum = numbersA[numbersA.Count - 1];
                numbersA.RemoveAt(numbersA.Count - 1);
                numbersA.Insert(0, lastNum);
            }
        }
    }
}