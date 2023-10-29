using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split(' ');

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown,
                };

                list.Add(student);
            }
            string cityName = Console.ReadLine();

            List<Student> finalList = list.Where(s => s.HomeTown == cityName).ToList();

            foreach (Student student in finalList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}