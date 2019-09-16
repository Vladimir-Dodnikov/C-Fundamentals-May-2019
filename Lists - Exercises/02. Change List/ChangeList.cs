using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class ChangeList
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "end")
                {
                    break;
                }

                List<string> commandArgs = input.Split(" ").ToList();

                string command = commandArgs[0];
                int index = 0;

                if (command == "Delete")
                {
                    index = int.Parse(commandArgs[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == index)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
                else if (command == "Insert")
                {
                    index = int.Parse(commandArgs[1]);
                    int position = int.Parse(commandArgs[2]);
                    numbers.Insert(position, index);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
