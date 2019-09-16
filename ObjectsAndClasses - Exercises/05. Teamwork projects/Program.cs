using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_projects
{
    class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            var listOfTeams = new List<Team>();
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] firstInput = Console.ReadLine().Split("-");
                string creator = firstInput[0];
                string teamName = firstInput[1];

                if (listOfTeams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (listOfTeams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                else
                {
                    var newTeam = new Team
                    {
                        Creator = creator,
                        TeamName = teamName,
                        Members = new List<string>()
                    };
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    listOfTeams.Add(newTeam);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                string[] arrInput = input.Split("->");
                string member = arrInput[0];
                string team = arrInput[1];

                var currentTeam = listOfTeams.FirstOrDefault(n => n.TeamName == team);

                if (listOfTeams.Any(x => x.Members.Contains(member)) || listOfTeams.Any(x => x.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }
                else if (!listOfTeams.Select(y => y.TeamName).Contains(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                else
                {
                    currentTeam.Members.Add(member);
                }
            }

            var sortedLists = listOfTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName);

            foreach (var team in sortedLists.Where(x => x.Members.Count > 0))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var tm in team.Members.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {tm}");
                }
            }

            Console.WriteLine($"Teams to disband:");
            foreach (var team in sortedLists.Where(x => x.Members.Count == 0))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}
