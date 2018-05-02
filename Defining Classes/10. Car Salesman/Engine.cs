public class Engine
{
    private string model;
    private string efficiency;
    private int power;
    private int displacement;

    public Engine()
    {
    }

    public string Model
    {
        get { return this.model; }
        set { model = value; }
    }
    
    public int Power
    {
        get { return this.power; }
        set { power = value; }
    }
    
    public int Displacement
    {
        get { return this.displacement; }
        set { displacement = value; }
    }
    
    public string Efficiency
    {
        get { return this.efficiency; }
        set { efficiency = value; }
    }
    
    public Engine(string model, int power) : this(model, power, efficiency: "n/a")
    {
        this.model = model;
        this.power = power;
    }
    public Engine(string model, int power, string efficiency) : this(model, power, displacement: -1)
    {
        this.model = model;
        this.power = power;
        this.efficiency = efficiency;
    }
    public Engine(string model, int power, int displacement) : this(model, power, displacement, efficiency: "n\a")
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
    }
    public Engine(string model, int power, int displacement, string efficiency)
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;
    }
    public override string ToString()
    {
        string na = @"n/a";
        if (this.displacement == 0 && this.efficiency != null)
        {
            return $"  {this.model}:\n    Power: {this.power}\n    Displacement: {na}\n    Efficiency: {this.efficiency}";
        }
        else if (this.efficiency == null && this.displacement != 0)
        {
            return $"  {this.model}:\n    Power: {this.power}\n    Displacement: {this.displacement}\n    Efficiency: {na}";
        }
        else if (this.efficiency == null && this.displacement == 0)
        {
            return $"  {this.model}:\n    Power: {this.power}\n    Displacement: {na}\n    Efficiency: {na}";
        }
        else
        {
            return $"  {this.model}:\n    Power: {this.power}\n    Displacement: {this.displacement}\n    Efficiency: {this.efficiency}";
        }
    }
}