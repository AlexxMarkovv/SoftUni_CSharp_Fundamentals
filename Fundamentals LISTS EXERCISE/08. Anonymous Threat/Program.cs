using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] cmndArrgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = cmndArrgs[0];
                int startIndex = int.Parse(cmndArrgs[1]);
                int endIndex = int.Parse(cmndArrgs[2]);
                string concatedWord = "";

                if (startIndex < 0 || startIndex > listOfStrings.Count - 1)
                {
                    startIndex = 0;
                }
                if (endIndex > listOfStrings.Count - 1 || endIndex < 0)
                {
                    endIndex = listOfStrings.Count - 1;
                }

                if (command == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatedWord += listOfStrings[i];
                    }
                    listOfStrings.RemoveRange(startIndex, endIndex - startIndex + 1);
                    listOfStrings.Insert(startIndex, concatedWord);
                }
                else if (command == "divide")
                {
                    List<string> dividedList = new List<string>();
                    int partitions = int.Parse(cmndArrgs[2]);
                    string word = listOfStrings[startIndex];
                    listOfStrings.RemoveAt(startIndex);
                    int parts = word.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            dividedList.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            dividedList.Add(word.Substring(i * parts, parts));
                        }
                    }
                    listOfStrings.InsertRange(startIndex, dividedList);
                }
            }

            Console.WriteLine(string.Join(" ", listOfStrings));
        }
    }
}