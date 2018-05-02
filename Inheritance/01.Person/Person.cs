using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private int age;

    private string name;

    public Person()
    {

    }

    public Person(string name, int age):this()
    {
        this.Name = name;
        this.Age = age;
    }

    protected virtual int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }

    protected  virtual string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            name = value;
        }
    }

    public override string ToString()
    {
        return $"Name: {this.Name}, Age: {this.Age}";
    }
}

