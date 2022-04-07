using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        public class Team
        {
            public string Name { get; set; }

            public string Creator { get; set; }

            public List<string> Users { get; set; } = new List<string>();
        }

        static void Main(string[] args)
        {
            var teamCount = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (var i = 0; i < teamCount; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                var creator = input[0];
                var team = input[1];

                var isTeamExist = teams.Select(x => x.Name).Contains(team);
                var isCreatorExist = teams.Any(t => t.Creator == creator);

                if (isTeamExist == false && isCreatorExist == false)
                {
                    teams.Add(new Team { Name = team, Creator = creator });
                    Console.WriteLine(
                        $"Team {team} has been created by {creator}!");
                }
                else if (isTeamExist)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (isCreatorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                var splitInput = input
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var fen = splitInput[0];
                var ofFensTeam = splitInput[1];


                var isTeamExist = teams.Any(x => x.Name == ofFensTeam);
                var isCreatorInTeam = teams.Any(x => x.Creator == fen);
                var isUserInTeam = teams.Any(x => x.Users.Contains(fen));

                if (isTeamExist && isCreatorInTeam == false && isUserInTeam == false)
                {
                    var test = teams.FirstOrDefault(t => t.Name == ofFensTeam);
                    test.Users.Add(fen);

                }
                else if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {ofFensTeam } does not exist!");
                }
                else if (isCreatorInTeam || isUserInTeam)
                {
                    Console.WriteLine($"Member {fen} cannot join team {ofFensTeam }!");
                }
            }

            var teamWithMembers = teams
                .Where(t => t.Users.Count > 0)
                .OrderByDescending(o => o.Users.Count)
                .ThenBy(x => x.Name)
                .ToList();

            var notValidTeams = teams
                .Where(x => x.Users.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();


            foreach (var team in teamWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                var t = team.Users.OrderBy(t => t);
                foreach (var teamUser in t)
                {
                    Console.WriteLine($"-- {teamUser}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var disbandTeam in notValidTeams)
            {
                Console.WriteLine(disbandTeam.Name);
            }
        }
    }
}
