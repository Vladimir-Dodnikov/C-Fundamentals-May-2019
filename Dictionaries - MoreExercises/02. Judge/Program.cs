using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Judge
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var judge = new Dictionary<string, Dictionary<string, int>>();
            var individualStats = new Dictionary<string, Dictionary<string, int>>();

            while (input != "no more time")
            {
                string[] inputArgs = input
                    .Split(" -> ")
                    .ToArray();
                string user = inputArgs[0];
                string contest = inputArgs[1];
                int points = int.Parse(inputArgs[2]);

                if (!judge.ContainsKey(contest))
                {
                    judge.Add(contest, new Dictionary<string, int>());
                }

                if (!judge[contest].ContainsKey(user))
                {
                    judge[contest].Add(user, 0);
                }

                if (judge[contest][user] < points)
                {
                    judge[contest][user] = points;
                }
                

                if (!individualStats.ContainsKey(user))
                {
                    individualStats.Add(user, new Dictionary<string, int>());
                }

                if (!individualStats[user].ContainsKey(contest))
                {
                    individualStats[user].Add(contest, 0);
                }

                if (individualStats[user][contest] < points)
                {
                    individualStats[user][contest] = points;
                }
                input = Console.ReadLine();
            }

            foreach (var contestName in judge)
            {
                Console.WriteLine($"{contestName.Key}: {contestName.Value.Count} participants");
                int counter = 1;

                foreach (var studentName in contestName.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{counter}. {studentName.Key} <::> {studentName.Value}");
                    counter++;
                }
            }
            Console.WriteLine("Individual standings:");
            int count = 1;
            foreach (var student in individualStats.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. { student.Key} -> {student.Value.Values.Sum()}");
                count++;
            }
        }
    }
}
