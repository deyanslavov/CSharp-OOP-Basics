public class Child
{
    private string name;
    private string birthday;

    public Child()
    {
    }

    public Child(string name, string birthday)
    {
        this.name = name;
        this.birthday = birthday;
    }

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }
    
    public string Birthday
    {
        get { return this.birthday; }
        set { birthday = value; }
    }
    
    public override string ToString()
    {
        return this.name + " " + this.birthday;
    }
}
