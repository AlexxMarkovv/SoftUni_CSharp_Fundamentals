using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentInfo = new Dictionary<string, List<double>>();
            //Dictionary<string, int> gradesCount = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentInfo.ContainsKey(studentName))
                {
                    studentInfo.Add(studentName, new List<double>());
                    studentInfo[studentName].Add(grade);
                }
                else
                {
                    studentInfo[studentName].Add(grade);
                }
            }

            foreach (var student in studentInfo.Where(x => x.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }


            //for (int i = 0; i < n; i++)
            //{
            //    string studentName = Console.ReadLine();
            //    double grade = double.Parse(Console.ReadLine());

            //    if (!studentInfo.ContainsKey(studentName))
            //    {
            //        studentInfo.Add(studentName, grade);
            //        gradesCount.Add(studentName, 1);
            //    }
            //    else
            //    {
            //        studentInfo[studentName] += grade;
            //        gradesCount[studentName]++;
            //    }
            //}

            //foreach (var student in studentInfo)
            //{
            //    double gradeS = student.Value;
            //    foreach (var counter in gradesCount)
            //    {
            //        double avgGrade = gradeS / counter.Value;
            //        if (student.Key == counter.Key && avgGrade >= 4.50)
            //        {
            //            Console.WriteLine($"{student.Key} -> {avgGrade:f2}");
            //        }
            //    }
            //}
        }
    }
}