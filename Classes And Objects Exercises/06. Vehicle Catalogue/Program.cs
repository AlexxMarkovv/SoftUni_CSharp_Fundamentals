using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArrs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = inputArrs[0];
               
                VehicleType vehicleType;
                bool isValidType = Enum.TryParse(inputArrs[0], true, out vehicleType);

                if (isValidType)
                {
                    string model = inputArrs[1];
                    string colour = inputArrs[2];
                    int horsePower = int.Parse(inputArrs[3]);

                    Vehicle vehicle = new Vehicle(vehicleType, model, colour, horsePower);
                    vehicles.Add(vehicle);
                }
            }

            string input2;
            while ((input2 = Console.ReadLine()) != "Close the Catalogue")
            {
                string vehicleModel = input2;

                var desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == vehicleModel);
                Console.WriteLine(desiredVehicle);
            }

            var cars = vehicles.Where(x => x.Type == VehicleType.Car).ToList();
            var trucks = vehicles.Where(x => x.Type == VehicleType.Truck).ToList();

            double carsAvgHorsepower = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double trucksAvgHorsepower = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:f2}.");
        }
    }

    public enum VehicleType
    {
        Car,
        Truck
    }
    public class Vehicle
    {
        public Vehicle (VehicleType type, string model, string colour, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = colour;
            this.HorsePower = horsePower;
        }
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set;}
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}