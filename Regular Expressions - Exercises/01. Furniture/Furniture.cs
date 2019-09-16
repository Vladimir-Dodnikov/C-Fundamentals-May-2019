using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Furniture
    {
        static void Main()
        {
            //string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)*)!(?<quantity>\d)";

            string input = Console.ReadLine();

            List<string> furnitures = new List<string>();

            decimal totalSpentMoney = 0;

            while (input != "Purchase")
            {
                Match regex = Regex.Match(input, pattern);

                if (regex.Success)
                {
                    string name = regex.Groups["name"].Value;
                    decimal price = decimal.Parse(regex.Groups["price"].Value);
                    decimal quantity = decimal.Parse(regex.Groups["quantity"].Value);

                    furnitures.Add(name);
                    totalSpentMoney += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {totalSpentMoney:f2}");
        }
    }
}
