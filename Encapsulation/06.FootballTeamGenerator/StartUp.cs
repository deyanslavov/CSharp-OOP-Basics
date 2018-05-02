namespace _06.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var teams = new List<Team>();

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                try
                {
                    var tokens = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    switch (tokens[0])
                    {
                        case "Team":
                            teams.Add(new Team(tokens[1]));
                            break;
                        case "Add":
                            if (!CheckIfTeamExists(teams, tokens[1]))
                                continue;

                            var player = new Player(tokens[2], new Stats(int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7])));
                            teams.First(t => t.Name == tokens[1]).AddPlayer(player);
                            break;
                        case "Remove":
                            player = new Player(tokens[2]);
                            teams.First(t => t.Name == tokens[1]).RemovePlayer(player);
                            break;
                        case "Rating":
                            if (!CheckIfTeamExists(teams, tokens[1]))
                                continue;

                            teams.First(t => t.Name == tokens[1]).PrintRating();
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

        }

        private static bool CheckIfTeamExists(List<Team > teams, string teamName)
        {
            if (!teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return false;
            }
            return true;
        }

        private bool CheckIfStatsAreValid(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            if (endurance < 0 || endurance > 100)
            {
                Console.WriteLine("Endurance should be between 0 and 100.");
                return false;
            }
            if (sprint < 0 || sprint > 100)
            {
                Console.WriteLine("Sprint should be between 0 and 100.");
                return false;
            }
            if (dribble < 0 || dribble > 100)
            {
                Console.WriteLine("Dribble should be between 0 and 100.");
                return false;
            }
            if (passing < 0 || passing > 100)
            {
                Console.WriteLine("Shooting should be between 0 and 100.");
                return false;
            }
            if (shooting < 0 || shooting > 100)
            {
                Console.WriteLine("Endurance should be between 0 and 100.");
                return false;
            }
            return true;
        }
    }
}
