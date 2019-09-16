using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class SoftUniBarIncome
    {
        static void Main()
        {
            string input = Console.ReadLine();

            //string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";

            decimal totalSum = 0;
            while (input != "end of shift")
            {
                MatchCollection validOrders = Regex.Matches(input, pattern);

                foreach (Match order in validOrders)
                {
                    string costumerName = order.Groups["name"].Value;
                    string productName = order.Groups["product"].Value;
                    decimal quantity = decimal.Parse(order.Groups["quantity"].Value);
                    decimal productPrice = decimal.Parse(order.Groups["price"].Value);

                    decimal costumerBill = quantity * productPrice;

                    Console.WriteLine($"{costumerName}: {productName} - {costumerBill:f2}");

                    totalSum += costumerBill;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
