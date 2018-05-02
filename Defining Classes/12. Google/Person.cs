using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private Car car;
    private List<Child> children;
    private List<Parent> parents;
    private List<Pokemon> pokemons;

    public Person()
    {
        this.Children = new List<Child>();
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Parent>();
    }

    public Person(string name, Company company, Car car, List<Child> children, List<Parent> parents, List<Pokemon> pokemons)
    {
        this.name = name;
        this.company = company;
        this.car = car;
        this.children = children;
        this.parents = parents;
        this.pokemons = pokemons;
    }

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }
    
    public Company Company
    {
        get { return this.company; }
        set { company = value; }
    }
    
    public Car Car
    {
        get { return this.car; }
        set { car = value; }
    }
    
    public List<Child> Children
    {
        get { return this.children; }
        set { children = value; }
    }
    
    public List<Parent> Parents
    {
        get { return this.parents; }
        set { parents = value; }
    }
    
    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { pokemons = value; }
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.Name);
        sb.AppendLine("Company:");
        if (this.Company != null)
        {
            sb.AppendLine(this.company.ToString());
        }
        sb.AppendLine("Car:");
        if (this.car != null)
        {
            sb.AppendLine(this.car.ToString());
        }
        sb.AppendLine("Pokemon:");
        if (this.pokemons.Count > 0)
        {
            foreach (var poke in pokemons)
            {
                sb.AppendLine(poke.ToString());
            }
        }
        sb.AppendLine("Parents:");
        if (this.parents.Count > 0)
        {
            foreach (var p in parents)
            {
                sb.AppendLine(p.ToString());
            }
        }
        sb.AppendLine("Children:");
        if (this.children.Count > 0)
        {
            foreach (var ch in children)
            {
                sb.AppendLine(ch.ToString());
            }
        }
        return sb.ToString().Trim();
    }
}
