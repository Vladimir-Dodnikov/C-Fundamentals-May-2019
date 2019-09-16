using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class ListOperations
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commandArgs = input.Split().ToList();

                string command = string.Empty;
                int index = 0;

                if ((command = commandArgs[0]) == "Add")
                {
                    index = int.Parse(commandArgs[1]);
                    numbers.Add(index);
                }
                else if ((command = commandArgs[0]) == "Insert")
                {
                    int element = int.Parse(commandArgs[1]);
                    index = int.Parse(commandArgs[2]);

                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, element);
                    }
                }
                else if ((command = commandArgs[0]) == "Remove")
                {
                    index = int.Parse(commandArgs[1]);

                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if ((command = (commandArgs[0] + " " + commandArgs[1])) == "Shift left")
                {
                    int shift = int.Parse(commandArgs[2]);

                    for (int i = 0; i < shift; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if ((command = (commandArgs[0] + " " + commandArgs[1])) == "Shift right")
                {
                    int shift = int.Parse(commandArgs[2]);

                    for (int i = 0; i < shift; i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count-1]);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
