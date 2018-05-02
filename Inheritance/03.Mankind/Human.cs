using System;

public class Human
{
    protected string firstName;
    protected string lastName;

    public Human()
    {

    }

    public Human(string firstName, string lastName)
        :this()
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            firstName = value;
        }
    }
    
    public string LastName
    {
        get { return lastName; }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            if (value.Length < 2)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            lastName = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}\nLast Name: {this.LastName}";
    }
}

