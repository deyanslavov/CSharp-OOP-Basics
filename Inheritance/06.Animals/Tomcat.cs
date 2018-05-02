using System;

public class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name, age)
    {
        this.Gender = "Male";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("MEOW");
    }
    
    public override string ToString()
    {
        return base.ToString();
    }
}

