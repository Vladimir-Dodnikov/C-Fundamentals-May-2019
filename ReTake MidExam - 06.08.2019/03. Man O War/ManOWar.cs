using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    class ManOWar
    {
        static void Main()
        {
            List<int> pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Retire")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];

                if (command == "Fire")
                {
                    int givenIndex = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);

                    if (givenIndex >= 0 && givenIndex <= (warShip.Count - 1))
                    {
                        warShip[givenIndex] -= damage;

                        if (warShip[givenIndex] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int currentDamage = int.Parse(commandArgs[3]);

                    if ((startIndex >= 0) && (startIndex <= (pirateShip.Count - 1)) &&
                        (endIndex >= 0) && (endIndex <= (pirateShip.Count - 1)))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= currentDamage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int givenIndex = int.Parse(commandArgs[1]);
                    int health = int.Parse(commandArgs[2]);

                    if (givenIndex >= 0 && givenIndex <= pirateShip.Count - 1)
                    {
                        if ((pirateShip[givenIndex] + health) >= capacity)
                        {
                            pirateShip[givenIndex] = capacity;
                        }
                        else
                        {
                            pirateShip[givenIndex] += health;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int counter = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        int section = pirateShip[i];
                        double neededCapacity = capacity * 0.2;

                        if (section < neededCapacity)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }
                input = Console.ReadLine();
            }

            if (pirateShip.Sum() > 0 && warShip.Sum() > 0)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }
        }
    }
}
