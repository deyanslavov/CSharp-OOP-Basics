using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private HashSet<string> corpsTypes = new HashSet<string>() { "Airforces", "Marines" };

    private string corps;

    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps) :
        base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get { return this.corps; }
        set
        {
            if (corpsTypes.Any(a => a == value))
            {
                this.corps = value;
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .Append($"Corps: {this.Corps}");
        return sb.ToString().TrimEnd();
    }
}

