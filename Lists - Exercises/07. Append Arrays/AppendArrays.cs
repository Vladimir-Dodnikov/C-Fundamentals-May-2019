using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class AppendArrays
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<int> numbers = new List<int>();
            foreach (var stringArray in input)
            {
                numbers.AddRange(stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();
                                
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
