using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Race
    {
        static void Main()
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();

            string input = Console.ReadLine();

            string[] currentName = input
                    .Split(", ");

            foreach (var name in currentName)
            {
                racers.Add(name, 0);
            }
            input = Console.ReadLine();

            while (input != "end of race")
            {
                var regexName = new Regex(@"(?<name>[A-Za-z])");
                var regexDigits = new Regex(@"(?<digit>[0-9])");

                string name = "";
                foreach (var letter in regexName.Matches(input))
                {
                    name += letter;
                }
                int distance = 0;
                foreach (var digit in regexDigits.Matches(input))
                {
                    distance += int.Parse(digit.ToString());
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += distance;
                }

                input = Console.ReadLine();
            }
            var sortedRacers = racers.OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x=>x.Key, x=>x.Value);

            Console.WriteLine($"1st place: {sortedRacers.Keys.First()}");
            sortedRacers.Remove(sortedRacers.Keys.First());
            Console.WriteLine($"2nd place: {sortedRacers.Keys.First()}");
            sortedRacers.Remove(sortedRacers.Keys.First());
            Console.WriteLine($"3rd place: {sortedRacers.Keys.First()}");
            sortedRacers.Remove(sortedRacers.Keys.First());
        }
    }
}
