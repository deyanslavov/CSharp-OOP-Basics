using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override double TotalPower => base.TotalPower * HeatAggression;

    public double HeatAggression
    {
        get { return heatAggression; }
        private set { heatAggression = value; }
    }

    public override string ToString()
    {
        return $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:f2}";
    }
}

