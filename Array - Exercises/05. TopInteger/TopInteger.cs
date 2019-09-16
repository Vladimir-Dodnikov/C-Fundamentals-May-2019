using System;
using System.Linq;

namespace _05._TopInteger
{
    class TopInteger
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int current = numbers[i];
                bool isTopInt = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (current <= nextNumber)
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    Console.Write(current + " ");
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
