public class Car
{
    private string model;
    private int weight;
    private string color;
    private Engine engine;

    public Car()
    {
    }

    public Car(string model)
    {
        this.model = model;
    }

    public Car(string model, int weight)
    {
        this.model = model;
        this.weight = weight;
    }

    public Car(string model, string color)
    {
        this.model = model;
        this.color = color;
    }

    public Car(string model, string color, int weight)
    {
        this.model = model;
        this.color = color;
        this.weight = weight;
    }

    public string Model
    {
        get { return this.model; }
        set { model = value; }
    }
    
    public int Weight
    {
        get { return this.weight; }
        set { weight = value; }
    }
    
    public string Color
    {
        get { return this.color; }
        set { color = value; }
    }
    
    public Engine Engine
    {
        get { return this.engine; }
        set { engine = value; }
    }
    
    public override string ToString()
    {
        string na = @"n/a";
        if (this.weight == 0 && this.color != null)
        {
            return $"{this.model}:\n{engine.ToString()}\n  Weight: {na}\n  Color: {this.color}";
        }
        else if (this.color == null && this.weight != 0)
        {
            return $"{this.model}:\n{engine.ToString()}\n  Weight: {this.weight}\n  Color: {na}";
        }
        else if (this.color == null && this.weight == 0)
        {
            return $"{this.model}:\n{engine.ToString()}\n  Weight: {na}\n  Color: {na}";
        }
        else
        {
            return $"{this.model}:\n{engine.ToString()}\n  Weight: {this.weight}\n  Color: {this.color}";
        }
    }
}