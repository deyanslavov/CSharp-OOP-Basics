using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private const int MIN_LENGTH = 1;
    private const int MAX_LENGTH = 15;

    private string name;
    private Dough dough;
    private List<Topping> toppings = new List<Topping>();

    public Pizza()
    {

    }

    public Pizza(string name)
    {
        this.Name = name;
    }

    public double Calories => this.Dough.Calories + this.Toppings.Sum(a => a.Calories);

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH || value.Length < MIN_LENGTH)
            {
                throw new ArgumentException($"Pizza name should be between {MIN_LENGTH} and {MAX_LENGTH} symbols.");
            }
            name = value;
        }
    }
    
    private Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }
    
    private List<Topping> Toppings
    {
        get { return toppings; }
        set { toppings = value; }
    }

    public void SetDought(Dough d)
    {
        this.Dough = d;
    }

    public void AddTopping(Topping t)
    {
        this.Toppings.Add(t);
        if (this.Toppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }
}

