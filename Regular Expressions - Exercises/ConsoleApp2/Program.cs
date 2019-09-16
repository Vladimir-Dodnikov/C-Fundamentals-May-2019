using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main()
        {
            string input = string.Empty;
            var furnitureList = new Dictionary<string, decimal>();

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Regex validation = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");

                Extraction(input, furnitureList, validation);
            }

            Printing(furnitureList);
        }

        private static void Extraction(string input, Dictionary<string, decimal> furnitureList, Regex validation)
        {
            if (validation.IsMatch(input))
            {
                var match = validation.Match(input);
                string name = match.Groups["item"].Value;
                decimal price = decimal.Parse(match.Groups["price"].Value);
                decimal quantity = decimal.Parse(match.Groups["quantity"].Value);
                furnitureList.Add(name, (price*quantity));
            }
        }

        private static void Printing(Dictionary<string, decimal> furnitureList)
        {
            Console.WriteLine("Bought furniture:");

            decimal sum = furnitureList.Sum(x=>x.Value);
            
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
