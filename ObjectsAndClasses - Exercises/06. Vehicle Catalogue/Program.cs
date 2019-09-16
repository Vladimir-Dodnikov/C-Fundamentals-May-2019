using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Catalogue
    {
        public List<Cars> Cars { get; set; }
        public List<Trucks> Trucks { get; set; }
    }
    class Trucks
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public Trucks(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
            this.Type = "Truck";
        }
    }
    class Cars
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public Cars(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
            this.Type = "Car";
        }
    }
    class Program
    {
        static void Main()
        {
            var listOfVehicles = new Catalogue();
            listOfVehicles.Cars = new List<Cars>();
            listOfVehicles.Trucks = new List<Trucks>();

            double sumCarPower = 0;
            double sumTruckPower = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] inputVehicle = input.Split();
                string typeOfVehicle = inputVehicle[0];
                string model = inputVehicle[1];
                string color = inputVehicle[2];
                int horsePower = int.Parse(inputVehicle[3]);

                if (typeOfVehicle.ToLower() == "car")
                {
                    var Car = new Cars(model, color, horsePower);
                    listOfVehicles.Cars.Add(Car);
                    sumCarPower += horsePower;
                }
                else if (typeOfVehicle.ToLower() == "truck")
                {
                    var Truck = new Trucks(model, color, horsePower);
                    listOfVehicles.Trucks.Add(Truck);
                    sumTruckPower += horsePower;
                }
            }

            while (true)
            {
                string inputModel = Console.ReadLine();
                if (inputModel == "Close the Catalogue")
                {
                    break;
                }
                if (listOfVehicles.Cars.Any(x => x.Model == inputModel))
                {
                    foreach (var car in listOfVehicles.Cars.Where(x=>x.Model == inputModel))
                    {
                        Console.WriteLine($"Type: {car.Type} \n" +
                            $"Model: {car.Model} \n" +
                            $"Color: {car.Color} \n" +
                            $"Horsepower: {car.HorsePower}");
                    }
                }
                else if (listOfVehicles.Trucks.Any(x=>x.Model == inputModel))
                {
                    foreach (var truck in listOfVehicles.Trucks.Where(x=>x.Model == inputModel))
                    {
                        Console.WriteLine($"Type: {truck.Type} \n" +
                            $"Model: {truck.Model} \n" +
                            $"Color: {truck.Color} \n" +
                            $"Horsepower: {truck.HorsePower}");
                    }
                }
            }
            double averagePowerCars = ((double)sumCarPower / listOfVehicles.Cars.Count);
            double averagePowerTrucks = ((double)sumTruckPower / listOfVehicles.Trucks.Count);

            if (listOfVehicles.Cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averagePowerCars:f2}.");
            }
            else
            {

                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (listOfVehicles.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averagePowerTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
