using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string nameOfGame = "";
            decimal totalSpent = 0;
            

            while (input != "Game Time")
            {
                nameOfGame = input;
                decimal gamePrice = 0;
                switch (input)
                {
                    case "OutFall 4": gamePrice = 39.99m; break;
                    case "CS: OG": gamePrice = 15.99m; break;
                    case "Zplinter Zell": gamePrice = 19.99m; break;
                    case "Honored 2": gamePrice = 59.99m; break;
                    case "RoverWatch": gamePrice = 29.99m; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99m; break;
                    default: Console.WriteLine("Not Found");
                        input= Console.ReadLine();
                        continue;
                }

                if (gamePrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    gamePrice = 0;
                    input= Console.ReadLine();
                    continue;

                }

                currentBalance -= gamePrice;
                if (currentBalance >= 0)
                {
                    totalSpent += gamePrice;
                    Console.WriteLine($"Bought {nameOfGame}");
                }
                
                if (currentBalance < 0)
                {
                    Console.WriteLine("Out of money!");
                        break;
                }

                input = Console.ReadLine();
            }

            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}