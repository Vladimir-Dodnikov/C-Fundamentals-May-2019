using System;

namespace _05._Orders
{
    class Orders
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee": Coffee(quantity);
                    break;
                case "water": Water(quantity);
                    break;
                case "coke": Coke(quantity);
                    break;
                case "snacks": Snacks(quantity);
                    break;
            }
        }
		static void Coffee(int quantity)
        {
            decimal price = 1.50m;
            decimal sum = quantity * price;
            Console.WriteLine($"{sum:f2}");
        }
        static void Water(int quantity)
        {
            decimal price = 1.00m;
            decimal sum = quantity * price;
            Console.WriteLine($"{sum:f2}");
        }
        static void Coke(int quantity)
        {
            decimal price = 1.40m;
            decimal sum = quantity * price;
            Console.WriteLine($"{sum:f2}");
        }
        static void Snacks(int quantity)
        {
            decimal price = 2.00m;
            decimal sum = quantity * price;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
