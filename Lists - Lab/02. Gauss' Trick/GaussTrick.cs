using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Gauss__Trick
{
    class GaussTrick
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int size = numbers.Count / 2;
            for (int i = 0; i < size; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
