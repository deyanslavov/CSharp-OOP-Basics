using System;

public class Kitten : Cat
{
    public Kitten(string name, int age):base(name, age)
    {
        this.Gender = "Female";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

