using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();
				
            int i = 0;
			
            while (i < numbers.Count - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = 0;
                    continue;
                }
                i++;
            }
			
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
