public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { age = value; }
    }
    public Person()
    {
        this.age = 1;
        this.name = "No name";
    }

    public Person(int age): this()
    {
        this.age = age;
    }
    public Person(string name, int age)
    {
        this.age = age;
        this.name = name;
    }
}

