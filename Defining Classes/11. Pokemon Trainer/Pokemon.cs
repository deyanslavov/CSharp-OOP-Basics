public class Pokemon
{
    private string name;
    private string element;
    private int health;

    public Pokemon()
    {
    }

    public Pokemon(string name, string element, int health)
    {
        this.name = name;
        this.element = element;
        this.health = health;
    }

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }

    public string Element
    {
        get { return this.element; }
        set { element = value; }
    }

    public int Health
    {
        get { return this.health; }
        set { health = value; }
    }
}
