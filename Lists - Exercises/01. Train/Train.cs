using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Train
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commandArgs = input.Split(" ").ToList();

                string command = commandArgs[0];
                int index = 0;

                if (command == "Add")
                {
                    index = int.Parse(commandArgs[1]);
                    wagons.Add(index);
                }
                else
                {
                    index = int.Parse(commandArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + index <= maxCapacity)
                        {
                            wagons[i] += index;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
