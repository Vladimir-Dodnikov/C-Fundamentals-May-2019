using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class ListManipulationBasics
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "end")
                {
                    break;
                }

                List<string> commandArgs = input.Split(" ").ToList();

                string command = commandArgs[0];
                int index = int.Parse(commandArgs[1]);

                if (command == "Add")
                {
                    numbers.Add(index);
                }
                else if (command == "Remove")
                {
                    numbers.Remove(index);
                }
                else if (command == "RemoveAt")
                {
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    index = int.Parse(commandArgs[2]);
                    int item = int.Parse(commandArgs[1]);
                    numbers.Insert(index, item);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
