using System;
using System.Collections.Generic;
using System.Linq;

public class Topping
{
    private const int MAX_WEIGHT = 50;
    private const int MIN_WEIGHT = 1;

    private Dictionary<string, double> toppingTypes = new Dictionary<string, double>()
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9
    };

    private double weight;
    private string type;

    public Topping()
    {

    }

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public double Calories => 2 * weight * toppingTypes[type.ToLower()];

    public string Type
    {
        get { return type; }
        set
        {
            if (!toppingTypes.Any(a => a.Key == value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }
}

