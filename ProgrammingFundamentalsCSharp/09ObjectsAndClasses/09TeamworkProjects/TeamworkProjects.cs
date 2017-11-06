namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team> { };

            for (int i = 0; i < n; i++)
            {
                Team currentTeam = ReadTeam();

                if (teams.Any(t => t.Name.Equals(currentTeam.Name)))
                {
                    Console.WriteLine($"Team {currentTeam.Name} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator.Equals(currentTeam.Creator)))
                {
                    Console.WriteLine($"{currentTeam.Creator} cannot create another team!");
                    continue;
                }

                teams.Add(currentTeam);

                Console.WriteLine($"Team {currentTeam.Name} has been created by {currentTeam.Creator}!");
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] candidates = input
                                    .Trim()
                                    .Split(new string[] { "->" }, StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .ToArray();

                string user = candidates[0];
                string joinTeam = candidates[1];

                if (!teams.Any(t => t.Name.Equals(joinTeam)))
                {
                    Console.WriteLine($"Team {joinTeam} does not exist!");

                    input = Console.ReadLine();

                    continue;
                }

                if (teams.Any(t => t.Members.Any(m => m.Equals(user))) ||
                    teams.Any(t => t.Creator.Equals(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {joinTeam}!");

                    input = Console.ReadLine();

                    continue;
                }

                int indexTeam = teams.IndexOf(teams.FirstOrDefault(t => t.Name.Equals(joinTeam)));

                teams[indexTeam].Members.Add(user);

                input = Console.ReadLine();
            }

            PrintReport(teams);
        }

        private static void PrintReport(List<Team> teams)
        {
            List<Team> validTeams = new List<Team> { };
            List<Team> emptyTeams = new List<Team> { };

            foreach (var team in teams)
            {
                if (team.Members.Count < 1)
                {
                    emptyTeams.Add(team);
                }
                else
                {
                    validTeams.Add(team);
                }
            }

            foreach (var team in validTeams
                                .OrderByDescending(t => t.Members.Count)
                                .ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);

                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(t=>t))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in emptyTeams
                                .OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }

        private static Team ReadTeam()
        {
            string[] input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { "-" }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            Team currentTeam = new Team();

            currentTeam.Creator = input[0];
            currentTeam.Name = input[1];
            currentTeam.Members = new List<string> { };

            return currentTeam;
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}