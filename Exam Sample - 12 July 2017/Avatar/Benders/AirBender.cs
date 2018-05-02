using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity): base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override double TotalPower => base.TotalPower * AerialIntegrity;

    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
        private set { aerialIntegrity = value; }
    }

    public override string ToString()
    {
        return $"Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}

