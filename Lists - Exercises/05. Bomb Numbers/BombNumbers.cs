using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> specialNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int bombNumber = specialNumbers[0];
            int bombPower = specialNumbers[1];
            GetRemovedNumbers(numbers, bombNumber, bombPower);

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        private static void GetRemovedNumbers(List<int> numbers, int bombNumber, int bombPower)
        {
            while (numbers.Contains(bombNumber))
            {
                int bombIndex = numbers.IndexOf(bombNumber);

                int leftSideToRemove = 0;
                int rightSideToRemove = 0;

                if ((bombIndex - bombPower) < 0)
                {
                    leftSideToRemove = 0;
                }
                else
                {
                    leftSideToRemove = bombIndex - bombPower;
                }

                if ((bombIndex + bombPower) >= numbers.Count)
                {
                    rightSideToRemove = numbers.Count - 1;
                }
                else
                {
                    rightSideToRemove = bombIndex + bombPower;
                }

                int numbersToRemove = rightSideToRemove - leftSideToRemove;

                for (int i = 0; i <= numbersToRemove; i++)
                {
                    numbers.RemoveAt(leftSideToRemove);
                }
            }
        }
    }
}
