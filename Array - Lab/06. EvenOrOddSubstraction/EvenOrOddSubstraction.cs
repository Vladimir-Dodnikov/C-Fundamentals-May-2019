using System;
using System.Linq;

namespace _06._EvenOrOddSubstraction
{
    class EvenOrOddSubstraction
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
                result = sumEven - sumOdd;
            }
            Console.WriteLine(result);
        }
    }
}
