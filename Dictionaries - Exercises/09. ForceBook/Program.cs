using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main()
        {
            var sideMembers = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] splittedInput = input.Split(" | ");

                    string side = splittedInput[0];
                    string member = splittedInput[1];

                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }

                    bool isContained = false;
                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(member))
                        {
                            isContained = true;
                            break;
                        }
                    }

                    if (!isContained)
                    {
                        sideMembers[side].Add(member);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] splittedArr = input.Split(" -> ");

                    string member = splittedArr[0];
                    string side = splittedArr[1];
                    
                    bool isContained = false;
                    string currentSide = "";
                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(member))
                        {
                            isContained = true;
                            currentSide = kvp.Key;
                            break;
                        }
                    }

                    if (isContained)
                    {
                        sideMembers[currentSide].Remove(member);
                    }

                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }
                    sideMembers[side].Add(member);

                    Console.WriteLine($"{member} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            sideMembers = sideMembers
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sideMembers)
            {
                string sideName = kvp.Key;
                List<string> sidesMembers = kvp.Value;
                sidesMembers.Sort();

                Console.WriteLine($"Side: {sideName}, Members: {sidesMembers.Count}");

                foreach (var item in sidesMembers)
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }
    }
}
