﻿using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people;

    public Family()
    {
        this.people = new List<Person>();
    }
    public List<Person> People
    {
        get { return this.people; }
        set { this.people = value; }
    }
    public void AddMember(Person person)
    {
        this.People.Add(person);
    }
    public Person GetOldestMember()
    {
        return people.OrderByDescending(a => a.Age).First();
    }
}

