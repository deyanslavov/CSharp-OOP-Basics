using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer()
    {
        this.pokemons = new List<Pokemon>();
    }

    public Trainer(string name, int badges, List<Pokemon> pokemons): this()
    {
        this.name = name;
        this.badges = badges;
        this.pokemons = pokemons;
    }

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }

    public int Badges
    {
        get { return this.badges; }
        set { badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { pokemons = value; }
    }
}
