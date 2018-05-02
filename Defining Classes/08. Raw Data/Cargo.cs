class Cargo
{
    private int weight;

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private string type;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public Cargo()
    {

    }

    public Cargo(int weight, string type)
    {
        this.type = type;
        this.weight = weight;
    }
}

