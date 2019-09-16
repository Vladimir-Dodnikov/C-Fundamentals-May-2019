using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var groupNumbers = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!groupNumbers.ContainsKey(number))
                {
                    groupNumbers[number] = 0;
                }
                groupNumbers[number]++;
            }
            foreach (var item in groupNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
