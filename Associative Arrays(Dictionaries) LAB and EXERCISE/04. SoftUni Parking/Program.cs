using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> register = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmndArrs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmndArrs[0];
                string userName = cmndArrs[1];

                if (command == "register")
                {
                    string plateNumber = cmndArrs[2];
                    if (!register.ContainsKey(userName))
                    {
                        register.Add(userName, plateNumber);
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                        continue;
                    }
                    Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                }
                else
                {
                    if (register.ContainsKey(userName))
                    {
                        register.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                        continue;
                    }
                    Console.WriteLine($"ERROR: user {userName} not found");
                }
            }

            foreach(var user in register)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}