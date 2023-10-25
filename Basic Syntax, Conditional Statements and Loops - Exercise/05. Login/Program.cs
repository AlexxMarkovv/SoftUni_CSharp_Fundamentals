using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string expectedPassword = new string(username.Reverse().ToArray());
            int failedTries = 0;

            while (true)
            {
                string providedPassword = Console.ReadLine();
                if (expectedPassword == providedPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (expectedPassword != providedPassword && failedTries <= 4)
                {
                    failedTries++;
                    if (failedTries <= 3)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    
                }

                if (failedTries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
        }
    }
}
