using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class ListManipulationAdvanced
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            List<int> changedNumbers = new List<int>(numbers);

            string input = string.Empty;

            bool changed = false;

            input = GetManipulateList(numbers, changed);
        }

        private static string GetManipulateList(List<int> numbers, bool changed)
        {
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

                if (command == "Add")
                {
                    index = int.Parse(commandArgs[1]);
                    numbers.Add(index);
                    changed = true;
                }
                else if (command == "Remove")
                {
                    index = int.Parse(commandArgs[1]);
                    numbers.Remove(index);
                    changed = true;
                }
                else if (command == "RemoveAt")
                {
                    index = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(index);
                    changed = true;
                }
                else if (command == "Insert")
                {
                    index = int.Parse(commandArgs[2]);
                    int item = int.Parse(commandArgs[1]);
                    numbers.Insert(index, item);
                    changed = true;
                }

                else if (command == "Contains")
                {
                    index = int.Parse(commandArgs[1]);
                    if (numbers.Contains(index))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                }
                else if (command == "Filter")
                {
                    string condition = commandArgs[1];
                    int number = int.Parse(commandArgs[2]);

                    if (condition == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            if (changed)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

            return input;
        }
    }
}
