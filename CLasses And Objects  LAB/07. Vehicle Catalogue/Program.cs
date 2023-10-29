using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogueVehicle catalog = new CatalogueVehicle();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end") 
            {
                string[] inputArrs = input.Split("/", StringSplitOptions.RemoveEmptyEntries);
                string type = inputArrs[0];
                string brand = inputArrs[1];
                string model = inputArrs[2];
                int hpOrWeight = int.Parse(inputArrs[3]);

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = hpOrWeight;
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = hpOrWeight;
                    catalog.Trucks.Add(truck);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars: ");
                foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks: ");
                foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        public class CatalogueVehicle
        {
            public CatalogueVehicle()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
    }
}