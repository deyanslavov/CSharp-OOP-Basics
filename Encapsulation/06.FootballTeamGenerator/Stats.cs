public class Stats
{
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Stats()
    {

    }

    public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Endurance = endurance;
        this.Shooting = shooting;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
    }

    public int Endurance
    {
        get { return endurance; }
        set
        {
            Validations.ValidateEndurance(value);
            endurance = value;
        }
    }
    
    public int Sprint
    {
        get { return sprint; }
        set
        {
            Validations.ValidateSprint(value);
            sprint = value;
        }
    }
    
    public int Dribble
    {
        get { return dribble; }
        set
        {
            Validations.ValidateDribble(value);
            dribble = value;
        }
    }
    
    public int Passing
    {
        get { return passing; }
        set
        {
            Validations.ValidatePassing(value);
            passing = value;
        }
    }
    
    public int Shooting
    {
        get { return shooting; }
        set
        {
            Validations.ValidateShooting(value);
            shooting = value;
        }
    }
}

