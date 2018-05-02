public class Pet : IBirthday
{
    public Pet(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public string Birthday { get; set; }

    public string Name { get; set; }
}

