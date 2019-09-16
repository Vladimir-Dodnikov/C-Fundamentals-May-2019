using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class TreasureHunt
    {
        static void Main()
        {
            List<string> loots = Console.ReadLine()
                .Split("|")
                .ToList();

            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] commandArgs = input.Split(" ");
                string command = commandArgs[0];

                if (command == "Loot")
                {
                    for (int i = 1; i <= commandArgs.Length - 1; i++)
                    {
                        if (!loots.Contains(commandArgs[i]))
                        {
                            loots.Insert(0, commandArgs[i]);
                        }
                    }

                }
                else if (command == "Drop")
                {
                    int givenIndex = int.Parse(commandArgs[1]);

                    if ((givenIndex >= 0) && (givenIndex <= loots.Count - 1))
                    {
                        loots.Add(loots[givenIndex]);
                        loots.RemoveAt(givenIndex);
                    }
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(commandArgs[1]);

                    if (count >= loots.Count)
                    {
                        Console.WriteLine(string.Join(", ", loots));
                        loots.Clear();
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", loots.TakeLast(count)));
                        loots.RemoveRange(loots.Count-count, count);

                    }
                }

                input = Console.ReadLine();
            }

            double sumLength = 0.0;

            foreach (var item in loots)
            {
                sumLength += item.Length;
            }

            double averageGain = (sumLength / loots.Count);

            if (loots.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
