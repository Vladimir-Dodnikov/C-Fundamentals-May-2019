using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Vehicle_Catalogue
{
    class Catalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class VehicleCatalogue
    {
        static void Main()
        {
            var vehicles = new Catalogue();
            vehicles.Cars = new List<Car>();
            vehicles.Trucks = new List<Truck>();

            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] vehicleProperties = input.Split('/').ToArray();
                string type = vehicleProperties[0];
                // vmesto da inicializiram tuk, napravo dolu!!!
                //string brand = ;
                //string model = ;
                //int powerOrWeight = ;

                if (type == "Car")
                {
                    var Car = new Car();
                    Car.Brand = vehicleProperties[1];       //napravo tuk
                    Car.Model = vehicleProperties[2];
                    Car.HorsePower = int.Parse(vehicleProperties[3]);
                    vehicles.Cars.Add(Car);
                }
                else if (type == "Truck")
                {
                    var Truck = new Truck();
                    Truck.Brand = vehicleProperties[1];       //napravo tuk
                    Truck.Model = vehicleProperties[2];
                    Truck.Weight = int.Parse(vehicleProperties[3]);
                    vehicles.Trucks.Add(Truck);
                }
            }
            if (vehicles.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (var car in vehicles.Cars.OrderBy(i => i.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehicles.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (var truck in vehicles.Trucks.OrderBy(i => i.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
