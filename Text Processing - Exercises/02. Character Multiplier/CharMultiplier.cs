using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class CharMultiplier
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(" ");

            int sum = 0;

            int length = Math.Min(input[0].Length, input[1].Length);

            for (int i = 0; i < length; i++)
            {
                sum += input[0][i] * input[1][i];
            }

            if (input[0].Length > input[1].Length)
            {
                for (int j = length; j < input[0].Length; j++)
                {
                    sum += input[0][j];
                }
            }

            if (input[1].Length > input[0].Length)
            {
                for (int j = length; j < input[1].Length; j++)
                {
                    sum += input[1][j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
