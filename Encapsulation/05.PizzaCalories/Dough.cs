using System;
using System.Collections.Generic;
using System.Linq;

public class Dough
{
    private const int MAX_WEIGHT = 200;
    private const int MIN_WEIGHT = 1;

    private Dictionary<string, double> flourTypes = new Dictionary<string, double>()
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0
    };

    private Dictionary<string, double> bakingTechniques = new Dictionary<string, double>()
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0
    };

    private double weight;
    private string flourType;
    private string bakingTechnique;

    public Dough()
    {

    }
   
    public Dough(double weight, string flourType, string bakingTechn)
    {
        this.Weight = weight;
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechn;
    }

    public double Calories => 2 * weight * flourTypes[FlourType.ToLower()] * bakingTechniques[BakingTechnique.ToLower()];

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }
    
    public string FlourType
    {
        get { return flourType; }
        set
        {
            if (!flourTypes.Any(a => a.Key == value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }
    
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            if (!bakingTechniques.Any(a => a.Key == value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

}

