using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class CarRace
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double sumLeftCar = 0;
            double sumRightCar = 0;
            double finishLine = numbers.Count / 2;

            for (int i = 0; i < finishLine; i++)
            {
                sumLeftCar += numbers[i];
                if (numbers[i] == 0)
                {
                    sumLeftCar *= 0.80;
                }
            }

            for (int i = numbers.Count - 1; i > finishLine; i--)
            {
                sumRightCar += numbers[i];
                if (numbers[i] == 0)
                {
                    sumRightCar *= 0.80;
                }
            }
            string racerOne = "left";
            string racerTwo = "right";

            if (sumLeftCar < sumRightCar)
            {
                Console.WriteLine($"The winner is {racerOne} with total time: {sumLeftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is {racerTwo} with total time: {sumRightCar}");
            }
            

        }
    }
}
