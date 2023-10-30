using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseList = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                string[] cmndArrs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmndArrs[0];
                string studentName = cmndArrs[1];

                if (!courseList.ContainsKey(courseName))
                {
                    courseList.Add(courseName, new List<string>());
                    courseList[courseName].Add(studentName);
                }
                else
                {
                    courseList[courseName].Add(studentName);
                }
            }

            foreach (var course in courseList)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}