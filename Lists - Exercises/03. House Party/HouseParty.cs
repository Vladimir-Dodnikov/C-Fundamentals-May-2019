using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class HouseParty
    {
        static void Main()
        {
            int countCommands = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < countCommands; i++)
            {
                string command = Console.ReadLine();

                List<string> commandArgs = command.Split().ToList();

                if (commandArgs[1] == "is" && commandArgs[2] == "going!")
                {
                    if (names.Contains(commandArgs[0]))
                    {
                        Console.WriteLine($"{commandArgs[0]} is already in the list!"); 
                    }
                    else
                    {
                        names.Add(commandArgs[0]);
                    }
                }
                else if (commandArgs[1] == "is" && commandArgs[2] == "not")
                {
                    if (names.Contains(commandArgs[0]))
                    {
                        names.Remove(commandArgs[0]); 
                    }
                    else
                    {
                        Console.WriteLine($"{commandArgs[0]} is not in the list!");
                    }
                    
                }
            }
            names.ForEach(Console.WriteLine);
        }
    }
}
