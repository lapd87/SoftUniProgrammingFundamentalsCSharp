namespace VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Vehicle> catalogue = new List<Vehicle> { };

            while (input != "End")
            {
                string[] inputArray = input
                                .Trim()
                                .Split(new string[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries)
                                .ToArray();

                Vehicle currentVehicle = new Vehicle();

                currentVehicle.Type = inputArray[0].ToLower();
                currentVehicle.Model = inputArray[1];
                currentVehicle.Color = inputArray[2];
                currentVehicle.Horsepower = int.Parse(inputArray[3]);

                catalogue.Add(currentVehicle);

                input = Console.ReadLine();
            }

            string report = Console.ReadLine();

            while (report != "Close the Catalogue")
            {
                foreach (var vehicle in catalogue)
                {
                    if (vehicle.Model == report)
                    {
                        Console.WriteLine($"Type: {vehicle.Type.First().ToString().ToUpper() + vehicle.Type.Substring(1)}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }

                report = Console.ReadLine();
            }

            int totalCarHorsepower = 0;
            int totalTruckHorsepower = 0;

            int carCount = 0;
            int truckCount = 0;

            foreach (var vehicle in catalogue)
            {
                if (vehicle.Type == "car")
                {
                    totalCarHorsepower += vehicle.Horsepower;
                    carCount++;
                }
                else
                {
                    totalTruckHorsepower += vehicle.Horsepower;
                    truckCount++;
                }
            }

            double carAverage = 0;
            double truckAverage = 0;

            if (carCount != 0)
            {
                carAverage = (double)totalCarHorsepower / carCount;
            }

            if (truckCount != 0)
            {
                truckAverage = (double)totalTruckHorsepower / truckCount;
            }

            Console.WriteLine($"Cars have average horsepower of: {carAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverage:f2}.");
        }
    }

    internal class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
}