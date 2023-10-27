using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] cmndArrgs = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string commandType = cmndArrgs[0];
                string lessonTitle = cmndArrgs[1];

                if (commandType == "Add" && schedule.Contains(lessonTitle) == false)
                {
                    schedule.Add(lessonTitle);
                }
                else if (commandType == "Insert" && schedule.Contains(lessonTitle) == false)
                {
                    int index = int.Parse(cmndArrgs[2]);

                    if (index < 0 || index > schedule.Count - 1)
                    {
                        continue;
                    }
                    schedule.Insert(index, lessonTitle);
                }
                else if (commandType == "Remove" && schedule.Contains(lessonTitle))
                {
                    schedule.Remove(lessonTitle);
                    if (schedule.Contains($"{lessonTitle}-Exercise"))
                    {
                        schedule.Remove($"{lessonTitle}-Exercise");
                    }
                }
                else if (commandType == "Swap")
                {
                    string lessonTitle2 = cmndArrgs[2];
                    int indexFirstTitle = schedule.IndexOf(lessonTitle);
                    int indexSecondTitle = schedule.IndexOf(lessonTitle2);

                    if (schedule.Contains(lessonTitle) && schedule.Contains(lessonTitle2))
                    {
                        schedule.Insert(indexFirstTitle, lessonTitle2);
                        if (indexFirstTitle < indexSecondTitle)
                        {
                            schedule.Insert(indexSecondTitle + 1, lessonTitle);
                        }
                        else
                        {
                            schedule.Insert(indexSecondTitle, lessonTitle);
                        }
                        
                        schedule.RemoveAt(indexFirstTitle);
                        if (indexSecondTitle == 0 || indexFirstTitle > indexSecondTitle)
                        {
                            schedule.RemoveAt(indexSecondTitle);
                        }
                        else
                        {
                            schedule.RemoveAt(indexSecondTitle - 1);
                        }
                    }

                    if (schedule.Contains($"{lessonTitle}-Exercise"))
                    {
                        schedule.Insert(indexSecondTitle + 1, $"{lessonTitle}-Exercise");
                        schedule.RemoveAt(indexFirstTitle + 1);
                    }

                    if (schedule.Contains($"{lessonTitle2}-Exercise"))
                    {
                        schedule.Insert(indexFirstTitle + 1, $"{lessonTitle2}-Exercise");
                        schedule.RemoveAt(indexSecondTitle + 1);
                    }
                }
                else if (commandType == "Exercise")
                {
                    if (schedule.Contains(lessonTitle) == false)
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add($"{lessonTitle}-Exercise");
                    }
                    else if (schedule.Contains(lessonTitle))
                    {
                        int index = schedule.IndexOf(lessonTitle);
                        schedule.Insert(index + 1, $"{lessonTitle}-Exercise");
                    }
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}