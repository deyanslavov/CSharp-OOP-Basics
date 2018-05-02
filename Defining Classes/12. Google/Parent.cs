public class Parent
{
    private string name;
    private string birthday;

    public Parent()
    {
    }

    public Parent(string name, string birthday)
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
