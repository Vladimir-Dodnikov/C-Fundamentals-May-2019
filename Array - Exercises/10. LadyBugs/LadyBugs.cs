using System;
using System.Linq;

namespace _10._LadyBugs
{
    class LadyBugs
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            string[] indexes = Console.ReadLine()
                .Split(" ");

            for (int i = 0; i < indexes.Length; i++)
            {
                int currentIndex = int.Parse(indexes[i]);
                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    field[currentIndex] = 1;
                }

            }

            string[] command = Console.ReadLine().Split(" ");

            while (string.Join(" ", command) != "end")
            {
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladybugIndex < 0 || ladybugIndex > fieldSize - 1 || field[ladybugIndex] == 0)
                {
                    command = Console.ReadLine().Split(" ");
                    continue;
                }
                field[ladybugIndex] = 0;

                if (direction == "right")
                {
                    ladybugIndex += flyLength;
                    while (ladybugIndex < fieldSize && field[ladybugIndex] == 1)
                    {
                        ladybugIndex += flyLength;
                    }
                    if (ladybugIndex < fieldSize)
                    {
                        field[ladybugIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    ladybugIndex -= flyLength;
                    while (ladybugIndex >= 0 && field[ladybugIndex] == 1)
                    {
                        ladybugIndex -= flyLength;
                    }
                    if (ladybugIndex >= 0)
                    {
                        field[ladybugIndex] = 1;
                    }
                }
                command = Console.ReadLine().Split(" ");
            }
            Console.Write(string.Join(" ", field));
            Console.WriteLine();
        }
    }
}
