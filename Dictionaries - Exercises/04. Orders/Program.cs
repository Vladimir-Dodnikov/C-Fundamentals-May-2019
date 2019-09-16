using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, decimal[]> products = new Dictionary<string, decimal[]>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                if (name == "buy")
                {
                    break;
                }
                decimal price = decimal.Parse(input[1]);
                decimal quantity = decimal.Parse(input[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new decimal[2]);
                }
                products[name][0] = price;
                products[name][1] += quantity;
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
            }
        }
    }
}
