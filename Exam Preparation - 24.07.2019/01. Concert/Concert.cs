using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Concert
    {
        static void Main()
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();

            Dictionary<string, int> bandTime = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] args = input.Split("; ");
                string command = args[0];
                string name = args[1];

                List<string> members = args[2]
                    .Split(", ")
                    .ToList();

                if (command == "Add")
                {
                    if (!bands.ContainsKey(name))
                    {
                        bands.Add(name, members);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bands[name].Contains(member))
                            {
                                bands[name].Add(member);
                            }
                        }
                    }
                }
                else
                {
                    int time = int.Parse(args[2]);

                    if (!bandTime.ContainsKey(name))
                    {
                        bandTime.Add(name, time);
                    }
                    else
                    {
                        bandTime[name] += time;
                    }
                }
                input = Console.ReadLine();
            }

            int totalTime = bandTime.Values.Sum();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string inputBand = Console.ReadLine();
            Console.WriteLine($"{inputBand}");

            foreach (var member in bands[inputBand])
            {
                Console.WriteLine($"=> {member.ToString()}");
            }
        }
    }
}
