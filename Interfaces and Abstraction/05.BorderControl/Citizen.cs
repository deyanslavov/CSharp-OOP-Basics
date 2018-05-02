public class Citizen : IIdentifiable, IBirthday, IBuyer
{
    public Citizen(string name, int age, string id, string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthday = birthday;
    }

    public string Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Birthday { get; set; }

    public int Food { get; private set; }

    public void BuyFood()
    {
        Food += 10;
    }
}

