using System;

namespace _7._Vanding_Machine
{
    class VMachine
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;
            string input;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);
                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1.0:
                    case 2.0:
                        totalMoney += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
            }
            string product;
            while ((product = Console.ReadLine()) != "End")
            {
                double price = 0;
                if (product == "Coke")
                {
                    price = 1;
                }
                else if (product == "Nuts")
                {
                    price = 2;
                }
                else if (product == "Water")
                {
                    price = 0.7;
                }
                else if (product == "Crisps")
                {
                    price = 1.5;
                }
                else if (product == "Soda")
                {
                    price = 0.8;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (totalMoney - price >= 0)
                {
                    totalMoney -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
