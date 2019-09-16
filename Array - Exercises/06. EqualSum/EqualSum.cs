using System;
using System.Linq;

namespace _06._EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sumLeft = 0;
            int sumRight = numbers.Sum();

            for (int i = 0; i < numbers.Length; i++)
            {
                sumRight -= numbers[i];

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }

                sumLeft += numbers[i];
            }
            Console.WriteLine("no");
        }
    }
}
