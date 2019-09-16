using System;
using System.Linq;

namespace _08._MagicSum
{
    class MagicSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int secondnumber = numbers[j];

                    if (firstNum+secondnumber == magicSum)
                    {
                        Console.WriteLine($"{firstNum} {secondnumber}");
                    }
                }
            }

        }
    }
}
