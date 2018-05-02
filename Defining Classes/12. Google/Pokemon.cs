public class Pokemon
{
    private string name;
    private string type;

    public Pokemon()
    {
    }

    public Pokemon(string name, string type)
    {
        this.name = name;
        this.type = type;
    }

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }
    
    public string Type
    {
        get { return this.type; }
        set { type = value; }
    }
    
    public override string ToString()
    {
        return this.Name + " " + this.type;
    }
}
