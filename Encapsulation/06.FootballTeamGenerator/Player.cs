public class Player
{
    private string name;

    public Player(string name)
    {
        this.Name = name;
    }

    public Player(string name, Stats stats) : this(name)
    {
        this.Stats = stats;
    }

    public string Name
    {
        get { return name; }
        set
        {
            Validations.ValidateName(value);
            name = value;
        }
    }
    
    public Stats Stats { get; set; } = new Stats();

    public double Skill => (Stats.Endurance + Stats.Dribble + Stats.Passing + Stats.Shooting + Stats.Sprint) / 5.00;
}

