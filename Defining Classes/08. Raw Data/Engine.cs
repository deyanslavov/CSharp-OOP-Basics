class Engine
{
    private int speed;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    private int power;

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public Engine()
    {

    }
    public Engine(int speed, int power):this()
    {
        this.speed = speed;
        this.power = power;
    }
}

