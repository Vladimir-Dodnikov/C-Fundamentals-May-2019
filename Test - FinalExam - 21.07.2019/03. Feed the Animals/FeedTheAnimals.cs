using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Feed_the_Animals
{
    class FeedTheAnimals
    {
        static void Main()
        {
            string input = string.Empty;

            var animalsDailyFoodLimit = new Dictionary<string, int>();

            var animalArea = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Last Info")
            {
                string[] inputArgs = input
                    .Split(":");

                string command = inputArgs[0];
                string animalName = inputArgs[1];
                int dailyFoodLimit = int.Parse(inputArgs[2]);
                string givenArea = inputArgs[3];

                switch (command)
                {
                    case "Add":
                        if (animalsDailyFoodLimit.ContainsKey(animalName))
                        {
                            animalsDailyFoodLimit[animalName] += dailyFoodLimit;
                        }
                        else
                        {
                            animalsDailyFoodLimit.Add(animalName, dailyFoodLimit);
                        }

                        if (!animalArea.ContainsKey(givenArea))
                        {
                            animalArea.Add(givenArea, new List<string>());
                        }

                        if (!animalArea[givenArea].Contains(animalName))

                        {
                            animalArea[givenArea].Add(animalName);
                        }
                        break;

                    case "Feed":
                        if (animalsDailyFoodLimit.ContainsKey(animalName))
                        {
                            animalsDailyFoodLimit[animalName] -= dailyFoodLimit;

                            if (animalsDailyFoodLimit[animalName] <= 0)
                            {
                                Console.WriteLine($"{animalName} was successfully fed");

                                animalsDailyFoodLimit.Remove(animalName);
                                animalArea[givenArea].Remove(animalName);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine($"Animals:");
            foreach (var limit in animalsDailyFoodLimit.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{limit.Key} -> {limit.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var areas in animalArea.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{areas.Key} : {areas.Value.Count()}");
            }
        }
    }
}
