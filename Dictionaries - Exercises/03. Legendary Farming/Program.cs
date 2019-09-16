using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;

            var junkMaterials = new Dictionary<string, int>();

            bool hasToBreak = false;

            while (!hasToBreak)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split(" ");

                hasToBreak = false;

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string type = input[i + 1];

                    if (type == "motes")
                    {
                        keyMaterials[type] += quantity;
                        if (keyMaterials[type] >= 250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            keyMaterials[type] -= 250;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else if (type == "fragments")
                    {
                        keyMaterials[type] += quantity;
                        if (keyMaterials[type] >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            keyMaterials[type] -= 250;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else if (type == "shards")
                    {
                        keyMaterials[type] += quantity;
                        if (keyMaterials[type] >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            keyMaterials[type] -= 250;
                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(type))
                        {
                            junkMaterials[type] = 0;
                        }
                        junkMaterials[type] += quantity;
                    }
                }
            }
            keyMaterials = keyMaterials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x=>x.Key, x=>x.Value);

            junkMaterials = junkMaterials
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
