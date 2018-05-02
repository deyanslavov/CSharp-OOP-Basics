public class Citizen : IResident, IPerson
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Country { get; set; }

    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    string IResident.GetName()
    {
        return "Mr/Ms/Mrs";
    }

    string IPerson.GetName()
    {
        return $"{this.Name}";
    }
}

