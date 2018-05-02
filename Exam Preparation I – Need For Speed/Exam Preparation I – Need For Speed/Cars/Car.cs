using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
        this.isParked = false;
        this.isRacing = false;
    }

    public bool isRacing { get; set; }

    public bool isParked { get; set; }

    public int OverallPerformace => (Horsepower / Acceleration) + (Suspension + Durability);

    public int EnginePerformace => Horsepower / Acceleration;

    public int SuspensionPerformace => Suspension + Durability;

    public string Brand
    {
        get { return brand; }
        protected set { brand = value; }
    }

    public string Model
    {
        get { return model; }
        protected set { model = value; }
    }

    public int YearOfProduction
    {
        get { return yearOfProduction; }
        protected set { yearOfProduction = value; }
    }

    public int Horsepower
    {
        get { return horsepower; }
        set { horsepower = value; }
    }

    public int Acceleration
    {
        get { return acceleration; }
        protected set { acceleration = value; }
    }

    public int Suspension
    {
        get { return suspension; }
        set { suspension = value; }
    }

    public int Durability
    {
        get { return durability; }
        protected set { durability = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Brand} {Model} {YearOfProduction}")
            .AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s")
            .AppendLine($"{Suspension} Suspension force, {Durability} Durability");

        return sb.ToString().TrimEnd();
    }
}

