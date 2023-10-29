using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split(' ');

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];

                //if (IsStudentExists(students, firstName, lastName))
                //{
                //    Student student = GetStudent(students, firstName, lastName);
                //    student.FirstName = firstName;
                //    student.LastName = lastName;
                //    student.Age = age;
                //    student.HomeTown = homeTown;
                //}
                //else
                //{
                //    Student student = new Student()
                //    {
                //        FirstName = firstName,
                //        LastName = lastName,
                //        Age = age,
                //        HomeTown = homeTown,
                //    };
                //    students.Add(student);
                //}


                Student student = students.FirstOrDefault(s => s.FirstName == firstName 
                && s.LastName == lastName);
                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
            }

            string cityName = Console.ReadLine();

            List<Student> finalList = students.Where(s => s.HomeTown == cityName).ToList();

            foreach (Student student in finalList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool IsStudentExists(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
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