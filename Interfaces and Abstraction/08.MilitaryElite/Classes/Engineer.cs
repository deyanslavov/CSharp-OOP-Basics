using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public HashSet<Repair> Repairs { get; set; }

    public Engineer(int id, string firstName, string lastName, double salary, string corps):
        base(id, firstName, lastName, salary, corps)
    {
        this.Repairs = new HashSet<Repair>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine("Repairs:");

        foreach (var m in this.Repairs)
        {
            sb.AppendLine("  " + m.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}

