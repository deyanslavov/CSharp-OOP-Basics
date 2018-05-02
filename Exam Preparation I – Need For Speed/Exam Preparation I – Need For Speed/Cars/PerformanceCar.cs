using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability, List<string> addOns) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = addOns;
        this.Horsepower += (this.Horsepower * 50) / 100;
        this.Suspension -= (this.Suspension * 25) / 100; 
    }

    public List<string> AddOns
    {
        get { return addOns; }
        set { addOns = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());

        if (this.AddOns.Count == 0)
        {
            sb.AppendLine("Add-ons: None");
        }
        else
        {
            sb.AppendLine("Add-ons: " + string.Join(", ", this.AddOns));
        }

        return sb.ToString().TrimEnd();
    }
}

