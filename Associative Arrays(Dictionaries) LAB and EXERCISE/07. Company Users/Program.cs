using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeesList = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] dataInfo = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                if (dataInfo[0] == "End")
                {
                    break;
                }

                string companyName = dataInfo[0];
                string employeeId = dataInfo[1];

                if (!employeesList.ContainsKey(companyName))
                {
                    employeesList.Add(companyName, new List<string>());
                    employeesList[companyName].Add(employeeId);
                }
                else if (!employeesList[companyName].Contains(employeeId))
                {
                    employeesList[companyName].Add(employeeId);
                }
            }

            foreach (var company in employeesList)
            {
                Console.WriteLine(company.Key);
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}