public class Rebel : IBuyer
{
    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public int Food { get; private set; }

    public string Name { get; set; }

    public string Group { get; set; }

    public int Age { get; set; }

    public void BuyFood()
    {
        Food += 5;
    }
}

