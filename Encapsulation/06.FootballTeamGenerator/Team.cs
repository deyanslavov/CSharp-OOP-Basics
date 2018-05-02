using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    
    public Team()
    {
        this.Players = new List<Player>();
    }

    public Team(string name) : this()
    {
        this.Name = name;
    }

    private List<Player> Players { get; set; }

    public string Name
    {
        get { return name; }
        set
        {
            Validations.ValidateName(value);
            name = value;
        }
    }

    public double Rating()
    {
        if (Players.Count == 0)
        {
            return 0;
        }
         return Math.Round(Players.Average(a => a.Skill));
    }

    public void AddPlayer(Player player)
    {
        this.Players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        if (!Players.Any(a => a.Name == player.Name))
        {
            throw new ArgumentException($"Player {player.Name} is not in {this.Name} team.");
        }
        var index = 0;

        for (int i = 0; i < Players.Count; i++)
        {
            if (Players[i].Name == player.Name)
            {
                index = i;
                break;
            }
        }
        this.Players.RemoveAt(index);
    }

    public void PrintRating()
    {
        Console.WriteLine($"{this.Name} - {this.Rating()}");
    }
}

