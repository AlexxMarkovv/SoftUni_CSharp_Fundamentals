using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;

            if (day == "Friday")
            {
                switch (groupType)
                {
                    case "Students": pricePerPerson = 8.45; break;
                    case "Business": pricePerPerson = 10.90; break;
                    case "Regular": pricePerPerson = 15.00; break;
                }
            }
            else if (day == "Saturday")
            {
                switch (groupType)
                {
                    case "Students": pricePerPerson = 9.80; break;
                    case "Business": pricePerPerson = 15.60; break;
                    case "Regular": pricePerPerson = 20.00; break;
                }
            }
            else
            {
                switch (groupType)
                {
                    case "Students": pricePerPerson = 10.46; break;
                    case "Business": pricePerPerson = 16.00; break;
                    case "Regular": pricePerPerson = 22.50; break;
                }
            }

            
            if (groupType == "Students" && people >= 30)
            {
                totalPrice = people * pricePerPerson;
                totalPrice *= 0.85;
            }
            else if (groupType == "Business" && people >= 100)
            {
                totalPrice = (people - 10) * pricePerPerson;
            }
            else if (groupType == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice = people * pricePerPerson;
                totalPrice *= 0.95;
            }
            else
            {
                totalPrice = people * pricePerPerson;
            }
            
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
