using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;

            while (input != "Start")
            {
                decimal coins = decimal.Parse(input);
                switch (coins)
                {
                    case 0.1m: sum += coins; break;
                    case 0.2m: sum += coins; break;
                    case 0.5m: sum += coins; break;
                    case 1.0m: sum += coins; break;
                    case 2.0m: sum += coins; break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();
            while (input2 != "End")
            {
                if (input2 == "Nuts")
                {
                    if (sum >= 2.0m)
                    {
                        sum -= 2.0m;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (input2 == "Water")
                {
                    if (sum >= 0.7m)
                    {
                        sum -= 0.7m;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (input2 == "Crisps")
                {
                    if (sum >= 1.5m)
                    {
                        sum -= 1.5m;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (input2 == "Soda")
                {
                    if (sum >= 0.8m)
                    {
                        sum -= 0.8m;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (input2 == "Coke")
                {
                    if (sum >= 1m)
                    {
                        sum -= 1m;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                input2 = Console.ReadLine();
            }

            if (input2 == "End")
            {
                Console.WriteLine($"Change: {sum:f2}");
            }
        }
    }
}
